
const int LED0 = LED_BUILTIN; //or 13 

void setup() {
  // put your setup code here, to run once:
pinMode(LED0, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
digitalWrite(LED0, HIGH);
delay(1000);
digitalWrite (LED0, LOW);
delay(1000);
}
