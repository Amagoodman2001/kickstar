// See https://aka.ms/new-console-template for more information

using FirstTry;

var x  = 20;
x = x*4;
//Console.WriteLine("Hello Gbenga, Welcome to my World!");
//Console.WriteLine("MAC Hack  Calculstion result =" + x);


Console.WriteLine("I am makeing a call to a method ");
//WhatsYourName();
DoSomething y = new DoSomething();
var yy = y.CallNameFunctions();
Console.WriteLine("Result of function call is " +  yy);

static void WhatsYourName(){
Console.WriteLine("My name is Yinka");
}

static string WhatsYourNameSir(){
    return "Why are you asking my name!";
}

Console.ReadLine();