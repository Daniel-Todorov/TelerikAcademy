//5. Implement a TrailObject class.
//It should inherit the GameObject class and should have a constructor which takes an additional "lifetime" integer.
//The TrailObject should disappear after a "lifetime" amount of turns. 
//You must NOT edit any existing .cs files.
//Then test the TrailObject by adding an instance of it in the engine through the AcademyPopcornManin.cs file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class TrailObject : GameObject
    {
        public const char Racket = 'i';
        public int LifeTime { get; set; }

        public TrailObject(MatrixCoords topLeft, int lifeTime)
            : base(topLeft, new char[,] { { 'x' } })
        {
            this.LifeTime = lifeTime;
        }

        public override void Update()
        {
            this.LifeTime--;

            if (this.LifeTime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
