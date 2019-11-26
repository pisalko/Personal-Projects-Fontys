#include <Display.h>

const int KEY2 = 9;
const int KEY1 = 8;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int BUZZER = 3;
const int DISPLAYCLK = 10;
const int DISPLAYDIO = 11;


uint8_t currentOuterSeg[12];
int mode, last = 0;


unsigned long long debounceTimer = 0;
bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;
String textRead = "";

typedef struct {
  uint8_t seg;
  uint8_t pos;
} Frame;

Frame frames[12];

void setup()
{
  Serial.begin(9600);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  pinMode(BUZZER, OUTPUT);
  debounceTimer = millis();
  Display.clear();
  //Displays "PLAY" on display in the beggining
  Display.showDigitAt(0, 0b01110011);
  Display.showDigitAt(1, 0b00111000);
  Display.showCharAt(2, 'A');
  Display.showCharAt(3, 'Y');
  //Filling the Outer 2 dimensional array

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
    
    if ( mode != 1)
    {
      Serial.println("Choose a segment !");
      mode = 1;
      Display.clear();
      int startingPos = random(0, 11);
      last = startingPos;
      Display.showDigitAt(frames[startingPos].pos, frames[startingPos].seg);
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
    }

  }
  //------------------------------------------------------------
  if (key2Click && !key2State) //Executing code when pressed Key2
  {
    Serial.println("Game has started !");
    mode = 2;
    for (int f = 1; f <= random(22, 69); f++)
    {
      last++;
      if (last == 12)
      {
        last = 0;
      }
      Display.clear();
      Display.showDigitAt(frames[last].pos, frames[last].seg);

      
    }

  }
  //------------------------------------------------------------

  //------------------------------------------------------------
}
