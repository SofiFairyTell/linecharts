namespace VP_LW_4
{
    partial class MathMethods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ComputButton = new System.Windows.Forms.Button();
            this.AccBox = new System.Windows.Forms.TextBox();
            this.DisBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ResBox = new System.Windows.Forms.GroupBox();
            this.ListOFres = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ResBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ComputButton);
            this.GroupBox1.Controls.Add(this.AccBox);
            this.GroupBox1.Controls.Add(this.DisBox);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(345, 210);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Уравнение";
            // 
            // ComputButton
            // 
            this.ComputButton.Location = new System.Drawing.Point(231, 121);
            this.ComputButton.Name = "ComputButton";
            this.ComputButton.Size = new System.Drawing.Size(100, 23);
            this.ComputButton.TabIndex = 8;
            this.ComputButton.Text = "Расчет";
            this.ComputButton.UseVisualStyleBackColor = true;
            this.ComputButton.Click += new System.EventHandler(this.ComputButton_Click_1);
            // 
            // AccBox
            // 
            this.AccBox.Location = new System.Drawing.Point(231, 35);
            this.AccBox.Name = "AccBox";
            this.AccBox.Size = new System.Drawing.Size(100, 22);
            this.AccBox.TabIndex = 7;
            // 
            // DisBox
            // 
            this.DisBox.Location = new System.Drawing.Point(231, 79);
            this.DisBox.Name = "DisBox";
            this.DisBox.Size = new System.Drawing.Size(100, 22);
            this.DisBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.DisBox, "Ввод в виде: A/B");
            this.DisBox.TextChanged += new System.EventHandler(this.DisBox_TextChanged);
            this.DisBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DisBox_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(160, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Интервал";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(160, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Точность";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.helpProvider2.SetHelpString(this.CheckBox2, "Root: Xnext = Xprev - F(Xprev) / Fdif(F1,Xprev)");
            this.CheckBox2.Location = new System.Drawing.Point(6, 160);
            this.CheckBox2.Name = "CheckBox2";
            this.helpProvider2.SetShowHelp(this.CheckBox2, true);
            this.helpProvider1.SetShowHelp(this.CheckBox2, true);
            this.CheckBox2.Size = new System.Drawing.Size(134, 21);
            this.CheckBox2.TabIndex = 3;
            this.CheckBox2.Text = "Метод Ньютона";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.helpProvider1.SetHelpString(this.CheckBox1, "Root: c = (a + b) * 0.5");
            this.CheckBox1.Location = new System.Drawing.Point(6, 121);
            this.CheckBox1.Name = "CheckBox1";
            this.helpProvider1.SetShowHelp(this.CheckBox1, true);
            this.CheckBox1.Size = new System.Drawing.Size(146, 21);
            this.CheckBox1.TabIndex = 2;
            this.CheckBox1.Text = "Метод дихотомии";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(6, 75);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(116, 21);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "x^3-x^2+2*x-4";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(7, 35);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(109, 21);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "x*Log(x+2)-1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(363, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Уравнение 1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Уравнение 2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(640, 419);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // ResBox
            // 
            this.ResBox.Controls.Add(this.ListOFres);
            this.ResBox.Location = new System.Drawing.Point(12, 229);
            this.ResBox.Name = "ResBox";
            this.ResBox.Size = new System.Drawing.Size(345, 209);
            this.ResBox.TabIndex = 2;
            this.ResBox.TabStop = false;
            this.ResBox.Text = "Результат";
            // 
            // ListOFres
            // 
            this.ListOFres.Location = new System.Drawing.Point(7, 22);
            this.ListOFres.Multiline = true;
            this.ListOFres.Name = "ListOFres";
            this.ListOFres.Size = new System.Drawing.Size(332, 180);
            this.ListOFres.TabIndex = 0;
            // 
            // MathMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.ResBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MathMethods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathMethods";
            this.toolTip1.SetToolTip(this, "Метод половинного деления");
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MathMethods_HelpButtonClicked);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MathMethods_HelpRequested);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResBox.ResumeLayout(false);
            this.ResBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox DisBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.TextBox AccBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox ResBox;
        private System.Windows.Forms.Button ComputButton;
        private System.Windows.Forms.TextBox ListOFres;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
    }
}