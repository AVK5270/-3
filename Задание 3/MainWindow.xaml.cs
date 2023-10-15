using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Задание_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        // регулярное выражение для адреса электронной почты
        string pattern1 = "^(([a-zA-Z0-9_-]+\\.)*[a-zA-Z0-9_-]+@[a-zA-Z0-9-]+(\\.[a-zA-Z0-9-]+)*\\.[a-zA-Z]{2,6})?$";
        // регулярное выражение для номера телефона
        string pattern2 = "^([7]{1}[9]{1}[0-9]{9})?$";
        // регулярное выражение для имени
        string pattern3 = "^([A-ZА-Я]{1}[a-zа-я]+)?$";

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool i = true;
            Person person = new Person();
            while (i)
            {
                string str = inputBox.Text;

                string[] substring = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (substring.Length == 3)
                {
                    foreach (string sub in substring)
                    {

                        Match match1 = Regex.Match(sub, pattern1);
                        if (match1.Success)
                        {
                            person.setMail(match1.Value);
                        }

                        Match match2 = Regex.Match(sub, pattern2);
                        if (match2.Success)
                        {
                            person.setPhone(match2.Value);
                        }

                        Match match3 = Regex.Match(sub, pattern3);
                        if (match3.Success)
                        {
                            person.setName(match3.Value);
                        }

                    }
                }
                if (person.getName() != null && person.getPhone() != null && person.getMail() != null)
                {
                    i = false;
                    outBox1.Text = person.getName();
                    outBox2.Text = person.getPhone();
                    outBox3.Text = person.getMail();
                    outBox_4.Text = person.getId();
                    break;
                }
                else
                {
                    inputBox.Text = "Вы неправильно ввели данные, повторите ввод. ";
                    break;
                }



            }
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            inputBox.Clear();   
        }
    }
}
