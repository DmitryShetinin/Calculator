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

namespace Calculate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum action
        {
            plus,
            minus,
            divide,
            multiplication
        }
        action actions;

        double num1;
        double num2; 

        public MainWindow()
        {
            InitializeComponent();
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputText.Text += "5";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InputText.Text += "1"; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputText.Text += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InputText.Text += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InputText.Text += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InputText.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InputText.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            InputText.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            InputText.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            InputText.Text += "0";
        }

      

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Second_text.Text = String.Empty;
            actions = action.plus;
           if (InputText.Text == String.Empty) { MessageBox.Show("Сначала введите число"); return; }
           num1 = Convert.ToDouble(InputText.Text);
           Second_text.Text += num1.ToString() + " + "; 
           InputText.Text = String.Empty;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Second_text.Text = String.Empty;
            actions = action.minus;
            if(InputText.Text == String.Empty) { MessageBox.Show("Сначала введите число"); return; }
            num1 = Convert.ToDouble(InputText.Text);
            Second_text.Text += num1.ToString() + " - ";
            InputText.Text = String.Empty;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Second_text.Text = String.Empty;
            actions = action.divide;
            if (InputText.Text == String.Empty) { MessageBox.Show("Сначала введите число"); return; }
            num1 = Convert.ToDouble(InputText.Text);
            Second_text.Text += num1.ToString() + " / ";
            InputText.Text = String.Empty;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Second_text.Text = String.Empty;
            actions = action.multiplication;
            if (InputText.Text == String.Empty) { MessageBox.Show("Сначала введите число"); return; }
            num1 = Convert.ToDouble(InputText.Text);
            Second_text.Text += num1.ToString() + " * ";
            InputText.Text = String.Empty;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
                InputText.Text += ",";
        }

    

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            int i = (int)actions;
            num2 = Convert.ToDouble(InputText.Text);
            Second_text.Text += num2.ToString() + " =";
            switch (i)
            {
                case 0:
                    InputText.Text = (num1 + num2).ToString();
            
                    break;
                case 1:
                    InputText.Text = (num1 - num2).ToString();
                    break;
                case 2:
                    try
                    {
                        InputText.Text = (num1 / num2).ToString();
                    }
                    catch (Exception v1)
                    {
                        MessageBox.Show(v1.Message);
                    }
                    break;
                case 3:
                    InputText.Text = (num1 * num2).ToString();
                    break;
               
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            InputText.Text = String.Empty;
            Second_text.Text = String.Empty;
        }
    }
}
