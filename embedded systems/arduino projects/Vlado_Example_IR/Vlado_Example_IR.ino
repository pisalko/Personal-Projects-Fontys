#include <IRremote.h>

IRreceive irrecv(2);
decode_results results;
void setup() {
  Serial.begin(9600);
  irrecv.enable();
}

void loop() {
  if(irrecv.decode(&results)){
    irrecv.resume();
    Serial.println(results.value, HEX);
  }
}
