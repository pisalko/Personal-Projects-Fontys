#include "TM1637Display.h"
const int LED1R = 4;
const int LED2G = 5;            //defining pins so magic numbers are avoided
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int NTC = A1;
const int LDR = A2;
const int BUZZER = 3;
const int DISPLAYCLK = 10;
const int DISPLAYDIO = 11;
const int POT = A0;
//---------------------------------------------------------------------------------------------
int modeCounter = 0;                                        //defining variables used troughout the code

int ntcEnvironment, ntcValueEnvironment, ldrValueEnvironment, ldrEnvironment, potValue;

bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;

unsigned long long debounceTimer, timerBuzzer;
//---------------------------------------------------------------------------------------------
TM1637Display display(DISPLAYCLK, DISPLAYDIO);                    //using custom library for the display because it has more functionalities than the provided one
//---------------------------------------------------------------------------------------------
void setup() 
{
  pinMode(KEY1, INPUT_PULLUP);                          //defining pin modes (input, output, analog or digital)
  pinMode(KEY2, INPUT_PULLUP);
  pinMode(NTC, INPUT);
  pinMode(LDR, INPUT);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(POT, INPUT);
  Serial.begin(9600);                                 //used for debugging
  debounceTimer, timerBuzzer = millis();              //variables used for calculation time troughout the code
  display.clear();                                    //clearing the display every time the program starts so there a
 }
//---------------------------------------------------------------------------------------------
void DisplayShow(uint8_t first, uint8_t second, uint8_t third, uint8_t fourth)      //Method used for the Display (because its easier that way and simpler, i have to write this code only once and then call it whenever i need it)
{
  display.setBrightness(map(potValue, 0, 1023, 0, 7), true); //0-7
  uint8_t displayShow[] = {first, second, third, fourth};
  display.setSegments(displayShow);
}
//---------------------------------------------------------------------------------------------
void BuzzerAlarm(int x, int y, int z)                                       //method for alarm (Buzzer and LEDs) using arguments for the buzzer's frequency (so I can give it different frequencies for the different alarms I have)
{
  if (modeCounter == 1) 
  {
    if (millis() - timerBuzzer > 450) 
    {
      analogWrite(LED2G, LOW);
      analogWrite(LED3B, LOW);
      digitalWrite(LED1R, LOW);
      digitalWrite(LED4Y, HIGH);
      tone(BUZZER, x, 100);
    }
    if (millis() - timerBuzzer > 550) 
    {
      tone(BUZZER, y, 250);

    } if (millis() - timerBuzzer > 800) 
    {
      tone(BUZZER, z, 450);
      timerBuzzer = millis();
      digitalWrite(LED1R, HIGH);
      digitalWrite(LED4Y, LOW);
    }
  }
  else if (modeCounter == 2)
  {
    if (millis() - timerBuzzer > 450) 
    {
      digitalWrite(LED4Y, LOW);
      analogWrite(LED3B, LOW);
      digitalWrite(LED1R, LOW);
      analogWrite(LED2G, map(potValue, 0, 1023, 0, 255));
      tone(BUZZER, x, 100);
    }
    if (millis() - timerBuzzer > 550) 
    {
      tone(BUZZER, y, 250);

    } if (millis() - timerBuzzer > 800) 
    {
      tone(BUZZER, z, 450);
      timerBuzzer = millis();
      analogWrite(LED3B, map(potValue, 0, 1023, 0, 255));
      analogWrite(LED2G, LOW);
    }
  }
}
//---------------------------------------------------------------------------------------------
void loop() {
//---------------------------------------------------------------------------------------------
  if (millis() - debounceTimer < 80)          //Debounce method (both buttons at once)
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }
//---------------------------------------------------------------------------------------------
  potValue = analogRead(POT);                   //reading values from potention meter and the 2 buttons
  key2State = digitalRead(KEY2);
  key1State = digitalRead(KEY1);
//---------------------------------------------------------------------------------------------       
  if (key1State != key1OldState)        //StateChange Machine KEY1         
  {
    key1OldState = key1State;
    key1Click = true;
  } else
  {
    key1Click = false;
  }

  if (key2State != key2OldState)        //StateChange Machine KEY2
  {
    key2Click = true;
    key2OldState = key2State;

  } else
  {
    key2Click = false;
  }
//---------------------------------------------------------------------------------------------
  if (key1Click && !key1State)      //Making KEY1 Click do something
  {
    digitalWrite(LED1R, LOW);
    analogWrite(LED2G, LOW);
    analogWrite(LED3B, LOW);
    digitalWrite(LED4Y, HIGH);
    modeCounter = 1;
    ntcValueEnvironment = map(analogRead(NTC), 0, 1023, 0, 351);
    Serial.println("Heat detection system ACTIVATED");
    noTone(BUZZER);
  }
  else if (key2Click && !key2State)        //Making KEY2 Click do something
  {
    digitalWrite(LED1R, LOW);
    analogWrite(LED3B, LOW);
    digitalWrite(LED4Y, LOW);
    analogWrite(LED2G, map(potValue, 0, 1023, 0, 255));

    modeCounter = 2;
    ldrValueEnvironment = map(analogRead(LDR), 0, 1023, 0, 351);
    Serial.println("Light detection system ACTIVATED");
    noTone(BUZZER);
  }
   if (key2Click && !key2State && key1Click && !key1State)   //If both buttons are pressed, change the mode to both systems deactiavted (This can be made as well for both systems to be activated)
  {
    display.clear();
    digitalWrite(LED1R, HIGH);
    analogWrite(LED2G, HIGH);
    analogWrite(LED3B, HIGH);
    digitalWrite(LED4Y, HIGH);
    Serial.println("Both Systems DEACTIVATED");
    noTone(BUZZER);
    modeCounter = 3;
  }
//---------------------------------------------------------------------------------------------
  switch (modeCounter)               //Decision which mode to be used
  {
    case 2:                                   //Light Alarm
      ldrEnvironment = map(analogRead(LDR), 0, 1023, 0, 351);
      if (ldrValueEnvironment + 10 < ldrEnvironment)
      {
        Serial.println("ALARM! TOO BRIGHT IN REACTOR!");
        DisplayShow(0b01011011, 0b00111000, 0b00110000, 0b01111000);
        BuzzerAlarm(800, 1000, 1200);
      }
      else
      {
        DisplayShow(0b00111000, 0b00110000, 0b01101111, 0b01111000);
        digitalWrite(LED1R, LOW);
        analogWrite(LED3B, LOW);
        digitalWrite(LED4Y, LOW);
        analogWrite(LED2G, map(potValue, 0, 1023, 0, 255));
      }
      break;
      
    case 1:                                   //Heat Alarm
      ntcEnvironment = map(analogRead(NTC), 0, 1023, 0, 351);
      if (ntcValueEnvironment - 7 > ntcEnvironment)
      {

        DisplayShow(0b01011011, 0b01110110, 0b00111111, 0b01111000);
        Serial.println("ALARM! TOO HOT IN REACTOR!");
        BuzzerAlarm(1000, 900, 600);
      }
      else
      {
        digitalWrite(LED1R, LOW);
        analogWrite(LED2G, LOW);
        analogWrite(LED3B, LOW);
        digitalWrite(LED4Y, HIGH);
        DisplayShow(0b01110110, 0b01111001, 0b01110111, 0b01111000);
      }
      break;
      
      case 3:                                   //Both sensors off - additional function (You need to press both buttons at once for this mode to be activated)
      if (key2Click && !key2State && key1Click && !key1State)
      {
        break;
      }
  }
//---------------------------------------------------------------------------------------------
}
