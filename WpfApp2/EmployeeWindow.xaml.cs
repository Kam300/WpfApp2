using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp2
{
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            LoadFootwearItems(); // Загружаем список обуви при инициализации окна
        }

        private void LoadFootwearItems()
        {
            // Пример данных. В реальной программе это может быть загрузка из базы данных или API
            var footwearItems = new List<FootwearItem>
            {
                new FootwearItem { Name = "Мужские кроссовки Clarks, \nцвет синий \n16 990 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\2.jpg", Season = "Осень", Type = "Сандали" },
                new FootwearItem { Name = "Мужские кроссовки Clarks, \nцвет синий \n3 990 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\1.jpg", Season = "Зима", Type = "Ботинки" },
                new FootwearItem { Name = "Унисекс кроссовки SCHOLL, \nцвет синий \n2 990 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\3.jpg", Season = "Осень", Type = "Обувь" },
                new FootwearItem { Name = "Женские кроссовки SCHOLL, \nцвет синий \n6 990 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\4.jpg", Season = "Весна", Type = "Обувь" },
                new FootwearItem { Name = "Мужские кеды Clarks, \nцвет коричневый \n8 990 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\5.jpeg", Season = "Весна", Type = "Обувь" },
                new FootwearItem { Name = "Тапочки \nБелык  \n9 000 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\6.jpg", Season = "Лето", Type = "Обувь" },
                new FootwearItem { Name = "Женские сланцы Clarks, \nцвет коричневый \n5 999 руб", ImagePath = "C:\\Users\\RobotComp.ru\\source\\repos\\WpfApp2\\WpfApp2\\image\\7.jpg", Season = "Лето", Type = "Обувь" },
            };

            FootwearItemsControl.ItemsSource = footwearItems;
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            string season = (SeasonComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string assortment = AssortmentComboBox.SelectedItem?.ToString();
            MessageBox.Show($"Заказ на {assortment} для сезона {season} сделан!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SendFeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Обратная связь отправлена!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
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
            MessageBox.Show("Статус заявки обновлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void peopleButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }

    public class FootwearItem
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Season { get; set; }
        public string Type { get; set; }
    }
}
