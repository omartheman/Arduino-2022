

void setup()
{
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
}

void loop()
{
  // Do a for loop that counts up to 10 
  // and turns on the LED each time
  
  for (int i = 0; i < 10; i++)
  {
    // create a variable i multiplied by 100
    // and assign it to the variable delayTime
    int delayTime = i * 100;

    digitalWrite(12, HIGH);  
    digitalWrite(11, LOW);  
    digitalWrite(10, LOW); 

    delay(delayTime);

    digitalWrite(12, LOW);  
    digitalWrite(11, HIGH);  
    digitalWrite(10, LOW);  

    delay(delayTime);

    digitalWrite(12, LOW);  
    digitalWrite(11, LOW);  
    digitalWrite(10, HIGH);  

    delay(delayTime);

  }
  
}