// See https://aka.ms/new-console-template for more information

public class GetStringArray
{


    public string[] GetArr()
    {

        Random rnd = new Random();

        Random random = new Random();

        int x = rnd.Next(3, 8);



        string[] arr = new string[x];

        for (int i = 0; i < x; i++)
        {
            string str = String.Empty;
            int y = rnd.Next(1, 8);

            while (y > 0)
            {

                bool b = false;

                while (b == false)
                {

                    char ch = (char)random.Next(55, 101);

                    if (!ch.Equals(""))
                    {
                        str += ch;
                        b = true;
                    }


                }
                y--;



            }
            arr[i] = str;


        }


        return arr;
    }

    public static void Main(string[] args)
    {

        GetStringArray getStringArray = new GetStringArray();

        string[] arr = getStringArray.GetArr();

        Console.WriteLine("Был такой массив");

        Console.Write("[");

        for (int i = 0; i < arr.Length - 1; i++)
        {

            Console.Write(" " + "'" + arr[i] + "'" + " ,");

        }


        Console.Write(" " + "'" + arr[arr.Length - 1] + "'" + " ");
        Console.Write("]");

        int x = 0;

        for (int i = 0; i < arr.Length; i++)
        {

            string str = arr[i];

            if (str.Length <= 3) { x++; }


        }

        string[] arr1 = new string[x];

        int y = 0;

        for (int i = 0; i < arr.Length; i++)
        {

            string str = arr[i];

            if (str.Length <= 3)
            {
                arr1[y] = str;
                y++;

            }


        }

        Console.WriteLine();
        Console.WriteLine("Станет такой");

        if (arr1.Length > 0)
        {
            Console.Write("[");
            for (int i = 0; i < arr1.Length - 1; i++)
            {

                Console.Write(" " + "'" + arr1[i] + "'" + " ,");

            }
            Console.Write(" " + "'" + arr1[arr1.Length - 1] + "'" + " ");
            Console.Write("]");

        }

        else
        {
            Console.Write("[]");
        }

    }





}
