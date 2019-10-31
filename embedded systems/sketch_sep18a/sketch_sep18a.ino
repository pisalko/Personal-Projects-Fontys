const int LED1R = 4;
const int LED2G = 5;
const int KEY1 = 8;
const int KEY2 = 9;
int a = 0;
int b = 0;
int btnState;


void setup() {
  // put your setup code here, to run once:
pinMode (LED1R, OUTPUT);
pinMode (LED2G, OUTPUT);
pinMode (KEY1, INPUT_PULLUP);
pinMode (KEY2, INPUT_PULLUP);
digitalWrite (LED2G, LOW);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
int btnState = digitalRead(KEY1);

int btnStateCounter = btnState;
btnState = digitalRead(KEY1);

if ( btnState != btnStateCounter) {

digitalWrite (LED2G, HIGH);

  //do shit if button is pressed
  btnStateCounter = btnState;
} else{
  digitalWrite (LED2G, LOW);
}
}
