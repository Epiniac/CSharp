namespace Minecraft
{
    public class Blocks
    {
        
        public enum BlockType // all block types we can have
        {
            NONE,
            DIRT,
            COBBLESTONE,
            LOG,
            PLANKS,
            CHEST,
            CRAFTING_TABLE,
            FURNACE,
            SAND
        }

        public BlockType type;  // the type of block
        public int count;       // the number of blocks in the stack
    
        public Blocks(BlockType type, int count)
        {
            this.type = type;
            this.count = count;
        }
    }
}