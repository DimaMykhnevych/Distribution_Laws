using System;
using System.Drawing;
using ZedGraph;

namespace Lab3
{
    partial class GraphicsForm
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.uniformDist = new System.Windows.Forms.TabPage();
            this.expDist = new System.Windows.Forms.TabPage();
            this.zedGraph2 = new ZedGraph.ZedGraphControl();
            this.gaussDist = new System.Windows.Forms.TabPage();
            this.zedGraph3 = new ZedGraph.ZedGraphControl();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstValue = new System.Windows.Forms.TextBox();
            this.secondValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.uniformDist.SuspendLayout();
            this.expDist.SuspendLayout();
            this.gaussDist.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.IsShowPointValues = false;
            this.zedGraph.Location = new System.Drawing.Point(22, 32);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.PointValueFormat = "G";
            this.zedGraph.Size = new System.Drawing.Size(1258, 475);
            this.zedGraph.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.uniformDist);
            this.tabControl1.Controls.Add(this.expDist);
            this.tabControl1.Controls.Add(this.gaussDist);
            this.tabControl1.Location = new System.Drawing.Point(18, 152);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1326, 574);
            this.tabControl1.TabIndex = 1;
            // 
            // uniformDist
            // 
            this.uniformDist.Controls.Add(this.zedGraph);
            this.uniformDist.Location = new System.Drawing.Point(4, 29);
            this.uniformDist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uniformDist.Name = "uniformDist";
            this.uniformDist.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uniformDist.Size = new System.Drawing.Size(1318, 541);
            this.uniformDist.TabIndex = 0;
            this.uniformDist.Text = "Равномерное";
            this.uniformDist.UseVisualStyleBackColor = true;
            // 
            // expDist
            // 
            this.expDist.Controls.Add(this.zedGraph2);
            this.expDist.Location = new System.Drawing.Point(4, 29);
            this.expDist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expDist.Name = "expDist";
            this.expDist.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expDist.Size = new System.Drawing.Size(1318, 541);
            this.expDist.TabIndex = 1;
            this.expDist.Text = "Экспоненциальное";
            this.expDist.UseVisualStyleBackColor = true;
            // 
            // zedGraph2
            // 
            this.zedGraph2.IsShowPointValues = false;
            this.zedGraph2.Location = new System.Drawing.Point(26, 25);
            this.zedGraph2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraph2.Name = "zedGraph2";
            this.zedGraph2.PointValueFormat = "G";
            this.zedGraph2.Size = new System.Drawing.Size(1246, 500);
            this.zedGraph2.TabIndex = 0;
            // 
            // gaussDist
            // 
            this.gaussDist.Controls.Add(this.zedGraph3);
            this.gaussDist.Location = new System.Drawing.Point(4, 29);
            this.gaussDist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gaussDist.Name = "gaussDist";
            this.gaussDist.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gaussDist.Size = new System.Drawing.Size(1318, 541);
            this.gaussDist.TabIndex = 2;
            this.gaussDist.Text = "Нормальное";
            this.gaussDist.UseVisualStyleBackColor = true;
            // 
            // zedGraph3
            // 
            this.zedGraph3.IsShowPointValues = false;
            this.zedGraph3.Location = new System.Drawing.Point(10, 11);
            this.zedGraph3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraph3.Name = "zedGraph3";
            this.zedGraph3.PointValueFormat = "G";
            this.zedGraph3.Size = new System.Drawing.Size(1276, 497);
            this.zedGraph3.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(24, 20);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1002, 106);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1054, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Верхнее значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1054, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Нижнее значение";
            // 
            // firstValue
            // 
            this.firstValue.Location = new System.Drawing.Point(1224, 23);
            this.firstValue.Name = "firstValue";
            this.firstValue.Size = new System.Drawing.Size(100, 26);
            this.firstValue.TabIndex = 5;
            // 
            // secondValue
            // 
            this.secondValue.Location = new System.Drawing.Point(1224, 70);
            this.secondValue.Name = "secondValue";
            this.secondValue.Size = new System.Drawing.Size(100, 26);
            this.secondValue.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1117, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondValue);
            this.Controls.Add(this.firstValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GraphicsForm";
            this.Text = "Graphics";
            this.Load += new System.EventHandler(this.GraphicsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.uniformDist.ResumeLayout(false);
            this.expDist.ResumeLayout(false);
            this.gaussDist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage uniformDist;
        private System.Windows.Forms.TabPage expDist;
        private System.Windows.Forms.TabPage gaussDist;
        private System.Windows.Forms.RichTextBox richTextBox;
        private ZedGraphControl zedGraph2;
        private ZedGraphControl zedGraph3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstValue;
        private System.Windows.Forms.TextBox secondValue;
        private System.Windows.Forms.Button button1;
    }
}

