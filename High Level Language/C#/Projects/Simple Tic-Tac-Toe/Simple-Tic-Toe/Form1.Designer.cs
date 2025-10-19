namespace Super_Tic_Toe
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            CPU_Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Black", 12F);
            textBox1.ForeColor = Color.Green;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Player 1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Black", 12F);
            textBox2.ForeColor = Color.FromArgb(192, 0, 0);
            textBox2.Location = new Point(372, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 0;
            textBox2.Text = "CPU Wins";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 74);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 1;
            button1.Text = ".";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Player_Click_Button;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(75, 180);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Player_Click_Button;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(75, 286);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 1;
            button3.Text = ".";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Player_Click_Button;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(181, 74);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 1;
            button4.Text = ".";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Player_Click_Button;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(181, 180);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 1;
            button5.Text = ".";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Player_Click_Button;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(181, 286);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 1;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Player_Click_Button;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(287, 74);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 1;
            button7.Text = ".";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Player_Click_Button;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(287, 180);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 1;
            button8.Text = ".";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Player_Click_Button;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(287, 286);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 1;
            button9.Text = ".";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Player_Click_Button;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(0, 192, 192);
            button10.Location = new Point(83, 413);
            button10.Name = "button10";
            button10.Size = new Size(92, 36);
            button10.TabIndex = 2;
            button10.Text = "Restarts";
            button10.UseVisualStyleBackColor = false;
            button10.Click += Restart_Game;
            // 
            // CPU_Timer
            // 
            CPU_Timer.Interval = 1000;
            CPU_Timer.Tick += CPU_move;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Simple Tic Tac Toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer CPU_Timer;
    }
}
