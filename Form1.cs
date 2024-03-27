using System.Text;
using static SlavaLab2.Form1;

namespace SlavaLab2
{
    public partial class Form1 : Form
    {
        private FixedLengthStringArray myFixedLengthStringArray1;
        private FixedLengthStringArray myFixedLengthStringArray2;
        public Form1()
        {
            InitializeComponent();
            myFixedLengthStringArray1 = new FixedLengthStringArray(5);
            myFixedLengthStringArray2 = new FixedLengthStringArray(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Рядок 1:";
            label2.Text = "Рядок 2:";
            label3.Text = "Результат:";
            label4.Text = "Звертання за індексом";
            btnOK.Text = "Зчеплення";
            btnOK2.Text = "Злиття";
            btnOK3.Text = "Індекс";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array1 = txtOne.Text.Split(',');
                string[] array2 = txtTwo.Text.Split(',');

                if (array1.Length != array2.Length)
                {
                    MessageBox.Show("Масиви повинні бути однакової довжини");
                    return;
                }

                myFixedLengthStringArray1 = new FixedLengthStringArray(array1.Length);
                myFixedLengthStringArray2 = new FixedLengthStringArray(array2.Length);

                for (int i = 0; i < array1.Length; i++)
                {
                    myFixedLengthStringArray1[i] = array1[i];
                    myFixedLengthStringArray2[i] = array2[i];
                }

                FixedLengthStringArray concatenatedArray = myFixedLengthStringArray1.Concat(myFixedLengthStringArray2);

                StringBuilder resultBuilder = new StringBuilder();
                for (int i = 0; i < concatenatedArray.Length; i++)
                {
                    resultBuilder.Append(concatenatedArray[i]);
                    if (i < concatenatedArray.Length - 1)
                        resultBuilder.Append(", ");
                }
                lblResult.Text = resultBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnOK3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array1 = txtOne.Text.Split(',');
                string[] array2 = txtTwo.Text.Split(',');

                string[] mergedArray = array1.Union(array2).ToArray();

                int index = Convert.ToInt32(txtBox.Text);

                if (index < 0 || index >= mergedArray.Length)
                {
                    MessageBox.Show("Індекс виходить за межі масиву");
                    return;
                }

                MessageBox.Show($"Елемент масиву за індексом {index}: {mergedArray[index]}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array1 = txtOne.Text.Split(',');
                string[] array2 = txtTwo.Text.Split(',');

                string[] mergedArray = array1.Union(array2).ToArray();

                lblResult.Text = string.Join(", ", mergedArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }
    }
}

