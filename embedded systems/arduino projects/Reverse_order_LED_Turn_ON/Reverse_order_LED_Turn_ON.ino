/**
 * Rich shield example
 * Adapted from Rich Shield Example Code
 * Fontys University of Applied Science
 * Name: RunLed
 * Date: 01 July 2019
 * Author: Jaap Geurts
 * Version 1.0
 */

const int LED1 = 4;
const int LED2 = 5;
const int LED3 = 6;
const int LED4 = 7;

// the currently active led.
int current = LED4;

// Runs once at startup
void setup()
{
    // Set the four ports to output.
    pinMode(LED1, OUTPUT);
    pinMode(LED2, OUTPUT);
    pinMode(LED3, OUTPUT);
    pinMode(LED4, OUTPUT);
}

// Runs forever
void loop()
{
    digitalWrite(current, HIGH); //turn on LED i
    delay(500);
    digitalWrite(current, LOW); //turn it off.

int i = 1;

    // advance to the next led

for ( i = 1, i



}
        
