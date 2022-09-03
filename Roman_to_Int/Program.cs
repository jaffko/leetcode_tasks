// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000
// starts from largest to lowest for ex MCMXCIV = 1994, M = 1000, CM = 900, XC = 90 IV = 4

//1. Берем index символ, если M, то + 1000, если D то +500, index +1
// если C, то смотрим index + 1, если там D, то это 400, если M, то это + 900, index + 2, если другой, то +100 index +1
// если L, то +50, index + 1
// если X, то смотрим index + 1, если там L, то это 40, если там C, то это + 90, index + 2, если другое, то + 10 index +1
// если V, то +5 index + 1
// если I, то смотрим index + 1, если там V, то это 4, если там X, то это 9, index + 2, если другое, то это +1
// во всех случаях с C, X, I проверка, index + 1 > s.Length перед условиями.

string s = "MMMCDLVIII";
int intNum = 0;
int romLen = s.Length;
char[] romChars = s.ToCharArray();
int i = 0;
while (i < romLen)
{
    switch (romChars[i])
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
            if (i + 1 >= romLen) intNum = intNum + 100;
            else 
            {
                if (romChars[i+1]=='D') 
                {
                    intNum = intNum + 400;
                    i++;
                }
                else if (romChars[i+1]=='M') 
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
            if (i + 1 >= romLen) intNum = intNum + 10;
            else 
            {
                if (romChars[i+1]=='L') 
                {
                    intNum = intNum + 40;
                    i++;
                }
                else if (romChars[i+1]=='C') 
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
            if (i + 1 >= romLen) intNum = intNum + 1;
            else 
            {
                if (romChars[i+1]=='V') 
                {
                    intNum = intNum + 4;
                    i++;
                }
                else if (romChars[i+1]=='X') 
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
