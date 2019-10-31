
const int LED1R = 4;

unsigned long long timestamp, durationOfBlinking = 0;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED1R, HIGH);
  timestamp, durationOfBlinking = millis();

}

void Counter()
{
  if (millis() - durationOfBlinking < 100)
    {
      
      Counter();
      
    }
    else
    {
      durationOfBlinking = millis();
      digitalWrite(LED1R, LOW);
      return;
    }
}

void loop() {
  // put your main code here, to run repeatedly:
  if (millis() - timestamp < 1000)
  {
    return;
  }
  else
  {
    timestamp = millis();
    digitalWrite(LED1R, HIGH);
    Counter();
 
  }
  
  

}
