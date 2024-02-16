using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villamlas
{
	internal class Villamlas
	{
        public List<int> Ora { get; set; }

        public Villamlas(string sorok) 
        {
            var sor = sorok.Split(';');
            Ora = new List<int>();
            foreach (var item in sor)
            {
                Ora.Add(int.Parse(item));
            }
        }
        public override string ToString()
        {
            return $"{string.Join(" ", Ora)}";
        }
    }
}
