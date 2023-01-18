namespace Shifrovalka
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
            this.txtTe = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnShifr = new System.Windows.Forms.Button();
            this.nudSdvig = new System.Windows.Forms.NumericUpDown();
            this.lblOne = new System.Windows.Forms.Label();
            this.nudShag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSdvigDe = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudShagDe = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.nudDlina = new System.Windows.Forms.NumericUpDown();
            this.nudDlinaDe = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSdvig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSdvigDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShagDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDlina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDlinaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTe
            // 
            this.txtTe.Location = new System.Drawing.Point(13, 11);
            this.txtTe.Multiline = true;
            this.txtTe.Name = "txtTe";
            this.txtTe.Size = new System.Drawing.Size(513, 76);
            this.txtTe.TabIndex = 0;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(13, 202);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(513, 76);
            this.txtRes.TabIndex = 1;
            // 
            // btnShifr
            // 
            this.btnShifr.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShifr.Location = new System.Drawing.Point(12, 144);
            this.btnShifr.Name = "btnShifr";
            this.btnShifr.Size = new System.Drawing.Size(142, 52);
            this.btnShifr.TabIndex = 2;
            this.btnShifr.Text = "Шифровать";
            this.btnShifr.UseVisualStyleBackColor = true;
            this.btnShifr.Click += new System.EventHandler(this.btnShifr_Click);
            // 
            // nudSdvig
            // 
            this.nudSdvig.Location = new System.Drawing.Point(13, 89);
            this.nudSdvig.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSdvig.Name = "nudSdvig";
            this.nudSdvig.Size = new System.Drawing.Size(45, 20);
            this.nudSdvig.TabIndex = 3;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(64, 91);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(37, 13);
            this.lblOne.TabIndex = 4;
            this.lblOne.Text = "Сдвиг";
            // 
            // nudShag
            // 
            this.nudShag.Location = new System.Drawing.Point(108, 88);
            this.nudShag.Name = "nudShag";
            this.nudShag.Size = new System.Drawing.Size(46, 20);
            this.nudShag.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Шаг";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Дешифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Шаг";
            // 
            // nudSdvigDe
            // 
            this.nudSdvigDe.Location = new System.Drawing.Point(480, 89);
            this.nudSdvigDe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSdvigDe.Name = "nudSdvigDe";
            this.nudSdvigDe.Size = new System.Drawing.Size(46, 20);
            this.nudSdvigDe.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сдвиг";
            // 
            // nudShagDe
            // 
            this.nudShagDe.Location = new System.Drawing.Point(384, 89);
            this.nudShagDe.Name = "nudShagDe";
            this.nudShagDe.Size = new System.Drawing.Size(45, 20);
            this.nudShagDe.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(194, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "С Б Р О С";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudDlina
            // 
            this.nudDlina.Location = new System.Drawing.Point(13, 114);
            this.nudDlina.Name = "nudDlina";
            this.nudDlina.Size = new System.Drawing.Size(57, 20);
            this.nudDlina.TabIndex = 13;
            // 
            // nudDlinaDe
            // 
            this.nudDlinaDe.Location = new System.Drawing.Point(469, 118);
            this.nudDlinaDe.Name = "nudDlinaDe";
            this.nudDlinaDe.Size = new System.Drawing.Size(57, 20);
            this.nudDlinaDe.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Длина шага";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Длина шага";
            // 
            // btnFF
            // 
            this.btnFF.Location = new System.Drawing.Point(209, 124);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(124, 23);
            this.btnFF.TabIndex = 17;
            this.btnFF.Text = "Аыфва";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.btnFF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 290);
            this.Controls.Add(this.btnFF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDlinaDe);
            this.Controls.Add(this.nudDlina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSdvigDe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudShagDe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudShag);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.nudSdvig);
            this.Controls.Add(this.btnShifr);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtTe);
            this.Name = "Form1";
            this.Text = "Конура радиста";
            ((System.ComponentModel.ISupportInitialize)(this.nudSdvig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSdvigDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShagDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDlina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDlinaDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTe;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnShifr;
        private System.Windows.Forms.NumericUpDown nudSdvig;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.NumericUpDown nudShag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSdvigDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudShagDe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudDlina;
        private System.Windows.Forms.NumericUpDown nudDlinaDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFF;
    }
}

