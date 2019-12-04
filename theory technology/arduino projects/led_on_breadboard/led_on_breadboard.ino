const int  LEDG = A0; // green
const int  LEDR = A1; // red
const int  LEDB = A2; // blue
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(A0, OUTPUT);
pinMode(A1, OUTPUT);
pinMode(A2, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LEDG, HIGH);
  digitalWrite(LEDR, HIGH);
  digitalWrite(LEDB, HIGH);
}
