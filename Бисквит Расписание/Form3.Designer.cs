namespace Бисквит_Расписание
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(240, 0);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 4;
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 13F);
            richTextBox1.Location = new Point(12, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(263, 264);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(richTextBox2);
            panel1.Location = new Point(4, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 132);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            panel1.MouseHover += panel1_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(259, 0);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveBorder;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox2.Location = new Point(8, 22);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(263, 107);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Кажется на стикере что-то написано. \nЕсли там что-то важное - скопируйте и сохраните\nесли нет то просто сотрите.";
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Info;
            ClientSize = new Size(300, 300);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Opacity = 1.0D;
            Text = "Form3";
            TopMost = true;
            TransparencyKey = SystemColors.AppWorkspace;
            Load += Form3_Load;
            MouseMove += Form3_MouseMove;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Button button3;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private RichTextBox richTextBox2;
        private Button button1;
    }
}