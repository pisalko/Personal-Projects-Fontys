const int  LED = A0;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(A0, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LED, HIGH);
}
