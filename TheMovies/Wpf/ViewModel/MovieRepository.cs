using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Wpf.View;

namespace Wpf.ViewModel
{
    public class MovieRepository
    {
        public void AddMovie(string Title, string Genre, string Length, string Instructor, string Premiere)
        {
            List<string> Movies = new List<string>();
            Movies.Add(Title)
            using(StreamWriter sw = new StreamWriter("FilmListe.csv", true))
            {
                sw.WriteLine(Title + ';' + Genre + ';' + Length + ';' + Instructor + ';' + Premiere);
            }
        }
    
        
    }
}
