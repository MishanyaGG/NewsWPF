using NewsWPF.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NewsWPF.Pages;

namespace NewsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Users> users = new List<Users>()
        {
            new Users("admin","admin"),
            new Users("editor","news2025")
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_BtnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Login_BtnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(login.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                NewsWindow window  = new NewsWindow();
                Close();
                window.Show();
            }

            else
            {
                MessageBox.Show("Ошибка авторизации. Проверьте логин и пароль");
                login.Text = ""; password.Text = "";
            }
        }
    }
}