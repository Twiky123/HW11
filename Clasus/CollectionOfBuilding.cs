
namespace Tymakov13
{
    internal class Collectionsofbuildings
    {
        private int number;

        public int Number
        {
            get { return number; }
        }
        private static int number_1 = 0;

        private void PrintNumber()
        {
            number_1++;
        }
        private uint height;

        public uint Height
        {
            get { return height; }
        }
        private uint floor;
        public uint Floor
        {
            get { return floor; }
        }
        private uint aparuaments;

        public uint Aparuaments
        {
            get { return aparuaments; }
        }
        private uint entry;

        public uint Entry
        {
            get { return entry; }
        }

        public Collectionsofbuildings(uint height, uint floor, uint aparuaments, uint entry)
        {
            number = number_1;
            this.height = height;
            this.floor = floor;
            this.aparuaments = aparuaments;
            this.entry = entry;
            PrintNumber();
        }

        public uint Heigth(uint heigth, uint floor)
        {
            uint result = (uint)(heigth / floor);
            return result;
        }

        public uint Quantity_apart_inENTR(uint floor, uint entry)
        {
            uint result1 = (uint)(floor / entry);
            return result1;
        }

        public uint Quantity_apart_infloor(uint aparuaments, uint floor)
        {
            uint result3 = (uint)(aparuaments / floor);
            return result3;
        }

    }
}