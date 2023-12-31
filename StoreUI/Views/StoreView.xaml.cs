﻿using System.Windows;
using DataAccess;
using System.Windows.Controls;
using DataAccess.Services;

namespace StoreUI.Views
{
    /// <summary>
    /// Interaction logic for StoreView.xaml
    /// </summary>
    public partial class StoreView : UserControl
    {
        private readonly StoreRepository _storeRepository;
        public StoreView()
        {
            InitializeComponent();
            _storeRepository = new StoreRepository(ApplicationContextManager.Context);
        }

        private void LoadBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var stores = _storeRepository.GetAllStores();
            StoreList.ItemsSource = stores;
        }
    }
}
