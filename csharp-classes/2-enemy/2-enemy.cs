using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Zombie health
        /// </summary>
        public int health;

        /// <summary>
        /// Construct zombie
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Const zom w health
        /// </summary> 
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }
    }
}
