namespace JePrefereDigimon
{
    public interface IMovable
    {
        /// <summary>
        /// Permet le déplacement
        /// </summary>
        /// <param name="x">Position sur l'axe des abscisses</param>
        /// <param name="y">Position sur l'axe des ordonnées</param>
        void Move(int x, int y);
    }
}
