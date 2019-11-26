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


int numberAtPos[4][10]; // see if needed


unsigned long long debounceTimer = 0;
bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;
String textRead = "";

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

  }
  //------------------------------------------------------------
  if (key2Click && !key2State) //Executing code when pressed Key2
  {

  }
  //------------------------------------------------------------

  //------------------------------------------------------------
}
