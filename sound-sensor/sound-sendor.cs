void setup() {
  
  Serial.begin(9600); // setup serial
  pinMode(7, OUTPUT);
  
}

void loop() {
  Serial.println(analogRead(A0));
  delay(100);
  
  
  if (analogRead(A0) > 100){
    digitalWrite(7, HIGH);  
  }
  else {
    digitalWrite(7, LOW);  
  }

} 