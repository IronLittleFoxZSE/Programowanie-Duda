

using System.Diagnostics;

int x = 54;
String y = new string("Ala");
String z = y;
 



void showMessage()
{
    Console.WriteLine("Hello");
}

showMessage();

Action zm = showMessage;
Action zm2 = zm;

zm2();

void showMessage2(string text)
{
    Console.WriteLine(text);
}

Action<string> zm3 = showMessage2;

showMessage2("Ala");
zm3("Ola");

void showMessage3(string text, int x)
{
    Console.WriteLine(text);
}
Action<string,int> zm4 = showMessage3;

showMessage3("Olek", 15);
zm4("Ilona", 87);

int GetValue()
{
    return 0;
}

Func<int> zm5 = GetValue;

x = GetValue();
x = zm5();

int GetValue2(string s)
{
    return 0;
}

Func<string,int> zm6 = GetValue2;

x = GetValue2("sdgas");
x = zm6("zsdfgasd");


void f1()
{

}

void f2()
{

}

if (x > 5)
    f1();
else
    f2();

Action delegata;

if (x > 5)
    delegata = f1;
else
    delegata = f2;

delegata = (x>5) ? f1 : f2;

delegata();



//-----------------------------------------------

List<int> list = new List<int>();
list.Add(15);
list.Add(7);
list.Add(88);
list.Add(-5);


List<int> evenNumbers = new List<int>();

foreach(int number in list)
    if (number % 2 == 0)
        evenNumbers.Add(number);


List<int> secondEvenNumbers;


List<int> whereEven(List<int> ints)
{
    List<int> returnList = new List<int>();

    foreach (int number in ints)
        if (number % 2 == 0)
            returnList.Add(number);

    return returnList;
}

List<int> wherePositive(List<int> ints)
{
    List<int> returnList = new List<int>();

    foreach (int number in ints)
        if (number >= 0)
            returnList.Add(number);

    return returnList;
}

bool checkEven(int n)
{
    return n % 2 == 0;
}

bool checkOdd(int n)
{
    return n % 2 == 1;
}

bool checkPositive(int number)
{
    return number >= 0;
}


List<int> whereEvenV2(List<int> ints)
{
    List<int> returnList = new List<int>();

    foreach (int number in ints)
        if (checkEven(number))
            returnList.Add(number);

    return returnList;
}

List<int> wherePositiveV2(List<int> ints)
{
    List<int> returnList = new List<int>();

    foreach (int number in ints)
        if (checkPositive(number))
            returnList.Add(number);

    return returnList;
}

List<int> where(List<int> ints, Func<int, bool> check)
{
    List<int> returnList = new List<int>();

    foreach (int number in ints)
        if (check(number))
            returnList.Add(number);

    return returnList;
}

secondEvenNumbers = whereEven(list);
secondEvenNumbers = where(list, checkEven);
List<int> positiveNumbers = where(list, checkPositive);
List<int> oddNumbers = where(list, checkOdd);

//KISS
//DRY
//SOLID





Console.ReadKey();


void ff1()
{
    Console.WriteLine("Ala");
}

void ff2()
{
    Console.WriteLine("Coś innego");
}

void ff3()
{
    Console.WriteLine("sdfhsefgjdgjkjh");
}

void fff1(string mesage)
{
    Console.WriteLine(mesage);
}

void fff2(string mesage)
{
    Debug.WriteLine(mesage);
}

void g(Action<string> action)
{
    action("ASDFG");
}

g(fff1);
g(fff2);