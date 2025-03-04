using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;
using HandyControlDemo.Properties.Langs;

namespace CheckComboBoxDemoCtl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            LangProvider.Culture = new CultureInfo("zh-cn");
            base.OnStartup(e);
        }
    }

}
