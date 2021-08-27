using System;
using System.Drawing;
using System.Windows.Forms;
namespace matrices_multiplier
{
    public partial class Form2 : Form
    {
        double[,] matrix1, matrix2;
        TextBox[,] m1;
        TextBox[,] m2;
        int m1Rows, m1Cols, m2Rows, m2Cols;
        void b1_Click(object sender, System.EventArgs e)
        {
            matrix1 = new Double[m1Rows, m1Cols];
            matrix2 = new Double[m2Rows, m2Cols];
            try
            {

                for (int i = 0; i < m1.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.GetLength(1); j++)
                    {
                        matrix1[i, j] = double.Parse(m1[i, j].Text);
                    }
                }
                for (int i = 0; i < m2.GetLength(0); i++)
                {
                    for (int j = 0; j < m2.GetLength(1); j++)
                    {
                        matrix2[i, j] = double.Parse(m2[i, j].Text);
                    }
                };
                Form3 form3 = new Form3(matrix1, matrix2);
                form3.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter decimal numbers and ensure you use dots instead of commas.", "Error");
            };
            
        }
        public Form2(int m1r, int m1c, int m2r, int m2c)
        {
            InitializeComponent();
            int fw1=0, fw2=0;
            m1Rows = m1r;
            m1Cols = m1c;
            m2Rows = m2r;
            m2Cols = m2c;
            m1 = new TextBox[m1r, m1c];
            m2 = new TextBox[m2r, m2c];
            Label l1 = new Label
            {
                Text = "First matrix",
                Location = new Point(10, 10),
                Size = new Size(100, 15)
            };
            Controls.Add(l1);
            int a = 10, b = 35;
            for (int i = 0; i < m1r; i++)
            {
                for (int j = 0; j < m1c; j++)
                {
                    m1[i, j] = new TextBox
                    {
                        Location = new Point(a, b),
                        Size = new Size(45, 10)
                    };
                    a += 55;
                    if (j == m1c - 1)
                    {
                        fw1 = a;
                        a = 10;
                    }
                    Controls.Add(m1[i, j]);
                }
                b += 25;
            }
            Label l2 = new Label
            {
                Text = "Second matrix",
                Location = new Point(10, b+5),
                Size = new Size(100,15)
            };
            Controls.Add(l2);
            b += 30;
            for (int i = 0; i < m2r; i++)
            {
                for (int j = 0; j < m2c; j++)
                {
                    m2[i, j] = new TextBox
                    {
                        Location = new Point(a, b),
                        Size = new Size(45, 10)
                    };
                    a += 55;
                    if (j == m2c - 1)
                    {
                        fw2 = a;
                        a = 10;
                    }

                    Controls.Add(m2[i, j]);
                }
                b += 25;
            }
            if (fw2 > fw1) fw1 = fw2;
            this.Size = new Size(20 + fw1, b+80);
            Button b1 = new Button
            {
                Text = "Multiply",
                Location = new Point(10, b)
            };
            b1.Click += new System.EventHandler(b1_Click);
            Controls.Add(b1);
        }
    }
}