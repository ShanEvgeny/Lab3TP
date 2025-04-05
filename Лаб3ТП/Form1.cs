using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Лаб3ТП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number;
            List<int> set;
            bool isChecked;
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                set = Logic.GetSet1();
                isChecked = checkBox1.Checked;
                if (set.Contains(number) && isChecked || !set.Contains(number) && !isChecked)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                textBox1.Text = "";
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (isChecked)
            {
                textBox2.Text = Logic.AddNumberToSet(number, isChecked, set);
            }
            else
            {
                textBox2.Text = Logic.DeleteNumberToSet(number, isChecked, set);
            }
            textBox1.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int number;
            List<int> set;
            bool isChecked;
            try
            {
                number = Convert.ToInt32(textBox3.Text);
                set = Logic.GetSet2();
                isChecked = checkBox2.Checked;
                if (set.Contains(number) && isChecked || !set.Contains(number) && !isChecked)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                textBox3.Text = "";
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isChecked)
            {
                textBox4.Text = Logic.AddNumberToSet(number, isChecked, set);
            }
            else
            {
                textBox4.Text = Logic.DeleteNumberToSet(number, isChecked, set);
            }
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var set1 = Logic.GetSet1();
            var set2 = Logic.GetSet2();
            textBox5.Text = Logic.UniteTwoSets(set1, set2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var set1 = Logic.GetSet1();
            var set2 = Logic.GetSet2();
            textBox5.Text = Logic.IntersectTwoSets(set1, set2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var set1 = Logic.GetSet1();
            var set2 = Logic.GetSet2();
            textBox5.Text = Logic.SubtractSecondSetFromFirstSet(set1, set2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var set1 = Logic.GetSet1();
            var set2 = Logic.GetSet2();
            textBox5.Text = Logic.SubtractFirstSetFromSecondSet(set1, set2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                checkBox1.Text = "удаление";
            }
            else
            {
                checkBox1.Text = "добавление";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(this, new EventArgs());
        }
    }
    public class Logic
    {
        private static List<int> set1 = new List<int>();
        private static List<int> set2 = new List<int>();
        public static string UniteTwoSets(List<int> set1, List<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set1)
            {
                if (set1.Contains(number) && !resultSet.Contains(number))
                    resultSet.Add(number);
            }
            foreach (int number in set2)
            {
                if (set2.Contains(number) && !resultSet.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            if (results == "")
                return "пустое множество";
            return results;//zdes bil nikita
        }
        public static string IntersectTwoSets(List<int> set1, List<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set1)
            {
                if (set1.Contains(number) && set2.Contains(number) && !resultSet.Contains(number))
                    resultSet.Add(number);
            }
            foreach (int number in set2)
            {
                if (set2.Contains(number) && set1.Contains(number) && !resultSet.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            if (results == "")
                return "пустое множество";
            return results;
        }
        public static string SubtractFirstSetFromSecondSet(List<int> set1, List<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set2)
            {
                if (!set1.Contains(number) && set2.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            if (results == "")
                return "пустое множество";
            return results;
        }
        public static string SubtractSecondSetFromFirstSet(List<int> set1, List<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set1)
            {
                if (set1.Contains(number) && !set2.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            if (results == "")
                return "пустое множество";
            return results;
        }
        public static string AddNumberToSet(int number, bool isChecked, List<int> set)
        {
            set.Add(number);
            return String.Join(" ", set);
        }
        public static string DeleteNumberToSet(int number, bool isChecked, List<int> set)
        {
            set.Remove(number);
            return String.Join(" ", set);
        }
        public static List<int> GetSet1()
        {
            return set1;
        }
        public static List<int> GetSet2()
        {
            return set2;
        }

    }
}