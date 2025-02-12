using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using HandyControlDemo.Service;
using HandyControlDemo.ViewModel;

namespace TreeViewDemoCtl.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<DataService>();
            var dataService = SimpleIoc.Default.GetInstance<DataService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
    Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;


        public MainViewModel Main => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}
