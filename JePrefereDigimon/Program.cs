using System;

namespace JePrefereDigimon
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string salam = "Salamèche";
                string carap = "Carapuce";
                string beurk = "Bulbizar";
                Console.WriteLine("Bonjour !");
                Console.WriteLine("Quel est ton nom ?");
                string nom = Console.ReadLine();
                Console.WriteLine("Bonjour {0} !", nom);
                Console.WriteLine("Choisi un pokemon pour commencer : ");
                Console.WriteLine("1 : Salamèche");
                Console.WriteLine("2 : Bulbizar");
                Console.WriteLine("3 : Carapuce");
                string choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Tu as choisi {0} !", salam);
                        break;
                    case "2":
                        Console.WriteLine("Tu as choisi {0} !", beurk);
                        break;
                    case "3":
                        Console.WriteLine("Tu as choisi {0} !", carap);
                        break;
                    default:
                        throw new ChoixException("Choix erroné !");
                }
            }
            catch (ChoixException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur inconnue\nIntitulé de l'erreur :\n" +
                    ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
