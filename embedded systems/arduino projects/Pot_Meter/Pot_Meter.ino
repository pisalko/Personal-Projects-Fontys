const int pot = A0;
const int LED3B = 6;
const int LED4Y = 7;
const int LED2G = 5;
const int LED1R = 4;

void setup() {
  // put your setup code here, to run once:
pinMode(pot, INPUT);
pinMode(LED3B, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int value = analogRead(pot);
int LedValue = value/4;

Serial.println(value);
analogWrite(LED3B, LedValue);



}

ivona cant
