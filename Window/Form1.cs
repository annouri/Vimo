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
using System.Net.Http;
using Newtonsoft.Json;

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
            label21.Text = "" + weekNumber;
            //label14.Text = DateTime.Now.ToString("HH:mm");
            //label4.Text = DateTime.Now.ToString("ddd");
            //label.Text = DateTime.Now.ToString("d MMM yyy");
            get_news("https://newsapi.org/v1/articles?source=the-next-web&sortBy=latest&apiKey=6782791a4f6a4774ba811636c8aacc2a");
            get_Weather("https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&APPID=0e839af4b2d3466fa03d6e5b2e36da60");
            get_forecast("https://api.openweathermap.org/data/2.5/forecast?q=Paris&units=metric&APPID=0e839af4b2d3466fa03d6e5b2e36da60");
            
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            var culture = CultureInfo.GetCultureInfo("cs-CZ");
            var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

            var dateTime = DateTime.Today;

            int weekNumber = culture.Calendar.GetWeekOfYear(dateTime, dateTimeInfo.CalendarWeekRule, dateTimeInfo.FirstDayOfWeek);
            label21.Text = ""+weekNumber;
            //label14.Text = DateTime.Now.ToString("HH:mm");
            //label4.Text= DateTime.Now.ToString("ddd");
            //label1.Text = DateTime.Now.ToString("d MMM yyy");
            
      
            
            
             }
        async void get_Weather(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage content = await client.GetAsync(uri))
                {
                    using (HttpContent data = content.Content)
                    {
                        string dt = await data.ReadAsStringAsync();
                        dynamic obj = JsonConvert.DeserializeObject(dt);
                        //Console.WriteLine(obj.weather["main"]);
                        //label17.Text = obj.weather[0].main;
                            label2.Text = obj.weather[0].main;
                        string temp = obj.main.temp;
                        label9.Text = temp.Substring(0, 2);
                        string icon = @"\Resources\weather\" + obj.weather[0].icon + ".png";
                        //panel4.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                           // (System.Environment.SpecialFolder.Personal)+icon);

                    }

                }
            }
        }
        async void get_forecast(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage content = await client.GetAsync(uri))
                {
                    using (HttpContent data = content.Content)
                    {
                        string dt = await data.ReadAsStringAsync();
                        dynamic obj = JsonConvert.DeserializeObject(dt);
                        //Console.WriteLine(obj.weather["main"]);
                        //label17.Text = obj.weather[0].main;
                        
                            string icon = @"\Resources\weather\" + obj.list[0].weather[0].icon+".png";
                        panel5.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                        (System.Environment.SpecialFolder.Personal) + icon);

                        icon = @"\Resources\weather\" + obj.list[1].weather[0].icon + ".png";
                        panel6.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                        (System.Environment.SpecialFolder.Personal) + icon);

                        icon = @"\Resources\weather\" + obj.list[2].weather[0].icon + ".png";
                        panel7.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                        (System.Environment.SpecialFolder.Personal) + icon);

                        icon = @"\Resources\weather\" + obj.list[3].weather[0].icon + ".png";
                        panel8.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                        (System.Environment.SpecialFolder.Personal) + icon);

                        icon = @"\Resources\weather\" + obj.list[4].weather[0].icon + ".png";
                        panel9.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
                        (System.Environment.SpecialFolder.Personal) + icon);

                        string temp = obj.list[0].main.temp;
                        label6.Text = obj.list[0].main.temp;

                        temp = obj.list[1].main.temp;
                        label7.Text = obj.list[1].main.temp;

                        temp = obj.list[2].main.temp;
                        label8.Text = obj.list[2].main.temp;

                        temp = obj.list[3].main.temp;
                        label10.Text = obj.list[3].main.temp;

                        temp = obj.list[4].main.temp;
                        label11.Text = obj.list[4].main.temp;

                        var culture = CultureInfo.GetCultureInfo("cs-CZ");
                        var dateTimeInfo = DateTimeFormatInfo.GetInstance(culture);

                        var today = DateTime.Today;

                        label15.Text = today.AddDays(1).ToString("dddd");
                        label16.Text = today.AddDays(2).ToString("dddd");
                        label17.Text = today.AddDays(3).ToString("dddd");
                        label18.Text = today.AddDays(4).ToString("dddd");
                        label19.Text = today.AddDays(5).ToString("dddd");

                    }

                }
            }
        }
        async void get_news(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage content = await client.GetAsync(uri))
                {
                    using (HttpContent data = content.Content)
                    {
                        string dt = await data.ReadAsStringAsync();
                        dynamic obj = JsonConvert.DeserializeObject(dt);
                        //Console.WriteLine(obj.weather["main"]);
                        //label17.Text = obj.weather[0].main;
                        int i = 0;
                        while (i!=1) {
                            for(int j = 0; j < 10; j++)
                            {
                                await Task.Delay(5000);
                                label20.Text = obj.articles[0].title;
                            }
                                
                        }
                        
                    }

                }
            }
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
          //  label5.Text = "France : la mère d'un jihadiste condamnée à deux ans de prison pour financement du terrorisme";
           // label16.ForeColor = System.Drawing.Color.White;
           // label15.ForeColor = System.Drawing.Color.Gray;
            //label13.ForeColor = System.Drawing.Color.Gray;
            //panel3.BackgroundImage = Image.FromFile
  // (System.Environment.GetFolderPath
   //(System.Environment.SpecialFolder.Personal)
   //+ @"\Resources\fr.jpg");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            //label5.Text = "France : un budget pour motiver les riches";
            //label16.ForeColor = System.Drawing.Color.Gray;
            //label15.ForeColor = System.Drawing.Color.Gray;
           // label13.ForeColor = System.Drawing.Color.White;
            //panel3.BackgroundImage = Image.FromFile
   //(System.Environment.GetFolderPath
   //(System.Environment.SpecialFolder.Personal)
   //+ @"\Resources\new1.jpg");

            
        }


        private void label15_Click(object sender, EventArgs e)
        {
           // label5.Text = "Réforme de l’Union européenne : le plus dur commence pour Emmanuel Macron";
            //label16.ForeColor = System.Drawing.Color.Gray;
            //label15.ForeColor = System.Drawing.Color.White;
           // label13.ForeColor = System.Drawing.Color.Gray;
            //panel3.BackgroundImage = Image.FromFile
   //(System.Environment.GetFolderPath
   //(System.Environment.SpecialFolder.Personal)
   //+ @"\Resources\new2.jpeg");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
