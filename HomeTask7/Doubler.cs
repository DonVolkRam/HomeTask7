using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask7
{
    public partial class Doubler : Form
    {
        int CommandCount=0;
        int UserNumber=1;
        int TargetNumber;
        Stack;
//        private delegate int Function();
        private int Increase()
        {
            return ++CommandCount;
        }

        private int Zero()
        {
            return 0;
        }

        public Doubler()
        {
            InitializeComponent();
        }

        private int GetNumber()
        {
            Random rnd = new Random();
                int number = rnd.Next(1, 1000);
            return number;
        }
        private delegate int Function();
        private void ChangeSteps(Function F)
        {
            CommandCount = F();
            lblStep.Text = Convert.ToString(CommandCount);
        }
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            ChangeSteps(Increase);
            UserNumber++;
            lblNumber.Text = Convert.ToString(UserNumber);
        }
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            ChangeSteps(Increase);
            UserNumber *= 2;
            lblNumber.Text = Convert.ToString(UserNumber);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ChangeSteps(Zero);
            UserNumber = 1;
            lblNumber.Text = Convert.ToString(UserNumber);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int Target = GetNumber();
            TargetNumber = Target;
            UserNumber = 1;
            string text = "Да начнется игра!\n" + "Ваше число : " + Target 
                + "\n Получите его за минимальное количество ходов";
                                 
            MessageBox.Show(text);

            ChangeSteps(Zero);
            lblNumber.Text = "1";
            lblTarget.Text = Convert.ToString(Target);
        }


    }
}
