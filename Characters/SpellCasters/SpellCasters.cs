namespace MagicDestroyers.Characters.SpellCasters
{
    public abstract class SpellCasters : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
    }
}
