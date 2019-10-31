const int KEY1 = 8;
const int LED1R = 4;
const int LED2G = 5;
const int BUZZER = 3;

bool key1State, key1OldState, key1Click = true;

String textInPort, textInPortCorrect;

unsigned long long debounceTimer = 0;

void setup()
{
  Serial.begin(2000000);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(KEY1, INPUT_PULLUP);
  debounceTimer = millis();
}

void loop()
{
  //------------------------------------------------------------
  if (millis() - debounceTimer < 50)          //Debounce method
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }
  //------------------------------------------------------------
  key1State = digitalRead(KEY1);
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
  if (key1Click && !key1State)      //Making KEY1 Click do something
  {
    digitalWrite(LED1R, HIGH);
    digitalWrite(LED2G, LOW);
    Serial.println("Alarm sounded!");
    textInPort = "haha";
  }
  //-------------------------------------------------------------
  if (Serial.available() > 0)            //Actual code 
  {
    textInPort = Serial.readString();
    textInPort.trim();
  }

  if (textInPort == "Responded")
  {
    //tone(BUZZER, 5000, 30);
    //delay(30);
    digitalWrite(LED2G, HIGH);
    textInPort = "";
  }
  else if (textInPort == "Clear")
  {
    digitalWrite(LED2G, LOW);
    digitalWrite(LED1R, LOW);
  }
  //-------------------------------------------------------------
}
