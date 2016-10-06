using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Character_Sheet
{
    public partial class AbilityForm : Form
    {
        private Random _random;

        public AbilityForm()
        {
            InitializeComponent();
            this._initialize();
        }

        /// <summary>
        /// used to initalize class member variables
        /// </summary>
        private void _initialize()
        {
            this._random = new Random();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            RollAbilities();
        }

        /// <summary>
        /// generates 11 abilities for the char sheet
        /// </summary>
        private void RollAbilities()
        {
            Program.character.Strength = Roll4D6();
            Program.character.
        }

        /// <summary>
        /// rolls 4 6-sided dice and returns the sum of the highest 3 values
        /// </summary>
        private int Roll4D6()
        {
            int result = 0;
            int lowest = 6;
            for (int i = 0; i < 4; i++)
            {
                int die = this._random.Next(1, 7);
                if (die < lowest)
                {
                    lowest = die;
                }
                result += die;
            }
            return result - lowest;
            /*
             * List<int> dice = new List<int>;
             * for (int i = 0; i < 4; i++) {
             *  dice.Add(_random.Next(1, 7));
             * }
             * dice.Sort();
             * dice.RemoveAt(0);
             * return dice.Sum();
             */
        }
    }
}
