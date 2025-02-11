using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using HandyControlDemo.ViewModel;

namespace DialogDemoCtl.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<DialogDemoViewModel>();
            SimpleIoc.Default.Register<InteractiveDialogViewModel>();
        }

        public static ViewModelLocator Instance = new Lazy<ViewModelLocator>(() =>
    Application.Current.TryFindResource("Locator") as ViewModelLocator).Value;

        public DialogDemoViewModel DialogDemo => SimpleIoc.Default.GetInstance<DialogDemoViewModel>();

        public InteractiveDialogViewModel InteractiveDialog => SimpleIoc.Default.GetInstance<InteractiveDialogViewModel>();
    }
}
