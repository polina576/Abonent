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
using System.Collections.ObjectModel;

namespace Abon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Abonent> Abonents { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // Создаём коллекцию абонентов
            Abonents = new ObservableCollection<Abonent>
            {
                new Abonent(1, "Политыко", "Полина", "Максимовна", "ул. Ленина, 1", "1234567890123456", 1000, 30, 60),
                new Abonent(2, "Гостева", "Виктория", "Николаевна", "ул. Мира, 2", "9876543210987654", 1500, 45, 25),
                new Abonent(3, "Дубровина", "Валерия", "Станиславовна", "ул. Гагарина, 3", "1122334455667788", 500, 15, 75),
                new Abonent(4, "Васильева", "Анастасия", "Сергеевна", "пр. Победы, 4", "8877665544332211", 2000, 60, 90),
                new Abonent(5, "Колотова", "Елизавета", "Дмитриевна", "ул. Пушкина, 5", "4455667788990011", 1200, 75, 55),
                new Abonent(6, "Соколова", "Елена", "Ивановна", "ул. Маяковского, 6", "3344556677889900", 1800, 20, 100),
                new Abonent(7, "Морозов", "Алексей", "Петрович", "ул. Набережная, 7", "2233445566778899", 900, 35, 40),
                new Abonent(8, "Козлова", "Ольга", "Викторовна", "ул. Горького, 8", "9988776655443322", 1400, 50, 80)
            };
        }

        private void FilterAbonents_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(FilterTimeTextBox.Text, out double filterTime))
            {
                // Фильтруем абонентов, у которых время городских переговоров больше заданного
                var filteredAbonents = Abonents.Where(a => a.CityTime > filterTime).ToList();
                subscriberDataGrid.ItemsSource = filteredAbonents;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное время.");
                subscriberDataGrid.ItemsSource = new List<Abonent>(); // Если не корректно - очищаем список
            }
        }
    }
}
