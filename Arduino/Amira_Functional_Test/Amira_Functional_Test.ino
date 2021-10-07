//////////////////////////////////////////////////////////////////////////////////
/*  Site:           SMTC Florida
    Customer:       Lumira
    FileName:       Amira_Functional_Test.c
    Revision:       1
    Created on:     10/05/2021
    Last Modified:  10/06/2021
    Developer(s):   B.Trigoboff
    Description:    Runs functional test for Lumira Amira


*/
//////////////////////////////////////////////////////////////////////////////////

//pin declarations

void setup()
{
  Serial.begin(9600);

  //pin assignments
  //photoresistors
  pinMode(2, INPUT_PULLUP);
  pinMode(3, INPUT_PULLUP);
  pinMode(4, INPUT_PULLUP);
  pinMode(5, INPUT_PULLUP);
  pinMode(6, INPUT_PULLUP);
  pinMode(7, INPUT_PULLUP);
  pinMode(8, INPUT_PULLUP);

  //device id pins
  pinMode(10, INPUT_PULLUP);
  pinMode(11, INPUT_PULLUP);
  pinMode(12, INPUT_PULLUP);

  //voltage sense pins
  //pinMode(14, INPUT);
  //pinMode(15, INPUT);
}

void loop()
{

  getDeviceId();
  checkLeds();
  //checkMotorA();
  //checkMotorB();
  delay(3000);
}

//checks digital pins for three bit identification
//digital pins are pulled up, dip switch is NOT-ed e.g. on on off = 001
void getDeviceId()
{
  //variable to hold unit under test (deviceUnderTest) value
  int deviceUnderTest = 0;

  //variables to hold swith positions (ID_0 = switch position 0)
  int ID_0 = 0;
  int ID_1 = 0;
  int ID_2 = 0;

  //read D10, D11, D12 and store value in ID variables
  ID_0 = digitalRead(10);
  ID_1 = digitalRead(11);
  ID_2 = digitalRead(12);

  if (ID_0 == 0 & ID_1 == 0 & ID_2 == 0)
  {
    deviceUnderTest = 0;
  }
  else if (ID_0 == 0 & ID_1 == 0 & ID_2 == 1)
  {
    deviceUnderTest = 1;
  }
  else if (ID_0 == 0 & ID_1 == 1 & ID_2 == 0)
  {
    deviceUnderTest = 2;
  }
  else if (ID_0 == 0 & ID_1 == 1 & ID_2 == 1)
  {
    deviceUnderTest = 3;
  }
  else if (ID_0 == 1 & ID_1 == 0 & ID_2 == 0)
  {
    deviceUnderTest = 4;
  }
  else if (ID_0 == 1 && ID_1 == 0 && ID_2 == 1)
  {
    deviceUnderTest = 5;
  }
  else if (ID_0 == 1 & ID_1 == 1 & ID_2 == 0)
  {
    deviceUnderTest = 6;
  }
  else if (ID_0 == 1 & ID_1 == 1 & ID_2 == 1)
  {
    deviceUnderTest = 7;
  }

  Serial.println();
  Serial.print("DEVICE_UNDER_TEST = ");
  Serial.print(deviceUnderTest , DEC);
  Serial.println();
  Serial.println();
}

void checkLeds()
{
  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_0 = digitalRead(2);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_1 = digitalRead(3);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_2 = digitalRead(4);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_3 = digitalRead(5);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_4 = digitalRead(6);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_5 = digitalRead(7);

  //send command to DUT to turn LED_0 on
  //*INSERT UART STRING COMMAND HERE*
  int PR_6 = digitalRead(8);

  if (PR_0 == 0 && PR_1 == 0 && PR_2 == 0 && PR_3 == 0 && PR_4 == 0 && PR_5 == 0 && PR_6 == 0)
  {
    Serial.println("ALL_LEDS_FUNCTIONING");
    Serial.println();
  }
  if (PR_0 == 0)
  {
    Serial.println("LED0_FUNCTIONING");
  }
  if (PR_0 == 1)
  {
    Serial.println("LED0_NOT_FUNCTIONING");
  }
  if (PR_1 == 0)
  {
    Serial.println("LED1_FUNCTIONING");
  }
  if (PR_1 == 1)
  {
    Serial.println("LED1_NOT_FUNCTIONING");
  }
  if (PR_2 == 0)
  {
    Serial.println("LED2_FUNCTIONING");
  }
  if (PR_2 == 1)
  {
    Serial.println("LED2_NOT_FUNCTIONING");
  }
  if (PR_3 == 0)
  {
    Serial.println("LED3_FUNCTIONING");
  }
  if (PR_3 == 1)
  {
    Serial.println("LED3_NOT_FUNCTIONING");
  }
  if (PR_4 == 0)
  {
    Serial.println("LED4_FUNCTIONING");
  }
  if (PR_4 == 1)
  {
    Serial.println("LED4_NOT_FUNCTIONING");
  }
  if (PR_5 == 0)
  {
    Serial.println("LED5_FUNCTIONING");
  }
  if (PR_5 == 1)
  {
    Serial.println("LED5_NOT_FUNCTIONING");
  }
  if (PR_6 == 0)
  {
    Serial.println("LED6_FUNCTIONING");
  }
  if (PR_6 == 1)
  {
    Serial.println("LED6_NOT_FUNCTIONING");
  }
  Serial.println();
}
