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
using System.Windows.Shapes;

namespace dubidubi.Views.Windows
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private bool IsAuthorization = true;
        public StartWindow()
        {
            InitializeComponent();
        }
        public void Regestarion_Btn_Click(object sender, RoutedEventArgs e)
        {
            
            if (IsAuthorization)
            {
                LoginText.Content = "Введите Login";
                PasswordText.Content = "Введите Password";
                BtnEnter.Content = "Регистрация";
                BtnReg.Content = "Назад";
            }
            else
            {
                LoginText.Content = "Login";
                PasswordText.Content = "Password";
                BtnEnter.Content = "Войти";
                BtnReg.Content = "Регистрация";
            }
            IsAuthorization = !IsAuthorization;
        }
        public void Enter_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (IsAuthorization)
            {
                MainWindow mainWin = new MainWindow();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = mainWin;
                mainWin.Show();
            }
            else
            {
                
                
            }
            
        }
    }
}
