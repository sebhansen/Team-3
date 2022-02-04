using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wpf.ViewModel;

namespace Wpf.View
{
    /// <summary>
    /// Interaction logic for MovieInformation.xaml
    /// </summary>
    public partial class MovieInformation : Window
    {
        MovieRepository movieRepository = new();

        public MovieInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            movieRepository.AddMovie(tbTitle.Text, tbGenre.Text, tbLength.Text, tbInstructor.Text, dpPremiere.SelectedDate.Value.Date.ToShortDateString());
            MessageBox.Show($"You have now added the movie {tbTitle.Text}");
            Close();
        }
    }
}

