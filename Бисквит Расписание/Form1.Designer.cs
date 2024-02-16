namespace Бисквит_Расписание
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button4 = new Button();
            button2 = new Button();
            dog_hide_text_panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            неделя1ToolStripMenuItem = new ToolStripMenuItem();
            неделя2ToolStripMenuItem = new ToolStripMenuItem();
            календарьToolStripMenuItem = new ToolStripMenuItem();
            дополнительноToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            всегдаСверToolStripMenuItem = new ToolStripMenuItem();
            змейкаToolStripMenuItem = new ToolStripMenuItem();
            DOCtoolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            button7 = new Button();
            richTextBox3 = new RichTextBox();
            panel2 = new Panel();
            button6 = new Button();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            richTextBox1 = new RichTextBox();
            dog_hide_label1 = new Label();
            Dog_OnTop = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            тихоToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dog_hide_text_panel1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(monthCalendar1);
            panel1.Controls.Add(richTextBox1);
            panel1.Font = new Font("Segoe UI", 18F);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 525);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // button4
            // 
            button4.BackColor = Color.LightPink;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(328, 0);
            button4.Name = "button4";
            button4.Size = new Size(72, 34);
            button4.TabIndex = 10;
            button4.Tag = "telegram";
            button4.Text = "X";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(348, 474);
            button2.Name = "button2";
            button2.Size = new Size(48, 48);
            button2.TabIndex = 2;
            button2.Tag = "telegram";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dog_hide_text_panel1
            // 
            dog_hide_text_panel1.BackColor = Color.WhiteSmoke;
            dog_hide_text_panel1.BackgroundImageLayout = ImageLayout.Stretch;
            dog_hide_text_panel1.BorderStyle = BorderStyle.FixedSingle;
            dog_hide_text_panel1.Location = new Point(385, 510);
            dog_hide_text_panel1.Name = "dog_hide_text_panel1";
            dog_hide_text_panel1.Size = new Size(10, 10);
            dog_hide_text_panel1.TabIndex = 9;
            dog_hide_text_panel1.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, календарьToolStripMenuItem, дополнительноToolStripMenuItem });
            menuStrip1.Location = new Point(9, 10);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(280, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { неделя1ToolStripMenuItem, неделя2ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(84, 20);
            toolStripMenuItem1.Text = "Расписание";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // неделя1ToolStripMenuItem
            // 
            неделя1ToolStripMenuItem.Name = "неделя1ToolStripMenuItem";
            неделя1ToolStripMenuItem.Size = new Size(136, 22);
            неделя1ToolStripMenuItem.Text = "Неделя №1";
            неделя1ToolStripMenuItem.Click += неделя1ToolStripMenuItem_Click;
            // 
            // неделя2ToolStripMenuItem
            // 
            неделя2ToolStripMenuItem.Name = "неделя2ToolStripMenuItem";
            неделя2ToolStripMenuItem.Size = new Size(136, 22);
            неделя2ToolStripMenuItem.Text = "Неделя №2";
            неделя2ToolStripMenuItem.Click += неделя2ToolStripMenuItem_Click;
            // 
            // календарьToolStripMenuItem
            // 
            календарьToolStripMenuItem.BackColor = SystemColors.Control;
            календарьToolStripMenuItem.Checked = true;
            календарьToolStripMenuItem.CheckState = CheckState.Checked;
            календарьToolStripMenuItem.Name = "календарьToolStripMenuItem";
            календарьToolStripMenuItem.Size = new Size(77, 20);
            календарьToolStripMenuItem.Text = "Календарь";
            календарьToolStripMenuItem.Click += календарьToolStripMenuItem_Click;
            // 
            // дополнительноToolStripMenuItem
            // 
            дополнительноToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, всегдаСверToolStripMenuItem, змейкаToolStripMenuItem, DOCtoolStripMenuItem });
            дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            дополнительноToolStripMenuItem.ShowShortcutKeys = false;
            дополнительноToolStripMenuItem.Size = new Size(107, 20);
            дополнительноToolStripMenuItem.Text = "Дополнительно";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShowShortcutKeys = false;
            toolStripMenuItem3.Size = new Size(164, 22);
            toolStripMenuItem3.Text = "Автозагрузка";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShowShortcutKeys = false;
            toolStripMenuItem4.Size = new Size(164, 22);
            toolStripMenuItem4.Text = "Минимизировать";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(164, 22);
            toolStripMenuItem5.Text = "Стикер";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // всегдаСверToolStripMenuItem
            // 
            всегдаСверToolStripMenuItem.Name = "всегдаСверToolStripMenuItem";
            всегдаСверToolStripMenuItem.Size = new Size(164, 22);
            всегдаСверToolStripMenuItem.Text = "Всегда сверху";
            всегдаСверToolStripMenuItem.Click += всегдаСверToolStripMenuItem_Click;
            // 
            // змейкаToolStripMenuItem
            // 
            змейкаToolStripMenuItem.Name = "змейкаToolStripMenuItem";
            змейкаToolStripMenuItem.Size = new Size(164, 22);
            змейкаToolStripMenuItem.Text = "Змейка";
            змейкаToolStripMenuItem.Click += змейкаToolStripMenuItem_Click;
            // 
            // DOCtoolStripMenuItem
            // 
            DOCtoolStripMenuItem.Name = "DOCtoolStripMenuItem";
            DOCtoolStripMenuItem.Size = new Size(164, 22);
            DOCtoolStripMenuItem.Text = "ZXC?";
            DOCtoolStripMenuItem.Click += DOCtoolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Controls.Add(richTextBox3);
            panel3.Location = new Point(20, 184);
            panel3.Name = "panel3";
            panel3.Size = new Size(331, 119);
            panel3.TabIndex = 2;
            panel3.Visible = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Pink;
            button7.Font = new Font("Segoe UI", 13F);
            button7.Location = new Point(283, -11);
            button7.Name = "button7";
            button7.Size = new Size(48, 35);
            button7.TabIndex = 1;
            button7.Text = "x";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox3.Location = new Point(3, 22);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(325, 94);
            richTextBox3.TabIndex = 0;
            richTextBox3.Text = "Время 20:00 Имеет смысл заняться домашним заданием.";
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(richTextBox2);
            panel2.Location = new Point(35, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 124);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Pink;
            button6.Font = new Font("Segoe UI", 10F);
            button6.Location = new Point(283, 0);
            button6.Name = "button6";
            button6.Size = new Size(45, 24);
            button6.TabIndex = 1;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox2.Location = new Point(3, 24);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(325, 95);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "Время 22:00 Имеет смысл лечь спать.";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(135, 474);
            button1.Name = "button1";
            button1.Size = new Size(122, 48);
            button1.TabIndex = 1;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            monthCalendar1.Location = new Point(93, 40);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 1;
            monthCalendar1.Visible = false;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(10, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 431);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Нажмите обновить...";
            // 
            // dog_hide_label1
            // 
            dog_hide_label1.AutoSize = true;
            dog_hide_label1.BackColor = SystemColors.ControlLightLight;
            dog_hide_label1.BorderStyle = BorderStyle.FixedSingle;
            dog_hide_label1.FlatStyle = FlatStyle.Popup;
            dog_hide_label1.Location = new Point(93, 9);
            dog_hide_label1.MaximumSize = new Size(999, 999);
            dog_hide_label1.Name = "dog_hide_label1";
            dog_hide_label1.Size = new Size(423, 27);
            dog_hide_label1.TabIndex = 0;
            dog_hide_label1.Text = "Да ладно кто-то дейтвительно это использует?";
            dog_hide_label1.Visible = false;
            dog_hide_label1.TextChanged += dog_hide_label1_TextChanged;
            dog_hide_label1.Click += dog_hide_label1_Click;
            // 
            // Dog_OnTop
            // 
            Dog_OnTop.BackColor = Color.Transparent;
            Dog_OnTop.BackgroundImage = (Image)resources.GetObject("Dog_OnTop.BackgroundImage");
            Dog_OnTop.BackgroundImageLayout = ImageLayout.Stretch;
            Dog_OnTop.Location = new Point(0, -5);
            Dog_OnTop.Name = "Dog_OnTop";
            Dog_OnTop.Size = new Size(110, 114);
            Dog_OnTop.TabIndex = 8;
            Dog_OnTop.Click += panel4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { тихоToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 26);
            // 
            // тихоToolStripMenuItem
            // 
            тихоToolStripMenuItem.Name = "тихоToolStripMenuItem";
            тихоToolStripMenuItem.Size = new Size(100, 22);
            тихоToolStripMenuItem.Text = "Тихо";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(406, 605);
            Controls.Add(dog_hide_label1);
            Controls.Add(panel1);
            Controls.Add(Dog_OnTop);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(1, 1);
            Name = "Form1";
            Text = "Расписание Бисквит";
            TransparencyKey = Color.Transparent;
            Load += Form1_Load;
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button6;
        private RichTextBox richTextBox2;
        private Panel panel3;
        private RichTextBox richTextBox3;
        private Button button7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem неделя1ToolStripMenuItem;
        private ToolStripMenuItem неделя2ToolStripMenuItem;
        private ToolStripMenuItem календарьToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Panel Dog_OnTop;
        private ToolStripMenuItem дополнительноToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        public ToolStripMenuItem toolStripMenuItem3;
        public Panel panel1;
        private ToolStripMenuItem всегдаСверToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem змейкаToolStripMenuItem;
        private Panel dog_hide_text_panel1;
        public Label dog_hide_label1;
        public MonthCalendar monthCalendar1;
        private Button button4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem тихоToolStripMenuItem;
        private ToolStripMenuItem DOCtoolStripMenuItem;
    }
}
