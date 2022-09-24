

void setup()
{
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
}

void loop()
{
  digitalWrite(12, HIGH);  
  digitalWrite(11, LOW);  
  digitalWrite(10, LOW);  
  
  delay(500);
  
  digitalWrite(12, LOW);  
  digitalWrite(11, HIGH);  
  digitalWrite(10, LOW);  
  
  delay(500);
  
  digitalWrite(12, LOW);  
  digitalWrite(11, LOW);  
  digitalWrite(10, HIGH);  
  
  delay(500);
}