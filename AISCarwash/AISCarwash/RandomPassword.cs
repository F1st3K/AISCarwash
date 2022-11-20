using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISCarwash
{
    internal class RandomPassword
    {
        public string Password { get; set; }
        private Random rand = new Random();
        int lenght;

        public  RandomPassword(int minLenght, int maxLenght)
        {
            lenght = rand.Next(minLenght, maxLenght);
            CreatePassword();
        }
        private void CreatePassword()
        {
            lenght = 8;
            for (int i = 0; i < lenght; i++)
            {
                Password += (char)rand.Next(0x0021, 0x007A);
            }
        }
    }
}
