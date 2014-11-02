//13. Implement a shoot ability for the player racket.
//The ability should only be activated when a Gift object falls on the racket.
//The shoot object should be a new class (e. g. Bullet) and should destroy normal Block objects (and be destroyed on collision with any block).
//Use the engine and ShootPlayerRacket method you implemented in task 4, but don't add items in any of the engine lists through the ShootPlayerRacket method.
//Also don't edit the Racket.cs file.
//Hint: you should have a ShootingRacket class and override its ProduceObjects method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Bullet : MovingObject
    {
        public Bullet(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '^' } }, new MatrixCoords(-1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == "unpassable";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
