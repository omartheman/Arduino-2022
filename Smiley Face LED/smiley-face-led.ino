

void setup() {
  // put your setup code here, to run once:

  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(4, OUTPUT);

}

void loop() {

  //Eyes
  digitalWrite(12, LOW);
  delay(200); 
  digitalWrite(12, HIGH);
  digitalWrite(11, LOW); 
  delay(200); 
  digitalWrite(11, HIGH);
  delay(200); 

  //Smiley 
  digitalWrite(10, HIGH);
  digitalWrite(9, HIGH);
  digitalWrite(8, HIGH);
  digitalWrite(7, HIGH);
  digitalWrite(6, HIGH);
  digitalWrite(5, HIGH);
  digitalWrite(4, HIGH);

  digitalWrite(10, LOW);
  delay(200);
  digitalWrite(10, HIGH);
  digitalWrite(8, LOW);
  delay(200);
  digitalWrite(8, HIGH);
  digitalWrite(5, LOW);
  delay(200);
  digitalWrite(5, HIGH);
  digitalWrite(4, LOW);
  delay(200);
  digitalWrite(4, HIGH);
  digitalWrite(6, LOW);
  delay(200);
  digitalWrite(6, HIGH);
  digitalWrite(7, LOW);
  delay(200);
  digitalWrite(7, HIGH);
  digitalWrite(9, LOW);
  delay(200);
  digitalWrite(9, HIGH);
}
