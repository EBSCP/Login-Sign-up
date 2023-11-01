namespace WinFormsApp4
{
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textPassword = new TextBox();
            label2 = new Label();
            Login = new Button();
            textMail = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            textLastName = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textName = new TextBox();
            label4 = new Label();
            lblTimer = new Label();
            progressBar1 = new ProgressBar();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 416);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textPassword);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Login);
            tabPage1.Controls.Add(textMail);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(103, 103);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(174, 27);
            textPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Mail:";
            // 
            // Login
            // 
            Login.Location = new Point(93, 168);
            Login.Name = "Login";
            Login.Size = new Size(161, 57);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button1_Click;
            // 
            // textMail
            // 
            textMail.Location = new Point(103, 50);
            textMail.Name = "textMail";
            textMail.Size = new Size(174, 27);
            textMail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 110);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textLastName);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textName);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textLastName
            // 
            textLastName.Location = new Point(91, 86);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(184, 27);
            textLastName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 93);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "LastName :";
            // 
            // button2
            // 
            button2.Location = new Point(79, 151);
            button2.Name = "button2";
            button2.Size = new Size(184, 57);
            button2.TabIndex = 7;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textName
            // 
            textName.Location = new Point(91, 32);
            textName.Name = "textName";
            textName.Size = new Size(184, 27);
            textName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 32);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Name:";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(473, 497);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(45, 20);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "Time:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 430);
            progressBar1.Maximum = 60;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(942, 60);
            progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 522);
            Controls.Add(lblTimer);
            Controls.Add(progressBar1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textPassword;
        private Label label2;
        private Button Login;
        private TextBox textMail;
        private Label label1;
        private TabPage tabPage2;
        private ProgressBar progressBar1;
        private Label lblTimer;
        private TextBox textLastName;
        private Label label3;
        private Button button2;
        private TextBox textName;
        private Label label4;
    }
}