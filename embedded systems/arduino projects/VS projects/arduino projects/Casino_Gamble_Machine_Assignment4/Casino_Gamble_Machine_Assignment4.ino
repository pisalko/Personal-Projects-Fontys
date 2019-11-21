const int KEY2 = 9;
const int KEY1 = 8;
//const int POT = A0;
//const int NTC = A1;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
//const int BUZZER = 3;
//const int DISPLAYCLK = 10;
//const int DISPLAYDIO = 11;
//const int NTC_R25 = 10000; // the resistance of the NTC at 25'C is 10k ohm copy-paste from example
//const int NTC_MATERIAL_CONSTANT = 3950; // value provided by manufacturer copy-paste from example


unsigned long long debounceTimer = 0;
bool key1State, key1OldState, key1Click, key2State, key2OldState, key2Click = true;
String textRead = "";

void setup()
{
  Serial.begin(9600);
  //pinMode(NTC, INPUT);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  //pinMode(POT, INPUT);
  debounceTimer = millis();
  //display.clear();
  //display.setBrightness(7);
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
  if (Serial.available() > 0)            //Reading Serial
  {
    textRead = Serial.readString();
    textRead.trim();
    if (textRead == "r")
    {
      digitalWrite(LED1R, LOW);
    }
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
