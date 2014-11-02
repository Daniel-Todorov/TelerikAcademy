namespace Minesweeper
{
    public class Player
    {
        private string name = null;
        private int scores = 0;

        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.name = name;
            this.scores = points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Scores
        {
            get { return this.scores; }
            set { this.scores = value; }
        }
    }
}
