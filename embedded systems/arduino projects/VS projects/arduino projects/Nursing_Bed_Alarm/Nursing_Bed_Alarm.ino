
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


unsigned long long debounceTimer, sendTempTimer, sendDegrTimer = 0;

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
  pinMode(POT, INPUT);
  debounceTimer = millis();
  display.clear();
  display.setBrightness(7);
  sendTempTimer, sendDegrTimer = millis();
  
}

float get_temperature()  // copy-paste from richshield example
{
  float temperature, resistance;
  int value;
  value = analogRead(NTC);
  resistance   = (float)value * NTC_R25 / (1024 - value); // Calculate resistance
  /* Calculate the temperature according to the following formula. */
  temperature  = 1 / (log(resistance / NTC_R25) / NTC_MATERIAL_CONSTANT + 1 / 298.15) - 273.15;
  return temperature;
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
    if (modeCounter > 3)
      modeCounter = 1;
    switch (modeCounter)
    {
      case 1:
        display.clear();
        Serial.println("1");

        break;
      case 2:
        display.clear();
        Serial.println("2");
        break;
      case 3:
        display.clear();
        Serial.println("3");
        break;
    }

  }
  //--------------------------------------------------------------
  if (key2Click && !key2State)      //Making KEY2 Click do something
  {
    Serial.flush();
    Serial.println('a');
    digitalWrite(LED1R, HIGH);
  }
  //----------------------------------------------------------------
  if (Serial.available() > 0)            //Reading Serial
  {
    textRead = Serial.readString();
    textRead.trim();
    if (textRead == "r")
    {
      digitalWrite(LED1R, LOW);
    }
  }
  //--------------------------------------------------------------

  switch (modeCounter)                  //Depending on mode, we do smth
  {
    case 1:
      if (textRead[0] == 't')
      {
        String formattedHour = textRead.substring(2);
        hourWithDot = formattedHour.toInt();
        display.showNumberDecEx(hourWithDot, 0b01000000, true);
      }

      break;

    case 2:
      {
        int intTemp = get_temperature() * 100;
        display.showNumberDecEx(intTemp, 0b01000000);

        if ((millis() - sendTempTimer > 2000))
        {
          Serial.flush();
          Serial.println("z" + String(intTemp));
          sendTempTimer = millis();
        }
      }
      break;

    case 3:
      {
        int degreesChair = map(analogRead(POT), 0, 1023, 0, 30);
        display.showNumberDec(degreesChair);
        
        if ((millis() - sendDegrTimer > 1000))
        {
          Serial.flush();
          Serial.println("d" + String(degreesChair));
          sendDegrTimer = millis();
        }
      }
      break;
  }

}
