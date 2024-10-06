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
            string materialPrice = MaterialPriceTextBox.Text;
            string purchaseDate = PurchaseDatePicker.SelectedDate?.ToShortDateString() ?? "Не указана";

            if (!string.IsNullOrWhiteSpace(materialName) && !string.IsNullOrWhiteSpace(materialPrice))
            {
                materials.Add($"{materialName} - {materialPrice}₽, Дата: {purchaseDate}");
                MaterialsListBox.Items.Add(materials[^1]);
                MaterialNameTextBox.Clear();
                MaterialPriceTextBox.Clear();
                PurchaseDatePicker.SelectedDate = null;
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void PurchaseMaterialsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Закупка материалов завершена!");
        }

        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отчет сформирован!");
        }
    }
}
