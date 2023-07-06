#include <SoftwareSerial.h>
#include <Arduino.h>
#define BtnUP 6
#define BtnDN 5
#define JoyStick 8

const int AXIS_X = A0;
const int AXIS_Y = A1;
SoftwareSerial BT(3, 2);

void setup() {
  
  Serial.begin(9600);
  BT.begin(9600);

  pinMode(BtnUP, INPUT);
  pinMode(BtnDN, INPUT);
  pinMode(JoyStick, INPUT_PULLUP);
}

void loop() {
  
    if (digitalRead(BtnUP) == HIGH) {
    BT.println("U");
    //   delay(500);
  }

  if (digitalRead(BtnDN) == HIGH) {
    BT.println("D");
  }
Serial.println(analogRead(AXIS_X));
//Serial.println(analogRead(AXIS_Y));


 //X축 방향값
  if (analogRead(AXIS_X) <= 400) {
    BT.println("a");
  } else if (analogRead(AXIS_X) >= 700) {
    BT.println("d");
  }
  //Y축 방향값
  if (analogRead(AXIS_Y) <= 400 ) {
    BT.println("s");
  } else if (analogRead(AXIS_Y) >= 700) {
    BT.println("w");
  }
}
