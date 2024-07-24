using System.Windows;
using System.Windows.Documents;
using NAudio.Wave;

namespace AudioDevice_Tester
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string textToSet = "";
            for (int n = -1; n < WaveOut.DeviceCount; n++)
                if (n > -1 && n < 10)
                    textToSet += "ID  " + n + " : " + WaveOut.GetCapabilities(n).ProductName + "\n";
                else
                    textToSet += "ID " + n + " : " + WaveOut.GetCapabilities(n).ProductName + "\n";
            deviceList.Text = textToSet;
        }
    }
}
