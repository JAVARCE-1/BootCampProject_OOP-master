using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp_OOP
{
    public class Video : MediaItem

    {
        private string _genero;
        private string _formato;
        public string Genero { get => _genero; set => _genero = value; }
        public string Formato { get => _formato; set => _formato = value; }

        public Video(string genero,
                     string formato,
                     string title,
                     TimeSpan duration) : base(title, duration)
        {
            if (string.IsNullOrWhiteSpace(genero))
                throw new ArgumentNullException(nameof(genero), "Pelicula cannot be empty.");
            if (string.IsNullOrWhiteSpace(formato))
                throw new ArgumentNullException(nameof(formato), "Formato cannot be empty.");

            _genero = genero;
            _formato = formato;

        }

        public override string CreatorInfo => _genero;



        public override void Play()
        {
            Console.WriteLine($"\n▶️ Pelicula: {Title} by {_genero}");
            //Console.WriteLine($"   Album: {Album}, Duration: {Duration:mm\\:ss}");
        }
        public override void DisplayDetails()
        {
 
            Console.WriteLine($"  Genero: {_genero}");
            Console.WriteLine($"  Formato: {_formato}");
        }


        public override string ToString()
        {
            return $"{Title} - {_genero} ({Duration:mm\\:ss}) formato video: {_formato}";
        }

    }
}
