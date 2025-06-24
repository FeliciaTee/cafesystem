namespace cafesystem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbPickup = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Meowcha Cafe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number :";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(596, 156);
            this.tB_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(167, 26);
            this.tB_name.TabIndex = 4;
            // 
            // tB_phone
            // 
            this.tB_phone.Location = new System.Drawing.Point(603, 228);
            this.tB_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(144, 26);
            this.tB_phone.TabIndex = 5;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Pink;
            this.btn_order.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(627, 456);
            this.btn_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(238, 49);
            this.btn_order.TabIndex = 6;
            this.btn_order.Tag = " ";
            this.btn_order.Text = "Start Ordering";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelivery.Location = new System.Drawing.Point(422, 348);
            this.rbDelivery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(106, 25);
            this.rbDelivery.TabIndex = 7;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbPickup
            // 
            this.rbPickup.AutoSize = true;
            this.rbPickup.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPickup.Location = new System.Drawing.Point(614, 348);
            this.rbPickup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbPickup.Name = "rbPickup";
            this.rbPickup.Size = new System.Drawing.Size(102, 25);
            this.rbPickup.TabIndex = 8;
            this.rbPickup.TabStop = true;
            this.rbPickup.Text = "Pick-Up";
            this.rbPickup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose your order method :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cafesystem.Properties.Resources.meow;
            this.pictureBox1.Location = new System.Drawing.Point(91, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(932, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbPickup);
            this.Controls.Add(this.rbDelivery);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.tB_phone);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Meowcha Cafe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbPickup;
        private System.Windows.Forms.Label label4;
    }
}

