using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pierwszy_program_okienkowy
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        string FirstNumber;
        string SecondNumber;
        string LiczbaPierwsza;
        string LiczbaDruga;
        string rezultat;
        char znak_dzialania = ' ';
        char przecinek = ' ';
        char min = ' ';
        private void b_backspace_Click(object sender, EventArgs e)
        {
            if(LiczbaDruga != "")
            {
                LiczbaDruga = "";
                tb_Wynik.Text = "";
            }
            else if(LiczbaDruga == "" && znak_dzialania != ' ')
            {
                znak_dzialania = ' ';
            }
            else if(LiczbaPierwsza != "" && znak_dzialania == ' ' && LiczbaDruga == "")
            {
                LiczbaPierwsza = "";
                tb_Wynik.Text = "";
            }
        }

        private void Dzielenie_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza != "")
            {
                znak_dzialania = '/';
                tb_Wynik.Text = "";
                min = ' ';
            }
        }

        private void Mnozenie_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza != "")
            {
                znak_dzialania = '*';
                tb_Wynik.Text = "";
                min = ' ';
            }
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza != "")
            {
                znak_dzialania = '-';
                tb_Wynik.Text = "";
                min = ' ';
            }
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza != "")
            {
                znak_dzialania = '+';
                tb_Wynik.Text = "";
                min = ' ';
            }
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void b_wynik_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza != "" && znak_dzialania != ' ' && LiczbaDruga != "")
            {
                switch (znak_dzialania)
                {
                    case ('+'):
                        {
                            rezultat = (double.Parse(FirstNumber) + double.Parse(SecondNumber)).ToString();
                            tb_Wynik.Text = rezultat;
                            LiczbaPierwsza = rezultat;
                            FirstNumber = rezultat;
                            break;
                        }
                    case ('-'):
                        {
                            rezultat = (double.Parse(FirstNumber) - double.Parse(SecondNumber)).ToString();
                            tb_Wynik.Text = rezultat;
                            LiczbaPierwsza = rezultat;
                            FirstNumber = rezultat;
                            break;
                        }
                    case ('*'):
                        {
                            rezultat = (double.Parse(FirstNumber) * double.Parse(FirstNumber)).ToString();
                            tb_Wynik.Text = rezultat;
                            LiczbaPierwsza = rezultat;
                            FirstNumber = rezultat;
                            break;
                        }
                    case ('/'):
                        {
                            if(SecondNumber != "0")
                            {
                                rezultat = (double.Parse(FirstNumber) / double.Parse(SecondNumber)).ToString();
                                tb_Wynik.Text = rezultat;
                                LiczbaPierwsza = rezultat;
                                FirstNumber = rezultat;
                                break;
                            }
                            else
                            {
                                tb_Wynik.Text = "ERROR";
                                LiczbaPierwsza = "";
                                LiczbaDruga = "";
                                FirstNumber = "";
                                SecondNumber = "";
                                znak_dzialania = ' ';
                                rezultat = "";
                                przecinek = ' ';
                                min = ' ';
                                break;
                            }
                            
                        }
                }
                //LiczbaPierwsza = ""; //wyzerowanie zmiennych aby po kliknieiu '=' mozna bylo wykonac
                LiczbaDruga = "";   // nowe dzialanie 
                SecondNumber = "";
                znak_dzialania = ' ';
                min = ' ';
            }
        }

        public void Dzialanie(int liczba) //funkcja obslugujaca textbox (wyswietla) PRZEBUDOWAC !!!
        {   //funkcja obsluguje tez przyciski numeryczne, co ma sie wyswietlac
            if (znak_dzialania == ' ') // wprowadzamy liczbe 1
            {
                if (przecinek == ' ')
                {
                    if (min == '-')
                    {
                        LiczbaPierwsza = LiczbaPierwsza + liczba; //przypisanie liczby z przycisku
                        tb_Wynik.Text = '-' + LiczbaPierwsza;
                        FirstNumber = '-' + LiczbaPierwsza;
                    }
                    else if (min == ' ')
                    {
                        LiczbaPierwsza = LiczbaPierwsza + liczba; //przypisanie liczby z przycisku
                        tb_Wynik.Text = LiczbaPierwsza;
                        FirstNumber = LiczbaPierwsza;
                    }
                }
                else if (przecinek == ',')
                {
                    if (min == '-')
                    {
                        LiczbaPierwsza = LiczbaPierwsza + ',' + liczba;
                        tb_Wynik.Text = '-' + LiczbaPierwsza;
                        FirstNumber = '-' + LiczbaPierwsza;
                        przecinek = ' ';
                    }
                    else if (min == ' ')
                    {
                        LiczbaPierwsza = LiczbaPierwsza + ',' + liczba;
                        tb_Wynik.Text = LiczbaPierwsza;
                        FirstNumber = LiczbaPierwsza;
                        przecinek = ' ';
                    }
                }
            }
            else if(znak_dzialania != ' ') // liczba 2
            {
                if (przecinek == ' ')
                {
                    if (min == '-')
                    {
                        LiczbaDruga = LiczbaDruga + liczba; //przypisanie liczby z przycisku
                        tb_Wynik.Text = '-' + LiczbaDruga;
                        SecondNumber = '-' + LiczbaDruga;
                    }
                    else if (min == ' ')
                    {
                        LiczbaDruga = LiczbaDruga + liczba; //przypisanie liczby z przycisku
                        tb_Wynik.Text = LiczbaDruga;
                        SecondNumber = LiczbaDruga;
                    }
                }
                else if (przecinek == ',')
                {
                    if (min == '-')
                    {
                        LiczbaDruga = LiczbaDruga + ',' + liczba;
                        tb_Wynik.Text = '-' + LiczbaDruga;
                        SecondNumber = '-' + LiczbaDruga;
                        przecinek = ' ';
                    }
                    else if (min == ' ')
                    {
                        LiczbaDruga = LiczbaDruga + ',' + liczba;
                        tb_Wynik.Text = LiczbaDruga;
                        SecondNumber = LiczbaDruga;
                        przecinek = ' ';
                    }
                }
            }
            
        }

        private void b_C_MouseClick(object sender, MouseEventArgs e) //przycisk 'C'
        {
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            znak_dzialania = ' ';
            tb_Wynik.Text = "";
            rezultat = "";
        }

        private void b_przecinek_Click(object sender, EventArgs e) //przecinek
        {
            if(LiczbaPierwsza != "")
            {
                przecinek = ',';
            }
        }

        private void b_procent_Click(object sender, EventArgs e)
        {
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            znak_dzialania = ' ';
            przecinek = ' ';
            tb_Wynik.Text = "";

            //this.Hide(); //zamyka tę formę
            naukowycs naukowy = new naukowycs(); 
            //naukowy.Show();
            this.Hide();
            naukowy.ShowDialog();
            // We get here when newform's DialogResult gets set
            this.Show();
        }

        private void sign_change_Click(object sender, EventArgs e)
        {
            if(LiczbaPierwsza == "")
            {
                min = '-';
            }
            else if(LiczbaPierwsza != "" && znak_dzialania != ' ')
            {
                min = '-';
            }
        }
    }
}
