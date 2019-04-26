/////////////////////////////////////////////
//This software was written for Crystal IS //
//to measure responsivity of photodetectors//
//by James Davis in 2019                   //
/////////////////////////////////////////////

String receivedString = "";
int port = A0;
void setup() {
  Serial.begin(9600);
  delay(1000);
  Serial.print("ready");
}

void loop() {
  if(Serial.available()) {
    receivedString = Serial.readStringUntil('\n');
    if (receivedString == "read") {
      Serial.println(analogRead(port));
    }
    if (receivedString.indexOf("port=")>0){
      port = receivedString.substring(receivedString.indexOf("port=")+5).toInt();
      Serial.println("port set to " + port);
    }
  }
}
