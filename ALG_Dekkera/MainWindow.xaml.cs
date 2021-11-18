using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ALG_Dekkera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public int F1 = 0;
        public int F2 = 0;
        public bool FreeZR = true, FreeF1=true, FreeF2 = true;
        public int Process = 1;   //процесс 1 главнее 2го
        public int ZR = 0; // возможность войти в критическую область  

        public MainWindow()
        {
            InitializeComponent();
        }
       

        private void Button_Click_2(object sender, RoutedEventArgs e) //установка 1 
        {
            F1 = 1;
            TB1.Text = "F1 установлено значение: " + F1.ToString();

        }
        private void Button_Click(object sender, RoutedEventArgs e)// проверка 1
        {
            if (F2 == 0)
            {
                TB1.Text ="F2 не намерен войти в критический участок";
            }
            else
                TB1.Text = "F2 намерен войти в критический участок";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) // проверка zr
        {
            if (FreeZR == true)
            {
                TB1.Text = "ZR cвободен для установка F1. Значение = "+ ZR.ToString();
            }
            else
                TB1.Text = "ZR занят F2. Значение = " + ZR.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //установка zr
        {
            if (FreeZR == true)
            {
                ZR = 1;
                FreeZR = false;
                FreeF1 = false;
                TB1.Text = "ZR = " + ZR.ToString();
            }
            else TB1.Text = "Error 01. ZR занят F2! Значение = " + ZR.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // вход в кр уч 1
        {
            if (FreeF1 ==false)
            {
                TB1.Text = "F1 вошёл в критический участок";
            }
            else TB1.Text = "F1 не может войти в критический участок т.к. он занят F2";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)// выход  из кр уч 1
        {
            if (FreeF1 == false)
            {
                TB1.Text = "F1 вышел из критического участка";
               // FreeF1 = true;
            }
            else TB1.Text = "F1 не входил в ранее в критический участок";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)// сброс zr
        {

            if (FreeF1 == false)
            {
                ZR = 0;
                FreeZR = true;
                FreeF1 = true;
                TB1.Text = "ZR сброшен и равен " + ZR.ToString();
            }
            else
                if (FreeZR == true)
                {
                TB1.Text = "ZR ранее не занимали. Значение: " + ZR.ToString();
                }
                else 
                TB1.Text = "ZR занял F2, его не может отменить F1";

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)// сброс f1
        {
            F1 = 0;

            TB1.Text = "F1 установлено значение: " + F1.ToString();
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// ////////////////////////

        private void Button_Click_8(object sender, RoutedEventArgs e) //1
        {
            F2 = 1;
            TB2.Text = "F2 установлено значение: " + F2.ToString();
        }     
        
        private void Button_Click_10(object sender, RoutedEventArgs e) //2 
        {
            if (F1 == 0)
            {
                TB2.Text = "F1 не намерен войти в критический участок";
            }
            else
                TB2.Text = "F1 намерен войти в критический участок";
        }
      private void Button_Click_11(object sender, RoutedEventArgs e) //3
        {
            if (FreeZR == true)
            {
                TB2.Text = "ZR cвободен для установка F2. Значение = " + ZR.ToString();
            }
            else
                TB2.Text = "ZR занят F1. Значение = " + ZR.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //4 
        {
            if (FreeZR == true)
            {
                ZR = 1;
                FreeZR = false;
                FreeF2 = false;
                TB2.Text = "ZR = " + ZR.ToString();
            }
            else TB2.Text = "Error 01. ZR занят F1! Значение = " + ZR.ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) //5
        {
            if (FreeF2 == false)
            {
                TB2.Text = "F2 вошёл в критический участок";
            }
            else TB2.Text = "F2 не может войти в критический участок т.к. он занят F1";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) //6
        {
            if (FreeF2 == false)
            {
                TB2.Text = "F2 вышел из критического участка";
            }
            else TB2.Text = "F2 не входил в ранее в критический участок";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e) //7
        {
            if (FreeF2 == false)
            {
                ZR = 0;
                FreeZR = true;
                FreeF2 = true;
                TB2.Text = "ZR сброшен и равен " + ZR.ToString();
            }
            else
            if (FreeZR == true)
                {
                    TB2.Text = "ZR ранее не занимали. Значение: " + ZR.ToString();
                }
                else
                TB2.Text = "ZR занял F1, его не может отменить F2";

        }

        private void Button_Click_15(object sender, RoutedEventArgs e) //8
        {
            F2 = 0;
            TB2.Text = "F2 установлено значение: " + F2.ToString();
        }
    }
}
