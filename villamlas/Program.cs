namespace villamlas
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
            Console.WriteLine("\n3.feladat");
            Console.WriteLine(legtobb(villamok));

            Console.WriteLine("\n4.feladat");
            negyes(villamok);

            Console.WriteLine("\n5. feladat");
            Console.WriteLine(otos(villamok));

            Console.WriteLine("\n6.feladat");
            Console.WriteLine($"{hatos(villamok)}. napon 200-nál kevesebb villámlás volt");

            Console.WriteLine("\n7.feladat");
            Console.WriteLine($"{hetes(villamok)}. napon nem volt villámlás");

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
                if (sum > 0)
                {
                    for (int j = 0; j < villamok[i].Ora.Count; j++)
                    {
                        if (villamok[i].Ora[j]>0)
                        {
                            Console.WriteLine($"{i+1} nap, {j+1} óra");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{i+1} nap null");      
                }
               
            }
        }

        static int otos(List<Villamlas> villamok)
        {
            int szam = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                for (int j = 0; j < villamok[i].Ora.Count; j++)
                {
                    if (villamok[i].Ora[j] > 0)
                    {
                        szam++;
                    }
                }
            }

		    return szam;
        }

        static int hatos(List<Villamlas> villamok) 
        {
            List<int> vSzam = new();
            int nap = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                vSzam.Add(villamok[i].Ora.Sum());
                
            }
            for (int i = 0; i < vSzam.Count; i++)
            {
                if (vSzam[i] < 200)
                {
                    nap = i;
                break;
                }
            }
            return nap+1;
        }

        static int hetes(List<Villamlas> villamok)
        {
            List<int> vSzam = new();
            int nap = 0;
            for (int i = 0; i < villamok.Count; i++)
            {
                vSzam.Add(villamok[i].Ora.Sum());

            }
            for (int i = 0; i < vSzam.Count; i++)
            {
                if (vSzam[i] == 0)
                {
                    nap = i;
                    break;
                }
            }
            return nap + 1;
        }


    }
}
