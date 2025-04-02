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
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        private user13Entities1 _context = user13Entities1.GetContext();
        private products _productsObject = new products();
        public AddProductPage(products productsObject = null)
        {
            InitializeComponent();

            if (productsObject != null)
            {
                this._productsObject = productsObject;
                TypeProductComboBox.SelectedValue = _productsObject.DisplayType;

                NameProductTextBox.Text = _productsObject.name;
                ArticulTextBox.Text = _productsObject.acticul.ToString();
                MinPriceTextBox.Text = _productsObject.min_price_partners.ToString();
                WidthTextBox.Text = _productsObject.width_roll.ToString();
            }

            TypeProductComboBox.ItemsSource = _context.product_type.Select(p => p.name).ToList();
        }

        private void SaveButtonClick_Click(object sender, RoutedEventArgs e)
        {
            _productsObject.product_type_id = TypeProductComboBox.SelectedIndex + 1;
            _productsObject.name = NameProductTextBox.Text;
            _productsObject.acticul = Convert.ToInt32(ArticulTextBox.Text);
            _productsObject.min_price_partners = Convert.ToDecimal(MinPriceTextBox.Text);
            _productsObject.width_roll = Convert.ToDecimal(WidthTextBox.Text);

            if (_productsObject.id == 0)
            {
                _productsObject.id = _context.products.Count() + 1;
                _context.products.Add(_productsObject); 
            }

            _context.SaveChanges();

            NavigationService.Navigate(new ProductPage());
        }
    }
}
