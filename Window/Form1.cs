using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            

            var culture = CultureInfo.GetCultureInfo("cs-CZ");
            var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

            var dateTime = DateTime.Today;

            int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);
            label3.Text = "" + weekNumber;
            label14.Text = DateTime.Now.ToString("HH:mm");
            //label4.Text = DateTime.Now.ToString("ddd");
            //label.Text = DateTime.Now.ToString("d MMM yyy");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            var culture = CultureInfo.GetCultureInfo("cs-CZ");
            var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

            var dateTime = DateTime.Today;

            int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);
            label3.Text = ""+weekNumber;
            label14.Text = DateTime.Now.ToString("HH:mm");
            //label4.Text= DateTime.Now.ToString("ddd");
            //label1.Text = DateTime.Now.ToString("d MMM yyy");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            label5.Text = "France : la mère d'un jihadiste condamnée à deux ans de prison pour financement du terrorisme";
            label16.ForeColor = System.Drawing.Color.White;
            label15.ForeColor = System.Drawing.Color.Gray;
            label13.ForeColor = System.Drawing.Color.Gray;
            panel3.BackgroundImage = Image.FromFile
   (System.Environment.GetFolderPath
   (System.Environment.SpecialFolder.Personal)
   + @"\Resources\fr.jpg");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            label5.Text = "France : un budget pour motiver les riches";
            label16.ForeColor = System.Drawing.Color.Gray;
            label15.ForeColor = System.Drawing.Color.Gray;
            label13.ForeColor = System.Drawing.Color.White;
            panel3.BackgroundImage = Image.FromFile
   (System.Environment.GetFolderPath
   (System.Environment.SpecialFolder.Personal)
   + @"\Resources\new1.jpg");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label5.Text = "Réforme de l’Union européenne : le plus dur commence pour Emmanuel Macron";
            label16.ForeColor = System.Drawing.Color.Gray;
            label15.ForeColor = System.Drawing.Color.White;
            label13.ForeColor = System.Drawing.Color.Gray;
            panel3.BackgroundImage = Image.FromFile
   (System.Environment.GetFolderPath
   (System.Environment.SpecialFolder.Personal)
   + @"\Resources\new2.jpeg");
        }
    }
}
