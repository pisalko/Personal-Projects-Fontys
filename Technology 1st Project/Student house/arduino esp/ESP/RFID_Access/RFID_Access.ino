#define SS_PIN D4  //D2
#define RST_PIN D3 //D1

#include <SPI.h>
#include <MFRC522.h>

MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.

String oldContent = "";
bool once = true;

void setup()
{
  Serial.begin(9600);   // Initiate a serial communication
  SPI.begin();      // Initiate  SPI bus
  mfrc522.PCD_Init();   // Initiate MFRC522
}
void loop()
{
  // Look for new cards
  if ( ! mfrc522.PICC_IsNewCardPresent())
  {
    return;
  }
  // Select one of the cards
  if ( ! mfrc522.PICC_ReadCardSerial())
  {
    return;
  }

  //Show UID on serial monitor
  //Serial.println();
  //Serial.print(" UID tag :");
  String content = "";
  byte letter;
  for (byte i = 0; i < mfrc522.uid.size; i++)
  {
    //Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
    //Serial.print(mfrc522.uid.uidByte[i], HEX);
    content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
    content.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  content.toUpperCase();
  if (once)
  {
    oldContent = content;
    
  }
  if (oldContent != content || once)
  {
    Serial.println(content);
    oldContent = content;

    once = false;
    /*Serial.println();
    if (content.substring(1) == "4A 43 5F 24") //change UID of the card that you want to give access
    {
      //Serial.println(" Access Granted ");
      //Serial.println(" Welcome Mr.Circuit ");

      //Serial.println(" Have FUN ");
      //Serial.println();
      oldContent = content;
    }

    else   
    {
      Serial.println(" Access Denied ");
      oldContent = content;
    }*/
  }
  else
  {
    //If the card read is the same
  }
}
