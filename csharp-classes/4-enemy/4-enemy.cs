using System;

namespace Enemies
{
    /// <summary>
    /// Represents a zombie with health and a name.
    /// </summary>
    public class Zombie
    {
        // Private fields
        private int health;
        private string name;

        /// <summary>
        /// Const zom w no health
        /// </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        /// <summary>
        /// Const zom w health
        /// </summary>
        /// <param name="value">The health value of the zombie (must be greater than or equal to 0).</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
            name = "(No name)";
        }

        /// <summary>
        /// Zom namer
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Get zom health
        /// </summary>
        /// <returns>Zom health</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}