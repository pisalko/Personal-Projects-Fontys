const int pot = A0;
const int LED3B = 6;
const int LED4Y = 7;
const int LED2G = 5;
const int LED1R = 4;


void setup() {
  // put your setup code here, to run once:
pinMode(pot, INPUT);
pinMode(LED3B, OUTPUT);
pinMode(LED4Y, OUTPUT);
pinMode(LED2G, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  int value = analogRead(pot);
  int ledBr = map(value, 0, 1023, 0, 255);
  
  if( value<341 ) {
  digitalWrite(LED4Y, HIGH);
  digitalWrite(LED3B, LOW);
  digitalWrite(LED2G, LOW);
} else if (value > 341 && value <700){
  digitalWrite(LED4Y, LOW);
  digitalWrite(LED3B, HIGH);
  digitalWrite(LED2G, LOW);
} else {
   digitalWrite(LED4Y, LOW);
  digitalWrite(LED3B, LOW);
  digitalWrite(LED2G, HIGH);
}
Serial.println(ledBr);
Serial.println(value);

}
