using System.Windows;
using System.Collections.Generic;

namespace WpfApp2
{
    public partial class CoordinatorWindow : Window
    {
        private List<string> materials = new List<string>();

        public CoordinatorWindow()
        {
            InitializeComponent();
        }

        private void AddMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            string materialName = MaterialNameTextBox.Text;
            string materialPriceText = MaterialPriceTextBox.Text;
            string qtyText = MaterialQuantityTextBox.Text;
            string purchaseDate = PurchaseDatePicker.SelectedDate?.ToShortDateString() ?? "Не указана";

            // Попробуем преобразовать строки в числа
            if (decimal.TryParse(materialPriceText, out decimal materialPrice) &&
                int.TryParse(qtyText, out int qty) && qty > 0)
            {
                decimal totalCost = materialPrice * qty;
                materials.Add($"{materialName} - {materialPrice}₽, Дата: {purchaseDate}, {qty} шт, Общая цена: {totalCost}₽");
                MaterialsListBox.Items.Add(materials[^1]);
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля правильно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void ClearInputFields()
        {
            MaterialNameTextBox.Clear();
            MaterialPriceTextBox.Clear();
            MaterialQuantityTextBox.Clear();
            PurchaseDatePicker.SelectedDate = null;
        }

        private void PurchaseMaterialsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Закупка материалов завершена!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отчет сформирован!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
         private void peopleButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
