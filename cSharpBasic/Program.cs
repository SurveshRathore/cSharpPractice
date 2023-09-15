// See https://aka.ms/new-console-template for more information
using cSharpBasic;

Console.WriteLine("Hello, World!");
//TestingCustomException testingCustomException = new TestingCustomException();
//testingCustomException.calculations(10, 0);
ArrayListJson arrayListJson = new ArrayListJson();
Boolean answer = false;
do
{
    Console.Write("Enter First Name: ");
    string fName = Console.ReadLine();

    Console.Write("Enter Last Name: ");
    string lName = Console.ReadLine();

    Console.Write("Enter Age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter City: ");
    string city = Console.ReadLine();

    
    arrayListJson.AddData(fName, lName, age, city);

    Console.Write("Do you to enter more data: ");
    answer = Convert.ToBoolean(Console.ReadLine());
}while(answer);


// arrayListJson.GetJsonData();