//6. Implement a MeteoriteBall.
//It should inherit the Ball class and should leave a trail of TrailObjects.
//Each trail object should last for 3 "turns".
//Other than that, the Meteorite ball should behave the same way as the normal ball.
//You must NOT edit any existing .cs file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public override IEnumerable<GameObject> ProduceObjects()
        {
            TrailObject trail = new TrailObject(this.TopLeft, 3);
            List<GameObject> trails = new List<GameObject>();
            trails.Add(trail);

            return trails;
        }

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }
    }
}
