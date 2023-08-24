//bool isLogged = false;

//if (isLogged)
//{
//    Console.WriteLine("Jus esate Prisijunges");
//}

//if(!isLogged)
//{
//    Console.WriteLine("Jus neprisijunges");
//}

//int number = 5;
//bool isNumber5 = number ==5;
//if(isNumber5)
//{
//    Console.WriteLine("Skaicius yra 5");
//}

//bool isNumber6Positive = number > 0;
//if(isNumber6Positive)
//{
//    Console.WriteLine("Skaicius yra teigimas");
//}

//Nested Ifs
//int age = 25;
//bool hasLicense = true; 

//if(age >= 18)
//{
//    Console.WriteLine("Jus esate pilnametis");

//    if (hasLicense)
//    {
//        Console.WriteLine("Jus turite teise vairuoti");
//    }
//    else
//    {
//        Console.WriteLine("Jums nera teises vairuoti");
//    }
//}
//else
//{
//    Console.WriteLine("Jus esate nepilnametis");
//}


// and operator &&
//int age = 25;
//bool hasLicense = true;

//if(age >= 18 && hasLicense)
//{
//    Console.WriteLine("jus turite teise vairuoti");
//}

// or operator ""
//Console.Write("Iveskite savo pareigas: ");
//string userInput = Console.ReadLine();

//if(userInput == "admin" || userInput == "administratorius")
//{
//    Console.WriteLine("Jus turite administratoriaus teises");
//}
//else
//{
//    Console.WriteLine("Jus nieko neturite, ir uzeiti i sistema negalite.");
//}

//or and operator combinet
//int age = 25;
//bool hasLicense = true;

//if ((age >= 18 && hasLicense) || age >= 65)
//        {
//    Console.WriteLine("Jus turite teise vairuoti arba jums priklauso pensija");
//}

int age = 25;
bool hasLicense = false;

if ((age >= 18 || hasLicense) && age >= 5)
{
    Console.WriteLine("Jus turite teise vairuoti arba jums priklauso pensija");
}

// &&
// true && true = true
// true && false = false
// false && true = false
// false && false = false

// ||
// true || true = true
// true || false = true
// false || true = true
// false || false = false