using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    class GuessTheNumber
    {
        Random random;

        public int RandomNumber;

        public GuessTheNumber()
        {
            random = new Random();
            RandomNumber = random.Next(1,101);
        }

        public void Compare(string UserNumber)
        {
            int.TryParse(UserNumber, out int userNum);
            if (RandomNumber == userNum)
                MessageBox.Show("Вы угадали число!");
            else
                MessageBox.Show($"Загаданное число = {RandomNumber}");
        }
    }
}
