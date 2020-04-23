namespace VP_LW_4
{
    partial class SolvingMethods
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
           System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
           System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChoBox = new System.Windows.Forms.GroupBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.СheckBox2 = new System.Windows.Forms.CheckBox();
            this.Distance = new System.Windows.Forms.Label();
            this.DisBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ComputButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.AccBox = new System.Windows.Forms.TextBox();
            this.ChoBox.SuspendLayout();
            this.ResultBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoBox
            // 
            this.ChoBox.Controls.Add(this.AccBox);
            this.ChoBox.Controls.Add(this.label1);
            this.ChoBox.Controls.Add(this.ComputButton);
            this.ChoBox.Controls.Add(this.DisBox);
            this.ChoBox.Controls.Add(this.Distance);
            this.ChoBox.Controls.Add(this.СheckBox2);
            this.ChoBox.Controls.Add(this.CheckBox1);
            this.ChoBox.Controls.Add(this.RadioButton2);
            this.ChoBox.Controls.Add(this.RadioButton1);
            this.ChoBox.Location = new System.Drawing.Point(12, 12);
            this.ChoBox.Name = "ChoBox";
            this.ChoBox.Size = new System.Drawing.Size(328, 208);
            this.ChoBox.TabIndex = 0;
            this.ChoBox.TabStop = false;
            this.ChoBox.Text = "Уравнение";
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(7, 44);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(113, 21);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Уравнение 1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(7, 83);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(113, 21);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Уравнение 2";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(6, 122);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(146, 21);
            this.CheckBox1.TabIndex = 2;
            this.CheckBox1.Text = "Метод дихотомии";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // СheckBox2
            // 
            this.СheckBox2.AutoSize = true;
            this.СheckBox2.Location = new System.Drawing.Point(6, 149);
            this.СheckBox2.Name = "СheckBox2";
            this.СheckBox2.Size = new System.Drawing.Size(134, 21);
            this.СheckBox2.TabIndex = 3;
            this.СheckBox2.Text = "Метод Ньютона";
            this.СheckBox2.UseVisualStyleBackColor = true;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(162, 83);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(64, 17);
            this.Distance.TabIndex = 4;
            this.Distance.Text = "Отрезок";
            // 
            // DisBox
            // 
            this.DisBox.Location = new System.Drawing.Point(233, 83);
            this.DisBox.Name = "DisBox";
            this.DisBox.Size = new System.Drawing.Size(74, 22);
            this.DisBox.TabIndex = 5;
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.listBox1);
            this.ResultBox.Location = new System.Drawing.Point(13, 225);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(326, 214);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Результат";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 180);
            this.listBox1.TabIndex = 0;
            // 
            // ComputButton
            // 
            this.ComputButton.Location = new System.Drawing.Point(214, 122);
            this.ComputButton.Name = "ComputButton";
            this.ComputButton.Size = new System.Drawing.Size(93, 30);
            this.ComputButton.TabIndex = 6;
            this.ComputButton.Text = "Расчет";
            this.ComputButton.UseVisualStyleBackColor = true;
            this.ComputButton.Click += new System.EventHandler(this.ComputButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(347, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(526, 400);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Точность";
            // 
            // AccBox
            // 
            this.AccBox.Location = new System.Drawing.Point(233, 43);
            this.AccBox.Name = "AccBox";
            this.AccBox.Size = new System.Drawing.Size(74, 22);
            this.AccBox.TabIndex = 8;
            // 
            // SolvingMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.ChoBox);
            this.Name = "SolvingMethods";
            this.Text = "SolvingMethods";
            this.ChoBox.ResumeLayout(false);
            this.ChoBox.PerformLayout();
            this.ResultBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChoBox;
        private System.Windows.Forms.Button ComputButton;
        private System.Windows.Forms.TextBox DisBox;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.CheckBox СheckBox2;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox AccBox;
        private System.Windows.Forms.Label label1;
    }
}