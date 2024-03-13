using System;
using System.Xml.Schema;

namespace Minecraft
{
    #region dependencies
    public enum MobType
    {
        PLAYER,
        PIG,
        COW,
        OCELOT,
        ZOMBIE,
        CREEPER
    }
    #endregion

    public class Entity
    {
        
        public Entity(MobType type,int hp,string noise, Blocks loot)
        {
        #region Constructor

        this.type = type;
        this.hp = hp;
        this.noise = noise;
        this.loot = loot;
        hpBase = hp;

        }
        #endregion
        
                protected MobType type;
                public MobType Type
                {
                    get { return type; }
                }

                protected int hp;
                public int Hp
                {
                    get { return hp; }
                }
                
                protected string noise;
                
                
                protected bool isKO;
                public bool IsKO
                {
                    get { return isKO; }
                }
                
                protected Blocks loot;
                
                protected int hpBase;

                

        #region Methods

        public virtual void WhoAmI()
        {
            Console.WriteLine("I am an entity ! {0}", noise);
        }
        
        public virtual void Describe()
        {
            if (type == MobType.OCELOT)
            {
                Console.WriteLine("I'm an {0} and I have {1} hp", type, Hp);
            }
            else
            {
                Console.WriteLine("I'm a {0} and I have {1} hp", type, Hp);
            }
        }
        
        public Blocks GetHurt(int count)
        {

            if ((hp - count <= 0))
            {
                isKO = true;
                hp = 0;
                return loot;
            }
            else
            {
                isKO = false;
                hp = hp - count;
                return new Blocks(Blocks.BlockType.NONE, 0);
            }
        }
        
        #endregion

    }}