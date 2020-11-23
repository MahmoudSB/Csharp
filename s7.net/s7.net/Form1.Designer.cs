namespace s7.net
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
            this.Lable_ipAddress = new System.Windows.Forms.Label();
            this.Lable_Rack = new System.Windows.Forms.Label();
            this.Lable_Slot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_CPU = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.label_Setpoint = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Write = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PresentValue = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lable_ipAddress
            // 
            this.Lable_ipAddress.AutoSize = true;
            this.Lable_ipAddress.Location = new System.Drawing.Point(30, 58);
            this.Lable_ipAddress.Name = "Lable_ipAddress";
            this.Lable_ipAddress.Size = new System.Drawing.Size(76, 17);
            this.Lable_ipAddress.TabIndex = 0;
            this.Lable_ipAddress.Text = "IP Address";
            this.Lable_ipAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lable_Rack
            // 
            this.Lable_Rack.AutoSize = true;
            this.Lable_Rack.Location = new System.Drawing.Point(30, 92);
            this.Lable_Rack.Name = "Lable_Rack";
            this.Lable_Rack.Size = new System.Drawing.Size(40, 17);
            this.Lable_Rack.TabIndex = 1;
            this.Lable_Rack.Text = "Rack";
            this.Lable_Rack.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Lable_Slot
            // 
            this.Lable_Slot.AutoSize = true;
            this.Lable_Slot.Location = new System.Drawing.Point(30, 128);
            this.Lable_Slot.Name = "Lable_Slot";
            this.Lable_Slot.Size = new System.Drawing.Size(32, 17);
            this.Lable_Slot.TabIndex = 2;
            this.Lable_Slot.Text = "Slot";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label_CPU
            // 
            this.label_CPU.AutoSize = true;
            this.label_CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CPU.Location = new System.Drawing.Point(28, 9);
            this.label_CPU.Name = "label_CPU";
            this.label_CPU.Size = new System.Drawing.Size(36, 17);
            this.label_CPU.TabIndex = 6;
            this.label_CPU.Text = "CPU";
            this.label_CPU.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(33, 171);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(106, 34);
            this.button_Connect.TabIndex = 8;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Location = new System.Drawing.Point(173, 171);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(106, 34);
            this.button_Disconnect.TabIndex = 9;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Setpoint
            // 
            this.label_Setpoint.AutoSize = true;
            this.label_Setpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Setpoint.Location = new System.Drawing.Point(392, 80);
            this.label_Setpoint.Name = "label_Setpoint";
            this.label_Setpoint.Size = new System.Drawing.Size(44, 17);
            this.label_Setpoint.TabIndex = 11;
            this.label_Setpoint.Text = "Value";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(523, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 22);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(416, 122);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(106, 34);
            this.button_Read.TabIndex = 14;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Write
            // 
            this.button_Write.Location = new System.Drawing.Point(548, 121);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(106, 34);
            this.button_Write.TabIndex = 15;
            this.button_Write.Text = "Write";
            this.button_Write.UseVisualStyleBackColor = true;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(413, 174);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(48, 17);
            this.label_Status.TabIndex = 16;
            this.label_Status.Text = "Status";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(467, 171);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 22);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(523, 20);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 22);
            this.textBox7.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Address";
            // 
            // label_PresentValue
            // 
            this.label_PresentValue.AutoSize = true;
            this.label_PresentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PresentValue.Location = new System.Drawing.Point(392, 51);
            this.label_PresentValue.Name = "label_PresentValue";
            this.label_PresentValue.Size = new System.Drawing.Size(82, 17);
            this.label_PresentValue.TabIndex = 10;
            this.label_PresentValue.Text = "Read Value";
            this.label_PresentValue.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(523, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 22);
            this.textBox5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 231);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Write);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_Setpoint);
            this.Controls.Add(this.label_PresentValue);
            this.Controls.Add(this.button_Disconnect);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_CPU);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lable_Slot);
            this.Controls.Add(this.Lable_Rack);
            this.Controls.Add(this.Lable_ipAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable_ipAddress;
        private System.Windows.Forms.Label Lable_Rack;
        private System.Windows.Forms.Label Lable_Slot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_CPU;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Label label_Setpoint;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Write;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_PresentValue;
        private System.Windows.Forms.TextBox textBox5;
    }
}

