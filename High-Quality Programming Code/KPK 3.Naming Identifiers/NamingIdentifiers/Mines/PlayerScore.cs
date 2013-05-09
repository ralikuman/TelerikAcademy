namespace Mines
{
    using System;
    using System.Linq;

    public class PlayerScore
    {
        private string name;
        private int collectedPoints;

        public PlayerScore(string name, int collectedPoints)
        {
            this.Name = name;
            this.CollectedPoints = collectedPoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int CollectedPoints
        {
            get
            {
                return this.collectedPoints;
            }

            private set
            {
                this.collectedPoints = value;
            }
        }
    }
}
