using System;
using System.Collections.Generic;
using System.IO;

namespace JePrefereDigimon
{
    public class Pokedex
    {
        List<Pokemon> Pokemons { get; set; }

        /// <summary>
        /// Charge le pokedex avec le contenu du fichier CSV
        /// </summary>
        /// <param name="filePath">Chemin du fichier</param>
        private void LoadPokedexFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Lit les lignes jusqu'à la fin du fichier
                    while (!reader.EndOfStream)
                    {
                        string listeDesPokemons = reader.ReadLine(); // Lit une ligne
                        string[] listeDesPokemonsSplit = listeDesPokemons.Split(';'); // Sépare chaque info dans un tableau
                        string type = listeDesPokemonsSplit[1]; // Le type se trouve à la postion 2 donc à l'index 1
                        Pokemon pokemon;
                        switch (type.ToUpper())
                        {
                            case "FEU":
                                pokemon = new FirePokemon();
                                InitializePokemon(pokemon, listeDesPokemonsSplit);
                                break;
                            case "EAU":
                                pokemon = new WaterPokemon();
                                InitializePokemon(pokemon, listeDesPokemonsSplit);
                                break;
                            case "PLANTE":
                                pokemon = new PlantPokemon();
                                InitializePokemon(pokemon, listeDesPokemonsSplit);
                                break;
                        }
                    }

                    // Ferme le fichier pour éviter les IOExceptions
                    reader.Close();
                }
            }
            else
            {
                // Créé le fichier et le ferme;
                var file = File.Create(filePath);
                file.Close();
                Console.WriteLine("Le fichier n'existait pas et a été créé");
            }
        }

        /// <summary>
        /// Initialise l'objet Pokemon
        /// </summary>
        /// <param name="pokemon">Le pokemon à initialiser</param>
        /// <param name="ligne">La ligne qui contient les infos du pokémon</param>
        private void InitializePokemon(Pokemon pokemon, string[] ligne)
        {
            pokemon.Nom = ligne[0];
            pokemon.Type = ligne[1];
            pokemon.Pv = Convert.ToInt32(ligne[2]);
            pokemon.Atk = Convert.ToInt32(ligne[3]);
            pokemon.Def = Convert.ToInt32(ligne[4]);

            // Ajoute à la liste
            Pokemons.Add(pokemon);
        }

        /// <summary>
        /// Trouve tous les pokemons de la liste du type passé en paramètre
        /// </summary>
        /// <param name="type">Le type à trouver</param>
        /// <returns>Tous les pokémons du type en paramètre</returns>
        private List<Pokemon> GetByType(string type)
        {
            return Pokemons.FindAll(x => x.Type == type);
        }
    }
}
