using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp2
{
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            var season = SeasonComboBox.SelectedItem?.ToString();
            var assortment = AssortmentComboBox.SelectedItem?.ToString();
            MessageBox.Show($"Заказ на {assortment} для сезона {season} сделан!");
        }

        private void SendFeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обратная связь отправлена!");
        }

        private void UploadImageButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FeedbackImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void UpdateOrderStatusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Статус заявки обновлен!");
        }
        private void peopleButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow employeeWindow = new MainWindow();
            employeeWindow.Show();
            this.Close();
        }
    }
}
