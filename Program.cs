// Console.WriteLine("Hello, Wolrd");
// Console.WriteLine("My name is Kayode");

//varriable decleration(int, double, string, bool)


int age = 50;

string name = "Al Ameen";

double height = 32.5;

bool isPresent = false;

age = 25;
/////////////////////////////////


// Console.WriteLine(name + " " + height ); //string concatination
//
// Console.WriteLine($"{name} {height}"); //string interpolation

//Console.WriteLine("My name is " + name + " I am " + age + " years old, " + (isPresent=false),"");

//Console.WriteLine($"My_name_is_{name}_and_I_am_{age}_years_old_my_height_is_{height}");

//March 7th 2026

decimal money = 1300000.3764783m;

float temperature = 30.5f;
char firstletter = 'f';
char secondletter = 'a';
char thirdletter = 't';
char fourthletter = 'e';
long pop = 25346645664564;

//Console.WriteLine($"welcome {firstletter}{secondletter}{thirdletter}{fourthletter}");

String score = "F";
 name = "Fatimah";

// int , memory = 4byte , whole number , e.g: 10, 20, 30
//float, memory = 4byte, decimal number(less precision), e.g : 10.5f, 20.5f
//double, memory = 8byte, decimal numbers , e.g: 10.857, 67.938, 10.5
//long, memory = 8byte, very large numbers , e.g: 9000000, 8000000, 9000003
//decimal, memory = 16byte, very pricise value(money), e.g: bank account balance

//max and min for -2,147.483,648 and max 2,147,484647

//Subject: Operators

//we have four operators: +, -, *, /, %

int a = 45;
int b = 40;
int addedresult = a + b;
int subtractedresult = a - b;
int multiplicationResult = a * b;
double divisionResult = (double)a / b;

// Console.WriteLine($"Adding a and b value = {addedresult}"); // string interpolation
// Console.WriteLine($"Subtracting a and b value = {subtractedresult}");
// Console.WriteLine($"Multiplying a and b value = {multiplicationResult}");
// Console.WriteLine($"Dividing a and b value = {divisionResult}");

// there is something we call precision loss and no precision loss

int pop1 = 200000;
long pop2 = 9000000000;

long popresult = pop1 + pop2;
//Console.WriteLine($"Population Total = {popresult}"); //no precision

int jumahbalance = 100;
double sweetprice = 5.75;

double jumahamountleft = jumahbalance - sweetprice;

//Console.WriteLine($"Jumah balance = {jumahamountleft}"); //no precision loss
//////////////


float value1 = 5.23437448f;
decimal value2 = 2.5m;

//decimal valueresult = (decimal)value1 + value2;//precision loss

float valueresult = value1 + (float)value2;//no precision

//Console.WriteLine($"Al ameen said totol added = {valueresult}"); 
//////////



double accountbalance = 10.3475;
decimal accountbalance2 = 5.20m;

decimal accountresult = (decimal)accountbalance + accountbalance2;

//Console.WriteLine($"Al Ameen said value added is {accountresult}");//15.5475


//Easy rules
//int + long => safe
//int + double => safe
//float + double => some precision loss
//double + decimal => conversion needed 
//float 



//Example

int ab = 45;
int bc = 40;

int remainder = ab % bc;

//Console.WriteLine($"Remainder value is {remainder}");

