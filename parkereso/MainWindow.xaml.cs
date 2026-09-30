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

namespace parkereso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> meret = new List<string> {"2 x 2","4 x 4","6 x 6" };
        List<string> tema = new List<string> { "emoji", "nevek", "szakáll" };
        public MainWindow()
        {
            InitializeComponent();
            lbox_meret.ItemsSource = meret;
            lbox_tema.ItemsSource = tema;
        }

        private void GombokElhejezese()
        {
            if (lbox_meret.SelectedItem == "2 x 2")
            {
                int meret = 2;
                parkeresoGrid.RowDefinitions.Clear();
                parkeresoGrid.ColumnDefinitions.Clear();
                for (int i = 0; i < 2; i++)
                {
                    parkeresoGrid.RowDefinitions.Add(new RowDefinition());
                    parkeresoGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }
                List<string> szamok = new List<string>();
                for (int i = 0; i < meret * meret / 2; i++)
                {
                    szamok.Add(i.ToString());
                    szamok.Add(i.ToString());
                }
                szamok = szamok.Shuffle().ToList();
                int index = 0;
                for (int i = 0; i < meret; i++)
                {
                    for (int j = 0; j < meret; j++)
                    {
                        
                        Button btn = new Button
                        {
                            Name = "btn_" + szamok[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_click;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        parkeresoGrid.Children.Add(btn);
                    }
                }
            }
            else if (lbox_meret.SelectedItem == "4 x 4")
            {
                int meret = 4;
                parkeresoGrid.RowDefinitions.Clear();
                parkeresoGrid.ColumnDefinitions.Clear();
                for (int i = 0; i < 4; i++)
                {
                    parkeresoGrid.RowDefinitions.Add(new RowDefinition());
                    parkeresoGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }
                List<string> szamok = new List<string>();
                for (int i = 0; i < meret * meret / 2; i++)
                {
                    szamok.Add(i.ToString());
                    szamok.Add(i.ToString());
                }
                szamok = szamok.Shuffle().ToList();
                int index = 0;
                for (int i = 0; i < meret; i++)
                {
                    for (int j = 0; j < meret; j++)
                    {

                        Button btn = new Button
                        {
                            Name = "btn_" + szamok[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_click;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        parkeresoGrid.Children.Add(btn);
                    }
                }
            }
            else if (lbox_meret.SelectedItem == "6 x 6")
            {
                int meret = 6;
                parkeresoGrid.RowDefinitions.Clear();
                parkeresoGrid.ColumnDefinitions.Clear();
                for (int i = 0; i < 6; i++)
                {
                    parkeresoGrid.RowDefinitions.Add(new RowDefinition());
                    parkeresoGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }
                List<string> szamok = new List<string>();
                for (int i = 0; i < meret * meret / 2; i++)
                {
                    szamok.Add(i.ToString());
                    szamok.Add(i.ToString());
                }
                szamok = szamok.Shuffle().ToList();
                int index = 0;
                for (int i = 0; i < meret; i++)
                {
                    for (int j = 0; j < meret; j++)
                    {

                        Button btn = new Button
                        {
                            Name = "btn_" + szamok[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_click;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        parkeresoGrid.Children.Add(btn);
                    }
                }
            }

            

            

        }
        string elozo_btn = null; Button elozo = null; 
        private void button_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.Content = btn.Name.Split('_')[1];
                btn.Background = Brushes.Coral;
            }
            string felirat = btn.Content.ToString();
            if (elozo_btn == null)
            {
                elozo_btn = felirat;
                elozo = btn;
                btn.Background = Brushes.Coral;
            }
            else if (elozo_btn == felirat)
            {
                MessageBox.Show("Találtál egy párt!");
                elozo_btn = null;
                btn.IsEnabled = false;
                elozo.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Nem találtál párt!");

                elozo_btn = null;
                btn.Background = Brushes.LightGray;
                btn.Content = "?";
                elozo.Background = Brushes.LightGray;
                elozo.Content = "?";
            }
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            GombokElhejezese();
        }
    }
}