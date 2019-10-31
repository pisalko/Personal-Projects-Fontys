const int RX = 0;
const int TX = 1;
const int IRLED = 2;
const int BUZZER = 3;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int POT = A0;
const int NTC = A1;
const int LDR = A2;
const int VOLT = A3;


bool lock = true;
bool Key1State;
bool Key2State;

unsigned long debounceTimer;

void setup() {
  // put your setup code here, to run once:
  pinMode(KEY1, INPUT_PULLUP);
  pinMode(KEY2, INPUT_PULLUP);
  Serial.begin(9600);
  debounceTimer = millis();
}





void loop() {

  if(millis() - debounceTimer < 80)
  {
    return;
  }
  else
  {
    debounceTimer = millis();
  }


  
  Key1State = digitalRead(KEY1);
  Key2State = digitalRead(KEY2);


  if (!Key1State)
  {
    if (!lock)
    {
      lock = true;
      Serial.println("valeeee");

      if (Key1State)
      {
        lock = false;
      }
    }
  }
  else
  {
    lock = false;
  }

}
