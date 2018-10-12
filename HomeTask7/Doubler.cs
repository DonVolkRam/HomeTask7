using System;
using System.Collections;
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
    /// <summary>
    /// Объект сохранения действий
    /// </summary>
    public struct EventBtn
    {
        /// <summary>
        /// значение вначале действия
        /// </summary>
        public int first;
        /// <summary>
        /// Шаг на котором совержено действие
        /// </summary>
        public int step;
        /// <summary>
        /// Тип совершенного действия
        /// </summary>
        public char method;
    }

    /// <summary>
    /// Форма игры удвоитель
    /// </summary>
    public partial class Doubler : Form
    {
        /// <summary>
        /// Счетчик шагов
        /// </summary>
        int CommandCount = 0;
        /// <summary>
        /// Текущее число
        /// </summary>
        int UserNumber = 1;
        /// <summary>
        /// Целевое чесло которое нужно достигнуть путем выполнения действий
        /// </summary>
        int TargetNumber;
        /// <summary>
        /// Список выполненых дейятвий
        /// </summary>
        List<EventBtn> History = new List<EventBtn>();
        Stack ts = new Stack();
        //        private delegate int Function();
        /// <summary>
        /// Увеличение шага
        /// </summary>
        /// <returns></returns>
        private int Increase()
        {
            return ++CommandCount;
        }
        /// <summary>
        /// обнуление шага
        /// </summary>
        /// <returns></returns>
        private int Zero()
        {
            return 0;
        }

        public Doubler()
        {
            InitializeComponent();
            EventBtn HisTemp;
            HisTemp.first = 1;
            HisTemp.step = 0;
            HisTemp.method = '_';
            History.Add(HisTemp);
        }

        /// <summary>
        /// Получение случайного числа от 0 до 1000
        /// </summary>
        /// <returns></returns>
        private int GetNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 1000);
            return number;
        }
        /// <summary>
        /// Делегат для работы со счетчиком шагов
        /// </summary>
        /// <returns></returns>
        private delegate int Function();
        /// <summary>
        /// Изменение значение счетчика шагов
        /// </summary>
        /// <param name="F">Увеличить или обнулить шаг</param>
        private void ChangeSteps(Function F)
        {
            CommandCount = F();
            lblStep.Text = Convert.ToString(CommandCount);
        }

        private delegate void Event(object sender, EventArgs e);

        /// <summary>
        /// Увеличение числа на 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            EventBtn HisTemp;
            ChangeSteps(Increase);
            UserNumber++;

            HisTemp.first = UserNumber;
            HisTemp.step = CommandCount;
            HisTemp.method = '+';
            History.Add(HisTemp);

            lblNumber.Text = Convert.ToString(UserNumber);
            lbHistory.Items.Add(1 + lbHistory.Items.Count + " Инкремент: число  " + HisTemp.first + "  шаг " + HisTemp.step);

            ts.Push(HisTemp);
            if (UserNumber == TargetNumber)
                MessageBox.Show("Поздравляю! \nВы справились с заданием за " + CommandCount + " шагов");
        }

        /// <summary>
        /// Увеличение числа в два раза
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            EventBtn HisTemp;
            ChangeSteps(Increase);
            UserNumber *= 2;

            HisTemp.first = UserNumber;
            HisTemp.step = CommandCount;
            HisTemp.method = '*';
            History.Add(HisTemp);

            lblNumber.Text = Convert.ToString(UserNumber);
            lbHistory.Items.Add(1 + lbHistory.Items.Count + " Умножение: число " + HisTemp.first + "  шаг " + HisTemp.step);
            ts.Push(HisTemp);
            if (UserNumber == TargetNumber)
                MessageBox.Show("Поздравляю! \nВы справились с заданием за " + CommandCount + " шагов");
        }

        /// <summary>
        /// Сброс всех изменений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ChangeSteps(Zero);
            UserNumber = 1;
            lblNumber.Text = Convert.ToString(UserNumber);
            ts.Clear();
            lbHistory.Items.Clear();
            History.Clear();

            EventBtn HisTemp;
            HisTemp.first = 1;
            HisTemp.step = 0;
            HisTemp.method = '_';
            History.Add(HisTemp);
        }

        /// <summary>
        /// Начало новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            int Target = GetNumber();
            TargetNumber = Target;
            UserNumber = 1;
            string text = "Да начнется игра!\n" + "Ваше число : " + Target
                + "\nПолучите его за минимальное количество ходов";

            MessageBox.Show(text);

            ChangeSteps(Zero);
            lblNumber.Text = "1";
            lblTarget.Text = Convert.ToString(Target);

            ts.Clear();
            lbHistory.Items.Clear();
            History.Clear();

            EventBtn HisTemp;
            HisTemp.first = 1;
            HisTemp.step = 0;
            HisTemp.method = '_';
            History.Add(HisTemp);
        }

        /// <summary>
        /// Отмена последнего действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ts.Count > 0)
            {
                ts.Pop();
                lbHistory.Items.RemoveAt(lbHistory.Items.Count - 1);
                History.RemoveAt(History.Count - 1);
                if (History.Count > 0)
                {
                    lblNumber.Text = Convert.ToString(UserNumber = History[History.Count - 1].first);
                    lblStep.Text = Convert.ToString(CommandCount = History[History.Count - 1].step);
                }
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Выбор и пременение действия из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            sender.ToString();
            if (lbHistory.Items.Count > 0)
            {
                lblNumber.Text = Convert.ToString(UserNumber = History[lbHistory.SelectedIndex].first);
                lblStep.Text = Convert.ToString(CommandCount = History[lbHistory.SelectedIndex].step);
            }
        }
    }
}
