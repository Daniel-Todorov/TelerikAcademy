//8. Implement an UnstopableBall and an UnpassableBlock.
//The UnstopableBall only bounces off UnpassableBlocks and will destroy any other block it passes through.
//The UnpassableBlock should be indestructible.
//Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class UnstopableBall : Ball
    {
        public new const string CollisionGroupString = "unstopable";

        public UnstopableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "block"
                || otherCollisionGroupString == "unpassable";
        }

        public override string GetCollisionGroupString()
        {
            return UnstopableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            for (int i = 0; i < collisionData.hitObjectsCollisionGroupStrings.Count; i++)
            {
                if (collisionData.hitObjectsCollisionGroupStrings[i] == "unpassable" || collisionData.hitObjectsCollisionGroupStrings[i] == "racket")
                {
                    if (collisionData.CollisionForceDirection.Row * this.Speed.Row < 0)
                    {
                        this.Speed.Row *= -1;
                    }
                    if (collisionData.CollisionForceDirection.Col * this.Speed.Col < 0)
                    {
                        this.Speed.Col *= -1;
                    }
                }
            }
        }
    }
}
