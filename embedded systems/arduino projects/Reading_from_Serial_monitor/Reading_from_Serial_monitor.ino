const int LED1R = 4;
const int LED2G = 5;
const int LED3B = 6;
const int LED4Y = 7;

String oldCommand;
String commandFromUser;

int counter = 0;

void setup() {
  Serial.begin(9600);
  pinMode(LED1R, OUTPUT);
  pinMode(LED2G, OUTPUT);
  pinMode(LED3B, OUTPUT);
  pinMode(LED4Y, OUTPUT);
  digitalWrite(LED1R, LOW);
  digitalWrite(LED2G, LOW);
  digitalWrite(LED3B, LOW);
  digitalWrite(LED4Y, LOW);

}

void loop() {
  

  commandFromUser = Serial.readString();

  if (commandFromUser != "")
  {
    Serial.println("vale");
    commandFromUser.trim();
    Serial.println("vale");
    if (counter == 0)
  {
    oldCommand = commandFromUser;
    counter ++;
  }
  }


  if (commandFromUser == "ON")
  {

    digitalWrite(LED2G, HIGH);
  }

  if (commandFromUser == "OFF")
  {
    digitalWrite(LED2G, LOW);
  }


  if (oldCommand == "rainbow")
  {
    for (int i = 0; i < 4; i++)
    {
      switch (i) {
        case 0:
          digitalWrite(LED1R, HIGH);
          digitalWrite(LED2G, LOW);
          digitalWrite(LED3B, LOW);
          digitalWrite(LED4Y, LOW);
          delay(100);
          break;

        case 1:
          digitalWrite(LED1R, LOW);
          digitalWrite(LED2G, HIGH);
          digitalWrite(LED3B, LOW);
          digitalWrite(LED4Y, LOW);
          delay(100);
          break;

        case 2:
          digitalWrite(LED1R, LOW);
          digitalWrite(LED2G, LOW);
          digitalWrite(LED3B, HIGH);
          digitalWrite(LED4Y, LOW);
          delay(100);
          break;

        case 3:
          digitalWrite(LED1R, LOW);
          digitalWrite(LED2G, LOW);
          digitalWrite(LED3B, LOW);
          digitalWrite(LED4Y, HIGH);
          delay(100);
          break;
      }
    }
  }

}
