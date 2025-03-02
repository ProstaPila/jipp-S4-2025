// See https://aka.ms/new-console-template for more information
;
Console.WriteLine("Podaj swoje imię:");
var name = Console.ReadLine();
Console.WriteLine("Hello " + name +"\n");

//int result = 5 + 9;

Console.WriteLine("Zadanie 1\n");
int number=9;
float money=12.12f;
string text="Hello";
bool isLogged=true;
char myChar='L';
decimal price=21.37m;

Console.WriteLine($" Number: {number}\n Float: {money}\n Text: {text}\n Bool: {isLogged}\n Char: {myChar}\n Decimal: {price}\n");

Console.WriteLine("Zadanie 2\n");
string myAge = "Age: ";
int wifeAge = 18;
string result = myAge + wifeAge;
Console.WriteLine(result+"\n");

Console.WriteLine("Zadanie 3\n");
bool isTrue = true,
     isFalse=false,
     isReallyTrue=true;

bool and = isTrue && isFalse,
     or = isTrue || isReallyTrue,
     negative = !isFalse;
Console.WriteLine($" And: {and}\n Or: {or}\n Negative: {negative}\n");

Console.WriteLine("Zadanie 4\n");
int a = 5, b = 12;
int add = a + b,
    sub = a - b,
    div = a / b,
    mul = a * b,
    mod = a % b;
Console.WriteLine($" Add: {add}\n Sub: {sub}\n Div: {div}\n Mul: {mul}\n Mod: {mod}\n");

Console.WriteLine("Zadanie 5\n");
string sA = "Ala ", sB = "ma ", sC = "kota.";
string stringResult = sA + sB + sC;
Console.WriteLine(stringResult);
