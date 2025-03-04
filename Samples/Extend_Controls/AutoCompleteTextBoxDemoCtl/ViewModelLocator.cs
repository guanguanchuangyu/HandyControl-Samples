using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using HandyControlDemo.Service;
using HandyControlDemo.ViewModel;

namespace AutoCompleteTextBoxDemoCtl.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<DataService>();
            SimpleIoc.Default.Register<InputElementDemoViewModel>();
            SimpleIoc.Default.Register<AutoCompleteTextBoxDemoViewModel>();
        }

        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
    Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;


        public InputElementDemoViewModel InputElementDemo => SimpleIoc.Default.GetInstance<InputElementDemoViewModel>();
        public AutoCompleteTextBoxDemoViewModel AutoCompleteTextBoxDemo => SimpleIoc.Default.GetInstance<AutoCompleteTextBoxDemoViewModel>();
    }
}
