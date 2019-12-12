using System.IO;

namespace JePrefereDigimon
{
    public class Globals
    {
        // Chemin du fichier CSV
        public static string filePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Pokemons.csv";
    }
}
