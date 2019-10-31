void setup() {
  // put your setup code here, to run once:
pinMode(8, INPUT_PULLUP); 
pinMode(4, OUTPUT);
}
void loop() {
  // put your main code here, to run repeatedly:
  int button1 = digitalRead(8);
if (button1 == LOW) {
  digitalWrite(4, HIGH);
}
else {
  digitalWrite(4, LOW);
}

}
