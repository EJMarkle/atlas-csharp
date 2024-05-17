using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class
    /// </summary>
    public class Zombie
    {
        private int health;

        /// <summary>
        /// Const zom w no health
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

        /// <summary>
        /// Get zom health
        /// </summary>
        /// <returns>Zombie health</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
