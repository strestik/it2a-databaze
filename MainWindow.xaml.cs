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
        public ObservableCollection<Kniha> Knihovna { get; set; }

        private void NactiVychoziKnihy()
        {
            Knihovna.Add(new Kniha(
                "Zaklínač I. - Poslední přání",
                "Andrzej Sapkowski",
                "1993",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-77-4"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač II. - Meč osudu",
                "Andrzej Sapkowski",
                "1992",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-78-1"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač III. - Krev elfů",
                "Andrzej Sapkowski",
                "1994",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-79-8"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač IV. - Čas opovržení",
                "Andrzej Sapkowski",
                "1995",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-80-4"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač V. - Křest ohněm",
                "Andrzej Sapkowski",
                "1996",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-81-1"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač VI. - Věž vlaštovky",
                "Andrzej Sapkowski",
                "1997",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-82-8"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač VII. - Paní jezera",
                "Andrzej Sapkowski",
                "1999",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-85951-83-5"
            ));

            Knihovna.Add(new Kniha(
                "Zaklínač VIII. - Bouřková sezóna",
                "Andrzej Sapkowski",
                "2013",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-7477-002-9"
            ));
            
            Knihovna.Add(new Kniha(
                "Zaklínač IX. - Rozcestí krkavců",
                "Andrzej Sapkowski",
                "2025",
                "Dark Fantasy",
                "Slovanský mytos",
                5,
                Knihovna.Count + 1,
                "978-80-7477-088-3"
            ));
            
            Knihovna.Add(new Kniha(
                "Eragon",
                "Christopher Paolini",
                "2004",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-7200-978-7"
            ));
            
            Knihovna.Add(new Kniha(
                "Eldest",
                "Christopher Paolini",
                "2005",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "80-253-0220-2"
            ));
            
            Knihovna.Add(new Kniha(
                "Brisingr",
                "Christopher Paolini",
                "2009",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-253-0775-5"
            ));

            Knihovna.Add(new Kniha(
                "Inheritance",
                "Christopher Paolini",
                "2012",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-253-5860-3"
            ));

            Knihovna.Add(new Kniha(
                "The Fork, the Witch, and the Worm",
                "Christopher Paolini",
                "2019",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-253-5835-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Fractal Noise",
                "Christopher Paolini",
                "2023",
                "Sci-Fi",
                "Space Opera",
                1,
                Knihovna.Count + 1,
                "978-80-253-6557-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Murtagh",
                "Christopher Paolini",
                "2024",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-253-7200-5"
            ));

            Knihovna.Add(new Kniha(
                "Sebrané spisy H. P. Lovecrafta",
                "H. P. Lovecraft",
                "2023",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-201-2"
            ));

            Knihovna.Add(new Kniha(
                "Hrobka",
                "H. P. Lovecraft",
                "2022",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-285-2"
            ));
            
            Knihovna.Add(new Kniha(
                "Měsíční močál",
                "H. P. Lovecraft",
                "2022",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-291-3"
            ));
            
            Knihovna.Add(new Kniha(
                "Volání Cthulhu - Spisy 3/I",
                "H. P. Lovecraft",
                "2022",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-275-3"
            ));
            
            Knihovna.Add(new Kniha(
                "Volání Cthulhu - Spisy 3/II",
                "H. P. Lovecraft",
                "2023",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-519-8"
            ));
            
            Knihovna.Add(new Kniha(
                "Stín z času",
                "H. P. Lovecraft",
                "2023",
                "Horor",
                "Kosmický horor",
                1,
                Knihovna.Count + 1,
                "978-80-7662-520-4"
            ));

            Knihovna.Add(new Kniha(
                "Barva kouzel",
                "Terry Pratchett",
                "1993",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "80-85609-28-2"
            ));
            
            Knihovna.Add(new Kniha(
                "Lehké fantastično",
                "Terry Pratchett",
                "1993",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-85609-29-5"
            ));
            
            Knihovna.Add(new Kniha(
                "Čaroprávnost",
                "Terry Pratchett",
                "1994",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-7197-388-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Mort",
                "Terry Pratchett",
                "1994",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-85609-55-4"
            ));
            
            Knihovna.Add(new Kniha(
                "Magický prazdroj",
                "Terry Pratchett",
                "1995",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-85609-67-7"
            ));
            
            Knihovna.Add(new Kniha(
                "Soudné sestry",
                "Terry Pratchett",
                "1995",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "80-85609-68-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Pyramidy",
                "Terry Pratchett",
                "1995",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-85609-69-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Stráže! Stráže!",
                "Terry Pratchett",
                "1996",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-85609-70-7"
            ));
            
            Knihovna.Add(new Kniha(
                "Erik",
                "Terry Pratchett",
                "1996",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-7197-003-3"
            ));
            
            Knihovna.Add(new Kniha(
                "Pohyblivé obrázky",
                "Terry Pratchett",
                "1996",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-7197-004-0"
            ));
            
            Knihovna.Add(new Kniha(
                "Sekáč",
                "Terry Pratchett",
                "1997",
                "Fantasy",
                "Humoristická fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-7197-005-7"
            ));

            Knihovna.Add(new Kniha(
                "Máj / Kytice",
                "K. H. Mácha, K. J. Erben",
                "2000",
                "Poezie",
                "Česká klasika",
                1,
                Knihovna.Count + 1,
                "978-80-86425-92-4"
            ));
            
            Knihovna.Add(new Kniha(
                "Písně kosmické",
                "Jan Neruda",
                "2009",
                "Poezie",
                "Česká klasika",
                1,
                Knihovna.Count + 1,
                "978-80-7399-743-4"
            ));
            
            Knihovna.Add(new Kniha(
                "Havran a jiné básně",
                "Edgar Allan Poe",
                "2025",
                "Poezie",
                "Americká romantická poezie",
                1,
                Knihovna.Count + 1,
                "978-80-277-2432-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Balady",
                "Johann Wolfgang von Goethe",
                "1976",
                "Poezie",
                "Německá klasická poezie",
                1,
                Knihovna.Count + 1,
                "9788074074615"
            ));
            
            Knihovna.Add(new Kniha(
                "Jáma a kyvadlo a jiné fantastické příběhy",
                "Edgar Allan Poe",
                "2007",
                "Povídky",
                "Americký horor",
                1,
                Knihovna.Count + 1,
                "978-80-7388-023-1"
            ));
            
            Knihovna.Add(new Kniha(
                "Tvůrce osudu",
                "Alice Shy",
                "2019",
                "Fantasy",
                "Temná fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-270-5807-5"
            ));
            
            Knihovna.Add(new Kniha(
                "Korsak a zlatý meč",
                "Jitka Komendová",
                "2016",
                "Fantasy",
                "YA Fantasy",
                1,
                Knihovna.Count + 1,
                "978-80-253-2885-9"
            ));
            
            Knihovna.Add(new Kniha(
                "Dobrodružství krále Artuše",
                "Olga M. Yuste",
                "2021",
                "Dobrodružné",
                "Legendy a mýty",
                1,
                Knihovna.Count + 1,
                "978-80-7557-775-4"
            ));
        }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Knihovna = new ObservableCollection<Kniha>();
            NactiVychoziKnihy();
        }
        private void PridatKnihu_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtRok.Text, out int rok))
            {
                MessageBox.Show("Zkontroluj rok!");
                return;
            }
            if (!int.TryParse(txtPocet.Text, out int ks))
            {
                MessageBox.Show("Zkontroluj možství!");
                return;
            }

            Kniha kniha = new Kniha(
                txtNazev.Text,
                txtAutor.Text,
                rok < 0 ? (rok * (-1)).ToString() + " př. n. l." : rok.ToString(),
                txtZanr.Text,
                txtPodzanr.Text,
                ks,
                Knihovna.Count + 1,
                txtISBN.Text
            );

            Knihovna.Add(kniha);
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
                k.RokVydani = rok.ToString();
                k.Zanr = txtZanr.Text;
                k.Podzanr = txtPodzanr.Text;
                k.Ks = ks;
                k.ISBN = txtISBN.Text;

                dataGrid.Items.Refresh();
            }
        }

        private void SmazatKnihu_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem is Kniha k)
            {
                Knihovna.Remove(k);
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

    }
}
