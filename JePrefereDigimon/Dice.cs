using System;

namespace JePrefereDigimon
{
    public class Dice
    {
        /// <summary>
        /// Renvoie un nombre entre 1 et 6
        /// </summary>
        /// <returns>Une valeur en 1 et 6</returns>
        public static int Roll()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }
    }
}
