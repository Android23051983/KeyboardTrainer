using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        Random random;
        private int namber_Slaider = 1;
        private int Lehgt_Text = 105;
        private int Lengt_Apper_Text = 90;
        private int fails = 0;
        private bool f = false;
        public MainWindow()
        {
            InitializeComponent();
            MyText.Focus();
            Slider_Slognosti.Value = namber_Slaider;
            slider_number.Text = Slider_Slognosti.Value.ToString();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            Shift.Visibility = Visibility.Hidden;
            foreach(var i in NoShift.Children)
            {
                if(i is StackPanel)
                {
                    foreach (var j in (i as StackPanel).Children)
                    {
                        if (j is Grid)
                        {
                            foreach(var item in (j as Grid).Children)
                            {
                                if(item is Button)
                                {
                                    if((item as Button).Name == e.Key.ToString())
                                    {
                                        (item as Button).Opacity = 0.5;
                                        if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                                        {
                                            //Shift.Visibility = Visibility.Visible;
                                            //NoShift.Visibility = Visibility.Collapsed;
                                            ToApper_Text();
                                            ToApper_Nambers();
                                        }
                                        if (e.Key == Key.Back)
                                        {
                                            f = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void OnKeyUpHandler(object sender, KeyEventArgs e)
        {
            foreach (var i in NoShift.Children)
            {
                if (i is StackPanel)
                {
                    foreach (var j in (i as StackPanel).Children)
                    {
                        if (j is Grid)
                        {
                            foreach (var item in (j as Grid).Children)
                            {
                                if (item is Button)
                                {
                                    if ((item as Button).Name == e.Key.ToString())
                                    {
                                        (item as Button).Opacity = 1;
                                        if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                                        {
                                            //Shift.Visibility = Visibility.Collapsed;
                                            //NoShift.Visibility = Visibility.Visible;
                                            ToLover_Text();
                                            ToLover_Nambers();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ToApper_Text()
        {
            this.Q.Content = "Q";
            this.W.Content = "W";
            this.E.Content = "E";
            this.R.Content = "R";
            this.T.Content = "T";
            this.Y.Content = "Y";
            this.U.Content = "U";
            this.I.Content = "I";
            this.O.Content = "O";
            this.P.Content = "P";
            this.A.Content = "A";
            this.S.Content = "S";
            this.D.Content = "D";
            this.F.Content = "F";
            this.G.Content = "G";
            this.H.Content = "H";
            this.J.Content = "J";
            this.K.Content = "K";
            this.L.Content = "L";
            this.Z.Content = "Z";
            this.X.Content = "X";
            this.C.Content = "C";
            this.V.Content = "V";
            this.B.Content = "B";
            this.N.Content = "N";
            this.M.Content = "M";

        }

        private void ToLover_Text()
        {
            this.Q.Content = "q";
            this.W.Content = "w";
            this.E.Content = "e";
            this.R.Content = "r";
            this.T.Content = "t";
            this.Y.Content = "y";
            this.U.Content = "u";
            this.I.Content = "i";
            this.O.Content = "o";
            this.P.Content = "p";
            this.A.Content = "a";
            this.S.Content = "s";
            this.D.Content = "d";
            this.F.Content = "f";
            this.G.Content = "g";
            this.H.Content = "h";
            this.J.Content = "j";
            this.K.Content = "k";
            this.L.Content = "l";
            this.Z.Content = "z";
            this.X.Content = "x";
            this.C.Content = "c";
            this.V.Content = "v";
            this.B.Content = "b";
            this.N.Content = "n";
            this.M.Content = "m";

        }

        private void ToApper_Nambers()
        {
            this.Oem3.Content = "~";
            this.D1.Content = "!";
            this.D2.Content = "@";
            this.D3.Content = "#";
            this.D4.Content = "$";
            this.D5.Content = "%";
            this.D6.Content = "^";
            this.D7.Content = "&";
            this.D8.Content = "*";
            this.D9.Content = "(";
            this.D0.Content = ")";
            this.OemMinus.Content = "_";
            this.OemPlus.Content = "+";
            this.OemOpenBrackets.Content = "{";
            this.Oem6.Content = "}";
            this.Oem5.Content = "|";
            this.Oem1.Content = ":";
            this.OemQuotes.Content = "\"";
            this.OemComma.Content = "<";
            this.OemPeriod.Content = ">";
            this.OemQuestion.Content = "?";
        }
        private void ToLover_Nambers()
        {
            this.Oem3.Content = "`";
            this.D1.Content = "1";
            this.D2.Content = "2";
            this.D3.Content = "3";
            this.D4.Content = "4";
            this.D5.Content = "5";
            this.D6.Content = "6";
            this.D7.Content = "7";
            this.D8.Content = "8";
            this.D9.Content = "9";
            this.D0.Content = "0";
            this.OemMinus.Content = "-";
            this.OemPlus.Content = "=";
            this.OemOpenBrackets.Content = "[";
            this.Oem6.Content = "]";
            this.Oem5.Content = "\\";
            this.Oem1.Content = ";";
            this.OemQuotes.Content = "'";
            this.OemComma.Content = ",";
            this.OemPeriod.Content = ".";
            this.OemQuestion.Content = "/";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            slider_number.Text = ((int)e.NewValue).ToString();
        }

        private void Zapolnenie_Text()
        {
            random = new Random();
            List<char> Simvol_Lover = new List<char> { '`','1','2','q','a','z','9','i','k',',',' ','3','w','s','x',
            '0','o','l','.',' ','4','e','d','c','-','=','p','[',']','\\',';','\'','/',' ','5','6','r','t','f','g','v','b',
            ' ','7','8','y','u','h','j','n','m',' '};
            List<char> Simvol_Upper = new List<char> { '~','!','@','Q','A','Z','(','I','K','<',' ','#','W','S','X',
            ')','O','L','>',' ','$','E','D','C','_','+','P','{','}','|',':','\"','?',' ','%','^','R','T','F','G','V','B',
            ' ','&','*','Y','U','H','J','N','M',' '};
            List<char> Stroca_Rand = new List<char> { };
            if (namber_Slaider == 1)
            {
                for (int i = 0; i < 11; i++)
                {
                    Stroca_Rand.Add(Simvol_Lover[i]);
                }
                if (this.Chec_Boks_Shift.IsChecked == true)
                {
                    for (int i = 0; i < 11; i++)
                    {
                        Stroca_Rand.Add(Simvol_Upper[i]);
                    }
                }
            }
            else if (namber_Slaider == 2)
            {
                for (int i = 0; i < 20; i++)
                {
                    Stroca_Rand.Add(Simvol_Lover[i]);
                }
                if (this.Chec_Boks_Shift.IsChecked == true)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Stroca_Rand.Add(Simvol_Upper[i]);
                    }
                }
            }
            else if (namber_Slaider == 3)
            {
                for (int i = 0; i < 34; i++)
                {
                    Stroca_Rand.Add(Simvol_Lover[i]);
                }
                if (this.Chec_Boks_Shift.IsChecked == true)
                {
                    for (int i = 0; i < 34; i++)
                    {
                        Stroca_Rand.Add(Simvol_Upper[i]);
                    }
                }
            }
            else if (namber_Slaider == 4)
            {
                for (int i = 0; i < 43; i++)
                {
                    Stroca_Rand.Add(Simvol_Lover[i]);
                }
                if (this.Chec_Boks_Shift.IsChecked == true)
                {
                    for (int i = 0; i < 43; i++)
                    {
                        Stroca_Rand.Add(Simvol_Upper[i]);
                    }
                }
            }
            else if (namber_Slaider == 5)
            {
                for (int i = 0; i < 52; i++)
                {
                    Stroca_Rand.Add(Simvol_Lover[i]);
                }
                if (this.Chec_Boks_Shift.IsChecked == true)
                {
                    for (int i = 0; i < 52; i++)
                    {
                        Stroca_Rand.Add(Simvol_Upper[i]);
                    }
                }
            }
            String str = "";
            if (this.Chec_Boks_Shift.IsChecked == true)
            {
                for (int i = 0; i < Lengt_Apper_Text; i++)
                {
                    str += Stroca_Rand[random.Next(Stroca_Rand.Count)];
                }
            }
            else
            {
                for (int i = 0; i < Lehgt_Text; i++)
                {
                    str += Stroca_Rand[random.Next(Stroca_Rand.Count)];
                }
            }
            this.GenerateText.Text = str;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zapolnenie_Text();
            MyText.Focus();
        }

        private void MyText_TextChanged(object sender, TextChangedEventArgs e)
        {
            int start = 0;
            int Text_Length = this.MyText.Text.Length;
            String str = this.GenerateText.Text.Substring(start, Text_Length);
            if (MyText.Text.Equals(str))
            {
                //MyTextColor.Text = MyText.Text;

                GenerateText.Background = Brushes.LightGreen; 
            }
            else
            {
                if (f == false)
                {
                    GenerateText.Background = Brushes.LightGray;
                    fails++;
                }
                Fails.Text = fails.ToString();
                //MessageBox.Show("Ахтунг");
            }
        }
    }
}