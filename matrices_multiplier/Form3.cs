using System.Drawing;
using System.Windows.Forms;
namespace matrices_multiplier
{
    public partial class Form3 : Form
    {
        public Form3(double[,] m1, double[,] m2)
        {
            InitializeComponent();
            int matrix1_rows = m1.GetLength(0);
            int matrix1_columns = m1.GetLength(1);
            int matrix2_rows = m2.GetLength(0);
            int matrix2_columns = m2.GetLength(1);
            double temp = 0;
            int fw = 0;
            TextBox[,] textbox_result = new TextBox[m1.GetLength(0), m2.GetLength(1)];
            double[,] result = new double[m1.GetLength(0), m2.GetLength(1)];
            int x = 10, y = 10;
            for (int i = 0; i < matrix1_rows; i++)
            {
                for (int j = 0; j < matrix2_columns; j++)
                {
                    for (int k = 0; k < matrix1_columns; k++)
                    {
                        temp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = temp;
                    textbox_result[i, j] = new TextBox
                    {
                        Text = temp.ToString(),
                        Location = new Point(x, y),
                        Size = new Size(30, 10)
                    };
                    temp = 0;
                    Controls.Add(textbox_result[i, j]);
                    x += 40;
                    if (j == matrix2_columns - 1)
                    {
                        fw = x;
                        y += 20;
                        x = 10;
                    }
                }
            }
            this.Size = new Size(fw + 20, y + 50);
        }
    }
}