const int KEY1 = 8;
const int LED2 = 6;
int lastButtonState = LOW;
int toggle = 0;

void setup() {
  // put your setup code here, to run once:
pinMode (KEY1, INPUT_PULLUP);
pinMode(LED2, OUTPUT);
Serial.begin(9600);
}

void loop () {

  int buttonState = digitalRead(KEY1);

  if(buttonState == LOW) {
    delay(50);
    buttonState = digitalRead(KEY1);
    if (buttonState == LOW) {
      if (toggle == 0) {
        digitalWrite(LED2, HIGH);
        Serial.println("LED ON");
        toggle = 1;
      } else {
        digitalWrite(LED2, LOW);
        Serial.println("LED OFF");
        toggle = 0;
      }
      /*digitalWrite(LED2, HIGH);
      Serial.println("on");
    }else {
      digitalWrite(LED2, LOW);*/
      
    
  }
}  










  
 /* if(buttonState != lastButtonState) {
    if ( buttonState == LOW) {
      digitalWrite(LED2, HIGH);
      Serial.println("LED ON");
    } else {
      digitalWrite(LED2, LOW);
      Serial.println("LED OFF");
    }
    lastButtonState = buttonState;
  }
  */
  }
