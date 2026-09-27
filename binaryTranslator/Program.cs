using System;

namespace binaryTranslator;


//------------------------------ Make Class ------------------------------//

class Make
{
    public static void New()
    {
        Console.WriteLine("");
    }

    public static void Separator()
    {
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("");
    }
}


//----------------------------- Program Class -----------------------------//

class Program
{
    //-------------------------- Binary to Base10 --------------------------//

    static void Binary()
    {
        Console.WriteLine("Enter a binary number:");
        string userinput = Console.ReadLine()!;

        while (true)
        {
            bool valid = true;

            foreach (char digit in userinput)
            {
                if (digit != '0' && digit != '1')
                {
                    Make.New();
                    Console.WriteLine("Please enter a valid binary number.");

                    userinput = Console.ReadLine()!;
                    valid = false;

                    break;
                }
            }

            if (valid)
            {
                break;
            }
        }

        char[] transformer = userinput.ToCharArray();
        Array.Reverse(transformer);
        string reversed = new string(transformer);

        long final = 0;
        long multip = 1;

        foreach (char number in reversed)
        {
            if (number == '1')
            {
                final += multip;
            }

            multip *= 2;
        }

        Make.New();
        Console.WriteLine(final);

        Make.Separator();
    }


    //-------------------------- Base10 to Binary --------------------------//

    static void Base10()
    {
        Console.WriteLine("Enter a number:");
        string userinput = Console.ReadLine()!;

        while (true)
        {
            bool valid = true;

            foreach (char digit in userinput)
            {
                if
                (
                    digit != '1' &&
                    digit != '2' &&
                    digit != '3' &&
                    digit != '4' &&
                    digit != '5' &&
                    digit != '6' &&
                    digit != '7' &&
                    digit != '8' &&
                    digit != '9' &&
                    digit != '0'
                )
                {
                    Make.New();
                    Console.WriteLine("Must enter a valid number.");

                    userinput = Console.ReadLine()!;
                    valid = false;

                    break;
                }
            }

            if (valid)
            {
                break;
            }
        }

        long number = long.Parse(userinput);

        long ans = 1;
        string final = "";
        long rem = 0;

        while (ans != 0)
        {
            ans = number / 2;
            rem = number % 2;

            if (rem != 0)
            {
                ans = (long)Math.Floor((double)ans);
                final += "1";
            }
            else
            {
                final += "0";
            }

            number = ans;
        }

        char[] transformer = final.ToCharArray();
        Array.Reverse(transformer);
        string reversed = new string(transformer);

        Make.New();
        Console.WriteLine(reversed);

        Make.Separator();
    }


    //---------------------------- Alpabet to Binary ----------------------------//

    public static void ATB()
    {
        char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        Console.Write("Type a letter/word/sentence: ");
        string text = Console.ReadLine()!;

        Make.New();

        foreach (char letter in text)
        {
            if (letter == ' ')
            {
                Console.Write("00100000 ");
                continue;
            }

            else if (letter == '!')
            {
                Console.Write("00100001 ");
                continue;
            }
            else if (letter == '"')
            {
                Console.Write("00100010 ");
                continue;
            }
            else if (letter == '#')
            {
                Console.Write("00100011 ");
                continue;
            }
            else if (letter == '$')
            {
                Console.Write("00100100 ");
                continue;
            }
            else if (letter == '%')
            {
                Console.Write("00100101 ");
                continue;
            }
            else if (letter == '&')
            {
                Console.Write("00100110 ");
                continue;
            }
            else if (letter == '\'')
            {
                Console.Write("00100111 ");
                continue;
            }
            else if (letter == '(')
            {
                Console.Write("00101000 ");
                continue;
            }
            else if (letter == ')')
            {
                Console.Write("00101001 ");
                continue;
            }
            else if (letter == '*')
            {
                Console.Write("00101010 ");
                continue;
            }
            else if (letter == '+')
            {
                Console.Write("00101011 ");
                continue;
            }
            else if (letter == ',')
            {
                Console.Write("00101100 ");
                continue;
            }
            else if (letter == '-')
            {
                Console.Write("00101101 ");
                continue;
            }
            else if (letter == '.')
            {
                Console.Write("00101110 ");
                continue;
            }
            else if (letter == '/')
            {
                Console.Write("00101111 ");
                continue;
            }
            else if (letter == ':')
            {
                Console.Write("00111010 ");
                continue;
            }
            else if (letter == ';')
            {
                Console.Write("00111011 ");
                continue;
            }
            else if (letter == '<')
            {
                Console.Write("00111100 ");
                continue;
            }
            else if (letter == '=')
            {
                Console.Write("00111101 ");
                continue;
            }
            else if (letter == '>')
            {
                Console.Write("00111110 ");
                continue;
            }
            else if (letter == '?')
            {
                Console.Write("00111111 ");
                continue;
            }
            else if (letter == '@')
            {
                Console.Write("01000000 ");
                continue;
            }
            else if (letter == '[')
            {
                Console.Write("01011011 ");
                continue;
            }
            else if (letter == '\\')
            {
                Console.Write("01011100 ");
                continue;
            }
            else if (letter == ']')
            {
                Console.Write("01011101 ");
                continue;
            }
            else if (letter == '^')
            {
                Console.Write("01011110 ");
                continue;
            }
            else if (letter == '_')
            {
                Console.Write("01011111 ");
                continue;
            }
            else if (letter == '`')
            {
                Console.Write("01100000 ");
                continue;
            }
            else if (letter == '{')
            {
                Console.Write("01111011 ");
                continue;
            }
            else if (letter == '|')
            {
                Console.Write("01111100 ");
                continue;
            }
            else if (letter == '}')
            {
                Console.Write("01111101 ");
                continue;
            }
            else if (letter == '~')
            {
                Console.Write("01111110 ");
                continue;
            }


            for (int j = 0; j < upper.Length; j++)
            {
                if (letter == upper[j])
                {
                    int ascii = 65 + j;
                    int number = ascii;

                    string binaryString = Convert.ToString(number, 2);

                    if (binaryString.Length != 8)
                        binaryString = "0" + binaryString;

                    Console.Write(binaryString + " ");
                    break;
                }

                if (letter == lower[j])
                {
                    int ascii = 97 + j;
                    int number = ascii;

                    string binaryString = Convert.ToString(number, 2);

                    if (binaryString.Length != 8)
                        binaryString = "0" + binaryString;

                    Console.Write(binaryString + " ");
                    break;
                }
            }
        }

        Make.New();
        Make.Separator();
    }


    //---------------------------- Binary to Alphabet ----------------------------//

    static void BTA()
    {
        char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        Console.WriteLine("Enter binary text:");
        string userinput = Console.ReadLine()!;

        Make.New();

        while (true)
        {
            bool valid = true;

            foreach (char digit in userinput)
            {
                if (digit != '0' && digit != '1' && digit != ' ')
                {
                    Make.New();
                    Console.WriteLine("Please enter a valid binary number.");

                    userinput = Console.ReadLine()!;
                    valid = false;

                    break;
                }
            }

            if (valid)
            {
                break;
            }
        }

        long num = 0;
        string Byte = "";

        foreach (char c in userinput)
        {
            if (c == ' ')
            {
                continue;
            }

            Byte += c;
            num++;

            if (num == 8)
            {
                char[] transformer = Byte.ToCharArray();
                Array.Reverse(transformer);
                string reversed = new string(transformer);

                long final = 0;
                long multip = 1;

                foreach (char number in reversed)
                {
                    if (number == '1')
                    {
                        final += multip;
                    }

                    multip *= 2;
                }

                if (final >= 65 && final <= 90)
                {
                    int index = (int)(final - 65);
                    Console.Write(upper[index]);
                }
                else if (final >= 97 && final <= 122)
                {
                    int index = (int)(final - 97);
                    Console.Write(lower[index]);
                }
                else if (final == 32)
                {
                    Console.Write(" ");
                }
                else if (final == 33)
                {
                    Console.Write("!");
                }
                else if (final == 34)
                {
                    Console.Write("\"");
                }
                else if (final == 35)
                {
                    Console.Write("#");
                }
                else if (final == 36)
                {
                    Console.Write("$");
                }
                else if (final == 37)
                {
                    Console.Write("%");
                }
                else if (final == 38)
                {
                    Console.Write("&");
                }
                else if (final == 39)
                {
                    Console.Write("'");
                }
                else if (final == 40)
                {
                    Console.Write("(");
                }
                else if (final == 41)
                {
                    Console.Write(")");
                }
                else if (final == 42)
                {
                    Console.Write("*");
                }
                else if (final == 43)
                {
                    Console.Write("+");
                }
                else if (final == 44)
                {
                    Console.Write(",");
                }
                else if (final == 45)
                {
                    Console.Write("-");
                }
                else if (final == 46)
                {
                    Console.Write(".");
                }
                else if (final == 47)
                {
                    Console.Write("/");
                }
                else if (final == 58)
                {
                    Console.Write(":");
                }
                else if (final == 59)
                {
                    Console.Write(";");
                }
                else if (final == 60)
                {
                    Console.Write("<");
                }
                else if (final == 61)
                {
                    Console.Write("=");
                }
                else if (final == 62)
                {
                    Console.Write(">");
                }
                else if (final == 63)
                {
                    Console.Write("?");
                }
                else if (final == 64)
                {
                    Console.Write("@");
                }
                else if (final == 91)
                {
                    Console.Write("[");
                }
                else if (final == 92)
                {
                    Console.Write("\\");
                }
                else if (final == 93)
                {
                    Console.Write("]");
                }
                else if (final == 94)
                {
                    Console.Write("^");
                }
                else if (final == 95)
                {
                    Console.Write("_");
                }
                else if (final == 96)
                {
                    Console.Write("`");
                }
                else if (final == 123)
                {
                    Console.Write("{");
                }
                else if (final == 124)
                {
                    Console.Write("|");
                }
                else if (final == 125)
                {
                    Console.Write("}");
                }
                else if (final == 126)
                {
                    Console.Write("~");
                }

                Byte = "";
                num = 0;
            }
        }

        if (num != 0)
        {
            Make.New();
            Console.WriteLine("Each character must contain 8 bits.");
        }

        Make.New();
        Make.Separator();
    }


    //---------------------------- Main Program ----------------------------//

    static void Main()
    {
        Console.Clear();

        Console.WriteLine("-======>>>>BINARY TRANSLATOR<<<<======-");
        Console.WriteLine("\n");

        while (true)
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1. Binary to Base10.");
            Console.WriteLine("2. Base10 to Binary.");
            Console.WriteLine("3. Alphabet to Binary");
            Console.WriteLine("4. Binary to Alphabet");

            Make.New();
            Console.Write("=> ");

            string choice = Console.ReadLine()!.Trim().ToLower();

            Make.New();

            if (choice == "1" || choice == "binary" || choice == "binary to base10")
            {
                Console.Clear();
                Binary();
            }
            else if (choice == "2" || choice == "base10" || choice == "base10 to binary")
            {
                Console.Clear();
                Base10();
            }
            else if (choice == "3" || choice == "alphabet to binary")
            {
                Console.Clear();
                ATB();
            }
            else if (choice == "4" || choice == "binary to alphabet")
            {
                Console.Clear();
                BTA();
            }
            else
            {
                Console.WriteLine("Please enter 1, 2, 3, or 4.");
                Make.Separator();
                continue;
            }

            Console.Write("Would you like to repeat? (y/n): ");

            string again = Console.ReadLine()!.Trim().ToLower();

            if (again != "y")
            {
                break;
            }

            Make.Separator();
        }
    }
}