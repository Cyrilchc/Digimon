using System;

namespace JePrefereDigimon
{
    public class Player : IMovable
    {
        private string Pseudo { get; set; }
        private Pokemon Pokemon { get; set; }

        /// <summary>
        /// Permet le déplacement   
        /// </summary>
        /// <param name="x">Position sur l'axe des abscisses</param>
        /// <param name="y">Position sur l'axe des ordonnées</param>
        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
