string hello = "Hello, World!";
string panic = "Dont't panic!";

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(hello);
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(panic);
//}

PrintStringTenTimes(hello);
PrintStringTenTimes(panic);
PrintStringTenTimes("Erasmus");

static void PrintStringTenTimes(string somestring)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(somestring);
    }

}
