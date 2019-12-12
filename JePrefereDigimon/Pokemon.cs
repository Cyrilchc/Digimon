using System;

namespace JePrefereDigimon
{
    public class Pokemon : IMovable
    {
        public string Nom { get; set; }
        public string Type { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
