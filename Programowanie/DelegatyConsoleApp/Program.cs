

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


