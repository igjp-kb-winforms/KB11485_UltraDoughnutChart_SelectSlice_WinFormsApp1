﻿namespace KB11485_UltraDoughnutChart_SelectSlice_WinFormsApp1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        ultraDoughnutChart1 = new Infragistics.Win.DataVisualization.UltraDoughnutChart();
        button1 = new Button();
        ((System.ComponentModel.ISupportInitialize)ultraDoughnutChart1).BeginInit();
        SuspendLayout();
        // 
        // ultraDoughnutChart1
        // 
        ultraDoughnutChart1.BackColor = Color.White;
        ultraDoughnutChart1.Location = new Point(0, 0);
        ultraDoughnutChart1.Name = "ultraDoughnutChart1";
        ultraDoughnutChart1.Size = new Size(443, 403);
        ultraDoughnutChart1.TabIndex = 0;
        ultraDoughnutChart1.Text = "ultraDoughnutChart1";
        // 
        // button1
        // 
        button1.Location = new Point(484, 21);
        button1.Name = "button1";
        button1.Size = new Size(250, 44);
        button1.TabIndex = 1;
        button1.Text = "1つ目の項目を選択する";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(ultraDoughnutChart1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)ultraDoughnutChart1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Infragistics.Win.DataVisualization.UltraDoughnutChart ultraDoughnutChart1;
    private Button button1;
}
