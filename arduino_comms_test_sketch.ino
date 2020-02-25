const int LedPin = 13;  
int ledState = 0;  

void setup()  
{   
  pinMode(LED_BUILTIN, OUTPUT);  
  Serial.begin(9600);    
}  

void loop()  
{   
    char receiveVal;     

    if(Serial.available() > 0)  
    {          
        receiveVal = Serial.read();  

       if(receiveVal == '1')      
          ledState = 1;     
       else  
          ledState = 0;       
    }     

    digitalWrite(LED_BUILTIN, ledState);   

    delay(50);      
}
