const int btn1 = 8;
const int LEDR = 4;
const int LEDG = 5;
const int LEDB = 6;
const int LEDY = 7;
int a = 4;

void setup() {
  // put your setup code here, to run once:
 pinMode(btn1, INPUT_PULLUP);                 //Identifies the pins
 pinMode(LEDR, OUTPUT);
 pinMode(LEDR, OUTPUT);
 pinMode(LEDB, OUTPUT);
 pinMode(LEDY, OUTPUT);                                 //Same
}

void loop() {
  // put your main code here, to run repeatedly:
 int btnState = digitalRead(btn1);             //gets the value of the button (if pressed or not)

if (a = 7){
  a = 4;
}

 if (btnState == LOW)
 {
  digitalWrite(a, HIGH);
  a++;
 }
 
 if (btnState == HIGH)
 {
  digitalWrite(a, LOW);
 }
 
} 
