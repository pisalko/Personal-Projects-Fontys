
const int LED1R = 4;

unsigned long long timestamp, durationOfBlinking = 0;


void setup()
{
  pinMode(LED1R, HIGH);
  timestamp, durationOfBlinking = millis();
}


void loop()
{
  if (millis() - timestamp < 1000)
  {
    return;
  }
  else
  {
    timestamp = millis();
    digitalWrite(LED1R, HIGH);
    delay(100);
  }
  digitalWrite(LED1R, LOW);
}
