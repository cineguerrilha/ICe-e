// Adafruit Motor shield library
// copyright Adafruit Industries LLC, 2009
// this code is public domain, enjoy!

#include <AFMotor.h>
uint8_t i;
AF_DCMotor motor(3);
boolean ramping=true;
void setup() {
  // turn off motor
  motor.setSpeed(0);
  motor.run(RELEASE);
  pinMode(13, INPUT);
}

void loop() {
  int MaxSpeed=150;
  motor.run(FORWARD);

  // wait for a pulse in port 13
  
   while(digitalRead(13) == LOW) 
   {  //While loop that SHOULD end if the input goes low
            delay(100);                                                // wait 100 ms
            // increase the counter
   }

   // rampa pra cima
 for (i=0; i<MaxSpeed; i++) {
    motor.setSpeed(i);  
    delay(200);
 }

delay(40000); //tempo de velocidade maxima

// rampa pra baixo
 for (i=MaxSpeed-1; i>0; i--) {
    motor.setSpeed(i);  
    delay(200);
 }
 
}
