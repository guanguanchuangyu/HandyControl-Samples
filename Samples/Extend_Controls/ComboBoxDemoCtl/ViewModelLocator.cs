using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using HandyControlDemo.ViewModel;

namespace ComboBoxDemoCtl.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<InputElementDemoViewModel>();
        }

        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
    Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;


        public InputElementDemoViewModel InputElementDemo => SimpleIoc.Default.GetInstance<InputElementDemoViewModel>();
    }
}
