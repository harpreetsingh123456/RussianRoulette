namespace harrpeetFireGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.pb_Gun = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Olive;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(500, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(101, 180);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(256, 65);
            this.button6.TabIndex = 7;
            this.button6.Text = "Shoot Away";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(101, 107);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "Shoot";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(272, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 65);
            this.button3.TabIndex = 5;
            this.button3.Text = "Spin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(8, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbGun
            // 
            this.pbGun.Location = new System.Drawing.Point(292, 135);
            this.pbGun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(62, 37);
            this.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGun.TabIndex = 4;
            this.pbGun.TabStop = false;
            this.pbGun.Visible = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Image = global::harrpeetFireGame.Properties.Resources.target;
            this.pbTarget.Location = new System.Drawing.Point(852, 34);
            this.pbTarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(249, 268);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTarget.TabIndex = 1;
            this.pbTarget.TabStop = false;
            // 
            // pb_Gun
            // 
            this.pb_Gun.Image = global::harrpeetFireGame.Properties.Resources._1st;
            this.pb_Gun.Location = new System.Drawing.Point(6, 34);
            this.pb_Gun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Gun.Name = "pb_Gun";
            this.pb_Gun.Size = new System.Drawing.Size(280, 268);
            this.pb_Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Gun.TabIndex = 0;
            this.pb_Gun.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Maroon;
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(39, 575);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "Try Again";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.pb_Gun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Gun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Gun;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

