
#include "TM1637Display.h"
const int KEY2 = 9;
const int KEY1 = 8;
const int POT = A0;
const int NTC = A1;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int BUZZER = 3;
const int DISPLAYCLK = 10;
const int DISPLAYDIO = 11;
const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm copy-paste from example
const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer copy-paste from example


unsigned long long debounceTimer = 0;

bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;

TM1637Display display(DISPLAYCLK, DISPLAYDIO);

int modeCounter = 0;
String textRead;
int hourWithDot;

void setup()
{
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(NTC, INPUT);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  
  debounceTimer = millis();
  display.clear();
}

float get_temperature()  // copy-paste from richshield example
{
    float temperature,resistance;
    int value;
    value = analogRead(NTC);
    resistance   = (float)value * NTC_R25/(1024 - value); // Calculate resistance
    /* Calculate the temperature according to the following formula. */
    temperature  = 1/(log(resistance/NTC_R25)/NTC_MATERIAL_CONSTANT+1/298.15)-273.15;
    return temperature;
}

void DisplayShow(int first, int second, int third, int fourth)      //Method used for the Display (because its easier that way and simpler, i have to write this code only once and then call it whenever i need it)
{
  display.setBrightness(7, true); //0-7
  display.showNumberDec(first, 0);
  display.showNumberDec(second, 1);
  display.showNumberDec(third, 2);
  display.showNumberDec(fourth, 3);
}

void loop()
{
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
  //-----------------------------------------------------------
  if (key1Click && !key1State)      //Making KEY1 Click do something
  {
    modeCounter++;
    switch (modeCounter) {
      case 1:
        Serial.println("1");
        break;
      case 2:
        Serial.println("2");
        break;
      case 3:
        Serial.println("3");
        break;
        if (modeCounter > 3)
          modeCounter = 1;
    }
  }
  //--------------------------------------------------------------
  if (key2Click && !key2State)      //Making KEY2 Click do something
  {
    Serial.println("a");
  }
  if (Serial.available() > 0)            //Actual code
  {
    textRead = Serial.readString();
    textRead.trim();
    switch (modeCounter) {
      case 1:
        if(textRead.startsWith("t:"))
        {
          textRead = textRead.substring(2);
          hourWithDot = textRead.toInt();
          
          display.showNumberDecEx(hourWithDot, 0b01000000);
          digitalWrite(LED1R, HIGH);

          
            if(textRead.startsWith("t:"))
        {
          textRead = textRead.substring(2, textRead.length());
          Serial.println("s" + hourWithDot);

        }
        
        }
        break;

      case 2:

        break;

      case 3:

        break;
    }
  }

}
