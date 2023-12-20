
namespace Araba_Kontrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictUp = new System.Windows.Forms.PictureBox();
            this.pictLeft = new System.Windows.Forms.PictureBox();
            this.pictDown = new System.Windows.Forms.PictureBox();
            this.pictRight = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxKontrol = new System.Windows.Forms.GroupBox();
            this.groupBoxBluetooth = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRight)).BeginInit();
            this.groupBoxKontrol.SuspendLayout();
            this.groupBoxBluetooth.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictUp
            // 
            this.pictUp.BackColor = System.Drawing.Color.DarkCyan;
            this.pictUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictUp.Image = ((System.Drawing.Image)(resources.GetObject("pictUp.Image")));
            this.pictUp.Location = new System.Drawing.Point(109, 16);
            this.pictUp.Name = "pictUp";
            this.pictUp.Size = new System.Drawing.Size(71, 58);
            this.pictUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictUp.TabIndex = 0;
            this.pictUp.TabStop = false;
            // 
            // pictLeft
            // 
            this.pictLeft.BackColor = System.Drawing.Color.DarkCyan;
            this.pictLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictLeft.Image")));
            this.pictLeft.Location = new System.Drawing.Point(9, 100);
            this.pictLeft.Name = "pictLeft";
            this.pictLeft.Size = new System.Drawing.Size(71, 58);
            this.pictLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLeft.TabIndex = 0;
            this.pictLeft.TabStop = false;
            // 
            // pictDown
            // 
            this.pictDown.BackColor = System.Drawing.Color.DarkCyan;
            this.pictDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictDown.Image = ((System.Drawing.Image)(resources.GetObject("pictDown.Image")));
            this.pictDown.Location = new System.Drawing.Point(109, 100);
            this.pictDown.Name = "pictDown";
            this.pictDown.Size = new System.Drawing.Size(71, 58);
            this.pictDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictDown.TabIndex = 0;
            this.pictDown.TabStop = false;
            // 
            // pictRight
            // 
            this.pictRight.BackColor = System.Drawing.Color.DarkCyan;
            this.pictRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictRight.Image = ((System.Drawing.Image)(resources.GetObject("pictRight.Image")));
            this.pictRight.Location = new System.Drawing.Point(206, 100);
            this.pictRight.Name = "pictRight";
            this.pictRight.Size = new System.Drawing.Size(71, 58);
            this.pictRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictRight.TabIndex = 0;
            this.pictRight.TabStop = false;
            // 
            // groupBoxKontrol
            // 
            this.groupBoxKontrol.Controls.Add(this.pictUp);
            this.groupBoxKontrol.Controls.Add(this.pictLeft);
            this.groupBoxKontrol.Controls.Add(this.pictRight);
            this.groupBoxKontrol.Controls.Add(this.pictDown);
            this.groupBoxKontrol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKontrol.ForeColor = System.Drawing.Color.PaleGreen;
            this.groupBoxKontrol.Location = new System.Drawing.Point(191, 175);
            this.groupBoxKontrol.Name = "groupBoxKontrol";
            this.groupBoxKontrol.Size = new System.Drawing.Size(288, 174);
            this.groupBoxKontrol.TabIndex = 1;
            this.groupBoxKontrol.TabStop = false;
            this.groupBoxKontrol.Text = "Kontrol Tuşları";
            // 
            // groupBoxBluetooth
            // 
            this.groupBoxBluetooth.Controls.Add(this.comboBox1);
            this.groupBoxBluetooth.Controls.Add(this.label2);
            this.groupBoxBluetooth.Controls.Add(this.button2);
            this.groupBoxBluetooth.Controls.Add(this.button1);
            this.groupBoxBluetooth.Controls.Add(this.label1);
            this.groupBoxBluetooth.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBluetooth.ForeColor = System.Drawing.Color.PaleGreen;
            this.groupBoxBluetooth.Location = new System.Drawing.Point(108, 12);
            this.groupBoxBluetooth.Name = "groupBoxBluetooth";
            this.groupBoxBluetooth.Size = new System.Drawing.Size(467, 100);
            this.groupBoxBluetooth.TabIndex = 2;
            this.groupBoxBluetooth.TabStop = false;
            this.groupBoxBluetooth.Text = "Bluetooth Haberleşme Bağlantısı";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bağlantı Durumu";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(179, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(179, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(645, 393);
            this.Controls.Add(this.groupBoxBluetooth);
            this.Controls.Add(this.groupBoxKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araba Kontrol Konsolu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRight)).EndInit();
            this.groupBoxKontrol.ResumeLayout(false);
            this.groupBoxBluetooth.ResumeLayout(false);
            this.groupBoxBluetooth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictUp;
        private System.Windows.Forms.PictureBox pictLeft;
        private System.Windows.Forms.PictureBox pictDown;
        private System.Windows.Forms.PictureBox pictRight;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxKontrol;
        private System.Windows.Forms.GroupBox groupBoxBluetooth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

