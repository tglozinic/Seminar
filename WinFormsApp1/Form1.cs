using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int seconds, stotinka;
        bool active;
        int unosMin;
       


        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //izvršava se kod pritiska na gumb "PAUSE"
        private void buttonStop_Click(object sender, EventArgs e)
        {
            active = false;
        }
        //izvršava se kod pritiska na gumb "RESUME"
        private void buttonResume_Click(object sender, EventArgs e)
        {
            active = true;
        }

        //izvršava se kod pritiska na gumb "RESET"
        // gašenje timera i pozivanje fukncije Reset()
        private void buttonReset_Click(object sender, EventArgs e)
        {
            active = false;
            Reset();
        }

        //izvršava se kod pritiska na gumb "START"
            // podešvanje početnih vrijednosti na štoperici
            // čitanje vrijednosti s labele i pretvaranje u oblik integer
            // pokretanje timera
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                unosMin = Int32.Parse(textBoxUnosMinuta.Text) - 1;
                seconds = 59;
                stotinka = 100;
                active = true;

            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite pravilno vrijeme");
                Reset();

            }




        }


        //funkcija timera
        //brojanje vremena unatrag od zadane vrijednosti
        //blinkanje labele zadnjih 30 sekundi i pozivanje novog timera 
        //reset funkcije kod isteka vremena
        //pozivanje DisplayTime() funkcije
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (active)
            {
                stotinka--;
                if (stotinka <= 0)
                {
                    seconds--;
                    stotinka = 100;
                    if (seconds <= 0)
                    {
                        unosMin--;
                        seconds = 59; 
                    }
                }

                if (unosMin < 0)
                {
                    Kraj();
                }
            }
            DisplayTime();
        }


        //Funkcija za prikaz vremena na labelama
        // pretvara integer vrijednosti u string i prikazuje u zadanom formatu
        private void DisplayTime()
        {
            labelStotinka.Text = stotinka.ToString("00");
            labelSeconds.Text = seconds.ToString("00");
            labelMinutes.Text = unosMin.ToString("00");
        }

        //Funkcija za podešavanje vremena na početne vrijednosti i gašenje timera
        private void Reset()
        {
            seconds = 0;
            unosMin = 0;
            stotinka = 0;
            active = false;

        }

        //Funkcija za prikaz dijaloga, zvuka za istek vremena i izlazak iz aplikacije
        private void Kraj()
        {
            Reset();
            MessageBox.Show("Vrijeme je isteklo");
            SystemSounds.Asterisk.Play();
            System.Environment.Exit(1);

        }

        //Timer za blinkanje labela prikaza vremena zadnjih 30 sekundi i promijene boje u crveno
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (active)
            {

                if ((unosMin == 0) && (seconds < 31))
                {
                    labelMinutes.ForeColor = System.Drawing.Color.Red;
                    labelSeconds.ForeColor = System.Drawing.Color.Red;
                    labelStotinka.ForeColor = System.Drawing.Color.Red;
                    label1.ForeColor = System.Drawing.Color.Red;
                    label2.ForeColor = System.Drawing.Color.Red;

                    labelMinutes.Visible = !labelMinutes.Visible;
                    labelSeconds.Visible = !labelSeconds.Visible;
                    labelStotinka.Visible = !labelStotinka.Visible;
                    label1.Visible = !label1.Visible;
                    label2.Visible = !label2.Visible;
            }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSeconds_Click(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
