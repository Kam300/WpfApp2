using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectRoleButton_Click(object sender, RoutedEventArgs e)
        {
           
                    EmployeeWindow employeeWindow = new EmployeeWindow();
                    employeeWindow.Show();
            this.Close();
         }
        private void RoleButton_Click(object sender, RoutedEventArgs e)
        { 

            CoordinatorWindow coordinatorWindow = new CoordinatorWindow();
                    coordinatorWindow.Show();
                
                this.Close();
            
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Background = new SolidColorBrush(Colors.DarkSeaGreen);
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Background = btn.Name == "СотрудникButton" ? new SolidColorBrush(Color.FromRgb(102, 205, 170)) : new SolidColorBrush(Color.FromRgb(32, 178, 170));
            }
        }

    }
}
