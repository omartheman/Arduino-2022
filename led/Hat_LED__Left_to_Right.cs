

void setup()
{
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);

}

int delayTime; 

void loop()
{
  // Do a for loop that counts up to 10 
  // and turns on the LED each time
  
  for (int i = 0; i < 20; i++)
  {
    // create a variable i multiplied by 100
    // and assign it to the variable delayTime
    int delayMultiplier = 50; 
    if (i < 10){
      delayTime = i * delayMultiplier;
    }
    // When i is over 10, make lights start slowing down again.
    else {
      // int delayTime = ((i - 2) * i ) * 100;
      delayTime = ( i + ( -2 * (i - 10) ) ) * delayMultiplier;
    }


    // 10 * 100 = 1000
    // (11 + x) * 100 = 900
    // (11 + x) * 1 = 9
    // (11 + x) = 9
    // (x) = -2

    // (12 + x) * 100 = 800
    // (12 + x) = 8
    // (x) = -4

    // (13 + x) * 100 = 700
    // (13 + x) = 7
    // (x) = -6

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