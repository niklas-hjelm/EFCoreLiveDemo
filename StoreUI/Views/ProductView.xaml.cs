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
using Common.Models;
using DataAccess;
using DataAccess.Services;

namespace StoreUI.Views
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        private readonly ProductRepository _productRepository;
        public ProductView()
        {
            InitializeComponent();
            _productRepository = new ProductRepository(ApplicationContextManager.Context);
        }

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var products = _productRepository.GetAllProducts();
            ProdList.Items.Clear();
            foreach (var productModel in products)
            {
                ProdList.Items.Add(productModel);
            }
        }

        private void SaveBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var allProducts = _productRepository.GetAllProducts();

            if (allProducts.Count(p => p.Name == NameTxt.Text) > 0)
            {
                MessageBox.Show("Product with that name already exists!");
                return;
            }
            if (double.TryParse(PriceTxt.Text, out double price))
            {
                var newProduct = new ProductModel()
                {
                    Name = NameTxt.Text,
                    Description = DescTxt.Text,
                    Price = price,
                };
                _productRepository.AddProduct(newProduct);
            }
        }
    }
}
