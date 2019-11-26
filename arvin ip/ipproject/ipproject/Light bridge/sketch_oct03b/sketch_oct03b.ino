#include "Display.h"

const int LIGHTSENSOR = 16;
const int LEDY = 7;
const int BUZZER = 3;

int pizzaCounter = 0;
bool passing;

void setup() {
  pinMode(LIGHTSENSOR, INPUT);
  pinMode(LEDY, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int  lightValue = analogRead(LIGHTSENSOR);
  Display.show(pizzaCounter);
  if (lightValue > 340) //if pizza is NOT above it checks for passing
  {
    if (passing) //if passing is true it increments pizza counter
    {
      pizzaCounter++;
      tone (BUZZER, 700, 500);
    }
    passing = false;
    digitalWrite(LEDY, LOW);
  }
  else if (lightValue < 300) //if pizza is above, sets passing to true
  {
    passing = true;
    digitalWrite(LEDY, HIGH);

  }

  Serial.println(pizzaCounter);

}
