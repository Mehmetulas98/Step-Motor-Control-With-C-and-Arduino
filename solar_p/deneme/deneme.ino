void setup() {
  Serial.begin(9600);
}


void loop() 
{
  if(Serial.available())
  {
    char c = Serial.read();
    if(c == '1')
    {
    digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(1000);                       // wait for a second
    digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
    delay(1000); 
    }
     
  }
}


 
