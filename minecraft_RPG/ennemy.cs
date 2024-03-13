using System;
using System.ComponentModel.DataAnnotations;

namespace Minecraft
{
    public class Aggressive : Entity
    {
        # region Constructor

        public Aggressive(MobType type, int hp, string noise, Blocks loot,
            int strength) : base (type, hp, noise, loot)
        {
            this.strength = strength;
        }
        
        #endregion

        private int strength;
        
        #region Methods
        
        public override void WhoAmI()
        {
            Console.WriteLine("I'm agressive ! {0}", noise);
        }
        
        public void Attack(Entity entity)
        {
            entity.GetHurt(strength);
        }

        #endregion
    }
}