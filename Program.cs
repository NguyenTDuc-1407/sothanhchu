int number;
Console.WriteLine("input number: ");
number = Convert.ToInt32(Console.ReadLine());
if (number <= 999 && 0 < number)
{
    int hundred = number / 10 / 10;
    int dozen = number % 100;
    int dozen2 = number / 10 % 10;
    number = number % 10;
    switch (hundred)
    {
        case 1:
            Console.Write("one hundred and ");
            break;
        case 2:
            Console.Write("two hundred and ");
            break;
        case 3:
            Console.Write("three hundred and ");
            break;
        case 4:
            Console.Write("four hundred and ");
            break;
        case 5:
            Console.Write("five hundred and ");
            break;
        case 6:
            Console.Write("six hundred and ");
            break;
        case 7:
            Console.Write("seven hundred and ");
            break;
        case 8:
            Console.Write("eighth hundred and ");
            break;
        case 9:
            Console.Write("nine hundred and ");
            break;
        default:
            break;
    }
    if (10 <= dozen && dozen < 21)
    {
        switch (dozen)
        {
            case 10:

                {
                    Console.Write("ten ");
                    break;
                }
            case 11:
                {
                    Console.Write("eleven ");
                    break;
                }
            case 12:
                {
                    Console.Write("twelve ");
                    break;
                }
            case 13:
                {
                    Console.Write("threeteen ");
                    break;
                }
            case 14:
                {
                    Console.Write("fourteen ");
                    break;
                }
            case 15:
                {
                    Console.Write("fiveteen ");
                    break;
                }
            case 16:
                {
                    Console.Write("sixteen ");
                    break;
                }
            case 17:
                {
                    Console.Write("seventeen ");
                    break;
                }
            case 18:
                {
                    Console.Write("eighthteen ");
                    break;
                }
            case 19:
                {
                    Console.Write("nineteen ");
                    break;
                }

            default:
                break;
        }
    }
    else
    {
        switch (dozen2)
        {
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
                Console.Write(" ");
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
}
