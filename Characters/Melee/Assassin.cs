using MagicDestroyers.Enums;
using MagicDestroyers.Equipments.Armors.Leather;
using MagicDestroyers.Equipments.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const string DEFAULT_NAME = "Assassin";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        /*
         Ques - Why we can't use const for giving default value of custom class objects
         */
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public LightLeatherVest BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Assassin()
            :this(DEFAULT_LEVEL,DEFAULT_NAME)
        {
        }

        /* 
         * 'this' keyword here is pointing to the class Assassin basically this keyword points to container under which it is used.
         */
        public Assassin(int level, string name)    
            : this(DEFAULT_HEALTH_POINTS, level, name)
        {
        }

        public Assassin(int healthPoints, int level, string name)
        {
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;

            base.Name = name;
            base.Faction = DEFAULT_FACTION;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        public void Raze()
        {

        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }
    }
}
