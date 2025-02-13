using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using HandyControlDemo.ViewModel;

namespace NativeWindowDemoCtl.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<WindowDemoViewModel>();
        }

        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
    Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;


        public WindowDemoViewModel WindowDemo => SimpleIoc.Default.GetInstance<WindowDemoViewModel>();
    }
}
