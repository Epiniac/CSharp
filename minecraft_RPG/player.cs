using System;
using System.Collections.Generic;
using System.Linq;


namespace Minecraft
{
    public class Player : Entity
    {
        # region Constructor
        public Player(string username, int weaponStrength)
            : base(MobType.PLAYER, 20, "Hi Guys", new Blocks(Blocks.BlockType.NONE,0))
        {
            // FIXME
        }
        #endregion

        private int weaponStrength;
        private string username;
        private List<Blocks> inventory = new List<Blocks>();

        #region Methods
        
        public override void WhoAmI()
        {
            Console.WriteLine("I am {0} ! {1}", username, noise);
        }
        
        public void Attack(Entity entity)
        {
            AddInInventory(entity.GetHurt(weaponStrength+1));
        }

        public void AddInInventory(Blocks blocks)
        {
            if (blocks.type != Blocks.BlockType.NONE && blocks.count > 0)
            {
                foreach (Blocks i in inventory)
                {
                    if (blocks.type == i.type && i.count + blocks.count <= 64)
                    {
                        i.count = i.count + blocks.count;
                        blocks.count = 0;
                    }
                    else if (i.type == blocks.type && i.count + blocks.count > 64 )
                    {
                        blocks.count -= (64 - i.count);
                        i.count = 64;
                    }
                }
                while (blocks.count > 64)
                {
                                    Blocks blocksBis = new Blocks(blocks.type, 64);
                                    inventory.Add(blocksBis);
                                    blocks.count -= 64;
                }
                inventory.Add(blocks);
            }
        }

        public void RemoveInInventory(Blocks blocks)
        { 
            int c = CountInInventory(blocks.type);
            foreach (Blocks i in inventory.ToList())
            {
                if (i.type == blocks.type)
                {
                    inventory.Remove(i);
                }
            }
            AddInInventory(new Blocks(blocks.type, (c - blocks.count)));
        }
        public void Heal(int life) 
        {
                if ((hp > 0) && (hp < hpBase))
                {
                    if (hp + life > hpBase)
                    {
                        hp = hpBase;
                    }
                    else
                    {
                        hp += life;
                    }
                }
        }
        
        public void DisplayInventory()
        {
                 Console.WriteLine("I have so many blocks. These are: ");
                 foreach (Blocks i in inventory)
                 {
                     Console.WriteLine("- {0} {1}", i.type, i.count);
                 }
        }
        
        public int CountInInventory(Blocks.BlockType type)
        {
            int c = 0;
            foreach (Blocks items in inventory)
            {
                if (items.type == type)
                {
                    c += items.count;
                }
            }
            return c;
        }
             #endregion
    }
}