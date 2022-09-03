//Given a roman numeral (from 1 to 3999), convert it to an integer.

Console.WriteLine("Enter Roman digit in range [1, 3999]: ");
string? s = Console.ReadLine();
int intNum = 0;
int i = 0;
while (i < s!.Length)
{
    switch (s[i])
    {
        case 'M':
        {
            intNum = intNum + 1000;
            break;
        }
        case 'D':
        {
            intNum = intNum + 500;
            break;
        }
        case 'L':
        {
            intNum = intNum + 50;
            break;
        }
        case 'V':
        {
            intNum = intNum + 5;
            break;
        }
        case 'C':
        {
            if (i + 1 >= s.Length) intNum = intNum + 100;
            else 
            {
                if (s[i+1]=='D') 
                {
                    intNum = intNum + 400;
                    i++;
                }
                else if (s[i+1]=='M') 
                {
                    intNum = intNum + 900;
                    i++;
                }
                else intNum = intNum + 100;
            }
            break;
        }
        case 'X':
        {
            if (i + 1 >= s.Length) intNum = intNum + 10;
            else 
            {
                if (s[i+1]=='L') 
                {
                    intNum = intNum + 40;
                    i++;
                }
                else if (s[i+1]=='C') 
                {
                    intNum = intNum + 90;
                    i++;
                }
                else intNum = intNum + 10;
            }
            break;
        }
        case 'I':
        {
            if (i + 1 >= s.Length) intNum = intNum + 1;
            else 
            {
                if (s[i+1]=='V') 
                {
                    intNum = intNum + 4;
                    i++;
                }
                else if (s[i+1]=='X') 
                {
                    intNum = intNum + 9;
                    i++;
                }
                else intNum = intNum + 1;
            }
            break;
        }
        default:
        {
            break;
        }
    }
    i++;
}
Console.WriteLine(intNum);
