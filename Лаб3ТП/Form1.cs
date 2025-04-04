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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(textBox1.Text);
            var isChecked = checkBox1.Checked;
            var set = Logic.GetSet1();
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
            var number = Convert.ToInt32(textBox3.Text);
            var isChecked = checkBox2.Checked;
            var set = Logic.GetSet2();
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
        private static HashSet<int> set1 = new HashSet<int>();
        private static HashSet<int> set2 = new HashSet<int>();
        public static string UniteTwoSets(HashSet<int> set1, HashSet<int> set2)
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
            return results;//zdes bil nikita
        }
        public static string IntersectTwoSets(HashSet<int> set1, HashSet<int> set2)
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
            return results;
        }
        public static string SubtractFirstSetFromSecondSet(HashSet<int> set1, HashSet<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set2)
            {
                if (!set1.Contains(number) && set2.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            return results;
        }
        public static string SubtractSecondSetFromFirstSet(HashSet<int> set1, HashSet<int> set2)
        {
            List<int> resultSet = new List<int>();
            string results;
            foreach (int number in set1)
            {
                if (set1.Contains(number) && !set2.Contains(number))
                    resultSet.Add(number);
            }
            results = String.Join(" ", resultSet);
            return results;
        }
        public static string AddNumberToSet(int number, bool isChecked, HashSet<int> set)
        {
            set.Add(number);
            return String.Join(" ", set);
        }
        public static string DeleteNumberToSet(int number, bool isChecked, HashSet<int> set)
        {
            set.Remove(number);
            return String.Join(" ", set);
        }
        public static HashSet<int> GetSet1()
        {
            return set1;
        }
        public static HashSet<int> GetSet2()
        {
            return set2;
        }

    }
}