// Console.WriteLine("Hello, Wolrd");
// Console.WriteLine("My name is Kayode");

//varriable decleration(int, double, string, bool)


using System.ComponentModel.Design;
using System.Diagnostics;

//int age = 50;

//string name = "Al Ameen";

double height = 32.5;

bool isPresent = false;

//age = 25;
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

//String score = "F";
// name = "Fatimah";

// int , memory = 4byte , whole number , e.g: 10, 20, 30
//float, memory = 4byte, decimal number(less precision), e.g : 10.5f, 20.5f
//double, memory = 8byte, decimal numbers , e.g: 10.857, 67.938, 10.5
//long, memory = 8byte, very large numbers , e.g: 9000000, 8000000, 9000003
//decimal, memory = 16byte, very pricise value(money), e.g: bank account balance

//max and min for -2,147.483,648 and max 2,147,484647

//Subject: Operators

//we have four operators: +, -, *, /, %

// int a = 45;
// int b = 40;
// int addedresult = a + b;
// int subtractedresult = a - b;
// int multiplicationResult = a * b;
// double divisionResult = (double)a / b;

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

//int ab = 45;
//int bc = 40;

//int remainder = ab % bc;

//Console.WriteLine($"Remainder value is {remainder}");


// int balance = 5000;
// int amounttransfered = 3000;

//int newbalance = balance - amounttransfered;//conventional way
//Console.WriteLine($"new balance  is {newbalance}");
//balance -= amounttransfered; //Prefered way

//Console.WriteLine($"new balance  is {balance}");

// int cd = 2;
// int de = 5;
//
// int jk = cd * de;// convensional way
//  cd *= de;

//Console.WriteLine($"new balance  is {cd}");


// march 8 2026

//Comparison Operators
// ==, equal to.
// !=, not equal to.
// >, greater than.
// <, less than.
// >=, greater than or equal to.
// <=, less than or equal to.

//Example
// int a = 10;
// int b = 10;

// Console.WriteLine(a > b);//true
// Console.WriteLine(a == b);//false
// Console.WriteLine(a != b);//true

// we make use of if and if-else for conditional operator;
// if (a > b)
// {
//     Console.WriteLine("Al Ameen was right about a > b");
// }
// else if (a == b)
// {
//     Console.WriteLine("Al Ameen was right about a = b");
// }
// else if (a < b)
// {
//     Console.WriteLine("Al Ameen was right about a < b");
// }
// else
// {
//     Console.WriteLine("Tutor said Al Ameen was wrong");
// }

//Another Example

// int score = 100;
//
// if (score >= 70)
// {
//     Console.WriteLine("Grade A");
// }    
// else if (score >= 60)
// {
//     Console.WriteLine("Grade B");
// }
// else if (score >= 50)
// {
//     Console.WriteLine("Grade C");
// }
// else
// {
//     Console.WriteLine("Fail");
// }


// Logical operators
// && , means "AND" , this binds true and true values
// || , means "OR" , only one has to be true
// | , means "NOT"


// Example of logical and comparision operators

// Using &&

// int score = 30;
//
// if (score >= 50 && score <= 100)
// {
//     Console.WriteLine("Passed");
// }
// else
// {
//     Console.WriteLine("Failed");
// }

// bool paidfees = true;
// bool hasicard = false;
// bool hasdonematric = true;
//
// if (paidfees && hasicard && hasdonematric)
// {
//     Console.WriteLine("You can enter the exam hall");
// }
// else
// {
//     Console.WriteLine("You cannot enter the exam hall");
// }

// Using ||

// bool isStudent = false;
// bool isSeniorCitizen = false;
//
// if (isStudent || isSeniorCitizen)
// {
//     Console.WriteLine("You are qualified for discount");
// }
// else
// {
//     Console.WriteLine("You are not qualified for discount");
// }




//  combine the && and ||

bool paidfees = true;
bool hasIcard = true;
bool hasdonematic = false;
bool hasdoneRegistration = false;
bool isCitizen = false;




//1
// if ((paidfees && hasIcard) || hasdonematic)
// {
//     Console.WriteLine("Student can enter exam hall");
// }
// else
// {
//     Console.WriteLine("Student cannot enter exam hall");
// }

//2
// if ((hasdoneRegistration && paidfees) || isCitizen)
// {
//     Console.WriteLine("Access Granted");
// }
// else
// {
//     Console.WriteLine("Access Denied");
// }

//3
// if (paidfees && (hasdonematic || hasdoneRegistration))
// {
//     Console.WriteLine("Student is fully verified");
// }
// else
// {
//     Console.WriteLine("Student is not verified");
// }

//4
// if ((paidfees && hasIcard) && (hasdonematic || hasdoneRegistration || isCitizen))
// {
//     Console.WriteLine("Student Cleared");
// }
// else
// {
//     Console.WriteLine("Student Not Cleared");
// }

//5
// if ((paidfees && hasIcard) && (hasdonematic || hasdonematic)
//     || (isCitizen && hasIcard))
// {
//     Console.WriteLine("Student can write the final exam");
// }
// else
// {
//     Console.WriteLine("Student cannot write the final exam");
// }

//6
// if (paidfees && hasIcard && hasdonematic || hasdonematic
//                                          || isCitizen && hasIcard && hasdonematic)
// {
//     Console.WriteLine("Student approved");
// }
// else
// {
//     Console.WriteLine("Student not approved");
// }

//7
// if (isCitizen && hasdonematic || hasdoneRegistration && paidfees && hasIcard)
// {
//     Console.WriteLine("Student approved for the exam");
// }
// else
// {
//     Console.WriteLine("Student not approved for the exam");
// }

//8
// if (isCitizen && hasdonematic || hasdoneRegistration && paidfees && hasIcard || paidfees)
// {
//     Console.WriteLine("Student approved for the exam");
// }
// else
// {
//     Console.WriteLine("Student not approved for the exam");
// }


// 14/march/2026
//Operator => /-

// bool passedExam = false;
// if (passedExam)
// {
//     Console.WriteLine("You have not passed the exam!");
// }
// else
// {
//     Console.WriteLine("You have passed the exam!"); 
// }






// do-while
// 1) code run first
// 2) then check the condition
// 3) if true it repeats

// int i = 1;
// do
// {
//     Console.Write(i);
//     i++;
// } while (i <= 5);

//for loop
// This is used when you know the number of time you want to loop
//for(innitialization, ConditionalAttribute, update)
// {
//  code to run
// }

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

//For Al Ameen use while loop... 32 to 67

// int i = 32;
// while (i <= 67)
// {
//     Console.WriteLine(i);
//     i++;
// }

//For Al Ameen do-while loop...99 to 107

// int i = 99;
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (i <= 107);

//For Al Ameen For loop...125 to 176
// for (int i = 125; i <= 176; i++)
// {
//     Console.WriteLine(i);
// }


// Print even number from 1 to 20

// for (int i = 1; i <= 20; i++)
// {
//     if (i % 2 != 0)
//     {
//         Console.WriteLine(i);
//     }
// }


//Arrays
// Arrays is used to store multiple of same data type in one variable

int num1 = 10;
int num2 = 20;
int num3 = 30;

// int[] numbers = { 10, 20, 30}; // array of numbers

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

string student1 = "Al Ameen";
string student2 = "Kayode";
string student3 = "Lekan";

// string[] students = {"Al Ameen", "Zara", "Abeni", "Kayode", "Lekan", "Ishola" }; // Array of students

//Console.WriteLine($"Abeni name to be printed\n...Print out result =\n{students[2]}"); // abeni 
//Console.WriteLine($"Zara name to be printed\n...Print out result =\n{students[1]}"); // Zara 

// indexing starts from o
// length starts from 1
//Console.WriteLine(students.Length); // this prints the length of students

// for (int i = 0; i < students.Length; i++)
// {
//     Console.WriteLine(students[i]);
// }

// using loop to add numbers together

// int[] numbers = { 10, 20, 30, 40}; // array of numbers
//
// int sum = 0; //base number we want to use to perform add operation
//
// for (int i = 0; i < numbers.Length; i++)
// {
//     sum = sum + numbers[i];
// }
// // sum = 0 + (numbers[0]) 10 = 10
// // sum = 10 + (numbers[1]) 20 = 30
// // sum = 30 + (numbers[2]) 30 = 60
// // sum = 60 + (numbers[3]) 40 = 100
//
//
// Console.WriteLine($"Sum of all the numbers = {sum}");

// using loop to multiply together
// int[] numb = {2, 3, 4, 5, 6};
//
// int mult = 1;
// for (int i = 0; i < numb.Length; i++)
// {
//     mult = mult * numb[i];
// }
// Console.WriteLine($"Multiplication of all the numbers = {mult}");


// Lets build multiplication table

// int multilicationtable = 2;
//
// for (int i =1; i <= 12; i++)
// {
//     Console.WriteLine($"{multilicationtable} x {i} = {multilicationtable * i}");
// }

// 2 x 1 = 2
// 2 x 2 = 4


// March 15th 2026
//Foreach, switch statement and User input

//Foreach
//This is used to iterate through arrays or collections easily without using indexes : Example below

// string[] students = {"Al Ameen", "Zara", "Abeni", "Kayode", "Lekan", "Ishola" }; // Array of students
//
// foreach (string student in students)
// { 
//     Console.WriteLine(student);
// }


// Switch Statements

// This is used when you want to check multiple possible value of a variable (we use this instead of using multiple if-else)

//Example
//Sunday, Monday, Tuesday, Wednesday, Thursday, Saturday

// int day = 7;
// switch (day)
// {
//     case 1:
//      Console.WriteLine("Sunday");
//      break;
//     case 2:
//      Console.WriteLine("Monday");
//      break;
//     case 3:
//      Console.WriteLine("Tuesday");
//      break;
//     case 4:
//      Console.WriteLine("Wednesday");
//      break;
//     default:
//      Console.WriteLine("Invalid day");
//      break;
//      
// }

//User Input
// We use this to make our code interactive instead of hardcoding it in out code , we give our computer an input to execute;

// Console.WriteLine("Enter your name:");
// string name =  Console.ReadLine(); // i will input this from my console
//
// Console.WriteLine("Enter your age:");
// int age = int.Parse(Console.ReadLine());
//
//
// Console.WriteLine($"///////\nHello, Welcome {name}!, i am {age} years old");



// ATM Machine Project
int pin = 7071;
int amount = 5000;
string Acctname = "Kayode";
int[] amountwithdraw = {2000, 500, 1000, 5000};


Console.WriteLine("Enter Your Pin");
int pinentry = int.Parse(Console.ReadLine());
if (pinentry == pin)
{
 Console.WriteLine("Enter your account type\n (1)Press 1 for saving \n (2)Press 2 for current");
 int accttypeEntry = int.Parse(Console.ReadLine());
 if (accttypeEntry == 1)
 { 
 Console.WriteLine("(1)///////////////////////\n Press 1 to withdraw. \n (2) Press 2 to check balance.");
 int bankoperation = int.Parse(Console.ReadLine());
 if (bankoperation == 1)
 {
 Console.WriteLine("////////////////////// \n select amount to withdraw\n(1) 2000. \n (2) 500 \n (3) 1000 \n (4) 5000 \n (5) Enter value you want to with");
  int amountToWithdraw = int.Parse(Console.ReadLine());
  // we move to switch case
  switch  (amountToWithdraw)
  {
    case 1:
     amount -= amountwithdraw[0];
     Console.WriteLine($"//////\n Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debt. \n Amount-Withdrawn = {amountwithdraw[0]}. \n Balance = {amount} \n Thank you for banking with us.");
     break;
    case 2:
     amount -= amountwithdraw[1];
     Console.WriteLine($"///////\n Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debt. \n Amount-Withdrawn = {amountwithdraw[1]}. \n Balance = {amount} \n Thank you for banking with us.");
     break;
    case 3:
     amount -= amountwithdraw[2];
     Console.WriteLine($"///////\n Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debt. \n Amount-Withdrawn = {amountwithdraw[2]}. \n Balance = {amount} \n Thank you for banking with us.");
     break;
    case 4:
     amount -= amountwithdraw[3];
     Console.WriteLine($"////////\n Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debt. \n Amount-Withdrawn = {amountwithdraw[3]}. \n Balance = {amount} \n Thank you for banking with us.");
     break;
    case 5:
     amount -= amountwithdraw[4];
     Console.WriteLine($"///////\n Withdraw Alert///\n Hi {Acctname}, you have done atm transaction.\n TransactionType = Debt. \n Amount-Withdrawn = {amountwithdraw[4]}. \n Balance = {amount} \n Thank you for banking with us.");
     break;
    default:
     Console.WriteLine("Invalid operation");
     break;
  }
 }
 Console.WriteLine($"//////\n AccountSummary///\n welcome {Acctname}, Your Account Balance is #{amount}");   
 }
 else
 {
  Console.WriteLine("//////\nYour account is invalid");
 }
    
}
else
{
 Console.WriteLine("Invalid pin");
}