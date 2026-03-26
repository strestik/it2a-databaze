using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace it2a_databaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<Kniha> Knihy { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Knihy = new ObservableCollection<Kniha>();
        }

        private void Nacist_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Kniha k)
            {
                txtNazev.Text = k.Nazev;
                txtAutor.Text = k.Autor;
                txtRok.Text = k.RokVydani.ToString();
                txtZanr.Text = k.Zanr;
                txtPodzanr.Text = k.Podzanr;
                txtPocet.Text = k.Ks.ToString();
                txtISBN.Text = k.ISBN;
            }
        }

        private void UpravitKnihu_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Kniha k)
            {
                if (!int.TryParse(txtRok.Text, out int rok) ||
                    !int.TryParse(txtPocet.Text, out int ks))
                {
                    MessageBox.Show("Zkontroluj čísla!");
                    return;
                }

                k.Nazev = txtNazev.Text;
                k.Autor = txtAutor.Text;
                k.RokVydani = rok;
                k.Zanr = txtZanr.Text;
                k.Podzanr = txtPodzanr.Text;
                k.Ks = ks;
                k.ISBN = txtISBN.Text;

                dataGrid.Items.Refresh(); // důležité!
            }
        }

        private void SmazatKnihu_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Kniha k)
            {
                Knihy.Remove(k);
            }
        }

        private void VymazFormular_Click(object sender, RoutedEventArgs e)
        {
            txtNazev.Text = "";
            txtAutor.Text = "";
            txtRok.Text = "";
            txtZanr.Text = "";
            txtPodzanr.Text = "";
            txtPocet.Text = "";
            txtISBN.Text = "";
        }

        private void PridatKnihu_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtRok.Text, out int rok) ||
                !int.TryParse(txtPocet.Text, out int ks))
            {
                MessageBox.Show("Zkontroluj čísla!");
                return;
            }

            Kniha kniha = new Kniha(
                txtNazev.Text,
                txtAutor.Text,
                rok,
                txtZanr.Text,
                txtPodzanr.Text,
                ks,
                Knihy.Count + 1,
                txtISBN.Text
            );

            Knihy.Add(kniha);
        }
    }
}