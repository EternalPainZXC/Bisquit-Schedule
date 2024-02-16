using Microsoft.Win32;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Drawing;
using System;
using System.Diagnostics.Metrics;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;








namespace Бисквит_Расписание
{



    public partial class Form1 : Form
    {








        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        Size default_main = new Size(400, 620);


        public Form1()
        {
            int _sleep_notify = 0;
            int _study_notify = 0;
            Size default_main_width = new Size(500, 0);
            Size default_main_height = new Size(0, 620);
            Size default_main = new Size(500, 620);
            Size default_main_min = new Size(500, 75);
            Size default_change_main = new Size(0, 550);

            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;





      


            // Сон
            async void InfiniteLoop()
            {
                DateTime alarmtime = DateTime.Now;
                string StrAlarmTime = (alarmtime.ToLongTimeString());
                int IntAlarmTime = (alarmtime.Hour);
                while (button6_Click_X == 0 && _sleep_notify == 0)
                {
                    //await Task.Delay(100);
                    //this.Text = DateTime.Now.ToString();

                    await Task.Delay(100);
                    if (IntAlarmTime >= 22)
                    {





                        Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
                        Location = new Point(resolution.Width / 2 - resolution.Width / 4, resolution.Height / 2 - resolution.Height / 4);
                        panel2.Visible = true;
                        richTextBox1.Text = richTextBox1.Text + "";
                        _sleep_notify = 1;
                        this.ClientSize = default_main;

                    }

                }

            }


            // Уроки
            async void InfiniteLoop2()
            {
                DateTime alarmtime2 = DateTime.Now;

                int IntAlarmTime2 = (alarmtime2.Hour);
                while (button7_Click_X == 0 && _study_notify == 0)
                {
                    //await Task.Delay(100);
                    //this.Text = DateTime.Now.ToString();

                    //
                    await Task.Delay(110);
                    if (IntAlarmTime2 >= 20 && IntAlarmTime2 < 22)
                    {



                        Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
                        Location = new Point(resolution.Width / 2 - resolution.Width / 4, resolution.Height / 2 - resolution.Height / 4);
                        panel3.Visible = true;
                        richTextBox1.Text = richTextBox1.Text + "";
                        _study_notify = 1;

                        this.ClientSize = default_main;

                    }

                }

            }




            async void InfiniteLoop3()
            {
                int dog_mind_time = 0;
                while (true)

                {
                    //await Task.Delay(100);
                    //this.Text = DateTime.Now.ToString();
                    //if (default_main == ClientSize)
                    //
                    await Task.Delay(1000);

                    dog_mind_time = dog_mind_time + 1;

                    switch (dog_mind_time)
                    {

                        case 10:
                            dog_hide_label1.Text = "Так-так-так....";
                            break;
                        case 30:
                            dog_hide_label1.Text = "Хм....";
                            break;
                        case 60:
                            dog_hide_label1.Text = "Мало кто знает, но человеческий мозг - биологический суперкомпьютер. ";
                            break;
                        case 90:
                            dog_hide_label1.Text = "Те кто могут опоздать, вы помните что с вами будет?";
                            break;
                        case 120:
                            dog_hide_label1.Text = "Я расскажу деканату обо всем, что ты делаешь на парах…";
                            break;
                        case 150:
                            dog_hide_label1.Text = "«Моя сестра прочитала это сообщение и сказала что я разочарование года» - © Николай Бесчетнов";
                            break;
                        case 180:
                            dog_hide_label1.Text = "Бррр шкибиди доп доп есес";
                            break;
                        case 190:
                            dog_hide_label1.Text = "«На самом деле, жизнь проста, но мы настойчиво ее усложняем» © Конфуций.";
                            break;
                        case 220:
                            dog_hide_label1.Text = "Две блондинки сидят на кухне. Одна спрашивает:\r\n- А куда девается свет, когда его выключают?\r\nВторая: (выключает свет, открывает холодильник)\r\n- Вот он!!!";
                            break;

                        case > 250:
                            dog_hide_label1.Text = "Z-z-z...";
                            break;

                    }



                    dog_hide_text_panel1.Visible = true;
                    dog_hide_label1.Visible = true;
                    dog_hide_label1.Text = dog_hide_label1.Text;
                    if(ClientSize.Height == 75)
                    {
                        ClientSize = new Size(default_main.Width + dog_hide_label1.Width, 75);
                    }
                    else
                    {
                        ClientSize = new Size(default_main.Width + dog_hide_label1.Width, default_main.Height);
                    }
                    



                }

            }



















            TopMost = false;
            InitializeComponent();

            // Сон
            InfiniteLoop();
            // Уроки
            InfiniteLoop2();
            // Собака думает
            InfiniteLoop3();












            /*
            DateTime alarmtime = DateTime.Now;
            string StrAlarmTime = (alarmtime.ToLongTimeString());
            int IntAlarmTime = (alarmtime.Hour);
             while (true)
            {
                if (IntAlarmTime >= 22)
                {
                    panel2.Visible = true;
                    richTextBox1.Text = "";
                }
            }

            DateTime curtime = DateTime.Now;
            Text = Text + " " + (curtime.ToLongTimeString());

            */



































            // Обход прозрачности
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;







        }



        // Обход прозрачности
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }












        int day1;
        int NumWeekOfYear;

        public void TxtBx(int day1, int NumWeekOfYear)
        {

            //DateTime datetest = DateTime.Now;

            //int day1;

            //int i = 0;
            DateTime ClockInfoFromSystem = DateTime.Now;
            //string day2;
            /// it is not working
            //day2 = ClockInfoFromSystem.DayOfWeek.ToString(); /// it gives me string
            day1 = (int)ClockInfoFromSystem.DayOfWeek; /// it gives me int


            Calendar Calendar = CultureInfo.InvariantCulture.Calendar;
            int weekNumber = Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            NumWeekOfYear = weekNumber;

            NumWeekOfYear = NumWeekOfYear % 2;
            //richTextBox1.Text = day1 + "";
            //richTextBox1.Text = day1 + "NumWeekOfYear";

            // Меняю код для тестов дня недели и поведения текста

            //day1 = 7;

            if (day1 == 1)
            {
                if (NumWeekOfYear == 1)
                {
                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                }
                else
                {
                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                }


                //richTextBox1.Text = /*day1+*/ "9:00-9:45\r\n9:55-10:40\r\n";

                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 2)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

                }

                // инструкции, которые выполняются, если условие-2 истинно.
            }
            else if (day1 == 3)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

                }

                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 4)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика с элементами математической логики"; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В. "; richTextBox1.Text = richTextBox1.Text + "3103";

                }


                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 5)
            {

                if (NumWeekOfYear == 1)
                {


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика и математическая логика "; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В "; richTextBox1.Text = richTextBox1.Text + "3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + "3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

                    //richTextBox1.Text = "9:00-10:40\r\n";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

                }

            }
            else if (day1 == 6)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной... \nБлижайший учебный день понедельник, расписание на понедельник:\n\n";
                richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 7)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной... \nБлижайший учебный день понедельник, расписание на понедельник:\n\n";
                richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                // инструкции, которые выполняются, если условие-3 истинно.
            }



        }


        public void TxtBxUs(int day1, int NumWeekOfYear)
        {

            //DateTime datetest = DateTime.Now;

            //int day1;

            //int i = 0;
            //DateTime ClockInfoFromSystem = DateTime.Now;
            //string day2;
            /// it is not working
            //day2 = ClockInfoFromSystem.DayOfWeek.ToString(); /// it gives me string
            //day1 = (int)ClockInfoFromSystem.DayOfWeek; /// it gives me int


            //Calendar Calendar = CultureInfo.InvariantCulture.Calendar;
            //int weekNumber = Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            //NumWeekOfYear = weekNumber;

            //NumWeekOfYear = NumWeekOfYear % 2;
            //richTextBox1.Text = day1 + "";
            //richTextBox1.Text = day1 + "NumWeekOfYear";

            // Меняю код для тестов дня недели и поведения текста

            //day1 = 7;

            if (day1 == 1)
            {
                if (NumWeekOfYear == 1)
                {
                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                }
                else
                {
                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                }


                //richTextBox1.Text = /*day1+*/ "9:00-9:45\r\n9:55-10:40\r\n";

                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 2)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

                }

                // инструкции, которые выполняются, если условие-2 истинно.
            }
            else if (day1 == 3)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

                }

                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 4)
            {
                if (NumWeekOfYear == 1)
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика с элементами математической логики"; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В. "; richTextBox1.Text = richTextBox1.Text + "3103";

                }


                // инструкции, которые выполняются, если условие-1 истинно.
            }
            else if (day1 == 5)
            {

                if (NumWeekOfYear == 1)
                {


                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика и математическая логика "; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В "; richTextBox1.Text = richTextBox1.Text + "3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + "3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

                    //richTextBox1.Text = "9:00-10:40\r\n";

                }
                else
                {

                    richTextBox1.Text = "";
                    richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3302 ";
                    richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3509 ";
                    richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
                    richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

                }

            }
            else if (day1 == 6)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной... \nБлижайший учебный день понедельник, расписание на понедельник:\n\n";
                richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                // инструкции, которые выполняются, если условие-3 истинно.
            }
            else if (day1 == 7)
            {
                richTextBox1.Text = /*day1+*/ "Сегодня выходной... \nБлижайший учебный день понедельник, расписание на понедельник:\n\n";
                richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
                richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

                // инструкции, которые выполняются, если условие-3 истинно.
            }



        }






















        int button6_Click_X = 0;
        int button7_Click_X = 0;


        private void button6_Click(object sender, EventArgs e)
        {

            button6_Click_X = 1;
            panel2.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            button7_Click_X = 1;
            panel3.Visible = false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }


        }















        //собака
        private void panel4_Click(object sender, EventArgs e)
        {

            //this.Close();
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(resolution.Width / 2 - resolution.Width / 4, resolution.Height / 2 - resolution.Height / 4);
            ClientSize = new Size(default_main.Width + dog_hide_label1.Width, default_main.Height);

            if (всегдаСверToolStripMenuItem.CheckState == CheckState.Checked)
            {
                TopMost = true;
                всегдаСверToolStripMenuItem.CheckState = CheckState.Checked;

            }
            else
            {

                TopMost = false;
            }







        }







        const string name = "Biscuit Schedule";
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                {
                    reg.SetValue(name, ExePath);

                }
                else
                {
                    reg.DeleteValue(name);

                }
                reg.Close();
            }
            catch
            {

                return false;

            }

            return true;
        }




        private void Form1_Load(object sender, EventArgs e)
        {




            // Проверка Автозагрузки

            string AutorunValue = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "Biscuit Schedule", defaultValue: null);

            string ExePath1 = System.Windows.Forms.Application.ExecutablePath;

            if (AutorunValue == ExePath1)
            {
                // Do stuff
                toolStripMenuItem3.CheckState = CheckState.Checked;

                Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

                Location = new Point(0, -115 + resolution.Height);
                ClientSize = new Size(400, 75);



                TopMost = true;







            }
            else
            {
                toolStripMenuItem3.CheckState = CheckState.Unchecked;

            }

            // Проверка меню ВсегдаCверху 


            if (TopMost == true)
            {

                всегдаСверToolStripMenuItem.CheckState = CheckState.Checked;

            }
            else
            {
                всегдаСверToolStripMenuItem.CheckState = CheckState.Unchecked;

            }



        }




        // Проверка Меню Автозагрузки
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {




            if (toolStripMenuItem3.CheckState == CheckState.Unchecked)
            {
                
                SetAutorunValue(true);
                toolStripMenuItem3.CheckState = CheckState.Checked;

            }
            else
            {


                SetAutorunValue(false);
                toolStripMenuItem3.CheckState = CheckState.Unchecked;

            }


        }



        // Выбор меню Минимизировать  
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(0, -115 + resolution.Height);
            this.ClientSize = new Size(500, 75);
            TopMost = true;

            dog_hide_text_panel1.Visible = true;
            dog_hide_label1.Visible = true;
            dog_hide_label1.Text = "Я тут!";

            /*
            
            НЕТ МОЗГОВ.

            DateTime timeNow1 = DateTime.Now;
            int wait_start = (timeNow1.Second);
            int wait_over = (timeNow1.Second) + 5;
            if (wait_start > wait_over)
            {
                dog_hide_text_panel1.Visible = false;
            }
            */







        }


        // Выбор меню ВсегдаСверху
        private void всегдаСверToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (всегдаСверToolStripMenuItem.CheckState == CheckState.Unchecked)
            {

                TopMost = true;
                всегдаСверToolStripMenuItem.CheckState = CheckState.Checked;

            }
            else
            {


                TopMost = false;
                всегдаСверToolStripMenuItem.CheckState = CheckState.Unchecked;

            }



        }







        // Змейка

        private void змейкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 settingsForm2 = new Form2();
            settingsForm2.Show();

        }

        private void dog_hide_label1_Click(object sender, EventArgs e)
        {
            dog_hide_label1.Visible = false;
        }





        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "В разработке.";
            // richTextBox1.Text = "taskkill / f / im \"Бисквит Расписание.exe\"";


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {



        }


        private void dog_hide_label1_TextChanged(object sender, EventArgs e)
        {
            
            Point dog_hide_label1_Def = new Point(80, 15);

            dog_hide_label1.Location = dog_hide_label1_Def;

            dog_hide_text_panel1.Visible = true;
            dog_hide_label1.Visible = true;
            dog_hide_label1.Text = dog_hide_label1.Text;
            //ClientSize = ClientSize;


            dog_hide_label1.Location = new Point(dog_hide_label1.Location.X, dog_hide_label1.Location.Y - dog_hide_label1.Height / 2);



            if (ClientSize.Height == 75)
            {
                ClientSize = new Size(default_main.Width, default_main.Height);
                ClientSize = new Size(ClientSize.Width + dog_hide_label1.Width - dog_hide_label1.Left, 75);

            }
            else
            {

                ClientSize = new Size(default_main.Width, default_main.Height);
                ClientSize = new Size(ClientSize.Width + dog_hide_label1.Width - dog_hide_label1.Left, ClientSize.Height);
            }









        }






        // Виджет
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {





            this.Visible = false;



            Form3 NewForm3 = new Form3();

            NewForm3.Show();




            if (NewForm3.Created == true && this.Visible == true)
            {



                //System.Diagnostics.Process process = new System.Diagnostics.Process();
                //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //startInfo.FileName = "cmd.exe";
                //"/C copy /b Image1.jpg + Archive.rar Image2.jpg"
                //startInfo.Arguments = "taskkill /f /im Бисквит Расписание.exe";

                //startInfo.Arguments = "taskkill / f / im \"Бисквит Расписание.exe\"";

                //process.StartInfo = startInfo;

                //process.Start();

                //process.Close();

                //string strCmdText;
                //strCmdText = "taskkill / f / im \"Бисквит Расписание.exe\"";
                //System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                //this.Close();




            }

            //this.Activate();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            dog_hide_text_panel1.Visible = true;
            dog_hide_label1.Visible = true;
            dog_hide_label1.Text = "Да ладно кто-то дейтвительно это использует?";

            ClientSize = new Size(400, 620);

            ClientSize = new Size(ClientSize.Width + dog_hide_label1.Width, ClientSize.Height);

            TxtBx(day1, NumWeekOfYear);



        }

        private void календарьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
                monthCalendar1.ShowToday = true;
                //monthCalendar1.SelectionRange.Start = DateTime.Now;
            }
            else
            {
                monthCalendar1.Visible = false;
                monthCalendar1.ShowToday = true;
                // monthCalendar1.SelectionRange.Start = DateTime.Now;
                // monthCalendar1.SelectionRange.Start = DateTime.Now;

            }






        }



        private void неделя1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text = richTextBox1.Text + "Понедельник\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

            richTextBox1.Text = richTextBox1.Text + "\n\nВторник\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

            richTextBox1.Text = richTextBox1.Text + "\n\nСреда\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

            richTextBox1.Text = richTextBox1.Text + "\n\nЧетверг\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал";

            richTextBox1.Text = richTextBox1.Text + "\n\nПятница\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика и математическая логика "; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В "; richTextBox1.Text = richTextBox1.Text + "3302 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + "3509 ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

            richTextBox1.Text = richTextBox1.Text + "\n\nСуббота\n";

            richTextBox1.Text = richTextBox1.Text + "\n\nВоскресение\n";



        }

        private void неделя2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            richTextBox1.Text = richTextBox1.Text + "Понедельник\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3321 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Основы алгоритмизации и программирования"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А "; richTextBox1.Text = richTextBox1.Text + "3320";

            richTextBox1.Text = richTextBox1.Text + "\n\nВторник\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3320";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Физическая культура"; richTextBox1.Text = richTextBox1.Text + " Иванов С.С. "; richTextBox1.Text = richTextBox1.Text + "Спорт.зал ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "3311";

            richTextBox1.Text = richTextBox1.Text + "\n\nСреда\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Математическое моделирование"; richTextBox1.Text = richTextBox1.Text + " Малахова Т.А. "; richTextBox1.Text = richTextBox1.Text + "3318 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Безопасность жизнедеятельности"; richTextBox1.Text = richTextBox1.Text + " Маршева Ю.И. "; richTextBox1.Text = richTextBox1.Text + "7106 ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + " Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Основы  проектирования баз данных"; richTextBox1.Text = richTextBox1.Text + "  Цикина Т.И "; richTextBox1.Text = richTextBox1.Text + "1420";

            richTextBox1.Text = richTextBox1.Text + "\n\nЧетверг\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "3312";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения "; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1409,1420";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Технология разработки  программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Толокольников С.Н. "; richTextBox1.Text = richTextBox1.Text + "1417";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Дискретная математика с элементами математической логики"; richTextBox1.Text = richTextBox1.Text + " Дерябина А.В. "; richTextBox1.Text = richTextBox1.Text + "3103";

            richTextBox1.Text = richTextBox1.Text + "\n\nПятница\n\n";

            richTextBox1.Text = richTextBox1.Text + "9:00-10:40\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3302 ";
            richTextBox1.Text = richTextBox1.Text + "\n10:50-12:30\n"; richTextBox1.Text = richTextBox1.Text + "Иностранный язык в профессиональной деятельности"; richTextBox1.Text = richTextBox1.Text + " Фетисов Л.С. "; richTextBox1.Text = richTextBox1.Text + " 3509 ";
            richTextBox1.Text = richTextBox1.Text + "\n13:00-14:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + " Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "1402";
            richTextBox1.Text = richTextBox1.Text + "\n15:00-16:40\n"; richTextBox1.Text = richTextBox1.Text + "Инструментальные средства разработки программного обеспечения"; richTextBox1.Text = richTextBox1.Text + "  Демидов В.А. "; richTextBox1.Text = richTextBox1.Text + "3320 ";

            richTextBox1.Text = richTextBox1.Text + "\n\nСуббота\n";

            richTextBox1.Text = richTextBox1.Text + "\n\nВоскресение\n";


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.SelectionRange.Start = DateTime.Now;




            DateTime tegerTest6 = monthCalendar1.SelectionRange.Start;
            int day1 = (int)tegerTest6.DayOfWeek;

            Calendar CalendarTest7 = CultureInfo.InvariantCulture.Calendar;
            int NumWeekOfYear = CalendarTest7.GetWeekOfYear(monthCalendar1.SelectionRange.Start, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            NumWeekOfYear = NumWeekOfYear % 2;

            TxtBxUs(day1, NumWeekOfYear);

            monthCalendar1.SelectionRange.Start = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            //richTextBox1.Text = "В разработке.";
            richTextBox1.Text = "taskkill / f / im \"Бисквит Расписание.exe\" АААААААААА killme";
            System.Diagnostics.Process KillMe = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            //"/C copy /b Image1.jpg + Archive.rar Image2.jpg"
            //startInfo.Arguments = "- taskkill /f /im Бисквит Расписание.exe";

            startInfo.Arguments = "/C taskkill /f /im \"Бисквит Расписание.exe\"";

            KillMe.StartInfo = startInfo;

            KillMe.Start();

            //process.Close();


            // string strCmdText;
            // strCmdText = "/C taskkill / f / im \"Бисквит Расписание.exe\"";
            // System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            ///this.Close();



        }

        private void Form1_Shown(object sender, EventArgs e)
        {

           
            if (ClientSize.Height == 75)
            {
                this.ClientSize = default_main;
                this.ClientSize = new Size(default_main.Width + dog_hide_label1.Width - dog_hide_label1.Left, 75);

            }
            else
            {
                this.ClientSize = default_main;
                this.ClientSize = new Size(default_main.Width + dog_hide_label1.Width - dog_hide_label1.Left, default_main.Height);

            }




            //this.ClientSize.Width = new (this.ClientSize.Width + dog_hide_label1.Width);




        }


    }


}
