using System.Windows;
using DataAccess;

namespace StoreUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            using var context = new ProductContext();
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                ProdList.Items.Add(product.Name);
            }
        }
    }
}