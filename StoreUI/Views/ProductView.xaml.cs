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
using Common.Services;
using DataAccess;

namespace StoreUI.Views
{
    /// <summary>
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : UserControl
    {
        //TODO: Private readonly för att inte kunna ändra eller påverka utifrån.
        private readonly ProductRepository _productRepository;
        public ProductView()
        {
            InitializeComponent();
            _productRepository = new ProductRepository(ApplicationContextManager.Context);
        }

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var products = _productRepository.GetAllProducts();
            foreach (var productModel in products)
            {
                ProdList.Items.Add(productModel);
            }
        }
    }
}
