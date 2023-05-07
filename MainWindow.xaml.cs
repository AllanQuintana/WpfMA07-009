using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace WpfMA07_009
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLimpiar_Click (object sender, RoutedEventArgs e)
        {
            this.txtNombre.Clear();
            this.txtTelefono.Clear();
        }

        private void btnGrabar_Click (object sender, RoutedEventArgs e)
        {
            string strNombre = this.txtNombre.Text.Trim();  // Guardar la variable, Trim() sirve para evitar espacios en inicio y al final
            string strTelefono = this.txtTelefono.Text.Trim();

            string contacto = strNombre.ToUpper() + "," + strTelefono;
            StreamWriter writer = new StreamWriter("MiAgenda.txt", true);
            writer.WriteLine(contacto);
            writer.Close();

            MessageBox.Show("Contacto agregado");
        }
    }
}
