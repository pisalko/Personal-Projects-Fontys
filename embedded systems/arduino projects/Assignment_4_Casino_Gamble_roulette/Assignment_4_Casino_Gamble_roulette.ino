#include <Display.h>
#include "pitches.h"

const int KEY2 = 9;
const int KEY1 = 8;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int BUZZER = 3;
const int DISPLAYCLK = 10;
const int DISPLAYDIO = 11;
const int LDR = A2;
const int NTC = A1;
const int POT = A0;


uint8_t currentOuterSeg[12];
int mode, last, lastRoundSeg, ldrValue, ntcValue, potValue = 0;

bool canStart = false;

unsigned long long debounceTimer, speedSeg, timeNow, debounceTimerInsideFor = 0;
bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;

//Here I am creating a struct (similar to a class) with 2 properties - segment and position.
typedef struct {
  uint8_t seg;
  uint8_t pos;
} Frame;

//I am creating a Struct array, which enables me to have 12 different combinations of position and segment.
Frame frames[12];

//method for delay without delay();
void MillisAsDelay(int interval)
{
  timeNow = millis();
  while (millis() < timeNow + interval)
  {

  }
}

int RealRandomNumber()
{
  ntcValue = analogRead(NTC);
  ldrValue = analogRead(LDR);
  potValue = map(analogRead(POT), 0, 1023, 4, 321);

 int valueDivided = ntcValue + ldrValue;

 int randomNumber = valueDivided / potValue;
 return randomNumber; 
}

void WinningSound() // Obsolete, can be implemented in another gamemode I have an idea of (not enough time)
{
  tone(BUZZER, 500, 200);
  MillisAsDelay(300);
  tone(BUZZER, 500, 200);
  MillisAsDelay(300);
  tone(BUZZER, 500, 200);
  MillisAsDelay(300);
  tone(BUZZER, 800, 150);
  MillisAsDelay(150);
  tone(BUZZER, 500, 500);
  MillisAsDelay(500);
  tone(BUZZER, 600, 800);
  MillisAsDelay(800);
  tone(BUZZER, 1000, 1300);
  MillisAsDelay(1300);
}

void WinningSound2()
{
  tone(BUZZER, 880, 50);
  MillisAsDelay(50);
  tone(BUZZER, 988);
  MillisAsDelay(50);
  tone(BUZZER, 523);
  MillisAsDelay(50);
  tone(BUZZER, 988);
  MillisAsDelay(50);
  tone(BUZZER, 523);
  MillisAsDelay(50);
  tone(BUZZER, 587);
  MillisAsDelay(50);
  tone(BUZZER, 523);
  MillisAsDelay(50);
  tone(BUZZER, 587);
  MillisAsDelay(50);
  tone(BUZZER, 659);
  MillisAsDelay(50);
  tone(BUZZER, 587);
  MillisAsDelay(50);
  tone(BUZZER, 659);
  MillisAsDelay(50);
  tone(BUZZER, 659);
  MillisAsDelay(50);
  noTone(BUZZER);
}

void LoosingSound()
{
  tone(BUZZER, 392, 250);
  MillisAsDelay(250);
  tone(BUZZER, 262, 500);
  MillisAsDelay(500);
}

void CheckForButtonsPressed()
{
  key1State = digitalRead(KEY1);
  key2State = digitalRead(KEY2);
  //-------------------------------------------------------------
  if (key1State != key1OldState)        //StateChange Machine KEY1
  {
    key1OldState = key1State;
    key1Click = true;
  }
  else
  {
    key1Click = false;
  }
  //------------------------------------------------------------
  if (key2State != key2OldState)        //StateChange Machine KEY2
  {
    key2OldState = key2State;
    key2Click = true;
  }
  else
  {
    key2Click = false;
  }
  //---------------------------------------------------------------
}

void FlashingLedsInASequence(int ledOn)
{
  switch (ledOn)
  {
    case 0:
      digitalWrite(LED1R, LOW);
      digitalWrite(LED2G, LOW);
      digitalWrite(LED3B, LOW);
      digitalWrite(LED4Y, HIGH);
      break;
    case 1:
      digitalWrite(LED1R, LOW);
      digitalWrite(LED2G, LOW);
      digitalWrite(LED3B, HIGH);
      digitalWrite(LED4Y, LOW);
      break;
    case 2:
      digitalWrite(LED1R, LOW);
      digitalWrite(LED2G, HIGH);
      digitalWrite(LED3B, LOW);
      digitalWrite(LED4Y, LOW);
      break;
    case 3:
      digitalWrite(LED1R, HIGH);
      digitalWrite(LED2G, LOW);
      digitalWrite(LED3B, LOW);
      digitalWrite(LED4Y, LOW);
      break;
    case 4:
      digitalWrite(LED1R, HIGH);
      digitalWrite(LED2G, HIGH);
      digitalWrite(LED3B, HIGH);
      digitalWrite(LED4Y, HIGH);
      break;
    case 5:
      digitalWrite(LED1R, LOW);
      digitalWrite(LED2G, LOW);
      digitalWrite(LED3B, LOW);
      digitalWrite(LED4Y, LOW);
      break;
  }
}

void setup()
{  
  Serial.begin(9600);
  RealRandomNumber();
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  pinMode(BUZZER, OUTPUT);
  pinMode(LDR, INPUT);
  pinMode(NTC, INPUT);
  pinMode(POT, INPUT);
  debounceTimer, speedSeg, debounceTimerInsideFor = millis();
  Display.clear();
  //Displays "PLAY" on display in the beggining
  Display.showDigitAt(0, 0b01110011);
  Display.showDigitAt(1, 0b00111000);
  Display.showCharAt(2, 'A');
  Display.showCharAt(3, 'Y');
  digitalWrite(LED1R, HIGH);
  digitalWrite(LED2G, HIGH);
  digitalWrite(LED3B, HIGH);
  digitalWrite(LED4Y, HIGH);

  //Here I am putting the segments in the Struct in order, this order can be changed extremely easily. (For example reverse the animation in the other way)
  //Position 1
  frames[0].pos = 0;
  frames[0].seg = 0b00001000;
  frames[1].pos = 0;
  frames[1].seg = 0b00010000;
  frames[2].pos = 0;
  frames[2].seg = 0b00100000;
  frames[3].pos = 0;
  frames[3].seg = 0b00000001;
  //Position 2
  frames[4].pos = 1;
  frames[4].seg = 0b00000001;
  frames[11].pos = 1;
  frames[11].seg = 0b00001000;
  //Position 3
  frames[5].pos = 2;
  frames[5].seg = 0b00000001;
  frames[10].pos = 2;
  frames[10].seg = 0b00001000;
  //Position 4
  frames[6].pos = 3;
  frames[6].seg = 0b00000001;
  frames[7].pos = 3;
  frames[7].seg = 0b00000010;
  frames[8].pos = 3;
  frames[8].seg = 0b00000100;
  frames[9].pos = 3;
  frames[9].seg = 0b00001000;
}

void loop()
{
  //-------------------------------------------------------------
  if (millis() - debounceTimer < 50)          //Debounce method
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }
  //--------------------------------------------------------------
  key1State = digitalRead(KEY1);
  key2State = digitalRead(KEY2);
  //-------------------------------------------------------------
  if (key1State != key1OldState)        //StateChange Machine KEY1
  {
    key1OldState = key1State;
    key1Click = true;
  }
  else
  {
    key1Click = false;
  }
  //------------------------------------------------------------
  if (key2State != key2OldState)        //StateChange Machine KEY2
  {
    key2OldState = key2State;
    key2Click = true;
  }
  else
  {
    key2Click = false;
  }
  //------------------------------------------------------------
  if (key1Click && !key1State) //Executing code once when pressed Key1
  {
    //EVERY time the player needs to choose a segment, the first segment visible will be completely random, which helps with ruining the predictability of the game
    if ( mode != 1)
    {
      Serial.println("Choose a segment !");
      mode = 1;
      Display.clear();
      int startingPos;
      for(int j = 0; j < RealRandomNumber(); j++)
      {
        startingPos = random(0, 11);             //This is the most random scneario I could think of with the hardware at hand
      }
      last = startingPos;
      Display.showDigitAt(frames[startingPos].pos, frames[startingPos].seg);
      FlashingLedsInASequence(0);
      lastRoundSeg = last;
    }
    else
    {
      last++;
      if (last == 12)
      {
        last = 0;
      }
      Display.clear();
      Display.showDigitAt(frames[last].pos, frames[last].seg);
      lastRoundSeg = last;
      digitalWrite(LED4Y, LOW);
      MillisAsDelay(30);
      FlashingLedsInASequence(0);
    }
    canStart = true;
  }
  //------------------------------------------------------------
  if (key2Click && !key2State) //Executing code when pressed Key2
  {
    if (canStart)
    {
      canStart = false;
      Serial.println("Game has started !");
      mode = 2;
      int delayByMillis = 5;
      int ledOn = 0; //Which led to begin the flashing sequence (0-3)
      speedSeg, debounceTimerInsideFor = millis();

      //take NTC/LDR value read and for loop as many tiems as ldr/ntc ??
      int rounds; //We can never have completely random number here but thats the best we can do.
      for(int j = 0; j < RealRandomNumber(); j++)
      {
        rounds = random(51, 63);
      }
      //Shuffling The segments - This is actually random, because we use the outside environment to calculate a random number.
      for (int f = 1; f <= rounds; f++)
      {
        //--------------------------------------------------
        if (millis() - debounceTimerInsideFor < 30)          //Debounce method
        {
          f--;
          continue;
        }
        else
        {
          debounceTimerInsideFor = millis();
        }
        //-------------------------------------------------
        CheckForButtonsPressed();
        if ((key1Click && !key1State) && (key2Click && !key2State))
        {
          tone(BUZZER, 6000, 150);
          MillisAsDelay(150);
          break;
        }
        else if (key1Click && !key1State)
        {
          tone(BUZZER, 200, 50);
          MillisAsDelay(50);
        }
        else if (key2Click && !key2State)
        {
          tone(BUZZER, 200, 50);
          MillisAsDelay(50);
        }

        if (millis() < speedSeg + delayByMillis)
        {
          f--;
        }
        else
        {
          //Buzzer
          tone(BUZZER, f * 30, 50 + (f / 10));
          MillisAsDelay(50 + (f / 10));

          if (f == rounds - 2)
          {
            tone(BUZZER, f * 50, 90);
            MillisAsDelay(90);
          }
          if (f == rounds - 1)
          {
            tone(BUZZER, f * 50, 110);
            MillisAsDelay(110);
          }
          if (f == rounds)
          {
            tone(BUZZER, 1800, 80);
            MillisAsDelay(80);
            //tone(BUZZER, 1800, 80);
            MillisAsDelay(80);
            tone(BUZZER, 2600, 200);
            MillisAsDelay(200);
          }


          //Flashing leds together with changing segments
          FlashingLedsInASequence(ledOn);
          ledOn++;
          if (ledOn == 4)
            ledOn = 0;
          //Slowing down the for loop gradually (Last 3 steps we want to be even slower for greater effect)
          speedSeg = millis();
          delayByMillis += 4;
          if (f == rounds - 3)
            delayByMillis += 150;
          if (f == rounds - 2)
            delayByMillis += 250;
          if (f == rounds - 1)
            delayByMillis += 350;
          //Changing sequence position
          last++;
          if (last == 12)
          {
            last = 0;
          }
          //Changing the segments on the screen
          Display.clear();
          Display.showDigitAt(frames[last].pos, frames[last].seg);
          if ( f == rounds )
          {
            MillisAsDelay(200);
          }
        }
      }

      // Win/Lose check
      if (lastRoundSeg == last)
      {

        lastRoundSeg = last;
        Serial.println("You won !");
        
        //Do fancy stuff with leds and buzzer and Display
        //Flashing leds
        for (int h = 2; h <= 9; h++)
        {
          if (h % 2 == 0)
          {
            FlashingLedsInASequence(4);
            MillisAsDelay(200);
          }
          else
          {
            FlashingLedsInASequence(5);
            MillisAsDelay(200);
          }
        }

        //Display yeah
        for (int i = 0; i < 4; i++)
        {
          MillisAsDelay(300);
          Display.clear();
          int first = i;
          int second = i + 1;
          int third = i + 2;
          int fourth = i + 3;
          if (second > 3)
            second = i - 3;
          if (third > 3)
            third = i - 2;
          if (fourth > 3)
            fourth = i - 1;


          Display.showCharAt(first, 'Y');
          Display.showCharAt(second, 'E');
          Display.showCharAt(third, 'A');
          Display.showCharAt(fourth, 'H');
          MillisAsDelay(300);

          //Winning sound buzzer
          if (i == 0)
          {
            for (int loopV = 0; loopV < 3; loopV++)
            {
              WinningSound2();
            }
          }

          if (i == 3)
          {
            Display.showCharAt(0, 'Y');
            Display.showCharAt(1, 'E');
            Display.showCharAt(2, 'A');
            Display.showCharAt(3, 'H');
            FlashingLedsInASequence(2);
          }
        }

      }
      else
      {
        lastRoundSeg = last;
        Serial.println("You lost !");
        //Flashing leds
        for (int h = 2; h <= 9; h++)
        {
          if (h % 2 == 0)
          {
            FlashingLedsInASequence(3);
            MillisAsDelay(200);
          }
          else
          {
            FlashingLedsInASequence(5);
            MillisAsDelay(200);
          }
        }
        //--------------------------------
        //Display LOSS
        for (int i = 0; i < 4; i++)
        {
          MillisAsDelay(300);
          Display.clear();
          int first = i;
          int second = i + 1;
          int third = i + 2;
          int fourth = i + 3;
          if (second > 3)
            second = i - 3;
          if (third > 3)
            third = i - 2;
          if (fourth > 3)
            fourth = i - 1;


          Display.showDigitAt(first, 0b00111000);
          Display.showCharAt(second, 'O');
          Display.showCharAt(third, 'S');
          Display.showCharAt(fourth, 'S');
          MillisAsDelay(300);

          //Winning sound buzzer ----------------------
          if (i == 0)
          {
            LoosingSound();
          }

          if (i == 3)
          {
            Display.showDigitAt(0, 0b00111000);
            Display.showCharAt(1, 'O');
            Display.showCharAt(2, 'S');
            Display.showCharAt(3, 'S');
            FlashingLedsInASequence(3);
          }
        }
        //-----------------
      }
    }
  }
  //------------------------------------------------------------

  //------------------------------------------------------------
}
