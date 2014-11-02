//4. Inherit the Engine class.
//Create a method ShootPlayerRacket.
//Leave it empty for now.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingEngine : Engine
    {
        public ShootingEngine(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
        }

        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShoothingRacket)
            {
                (this.playerRacket as ShoothingRacket).Shoot();
            }
        }
    }
}
