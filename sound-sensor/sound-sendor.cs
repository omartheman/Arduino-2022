void setup() {
  
  Serial.begin(9600); // setup serial
  pinMode(7, OUTPUT);
  
}

int counter = 0; 

void loop() {
  Serial.println(analogRead(A0));
  delay(100);
  
  
  if (analogRead(A0) > 100){
    counter++; 
  }

  if (counter % 2 == 0){
    digitalWrite(7, HIGH);  
  }
  else {
    digitalWrite(7, LOW); 
  }


} 