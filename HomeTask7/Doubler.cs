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
//        private delegate int Function();
        private int Increase()
        {
            return CommandCount++;
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
            CommandCount = F;
            lblNumber.Text = Convert.ToString(CommandCount);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ChangeSteps(Increase);
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();            
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            ChangeSteps(Increase);
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ChangeSteps(Zero);
            lblNumber.Text = "1";            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int Target = GetNumber();
            string text = "Да начнется игра!\n" + "Ваше число : " + Target 
                + "\n Получите его за минимальное количество ходов";
                                 
            MessageBox.Show(text);

            ChangeSteps(Zero);
            lblNumber.Text = "1";
            lblTarget.Text = Convert.ToString(Target);
        }
    }
}
