using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class
    /// </summary>
    public class Zombie
    {
        // Private fields
        private int health;
        private string name;

        /// <summary>
        /// Const zom w o health
        /// </summary>
        public Zombie()
        {
            health = 0;
            name = "(No name)";
        }

        /// <summary>
        /// Const zom w health and name
        /// </summary>
        public Zombie(int value)
        {
            // Validate the health value
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

        /// <summary>
        /// Makes string that contains zom attributes
        /// </summary>
        /// <returns>Zom attributes string</returns>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
