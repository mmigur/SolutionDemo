using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using user13.Model;

namespace user13.View
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private user13Entities1 _context = user13Entities1.GetContext();
        public ProductPage()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void LoadProduct() 
        {
            ProductListBox.ItemsSource = _context.products.ToList();
        }

        private void ProductListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItems = ProductListBox.SelectedItems.Cast<products>().FirstOrDefault();
            if (selectedItems != null)
            {
                NavigationService.Navigate(new AddProductPage(selectedItems));
                LoadProduct();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddProductPage());
        }
    }
}
