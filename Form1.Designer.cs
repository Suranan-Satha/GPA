namespace _04022025
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_input_GPA = new System.Windows.Forms.TextBox();
            this.tb_GPAx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_input_STD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input_GPA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_input_GPA
            // 
            this.tb_input_GPA.Location = new System.Drawing.Point(190, 95);
            this.tb_input_GPA.Name = "tb_input_GPA";
            this.tb_input_GPA.Size = new System.Drawing.Size(100, 22);
            this.tb_input_GPA.TabIndex = 2;
            // 
            // tb_GPAx
            // 
            this.tb_GPAx.Location = new System.Drawing.Point(190, 135);
            this.tb_GPAx.Name = "tb_GPAx";
            this.tb_GPAx.Size = new System.Drawing.Size(100, 22);
            this.tb_GPAx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPAx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student";
            // 
            // tb_input_STD
            // 
            this.tb_input_STD.Location = new System.Drawing.Point(190, 60);
            this.tb_input_STD.Name = "tb_input_STD";
            this.tb_input_STD.Size = new System.Drawing.Size(100, 22);
            this.tb_input_STD.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MAX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "MIN";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(81, 269);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(100, 22);
            this.tb_min.TabIndex = 9;
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(81, 227);
            this.tb_max.Name = "tb_max";
            this.tb_max.Size = new System.Drawing.Size(100, 22);
            this.tb_max.TabIndex = 10;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(275, 206);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(173, 85);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 334);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_input_STD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_GPAx);
            this.Controls.Add(this.tb_input_GPA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_input_GPA;
        private System.Windows.Forms.TextBox tb_GPAx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_input_STD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Button btn_clear;
    }
}

