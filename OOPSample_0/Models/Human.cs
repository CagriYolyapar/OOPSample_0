using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_0.Models
{
    public class Human
    {
        public string Name { get; set; }
        public void CayIc(Human human)
        {
            Console.WriteLine($"{human.Name} ile cay iciyoruz");
        }
    }
}
