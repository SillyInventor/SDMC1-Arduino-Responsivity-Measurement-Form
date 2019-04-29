/////////////////////////////////////////////
//This software was written for Crystal IS //
//to measure responsivity of photodetectors//
//by James Davis in 2019                   //
/////////////////////////////////////////////

String receivedString = "";

int port = A0;
int lengthOfReading = 500;

unsigned long readTime = 0;

double finalReading = 0;
double numberOfReadings = 0;
double reading = 0;

boolean takeReading = false;

void setup() {
  Serial.begin(9600);
  delay(100);
  Serial.println("ready");
}

void loop() {
  // Have you completed a reading? If so, then send the reading
  if(takeReading && millis()>readTime) {
    finalReading = reading / numberOfReadings;
    numberOfReadings = 0;
    reading = 0;
    takeReading = false;
    Serial.println(finalReading);
  }
  // Are you still collecting a reading?
  else if(takeReading) {
    reading += analogRead(port);
    numberOfReadings++;
  }
  // Are you being told to do something?
  if(Serial.available()) {
    receivedString = Serial.readStringUntil('\n');
    if (receivedString == "read") { // Start reading
      readTime = millis() + lengthOfReading;
      takeReading = true;
    }
    if (receivedString.indexOf("port=")>=0){ // Set your port number
      Serial.println(receivedString.substring(receivedString.indexOf("port=")+5));
      port = receivedString.substring(receivedString.indexOf("port=")+5).toInt();
      Serial.println("port set to " + port);
    }
  }
}
