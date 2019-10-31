const int LDR = A2;                                      //we defined Light Dependent Resistor
const int NTC = A1;                                      //we defined Negative Temperature Coefficient
const int LED_RED = 4;                                   //pin is defined as red LED
const int LED_GREEN = 5;                                 //pin is defined as green LED
const int LED_BLUE = 6;                                  //pin is defined as blue LED
const int LED_YELLOW = 7;                                //pin is defined as yellow LED
const int BUTTON_TEMPERATURE_MODE = 8;                   //Key 1 is defined as the Temperature mode button
const int BUTTON_BRIGHTNESS_MODE = 9;                    //Key 2 is defined as the Brightness mode button
const int BUZZER = 3;                                    //buzzer defined
 
//defining Environment light and Temperature for analog reading in void loop (so that when we read the value it stays the same while running a program)
int ENVIRONMENT_LIGHT;                        
int TEMPERATURE;
int DURATION = 0;                                        //definig a counter for 10 seconds for the buzzer
int modeCounter = 0;                                     //defining a counter that follows in which mode (Brightness or Temperature) are we
 
//defining the variables as boolean (they have two possible states - true/false, high/low, 0/1)
bool BUTTON_TEMPERATURE_MODE_STATE = false;
bool BUTTON_TEMPERATURE_MODE_OLD_STATE = false;
bool BUTTON_TEMPERATURE_MODE_CLICK = false;
 
bool BUTTON_BRIGHTNESS_MODE_STATE = false;
bool BUTTON_BRIGHTNESS_MODE_OLD_STATE = false;
bool BUTTON_BRIGHTNESS_MODE_CLICK = false;
 
void setup() {
  //definig pins as inputs, outputs or input_pullups(buttons)
  pinMode(LDR, INPUT);
  pinMode(NTC, INPUT);
  pinMode(BUZZER, OUTPUT);
  pinMode(LED_RED, OUTPUT);
  pinMode(LED_GREEN, OUTPUT);
  pinMode(LED_BLUE, OUTPUT);
  pinMode(LED_YELLOW, OUTPUT);
  pinMode(BUTTON_TEMPERATURE_MODE, INPUT_PULLUP);
  pinMode(BUTTON_BRIGHTNESS_MODE, INPUT_PULLUP);
  Serial.begin(9600);
  ENVIRONMENT_LIGHT = analogRead(A2);
  TEMPERATURE = analogRead(A1);
}
 
void loop() {
  //reading the LDR and NTC as analog inputs
  int ENVIRONMENT_LIGHT_NOW = analogRead(A2);
  int TEMPERATURE_NOW = analogRead(A1);
 
  //reading the Temperature mode and the Brightness mode buttons
  BUTTON_TEMPERATURE_MODE_STATE = digitalRead(BUTTON_TEMPERATURE_MODE);
  BUTTON_BRIGHTNESS_MODE_STATE = digitalRead(BUTTON_BRIGHTNESS_MODE);
 
  //comparing the button state of the Temperature mode button with the old state of the button
  if (BUTTON_TEMPERATURE_MODE_STATE != BUTTON_TEMPERATURE_MODE_OLD_STATE)
  {
    BUTTON_TEMPERATURE_MODE_OLD_STATE = BUTTON_TEMPERATURE_MODE_STATE; //if the BUTTON_TEMPERATURE_MODE_STATE has changed, we assign that new state to the BUTTON_TEMPERATURE_MODE_OLD_STATE
    BUTTON_TEMPERATURE_MODE_CLICK = true;                              //BUTTON_TEMPERATURE_MODE_CLICK changed its value from false to true
  }
  else
  {
    BUTTON_TEMPERATURE_MODE_CLICK = false;                             //if the change didn't happen, we don't change the value of the BUTTON_TEMPERATURE_MODE_CLICK
  }
  //comparing the button state of the Brightness mode button with the old state of the button
  if (BUTTON_BRIGHTNESS_MODE_STATE != BUTTON_BRIGHTNESS_MODE_OLD_STATE)
  {
    BUTTON_BRIGHTNESS_MODE_OLD_STATE = BUTTON_BRIGHTNESS_MODE_STATE;   //if the BUTTON_BRIGHTNESS_MODE_STATE has changed, we assign that new state to the BUTTON_BRIGHTNESS_MODE_OLD_STATE
    BUTTON_BRIGHTNESS_MODE_CLICK = true;                               //BUTTON_BRIGHTNESS_MODE_CLICK changed its value from false to true
  }
  else                                                                 //if the change didn't happen, we don't change the value of the BUTTON_BRIGHTNESS_MODE_CLICK
  {
    BUTTON_BRIGHTNESS_MODE_CLICK = false;
  }
 
  if (BUTTON_BRIGHTNESS_MODE_STATE == LOW)
  {
    delay(50);                                                         //soultion to the debouncing problem
    BUTTON_BRIGHTNESS_MODE_STATE = digitalRead(BUTTON_BRIGHTNESS_MODE);
    if (BUTTON_BRIGHTNESS_MODE_STATE == LOW)
    {
      if (BUTTON_BRIGHTNESS_MODE_CLICK)
      {
        modeCounter = 1;                                                //we are now in the Brightness mode untill we press the Temperature button, then the modeCounter becomes 2
        //signalizing which led is on
        digitalWrite(LED_YELLOW, HIGH);
        digitalWrite(LED_BLUE, LOW);
       
        Serial.print("This is your enviroment light: ") + Serial.println(ENVIRONMENT_LIGHT);   //showing value on the Serial Monitor
      }
    }
  }
 
 
  if (BUTTON_TEMPERATURE_MODE_STATE == LOW)
  {
    delay(50);                                                         //soultion to the debouncing problem
    BUTTON_TEMPERATURE_MODE_STATE = digitalRead(BUTTON_TEMPERATURE_MODE);
    if(BUTTON_TEMPERATURE_MODE_STATE == LOW)
    {
    if (BUTTON_TEMPERATURE_MODE_CLICK)
    {
      modeCounter = 2;                                                  //we are now in the Temperature mode untill we press the Brightness button, then the modeCounter becomes 1
      digitalWrite(LED_BLUE, HIGH);
      digitalWrite(LED_YELLOW, LOW);
     
      Serial.print("This is the temperature: ") + Serial.println(TEMPERATURE);
    }
    }
  }
 
 
  if(modeCounter == 1)
  {
  if(ENVIRONMENT_LIGHT + 50 < ENVIRONMENT_LIGHT_NOW)            //we want to activate the alarm when the value and the brightness increases by 50, not 1; threshold for Brightness mode
      {
        //defining that the buzzer will be on for 10 seconds
        while(DURATION<1000)
        {
          digitalWrite(LED_RED, HIGH);
          tone(BUZZER, 60, 10);
          delay(10);
          noTone(BUZZER);    
          DURATION++;
          digitalWrite(LED_RED, LOW);
          BUTTON_TEMPERATURE_MODE_STATE = digitalRead(BUTTON_TEMPERATURE_MODE);
          if(BUTTON_TEMPERATURE_MODE_STATE == LOW)        //if we press the button for Temperature, the buzzer will stop and switch to the Brightness mode
          {
            modeCounter = 2;
            break;
          }
 
        }
        DURATION = 0;                                     //reseting the counter
      }
  }
  else if(modeCounter == 2)
  {
    if(TEMPERATURE - 20 > TEMPERATURE_NOW)          //we want to activate the alarm when the value decreases by 20 (and temperature increases by 20), not 1; threshold for Temperature mode
    {
      while(DURATION<1000)
      {
        digitalWrite(LED_RED, HIGH);
        tone(BUZZER, 30, 10);
        delay(10);
        noTone(BUZZER);
        DURATION++;
        digitalWrite(LED_RED, LOW);
        BUTTON_BRIGHTNESS_MODE_STATE = digitalRead(BUTTON_BRIGHTNESS_MODE);
        if(BUTTON_BRIGHTNESS_MODE_STATE == LOW)
          {
            modeCounter = 1;
            break;
          }
      }
      DURATION = 0;
    }
  }
}
