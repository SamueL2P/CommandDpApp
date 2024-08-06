using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDpApp.Models
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("TV Turned ON");
        }

        public void Off()
        {
            Console.WriteLine("TV Turned Off");
        }
    }
}
