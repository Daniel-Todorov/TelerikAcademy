//10. Implement an ExplodingBlock.
//It shoudl destroy all blocks around it when it is destroyed.
//You must NOT edit any existing .cs file.
//Hint: what does an explosion "produce".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Boom : MovingObject
    {
        public Boom(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body, speed)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
        public override void Update()
        {
            this.IsDestroyed = true;
        }
    }
}
