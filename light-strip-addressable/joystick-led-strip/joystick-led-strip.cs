//https://create.arduino.cc/projecthub/MisterBotBreak/how-to-use-a-joystick-with-serial-monitor-1f04f0
 
/*****************  NEEDED TO MAKE NODEMCU WORK ***************************/
#define FASTLED_INTERRUPT_RETRY_COUNT 0
#define FASTLED_ESP8266_RAW_PIN_ORDER
/******************  LIBRARY SECTION *************************************/
#include <FastLED.h>
/*****************  LED LAYOUT AND SETUP *********************************/
#define NUM_LEDS 500
/*****************  DECLARATIONS  ****************************************/
CRGB leds[NUM_LEDS];
/*****************  GLOBAL VARIABLES  ************************************/
const int ledPin = 5; //marked as D2 on the board
/*****************  SETUP FUNCTIONS  ****************************************/


// ###########JOYSTICK  

int VRx = A0;
int VRy = A1;
int SW = 2;

int xPosition = 0;
int yPosition = 0;
int SW_state = 0;
int mapX = 0;
int mapY = 0;


// this constant won't change:
const int  buttonPin = 2;    // the pin that the pushbutton is attached to
// const int ledPin = 13;       // the pin that the LED is attached to

// Variables will change:
int buttonPushCounter = 0;   // counter for the number of button presses
int buttonState = 0;         // current state of the button
int lastButtonState = 0;     // previous state of the button

void setup() {
  // initialize the button pin as a input:
  pinMode(buttonPin, INPUT);
  // initialize the LED as an output:
  // pinMode(ledPin, OUTPUT);
  // initialize serial communication:
  Serial.begin(9600);
  buttonPushCounter;
  
  FastLED.addLeds<WS2812B, ledPin, RGB>(leds, NUM_LEDS);
  
  
  
  // ####### JOYSTICK : 
  
  pinMode(VRx, INPUT);
  pinMode(VRy, INPUT);
  pinMode(SW, INPUT_PULLUP); 
}


void loop() {
  
  // ###########  JOYSTICK
  
  xPosition = analogRead(VRx);
  yPosition = analogRead(VRy);
  SW_state = digitalRead(SW);
  mapX = map(xPosition, 0, 1023, -512, 512);
  mapY = map(yPosition, 0, 1023, -512, 512);
  
  Serial.print("X: ");
  Serial.print(mapX);
  Serial.print(" | Y: ");
  Serial.print(mapY);
  Serial.print(" | Button: ");
  Serial.println(SW_state);

  delay(100);
  
  
  // ########### LED 
  
  // read the pushbutton input pin:
  buttonState = mapX;

  // compare the buttonState to its previous state
  if (true) {
    // if the state has changed, increment the counter
    if (true) {
      // if the current state is HIGH then the button went from off to on:
      
      if (mapX > 200){
        buttonPushCounter++;
      }
      Serial.println("on");
      Serial.println("number of button pushes: ");
      Serial.println(buttonPushCounter);
    } else {
      // if the current state is LOW then the button went from on to off:
      Serial.println("off");
    }
    // Delay a little bit to avoid bouncing
    delay(50);
  }
  // save the current state as the last state, for next time through the loop
  lastButtonState = buttonState;


  // turns on the LED every four button pushes by checking the modulo of the
  // button push counter. the modulo function gives you the remainder of the
  // division of two numbers:
  if (buttonPushCounter % 4 == 0) {
    // digitalWrite(ledPin, HIGH);
  } else {
    // digitalWrite(ledPin, LOW);
  }

  leds[buttonPushCounter - 1] = CHSV (0, 0, 0);
  leds[buttonPushCounter] = CHSV (96, 255, 192);
  FastLED.show();
  
  
  
}
/*

*/
