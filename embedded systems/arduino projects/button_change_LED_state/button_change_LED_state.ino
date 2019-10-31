#include "Display.h"                  //Here we include the Display Library from the RichShield library we downloaded from Canvas, this way we can use the display on the Shield.
const int LED1R = 4;                  //Defining the pins for all the LEDS/Buttons we are going to use (constants because they are not supposed to change)
const int LED2G = 5;                  // |
const int KEY1 = 8;                   // |  
const int KEY2 = 9;                   // <----  Until this line (from line 2 to 5)
int counterBeggining = 1;             // We use this counter just once because we want the 2 LEDS (red & green) light up just once in the beggining of the program
int counterA = 0;                     //counter for the Input Digit button
int counterB = 1;                     //counter how many times we've pressed the confirm button (Also on the display, example - "2CF" means you have just confirmed the 2nd digit, "3CF" - third digit and so on.
int userDigitOne;                     //The first digit the user inputs
int userDigitTwo;                     //The second digit the user inputs
int userDigitThree;                   //The third digit the user inputs
int userDigitFour;                    //The fourth digit the user inputs
bool key1State = HIGH;                //We use this and the next 2 booleans to create the StateChanger Machine later for the Key1(Digit Input)
bool key1OldState = HIGH;             
bool key1Click = HIGH;
bool key2State = HIGH;                //We use this and the next 2 booleans to create the StateChanger Machine later for the Key2(Confirm)
bool key2OldState = HIGH;
bool key2Click = HIGH;

char passNumOne = 4;                  //this char and next 3 is the pre-set password for the safe - pass: 4123
char passNumTwo = 1;
char passNumThree = 2;
char passNumFour = 3;


void setup() {
  // put your setup code here, to run once:
pinMode(LED1R, OUTPUT);                //In the setup method I define which pin what function will have (Keys and LEDS)
pinMode(LED2G, OUTPUT);                //Display's pins are not defined since I saw they are already defined in the RichShield Library we use
pinMode(KEY1, INPUT_PULLUP);
pinMode(KEY2, INPUT_PULLUP);
Serial.begin(9600);                    //I have used the console multiple times for debugging and understanding how the variables change throughout the code
Display.show("    ");                  //I clear the Display every time I upload the code, since for some reason this is not included in the Library...
}

void loop()
{
  // put your main code here, to run repeatedly:
  key1State = digitalRead(KEY1);                //I read KEY1's state
  key2State = digitalRead(KEY2);                //I read KEY2's state



//      KEY1 StateChange Machine

  if ( key1State != key1OldState )      //If there is a change in the key1's state (pressed?), store a boolean that has a value of "true" (because a change occured)
  {
    key1OldState = key1State;           //Assign the new state of the Key1 to the old State of the Key1, so we can use it later (in the next check, when the program reruns)
    key1Click = true;                   //We register if there was a click or not (change)
  }
  else
  {
    key1Click = false;                  //In case there was no change
  }


//      KEY2 StateChange Machine

  if ( key2State != key2OldState )      //If there is a change in the key2's state (pressed?), store a boolean that has a value of "true" (because a change occured)
  {
    key2OldState = key2State;           //Assign the new state of the Key2 to the old State of the Key2, so we can use it later (in the next check, when the program reruns)
    key2Click = true;                   //We register if there was a click or not (change)
  }
  else
  {
    key2Click = false;                  //In case there was no change
  }



  //Debouncing problem solution for Key1 (Input Digits)

  if(key1State == LOW) 
  {                    //First, we check if the button is pushed so we execute the given code
    delay(50);                              //We delay right after we register the Key's push, because in this time frame (50 milliseconds) the Bouncing problem should have stopped
    key1State = digitalRead(KEY1);          //We read the state of the Key again (after the bouncing has ended)
    if (key1State == LOW) 
    {                                        /*We check again if the button is still pressed (and if it is, it means the bouncing has stopped and the state 
                                              of the button will remain LOW without going back to HIGH, unless we release the button)*/
      if (key1Click)                           //INPUT DIGITS BUTTON, we check if there was a change in the state of the button
      {
        digitalWrite(LED1R, LOW);              //clear the red LED if the last input password was wrong
        if (counterBeggining == 1)
        {            //This is the counter that we use only once to initialize the start of the program
          Serial.println("Program Begins!");
          digitalWrite(LED2G, HIGH);               //Light up red & green light for half a second (500 milliseconds)
          digitalWrite(LED1R, HIGH);
          delay(1000);
          digitalWrite(LED2G, LOW);
          digitalWrite(LED1R, LOW);
          counterBeggining++;                      //Increase the value of the counter so this if check is not executed ever again
        }
        else
        {
          digitalWrite(LED2G, HIGH);               //Lighting up the green LED every time the Input Digit Button is pressed (to indicate action)
          delay(60);
          digitalWrite(LED2G, LOW);
          counterA++;                              //Increasing the counter of the Digit and reseting it if it exceeds 4 (cause it has to be between 1 and 4)
        if(counterA>4)
        {
          counterA=1;
        }
  Display.show("    ");                    //Clearing the Display if there is anything on it from the previous functions executed
  Display.showDigitAt(0, counterA);        //Displaying the current digit (of the counter)
  Serial.print("Counter digit: ");       //For debugging
  Serial.println(counterA);                //Debugging
        }

  
      }
      else if(key1Click != true)               //We do not use this, it can be deleted, but I left it in case I want to add more functionality
      {
        
      }
    }
  } 
      if(key2State == LOW) 
      {                                       //First, we check if the button is pushed so we execute the given code
        delay(50);                              //We delay right after we register the Key's push, because in this time frame (50 milliseconds) the Bouncing problem should have stopped
        key2State = digitalRead(KEY2);          //We read the state of the Key again (after the bouncing has ended)
        if (key2State == LOW) 
        {                                       /*We check again if the button is still pressed (and if it is, it means the bouncing has stopped and the state 
                                              of the button will remain LOW without going back to HIGH, unless we release the button)*/
           if (counterBeggining > 1)
           {                                   //With this If check we ensure that we cant start the program with our "Confirm" button but with only the "Input"   
             if (key2Click)                            //CONFIRM BUTTON, we check whether or not there was a change and if there was a change this If statement will be true
            {
               digitalWrite(LED1R, LOW);              //clear the red LED if the last input password was wrong
               if(counterB == 1)                       //This counter is used to keep track of how many times the CONFIRM button is pressed, and once 
               {                                       //it's pressed 4 times, to be reset & the password to be checked
                 digitalWrite(LED1R, HIGH);            //Turns on and off the LED when the button is pressed
                 delay(100);
                 digitalWrite(LED1R, LOW);
                 userDigitOne = counterA;                //Saves the value of the counter to an external variable which we can use later (to compare it to the password)
                 counterA = 0;                           //Resets the Digit counter so it starts from 1 not from where it's left
                 Display.show("    ");                   //Clears Display
                 Display.showDigitAt(0, 1);              //This and the next 2 lines is my visual confirmation that you have confirmed the digit (and which digit you have confirmed 1st, 2nd, 3rd or 4th)
                Display.showCharAt(2, 'c');             
                Display.showCharAt(3, 'f');
                counterB++;                             //We increment the CONFIRM button counter
                Serial.print("Confirmed 1st Digit: ");    //Just for clarification & debugging
                Serial.println(userDigitOne);                
              }
              else if(counterB == 2)                    //Same as above
              {
                digitalWrite(LED1R, HIGH);
                delay(100);
                digitalWrite(LED1R, LOW);
                userDigitTwo = counterA;
                counterA = 0;
                Display.show("    ");
                Display.showDigitAt(0, 2);
                Display.showCharAt(2, 'c');
                Display.showCharAt(3, 'f');
                counterB++;
                Serial.print("Confirmed 2nd Digit: "); 
                Serial.println(userDigitTwo);
              }
              else if(counterB == 3)                      //Same as above
              {
                digitalWrite(LED1R, HIGH);
                delay(100);
                digitalWrite(LED1R, LOW);
                userDigitThree = counterA;
                counterA = 0;
                Display.show("    ");
                Display.showDigitAt(0, 3);
                Display.showCharAt(2, 'c');
                Display.showCharAt(3, 'f');
                counterB++;
                Serial.print("Confirmed 3rd Digit: "); 
                Serial.println(userDigitThree);
              }
              else if(counterB == 4)                      //Same as above
              {
                digitalWrite(LED1R, HIGH);
                delay(100);
                digitalWrite(LED1R, LOW);
                userDigitFour = counterA;
                counterA = 0;
                Display.show("    ");
                Display.showDigitAt(0, 4);
                Display.showCharAt(2, 'c');
                Display.showCharAt(3, 'f');
                counterB++;
                Serial.print("Confirmed 4th Digit: "); 
                Serial.println(userDigitFour);
     
     if(counterB++>4)
     {
       if (passNumOne == userDigitOne && passNumTwo == userDigitTwo && passNumThree == userDigitThree && passNumFour == userDigitFour)      //This is where we check  if the inputted digits
         {//success                                                                                                                                  are the same as the pre-set password
         digitalWrite(LED2G, HIGH);                         
         Display.show("    ");                                 //clearing the display and setting a message you've unlocked the safe
         Display.showCharAt(0, '-');
         Display.showCharAt(1, 'd');
         Display.showCharAt(2, 'a');
         Display.showCharAt(3, '-');
       
         Serial.println("Safe unlocked!");
         counterB = 1;
       
      /*Display.show("    ");                               //I want to make changes to the Library provided but that will work only on the edited library (on my pc)
       Display.showCharAt(0, 'p');                          //so I commented this part
       Display.showCharAt(1, 'a');
       Display.showCharAt(2, '5');
       Display.showCharAt(3, '5');*/
         }
         else 
         {                                                          //fail of right code
         Serial.println("Wrong password ! Please try again !");
         digitalWrite(LED1R, HIGH);                          //Red LED that indicate wrong password
         Display.show("    ");                                //Clear the Display and display a message indicating the password is wrong and start inputting digits again, without having to activate the program again
         Display.showCharAt(0, 'f');
         Display.showCharAt(1, 'f');
         Display.showCharAt(2, 'f');
         Display.showCharAt(3, 'f');
         counterB = 1;
        }
       } 
      }
      else if(key2Click != true)                            //we dont use that but we can use it if we need more functionalities
      {
      }
    }
   }
  }
 }
}  
