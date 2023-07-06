#include <Servo.h>
#include <SoftwareSerial.h>
//엄지-검지-중지-약지-새끼
#define Vibe1 8
#define Vibe2 5
#define Vibe3 4
#define Vibe4 7
#define Vibe5 6
Servo servo[3];
const byte servoPin[3]={9,10,11};
int flexpin1=A1; //검지
int flexpin2=A2; //중간손가락


const int rxPin = 2;
const int txPin = 3;

SoftwareSerial BT(rxPin, txPin);

void setup() {

  Serial.begin(9600);
  BT.begin(9600);
  servo[0].attach(servoPin[0]);
  servo[1].attach(servoPin[1]);
  servo[2].attach(servoPin[2]);
  pinMode(Vibe1, OUTPUT);
  pinMode(Vibe2, OUTPUT);
  pinMode(Vibe3, OUTPUT);
  pinMode(Vibe4, OUTPUT);
  pinMode(Vibe5, OUTPUT);
}

void loop() {
  //검지 손가락 플렉서
  /*int flexVal;
  flexVal=analogRead(flexpin1);
  //Serial.print("sensor: "); Serial.print(flexVal);
  delay(300);
 
  if(flexVal>450){
    servo[0].write(90);
    servo[1].write(90);
    servo[2].write(90);
    BT.println("G");
  
    //Serial.print("sensor: "); Serial.print(flexVal);
    Serial.println("    grabbing the block");
    
  }
  if(flexVal<=420){
    servo[0].write(0);
    servo[1].write(0);
    servo[2].write(0);
    delay(20);
    //Serial.print("sensor: "); Serial.print(flexVal);
    Serial.println("    normal state");
    
  }*/
  //중지 손가락 플렉서
  int flexVal2;
  flexVal2=analogRead(flexpin2);
  Serial.print("sensor: "); Serial.print(flexVal2);
  delay(300);
 
  if(flexVal2>450){
    servo[0].write(90);
    servo[1].write(90);
    servo[2].write(90);
    BT.println("G");
  
    //Serial.print("sensor: "); Serial.print(flexVal);
    Serial.println("    grabbing the block");
    
  }

  if(flexVal2<=430){
    servo[0].write(0);
    servo[1].write(0);
    servo[2].write(0);
    delay(20);
    //Serial.print("sensor: "); Serial.print(flexVal);
    Serial.println("    normal state");
    
  }

    if (BT.available())
   {
    
    char cmd = BT.read();
    //Serial.print(cmd);

    if(cmd=='1'){
      Serial.println("tumb finger viberate feedback");
      analogWrite(Vibe1, 255);
      delay(1500);
      analogWrite(Vibe1, 0);
      delay(500);
    }
    if (cmd == '2') {
      Serial.println("index finger viberate feedback");
      analogWrite(Vibe2, 255);
      delay(1500);
      analogWrite(Vibe2, 0);
      delay(500);
    }
    if (cmd == '3') {
      Serial.println("middle finger viberate feedback");
      analogWrite(Vibe3, 255);
      delay(1500);
      analogWrite(Vibe3, 0);
      delay(500);
    }
    if (cmd == '4') {
      Serial.println("ring finger viberate feedback");
      analogWrite(Vibe4, 255);
      delay(1500);
      analogWrite(Vibe4, 0);
      delay(500);
    }
    if (cmd == '5') {
      Serial.println("pinky finger viberate feedback");
      analogWrite(Vibe5, 255);
      delay(1500);
      analogWrite(Vibe5, 0);
      delay(500);
    }
 
   
   }

}