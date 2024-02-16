﻿namespace villamlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Villamlas> villamok = new();
			using StreamReader sr = new StreamReader(
				path: @"..\..\..\src\villam.txt",
				encoding: System.Text.Encoding.UTF8
				);
			while ( !sr.EndOfStream )
			{
				villamok.Add(new Villamlas(sr.ReadLine()));
			}

            foreach (var item in villamok)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("3.feladat");
            Console.WriteLine(legtobb(villamok));

            Console.WriteLine("4.feladat");
            negyes(villamok);

            Console.WriteLine("5. feladat");
        }

		static int legtobb(List<Villamlas> villamok)
		{
			List<int> lista = new List<int>();
			int max = 0;

            foreach (var item in villamok)
            {
                for (int i = 0; i < item.Ora.Count; i++)
                {
					lista.Add(item.Ora[i]);
                }
            }

			max = lista.Max() ;

            return max;
		}

		static void negyes (List<Villamlas> villamok) 
		{
            for (int i = 0; i < villamok.Count; i++)
            {
                int sum = villamok[i].Ora.Sum();
                for (int j = 0; j < villamok[i].Ora.Count; j++)
                {
                    if (sum > 0)
                    {
                        Console.WriteLine($"{i+1} nap,  óra");
                    }
                    else
                    {
                        Console.WriteLine($"{i+1} nap null");
                        
                    }
                    break;
                }
            }
        }

        static int otos(List<Villamlas> villamok)
        {
            int szam = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                int sum = villamok[i].Ora.Sum();
            }

		    return szam;
        }
	}
}
