using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EqualMethods;
namespace VP_LW_4
{
    public partial class MathMethods : Form
    {
        public MathMethods()
        {
            InitializeComponent();
        }

               
        private void ComputButton_Click_1(object sender, EventArgs e)
        {
            Methods M = new Methods();
            double a, b, Acc, h, X;
            if (string.IsNullOrEmpty(AccBox.Text) || string.IsNullOrEmpty(DisBox.Text))
            {
                MessageBox.Show("Нельзя пустые строки");
            }
            else
            {

                DisBox.KeyPress += DisBox_KeyPress;
                string[] distance = DisBox.Text.Split('/');
                a = double.Parse(distance[0], System.Globalization.CultureInfo.InvariantCulture);
                b = double.Parse(distance[1], System.Globalization.CultureInfo.InvariantCulture);
                Acc = double.Parse(AccBox.Text, System.Globalization.CultureInfo.InvariantCulture);//второй параметр для контроля . и ,


                //первое уравнение
                if (CheckBox1.Checked == true && RadioButton1.Checked == true)
                {
                    try
                    {
                        ListOFres.Text = M.Half_interval(M.F1, a, b, Acc).ToString();
                    }
                    catch (Exception J)
                    {
                        MessageBox.Show(J.Message);
                    }
                }
                else
                {
                    if (CheckBox2.Checked == true && RadioButton1.Checked == true)
                    {
                        try
                        {
                            ListOFres.Text = M.N_tangent(M.F1, a, Acc).ToString();
                        }
                        catch (Exception J)
                        {
                            MessageBox.Show(J.Message);
                        }
                    }
                }
                //второе уравнение
                if (CheckBox1.Checked == true && RadioButton2.Checked == true)
                {
                    try
                    {
                        ListOFres.Text = M.Half_interval(M.F2, a, b, Acc).ToString();
                    }
                    catch (Exception J)
                    {
                        MessageBox.Show(J.Message);
                    }
                }
                else
                {
                    if (CheckBox2.Checked == true && RadioButton2.Checked == true)
                    {
                        try
                        {
                            ListOFres.Text = M.N_tangent(M.F2, a, Acc).ToString();
                        }
                        catch (Exception J)
                        {
                            MessageBox.Show(J.Message);
                        }
                    }
                }

                //построение графика
                h = Math.Pow(Acc, 0.25);//по правилу Рунге
                int n = (int)((b - a) / h);
                X = a;
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (int i = 0; i <= n; i++)
                {
                    X = X + h;
                    chart1.Series[0].Points.AddXY(X, M.F1(X));
                    chart1.Series[1].Points.AddXY(X, M.F2(X));
                }
            }
        }

        private void DisBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(!(c>='0'&&c<='9'||c=='-'||c=='.'||c=='/'||c=='\b'))
                {
                e.Handled = true;
            }
        }

        private void MathMethods_HelpButtonClicked(object sender, CancelEventArgs e)
        {
           // MessageBox.Show("Программа решает нелинейные уравнения методом Ньютона и методом половинного деления");
        }

        private void MathMethods_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Программа решает нелинейные уравнения методом Ньютона и методом половинного деления");

        }
    }
}
