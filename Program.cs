// See https://aka.ms/new-console-template for more information
int mod1, mod2, mod3, mod4, mod5, mod6;
try
{
    Console.WriteLine("How many credits did you get on the first module?");
    mod1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many credits did you get on the second module?");
    mod2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many credits did you get on the third module?");
    mod3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many credits did you get on the fourth module?");
    mod4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many credits did you get on the fifth module?");
    mod5 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How many credits did you get on the sixth module?");
    mod6 = Convert.ToInt32(Console.ReadLine());

    double average, percentage;
    //Average (mean) is calculated by adding all the individual elements and dividing it by how many elements there are.
    average = (double)(mod1+mod2+mod3+mod4+mod5+mod6)/6;
    //Percentage is calculated by dividing the average by the total credit for each one (i.e. 15) then multiplying by 100. Simplified down to /3 and *20 as both are divisible by 5.
    percentage = (average/3)*20;

    switch(percentage)
    {
        case >=70:
            Console.WriteLine("Amazing! You got a 1st!");
            break;
        case >=60:
            Console.WriteLine("Great job! You got a 2:1!");
            break;
        case >=50:
            Console.WriteLine("Good job! You got a 2:2!");
            break;
        case >=40:
            Console.WriteLine("Well done! You passed with a 3rd!");
            break;
        default:
            Console.WriteLine("Oh no! You failed!");
            break;
    }
}
catch
{
    Console.WriteLine("Incorrect input!");
}

Console.ReadKey();