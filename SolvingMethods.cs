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
    public partial class SolvingMethods : Form
    {

        //public SolvingMethods()
        //{
        //    InitializeComponent();
          
        //}

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ComputButton_Click(object sender, EventArgs e)
        {
            Methods M = new Methods();
            double a, b,Acc,h,X,Y;
            int n = 12;
            string[] distance = DisBox.Text.Split(',');
            a = double.Parse(distance[0]);
            b = double.Parse(distance[1]);
            Acc = double.Parse(AccBox.Text);
            h = (b - a) / n;
            X = a;
            for (int i = 1; i < n; i++)
            {
                X = X + h;
                Y = M.F1(X);
                chart1.Series[0].Points.AddXY(X, Y);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // SolvingMethods
        //    // 
        //    this.ClientSize = new System.Drawing.Size(741, 406);
        //    this.Name = "SolvingMethods";
        //    this.ResumeLayout(false);

        //}
    }
}
