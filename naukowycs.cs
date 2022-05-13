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
    public partial class naukowycs : Form
    {
        public naukowycs()
        {
            InitializeComponent();
        }
        string Number1;
        string Number2;
        string Liczba1;
        string Liczba2;
        string result;
        //public string Potega;
        //char a = ' ';
        char znak_dz = ' ';
        char prz_n = ' ';
        char minus = ' ';
        string funkcje_specjalne = "" ;
        string a = "";
        string b = "";
        string c = "";
        string d = "";

        private void b_dzielenie_n_Click(object sender, EventArgs e)
        {
            if(Liczba1 != "")
            {
                znak_dz = '/';
                textBox2.Text = "";
                funkcje_specjalne = "";
                minus = ' ';
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if (funkcje_specjalne != "" && Liczba1 == "")
            {
                funkcje_specjalne = "";
                Liczba1 = "";
                Liczba2 = "";
                Number1 = "";
                Number2 = "";
                znak_dz = ' ';
                minus = ' ';
                prz_n = ' ';
                textBox2.Text = "";
                result = "";
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox2.Text = "ERROR";
            }
        }

        private void b_mnozenie_n_Click(object sender, EventArgs e)
        {
            if (Liczba1 != "")
            {
                znak_dz = '*';
                textBox2.Text = "";
                funkcje_specjalne = "";
                minus = ' ';
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if (funkcje_specjalne != "" && Liczba1 == "")
            {
                funkcje_specjalne = "";
                Liczba1 = "";
                Liczba2 = "";
                Number1 = "";
                Number2 = "";
                znak_dz = ' ';
                minus = ' ';
                prz_n = ' ';
                textBox2.Text = "";
                result = "";
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox2.Text = "ERROR";
            }
        }

        private void b_odejmowanie_n_Click(object sender, EventArgs e)
        {
            if(Liczba1 != "")
            {
                znak_dz = '-';
                textBox2.Text = "";
                funkcje_specjalne = "";
                minus = ' ';
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if (funkcje_specjalne != "" && Liczba1 == "")
            {
                funkcje_specjalne = "";
                Liczba1 = "";
                Liczba2 = "";
                Number1 = "";
                Number2 = "";
                znak_dz = ' ';
                minus = ' ';
                prz_n = ' ';
                textBox2.Text = "";
                result = "";
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox2.Text = "ERROR";
            }
        }

        private void b_dodawanie_n_Click(object sender, EventArgs e)
        {
            if (Liczba1 != "")
            {
                znak_dz = '+';
                textBox2.Text = "";
                funkcje_specjalne = "";
                minus = ' ';
                checkBox1.Enabled = false;
                checkBox1.Checked = false;
            }
            if(funkcje_specjalne != "" && Liczba1 == "")
            {
                funkcje_specjalne = "";
                Liczba1 = "";
                Liczba2 = "";
                Number1 = "";
                Number2 = "";
                znak_dz = ' ';
                minus = ' ';
                prz_n = ' ';
                textBox2.Text = "";
                result = "";
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox2.Text = "ERROR";
            }
        }

        private void button_Cn_Click(object sender, EventArgs e)
        {
            Liczba1 = "";
            Liczba2 = "";
            Number1 = "";
            Number2 = "";
            znak_dz = ' ';
            minus = ' ';
            prz_n = ' ';
            textBox2.Text = "";
            result = "";
            funkcje_specjalne = "";
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            a = "";
            b = "";
            c = "";
            d = "";
        }

        private void b_BCSP_n_Click(object sender, EventArgs e)
        {
            if (Liczba2 != "")
            {
                Liczba2 = "";
                Number2 = "";
                textBox2.Text = "";
            }
            else if (Liczba2 == "" && znak_dz != ' ')
            {
                znak_dz = ' ';
            }
            else if (Liczba1 != "" && znak_dz == ' ' && Liczba2 == "")
            {
                Liczba1 = "";
                Number1 = "";
                textBox2.Text = "";
            }
            if(funkcje_specjalne != "")
            {
                funkcje_specjalne = "";
            }
        }
        private void b_7_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(7);
        }

        private void b_8_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(8);
        }

        private void b_9_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(9);
        }

        private void b_6_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(6);
        }

        private void b_5_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(5);
        }

        private void b_4_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(4);
        }

        private void b_1_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(1);
        }

        private void b_2_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(2);
        }

        private void b_3_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(3);
        }

        private void b_0_n_Click(object sender, EventArgs e)
        {
            Dzialanie_n(0);
        }

        private void przecinek_n_Click(object sender, EventArgs e)
        {
           if(Liczba1 != "")
           {
                prz_n = ',';
           }
           else if (Liczba1 != "" && a != "")
           {
                prz_n = ',';
           }
           else if (Liczba2 != "" && b != "")
           {
                prz_n = ',';
           }
        }

        private void wynik_n_Click(object sender, EventArgs e)
        {
            
            if (funkcje_specjalne != "" && Liczba2 == "" && znak_dz != ' ')
            {
                funkcje_specjalne = "";
                Liczba1 = "";
                Liczba2 = "";
                Number1 = "";
                Number2 = "";
                znak_dz = ' ';
                minus = ' ';
                prz_n = ' ';
                textBox2.Text = "";
                result = "";
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                textBox2.Text = "ERROR";
            }
            
            if (Liczba2 == "")
            {
                switch (funkcje_specjalne)
                {
                    case ("sqrt"):
                        {
                            if(minus == ' ')
                            {
                                Liczba1 = (Math.Sqrt(double.Parse(Liczba1))).ToString();
                                textBox2.Text = Liczba1;
                                break;
                            }
                            else if(minus == '-')
                            {
                                Liczba1 = (Math.Round((Math.Sqrt(Math.Abs(double.Parse(Liczba1)))),3)).ToString();
                                textBox2.Text = Liczba1 + "i  v  -" + Liczba1 + "i"; 
                                break;
                            }
                            break;
                        }
                    case ("sin"):
                        {
                            //string a;
                            if (minus == '-')
                            {
                                Liczba1 = '-' + Liczba1;
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Sin(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            else if(minus == ' ')
                            {  
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Sin(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            break;
                        }
                    case ("cos"):
                        {
                            if (minus == '-')
                            {
                                Liczba1 = '-' + Liczba1;
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Cos(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            else if (minus == ' ')
                            {
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Cos(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            break;
                        }
                    case ("tan"):
                        {
                            if (minus == '-')
                            {
                                Liczba1 = '-' + Liczba1;
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Tan(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            else if (minus == ' ')
                            {
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = Math.Tan(double.Parse(Liczba1)).ToString();
                                textBox2.Text = Liczba1;
                            }
                            break;
                        }
                    case ("cot"):
                        {
                            if (minus == '-')
                            {
                                Liczba1 = '-' + Liczba1;
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = (1/Math.Tan(double.Parse(Liczba1))).ToString();
                                textBox2.Text = Liczba1;
                            }
                            else if (minus == ' ')
                            {
                                Liczba1 = (Math.PI * double.Parse(Liczba1) / 180).ToString(); //radiany na stopnie
                                Liczba1 = (1/Math.Tan(double.Parse(Liczba1))).ToString();
                                textBox2.Text = Liczba1;
                            }
                            break;                         
                        }
                }
                Liczba1 = "";
                funkcje_specjalne = "";
                minus = ' ';
            }

           // funkcje_specjalne = "";

            if (Liczba1 != "" && znak_dz != ' ' && Liczba2 != "")
            {
                switch (znak_dz)
                {
                    case ('+'):
                        {
                            result = (double.Parse(Number1) + double.Parse(Number2)).ToString();
                            textBox2.Text = result;
                            Liczba1 = result;
                            Number1 = result;
                            funkcje_specjalne = "";
                            break;
                        }
                    case ('-'):
                        {
                            result = (double.Parse(Number1) - double.Parse(Number2)).ToString();
                            textBox2.Text = result;
                            Liczba1 = result;
                            Number1 = result;
                            funkcje_specjalne = "";
                            break;
                        }
                    case ('*'):
                        {
                            result = (double.Parse(Number1) * double.Parse(Number2)).ToString();
                            textBox2.Text = result;
                            Liczba1 = result;
                            Number1 = result;
                            funkcje_specjalne = "";
                            break;
                        }
                    case ('/'):
                        {
                            if (Number2 != "0")
                            {
                                result = (double.Parse(Number1) / double.Parse(Number2)).ToString();
                                textBox2.Text = result;
                                Liczba1 = result;
                                Number1 = result;
                                break;
                            }
                            else
                            {
                                textBox2.Text = "ERROR";
                                Liczba1 = "";
                                Liczba2 = "";
                                Number1 = "";
                                Number2 = "";
                                result = "";
                                znak_dz = ' ';
                                funkcje_specjalne = "";
                                break;
                            }
                        }
                }
                //Liczba1 = ""; //wyzerowanie zmiennych aby po kliknieiu '=' mozna bylo wykonac
                Liczba2 = "";
                Number2 = "";// nowe dzialanie 
                znak_dz = ' ';
                minus = ' ';
                funkcje_specjalne = "";
                a = "";
                b = "";
                c = "";
                d = "";
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
        public void Dzialanie_n(int liczba)
        {
            if (znak_dz == ' ')//WPROWADZAMY LICZBE 1 !
            {
                switch (funkcje_specjalne)
                {
                    case ("sqrt"):
                        {                           
                            if(prz_n == ' ')
                            {
                                Liczba1 = Liczba1 + liczba;
                                textBox2.Text = "sqrt(" + Liczba1 + ")";
                                Number1 = Math.Sqrt(double.Parse(Liczba1)).ToString();
                            }
                            else if(prz_n == ',')
                            {
                                Liczba1 = Liczba1 + ',' + liczba;
                                textBox2.Text = "sqrt(" + Liczba1 + ")";
                                Number1 = Math.Sqrt(double.Parse(Liczba1)).ToString();
                                prz_n = ' ';                                
                            }
                            break; 
                        }
                    case ("pow"):
                        {
                            if(checkBox1.Checked == false)
                            {
                                if(prz_n == ' ')
                                {
                                    if(minus == ' ')
                                    {
                                        Liczba1 = Liczba1 + liczba;
                                        textBox2.Text = Liczba1 + '^';
                                    }
                                    else if(minus == '-')
                                    {
                                        Liczba1 = Liczba1 + liczba;
                                        textBox2.Text = '-' + Liczba1 + '^';
                                        Liczba1 = '-' + Liczba1;
                                        minus = ' ';
                                    }
                                }
                                else if(prz_n == ',')
                                {
                                    if(minus == ' ')
                                    {
                                        Liczba1 = Liczba1 + ',' + liczba;
                                        textBox2.Text = Liczba1 + '^';
                                        prz_n = ' ';
                                    }
                                    else if(minus == '-')
                                    {
                                        Liczba1 = Liczba1 + ',' + liczba;
                                        textBox2.Text = '-' + Liczba1 + '^';
                                        Liczba1 = '-' + Liczba1;
                                        prz_n = ' ';
                                        minus = ' ';
                                    }
                                }                                
                            }
                    
                            if(Liczba1 != "" && checkBox1.Checked == true)
                            {
                                if(prz_n == ' ')
                                {
                                    if(minus == ' ')
                                    {
                                        a = a + liczba;
                                        textBox2.Text = Liczba1 + '^' + a;
                                        Number1 = (Math.Pow(double.Parse(Liczba1), double.Parse(a))).ToString();
                                    }
                                    else if (minus == '-')
                                    {
                                        a = a + liczba;
                                        textBox2.Text = Liczba1 + '^' + "(" + '-' + a + ")";
                                        //a = (double.Parse(a) * (-1)).ToString();
                                        c = (Math.Abs(double.Parse(a)) * (-1)).ToString();
                                        Number1 = (Math.Pow(double.Parse(Liczba1), double.Parse(c))).ToString();                                    
                                    }
                                }
                                else if(prz_n == ',')
                                {
                                    if (minus == ' ')
                                    {
                                        a = a + ',' + liczba;
                                        textBox2.Text = Liczba1 + '^' + a;
                                        Number1 = (Math.Pow(double.Parse(Liczba1), double.Parse(a))).ToString();
                                        prz_n = ' ';
                                    }
                                    else if (minus == '-')
                                    {
                                        a = a + ',' + liczba;
                                        textBox2.Text = Liczba1 + '^' + "(" + '-' + a + ")";
                                        //a = (double.Parse(a) * (-1)).ToString();
                                        c = (Math.Abs(double.Parse(a)) * (-1)).ToString();
                                        Number1 = (Math.Pow(double.Parse(Liczba1), double.Parse(c))).ToString();
                                        prz_n = ' ';
                                    }
                                }                              
                                break;
                            }
                            break;
                        }
                    case ("sin"):
                        {                          
                            if (prz_n == ' ')
                            {
                                if(minus =='-')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "sin(" + '-' + Liczba1 + ")";
                                    Number1 = '-'+(Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Sin(double.Parse(Number1)).ToString();
                                }
                                else if(minus == ' ')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "sin(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Sin(double.Parse(Number1)).ToString();
                                }           
                            }
                            else if (prz_n == ',')
                            {
                                if(minus == '-')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "sin(" + '-' + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = '-'+Math.Sin(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                }
                                else if(minus == ' ')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "sin(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Sin(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                } 
                            }
                            break;                           
                        }
                    case ("cos"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "cos(" + '-' + Liczba1 + ")";
                                    Number1 = '-' + (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Cos(double.Parse(Number1)).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "cos(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Cos(double.Parse(Number1)).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "cos(" + '-' + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = '-' + Math.Cos(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "cos(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Cos(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    case ("tan"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "tan(" + '-' + Liczba1 + ")";
                                    Number1 = '-' + (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Tan(double.Parse(Number1)).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "tan(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Tan(double.Parse(Number1)).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "tan(" + '-' + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = '-' + Math.Tan(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "tan(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = Math.Tan(double.Parse(Number1)).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    case ("cot"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "cot(" + '-' + Liczba1 + ")";
                                    Number1 = '-' + (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = (1/Math.Tan(double.Parse(Number1))).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + liczba;
                                    textBox2.Text = "cot(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = (1/Math.Tan(double.Parse(Number1))).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "cot(" + '-' + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = '-' + (1/Math.Tan(double.Parse(Number1))).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = "cot(" + Liczba1 + ")";
                                    Number1 = (Math.PI * double.Parse(Liczba1) / 180).ToString();
                                    Number1 = (1/Math.Tan(double.Parse(Number1))).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    default: //nie ma zadnej funkcji specjalnej
                        {                          
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba1 = Liczba1 + liczba; //przypisanie liczby z przycisku
                                    textBox2.Text = '-' + Liczba1;
                                    Number1 = '-' + Liczba1;
                                }
                                else if (minus == ' ')
                                {
                                    Liczba1 = Liczba1 + liczba; //przypisanie liczby z przycisku
                                    textBox2.Text = Liczba1;
                                    Number1 = Liczba1;
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if(minus == '-')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = '-' + Liczba1;
                                    Number1 = '-' + Liczba1;
                                    prz_n = ' ';
                                }
                                else if(minus == ' ')
                                {
                                    Liczba1 = Liczba1 + ',' + liczba;
                                    textBox2.Text = Liczba1;
                                    Number1 = Liczba1;
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                }
            }
//------------------------------------------------------------------------------------------------------------------
            else if (znak_dz != ' ') //WPROWADZAMY LICZBE 2
            {
                switch (funkcje_specjalne)
                {
                    case ("sqrt"):
                        {
                            if (prz_n == ' ')
                            {
                                Liczba2 = Liczba2 + liczba;
                                textBox2.Text = "sqrt(" + Liczba2 + ")";
                                Number2 = Math.Sqrt(double.Parse(Liczba2)).ToString();
                            }
                            else if (prz_n == ',')
                            {
                                Liczba2 = Liczba2 + ',' + liczba;
                                textBox2.Text = "sqrt(" + Liczba2 + ")";
                                Number2 = Math.Sqrt(double.Parse(Liczba2)).ToString();
                                prz_n = ' ';                               
                            }
                            break;
                        }
                    case ("pow"):
                        {
                            if (checkBox1.Checked == false)
                            {
                                if (prz_n == ' ')
                                {
                                    if (minus == ' ')
                                    {
                                        Liczba2 = Liczba2 + liczba;
                                        textBox2.Text = Liczba2 + '^';
                                    }
                                    else if (minus == '-')
                                    {
                                        Liczba2 = Liczba2 + liczba;
                                        textBox2.Text = '-' + Liczba2 + '^';
                                        Liczba2 = '-' + Liczba2;
                                        minus = ' ';
                                    }
                                }
                                else if (prz_n == ',')
                                {
                                    if (minus == ' ')
                                    {
                                        Liczba2 = Liczba2 + ',' + liczba;
                                        textBox2.Text = Liczba2 + '^';
                                        prz_n = ' ';
                                    }
                                    else if (minus == '-')
                                    {
                                        Liczba2 = Liczba2 + ',' + liczba;
                                        textBox2.Text = '-' + Liczba2 + '^';
                                        Liczba2 = '-' + Liczba2;
                                        prz_n = ' ';
                                        minus = ' ';
                                    }
                                }
                            }

                            if (Liczba2 != "" && checkBox1.Checked == true)
                            {
                                if (prz_n == ' ')
                                {
                                    if (minus == ' ')
                                    {
                                        b = b + liczba;
                                        textBox2.Text = Liczba2 + '^' + b;
                                        Number2 = (Math.Pow(double.Parse(Liczba2), double.Parse(b))).ToString();
                                    }
                                    else if (minus == '-')
                                    {
                                        b = b + liczba;
                                        textBox2.Text = Liczba2 + '^' + "(" + '-' + b + ")";
                                        d = (Math.Abs(double.Parse(b)) * (-1)).ToString();
                                        Number2 = (Math.Pow(double.Parse(Liczba2), double.Parse(d))).ToString();
                                    }
                                }
                                else if (prz_n == ',')
                                {
                                    if (minus == ' ')
                                    {
                                        b = b + ',' + liczba;
                                        textBox2.Text = Liczba2 + '^' + b;
                                        Number2 = (Math.Pow(double.Parse(Liczba2), double.Parse(b))).ToString();
                                        prz_n = ' ';
                                    }
                                    else if (minus == '-')
                                    {
                                        b = b + ',' + liczba;
                                        textBox2.Text = Liczba2 + '^' + "(" + '-' + b + ")";
                                        d = (Math.Abs(double.Parse(b)) * (-1)).ToString();
                                        Number2 = (Math.Pow(double.Parse(Liczba2), double.Parse(d))).ToString();
                                        prz_n = ' ';
                                    }
                                }
                                break;
                            }
                            break;
                        }
                    case ("sin"):
                        {
                            if (prz_n == ' ')
                            {
                                if(minus == '-')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "sin(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-'+Math.Sin(double.Parse(Number2)).ToString();
                                }
                                else if(minus == ' ')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "sin(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Sin(double.Parse(Number2)).ToString();
                                } 
                            }
                            else if (prz_n == ',')
                            {
                                if(minus == '-')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "sin(" + '-'+Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-'+Math.Sin(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }
                                else if(minus == ' ')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "sin(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Sin(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }                             
                            }
                            break;
                        }
                    case ("cos"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "cos(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-' + Math.Cos(double.Parse(Number2)).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "cos(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Cos(double.Parse(Number2)).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "cos(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-' + Math.Cos(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "cos(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Cos(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    case ("tan"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "tan(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-' + Math.Tan(double.Parse(Number2)).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "tan(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Tan(double.Parse(Number2)).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "tan(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-' + Math.Tan(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "tan(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = Math.Tan(double.Parse(Number2)).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    case ("cot"):
                        {
                            if (prz_n == ' ')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = "cot(" + '-' + Liczba2 + ")";
                                    Number2 = '-' + (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = (1/Math.Tan(double.Parse(Number2))).ToString();
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2+ liczba;
                                    textBox2.Text = "cot(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = (1/Math.Tan(double.Parse(Number2))).ToString();
                                }
                            }
                            else if (prz_n == ',')
                            {
                                if (minus == '-')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "cot(" + '-' + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = '-' + (1/Math.Tan(double.Parse(Number2))).ToString();
                                    prz_n = ' ';
                                }
                                else if (minus == ' ')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = "tan(" + Liczba2 + ")";
                                    Number2 = (Math.PI * double.Parse(Liczba2) / 180).ToString();
                                    Number2 = (1/Math.Tan(double.Parse(Number2))).ToString();
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                    default: //nie ma zadnej f. specjalnej dla drugiej liczby
                        {                           
                            if (prz_n == ' ')
                            {
                                if(minus == '-')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = '-' +Liczba2;
                                    Number2 = '-' + Liczba2;
                                }
                                else if(minus == ' ')
                                {
                                    Liczba2 = Liczba2 + liczba;
                                    textBox2.Text = Liczba2;
                                    Number2 = Liczba2;
                                } 
                            }
                            else if (prz_n == ',')
                            {
                                if(minus == '-')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = '-' + Liczba2;
                                    Number2 = '-' + Liczba2;
                                    prz_n = ' ';
                                }
                                else if(minus == ' ')
                                {
                                    Liczba2 = Liczba2 + ',' + liczba;
                                    textBox2.Text = Liczba2;
                                    Number2 = Liczba2;
                                    prz_n = ' ';
                                }
                            }
                            break;
                        }
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------
        private void b_prosty_Click(object sender, EventArgs e)
        {
            Liczba1 = "";
            Liczba2 = "";
            Number1 = "";
            Number2 = "";
            znak_dz = ' ';
            prz_n = ' ';
            minus = ' ';
            textBox2.Text = "";

            this.DialogResult = DialogResult.OK;
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "sqrt";
        }

        private void zmiana_znaku_Click(object sender, EventArgs e)
        {
            if(Liczba1 == "" )
            {
                minus = '-';
            }
            else if(Liczba1 != "" && znak_dz != ' ')
            {
                minus = '-';
            } 
            else if(Liczba1 != "" && checkBox1.Checked == true && a == "")
            {
                minus = '-';
            }
            else if (Liczba2 != "" && checkBox1.Checked == true && b == "")
            {
                minus = '-';
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "sin";
        }

        private void naukowycs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Liczba1 = "";
            Liczba2 = "";
            Number1 = "";
            Number2 = "";
            znak_dz = ' ';
            prz_n = ' ';
            minus = ' ';
            textBox2.Text = "";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "cos";
        }

        private void tan_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "tan";
        }

        private void cot_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "cot";
        }

        private void potega_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "pow";
            checkBox1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(prz_n == ',')
            {
                prz_n = ' ';
            }

            if(minus == '-')
            {
                minus = ' ';
            }
        }

        private void w_bezwgl_Click(object sender, EventArgs e)
        {
            funkcje_specjalne = "abs";
        }
    }
}
