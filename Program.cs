int number;
Console.WriteLine("input number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number <= 999 && 0 < number)
{
    int hundred = number/10/10;
    int dozen = number / 10 % 10;
    number = number % 10;
    switch (hundred)
    {
        case 1:
            Console.Write("hundred ");
            break;
        case 2:
            Console.Write("two hundred ");
            break;
        case 3:
            Console.Write("three hundred ");
            break;
        case 4:
            Console.Write("four hundred ");
            break;
        case 5:
            Console.Write("five hundred  ");
            break;
        case 6:
            Console.Write("six hundred  ");
            break;
        case 7:
            Console.Write("seven hundred   ");
            break;
        case 8:
            Console.Write("eighth hundred  ");
            break;
        case 9:
            Console.Write("nine hundred  ");
            break;
        default:
            break;
    }
    switch (dozen)
    {
        case 1:
            Console.Write("ten ");
            break;
        case 2:
            Console.Write("twenty ");
            break;
        case 3:
            Console.Write("threety ");
            break;
        case 4:
            Console.Write("fourty ");
            break;
        case 5:
            Console.Write("fivety ");
            break;
        case 6:
            Console.Write("sixty ");
            break;
        case 7:
            Console.Write("seventy ");
            break;
        case 8:
            Console.Write("eighthty ");
            break;
        case 9:
            Console.Write("ninety ");
            break;
        case 0:
            Console.Write("and ");
            break;
        default:
            break;
    }
    switch (number)
    {
        case 1:
            Console.Write("one ");
            break;
        case 2:
            Console.Write("two ");
            break;
        case 3:
            Console.Write("three ");
            break;
        case 4:
            Console.Write("four ");
            break;
        case 5:
            Console.Write("five ");
            break;
        case 6:
            Console.Write("six ");
            break;
        case 7:
            Console.Write("seven ");
            break;
        case 8:
            Console.Write("eighth ");
            break;
        case 9:
            Console.Write("nine ");
            break;
        case 0:
            Console.Write(" ");
            break;
        default:
            break;

    }
}
