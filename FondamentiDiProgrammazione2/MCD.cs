internal class Program
{
    private static void Main(string[] args)
    {
        int n1 = 174689044;
        int n2 = 139864355;
 
        Console.WriteLine(mcdFinder(n1, n2));

    }
    public static int mcdFinder(int a, int b)
    {

        int mcd = 1;
        int divisore = 2;
        if (a % b == 0)
            return b;
        if (b % a == 0)
            return a;
        if (a > b)
        {
            while (a != 1 && b != 1 && divisore < b)
            {

                if (a % divisore == 0 && b % divisore == 0)
                {
                    a /= divisore;
                    b /= divisore;
                    mcd *= divisore;
                    divisore = 2;
                    continue;
                }
                if (divisore % 2 == 0)
                    divisore++;
                else
                {
                    divisore++;
                    divisore++;
                }
            }
        }
        else
        {
            while ((a != 1 && b != 1) && divisore != a)
            {
                if (a % divisore == 0 && b % divisore == 0)
                {
                    a = a / divisore;
                    b = b / divisore;
                    mcd = mcd * divisore;
                    divisore = 2;
                    continue;
                }
                if (divisore % 2 == 0)
                    divisore++;
                else
                {
                    divisore++;
                    divisore++;
                }

            }
        }
        return mcd;
    }
}



/* //DA RIMETTERE NEL MAIL
List<int> dummyList = new List<int>(); 
int[] dummyArray = new int[10];
*/


/* //DA TENERE SOTTO IL MAIN
public int[] bubblesort(int[] v)
{
    for(int i = 0;i<)
    return v;
}
*/