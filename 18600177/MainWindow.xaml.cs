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

namespace _18600177
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_click(object sender, RoutedEventArgs e)
        {
            var _username = username.Text;
            var _password = password.Password;

            if (_username.Length == 0 && _password.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu khônng được để trống!");
            }
            if (_username != "admin")
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!");
                return;
            }
            if (_password != "qwe3@1")
            {
                MessageBox.Show("Mật khẩu chưa đúng!");
                return;
            }
            if (_username == "admin" && _password == "qwe3@1")
            {
                Dashboards screen = new Dashboards();
                this.Close();
                screen.Show();
            }
        }
    }
}
