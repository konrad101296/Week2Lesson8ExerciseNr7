Console.WriteLine("podaj ile linijek ma miec diament: ");
int lenght = int.Parse(Console.ReadLine());
int divided = lenght / 2;
int space = lenght / 2;
int star = 1;
for (int i = 0; i < lenght; i++)
{
    Console.WriteLine();
    if (divided > i)
    {
        for (int j = 0; j < space; j++)
        {
            Console.Write(" ");
        }
        space--;
        for (int j = 0; j < star; j++)
        {
            Console.Write("*");
        }
        star += 2;
    }
    else if (divided <= i)
    {
        for (int j = 0; j < space; j++)
        {
            Console.Write(" ");
        }
        space++;
        for (int j = 0; j < star; j++)
        {
            Console.Write("*");
        }
        star -= 2;

    }
}