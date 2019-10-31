const int BUZZER = 3;
const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;
const int KEY1 = 8;
const int KEY2 = 9;
const int NTC = A1;
const int LDR = A2;
const int UPPER_TH = 460;
const int LOWER_TH = 450;
int light;
int temp;

//signal between 0V - 5V = 0-1023 valued
//more light - more resistance - higher value read

//temp is between 0 and 40 degrees (roughly), usually in room temp its around 410-480
void setup() {
  // put your setup code here, to run once:
  pinMode(NTC, INPUT);
  pinMode(LDR, INPUT);
  Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:

light = analogRead(LDR);
temp = analogRead(NTC);


/*if(light <= 341)
{
  Serial.print("dark - ");
  Serial.println(light);
} else if (light >341 && light <= 900)
{
  Serial.print("daylight - ");
  Serial.println(light);
} else if ( light > 900)
{
  Serial.print("highlight - ");
  Serial.println(light);
}*/


Serial.println(temp);

if(temp < UPPER_TH)
  {
    //heather off
    digitalWrite(LED1R, LOW);
    Serial.println(temp);
  }
  if(temp > LOWER_TH)
  {
    //heather on
    digitalWrite(LED1R, HIGH);
    Serial.println(temp);
  }




}
