namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            startButton = new Button();
            panelMenu = new Panel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelContent = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 222, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(startButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 719);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 250);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 1;
            label1.Text = "Текст приветствия(потом)";
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(150, 211, 248);
            startButton.Font = new Font("Yu Gothic UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.Location = new Point(337, 502);
            startButton.Name = "startButton";
            startButton.Size = new Size(202, 84);
            startButton.TabIndex = 0;
            startButton.Text = "Поехали";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(165, 223, 199);
            panelMenu.Controls.Add(button12);
            panelMenu.Controls.Add(button11);
            panelMenu.Controls.Add(button10);
            panelMenu.Controls.Add(button9);
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(859, 719);
            panelMenu.TabIndex = 3;
            panelMenu.Visible = false;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(225, 350);
            button12.Name = "button12";
            button12.Size = new Size(100, 75);
            button12.TabIndex = 11;
            button12.Text = "Декабрь";
            button12.UseVisualStyleBackColor = true;
            button12.Click += MonthButton_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(75, 350);
            button11.Name = "button11";
            button11.Size = new Size(100, 75);
            button11.TabIndex = 10;
            button11.Text = "Ноябрь";
            button11.UseVisualStyleBackColor = true;
            button11.Click += MonthButton_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(675, 219);
            button10.Name = "button10";
            button10.Size = new Size(100, 75);
            button10.TabIndex = 9;
            button10.Text = "Октябрь";
            button10.UseVisualStyleBackColor = true;
            button10.Click += MonthButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(525, 219);
            button9.Name = "button9";
            button9.Size = new Size(100, 75);
            button9.TabIndex = 8;
            button9.Text = "Сентябрь";
            button9.UseVisualStyleBackColor = true;
            button9.Click += MonthButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(375, 219);
            button8.Name = "button8";
            button8.Size = new Size(100, 75);
            button8.TabIndex = 7;
            button8.Text = "Август";
            button8.UseVisualStyleBackColor = true;
            button8.Click += MonthButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(225, 219);
            button7.Name = "button7";
            button7.Size = new Size(100, 75);
            button7.TabIndex = 6;
            button7.Text = "Июль";
            button7.UseVisualStyleBackColor = true;
            button7.Click += MonthButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(75, 219);
            button6.Name = "button6";
            button6.Size = new Size(100, 75);
            button6.TabIndex = 5;
            button6.Text = "Июнь";
            button6.UseVisualStyleBackColor = true;
            button6.Click += MonthButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(675, 88);
            button5.Name = "button5";
            button5.Size = new Size(100, 75);
            button5.TabIndex = 4;
            button5.Text = "Май";
            button5.UseVisualStyleBackColor = true;
            button5.Click += MonthButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(525, 88);
            button4.Name = "button4";
            button4.Size = new Size(100, 75);
            button4.TabIndex = 3;
            button4.Text = "Апрель";
            button4.UseVisualStyleBackColor = true;
            button4.Click += MonthButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(375, 88);
            button3.Name = "button3";
            button3.Size = new Size(100, 75);
            button3.TabIndex = 2;
            button3.Text = "Март";
            button3.UseVisualStyleBackColor = true;
            button3.Click += MonthButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(225, 88);
            button2.Name = "button2";
            button2.Size = new Size(100, 75);
            button2.TabIndex = 1;
            button2.Text = "Февраль";
            button2.UseVisualStyleBackColor = true;
            button2.Click += MonthButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 88);
            button1.Name = "button1";
            button1.Size = new Size(100, 75);
            button1.TabIndex = 0;
            button1.Text = "Январь";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MonthButton_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(210, 188, 224);
            panelContent.Controls.Add(btnBack);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(859, 719);
            panelContent.TabIndex = 12;
            panelContent.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(753, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(503, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 719);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button startButton;
        private Label label1;
        private Panel panelMenu;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panelContent;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}
