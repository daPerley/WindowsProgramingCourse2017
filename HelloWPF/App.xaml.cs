using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            Window f = new Window
            {
                Title = "Hello World"
            };
            f.Show();

            // Something tells me he skipped something...
        }
    }
}
