

                //!!!NOTE!!!
//It is kind of messy with all the new features.
//Most of them are in comments. Only the last features are active.
//Please, follow the problems one by one and reveal the commented lines to check the results.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            //1. The AcademyPopcorn class contains an IndestructibleBlock class.
            //Use it to create side and ceiling walls to the game.
            //You can ONLY edit the AcademyPopcornMain.cs file.

            //LeftWall
            for (int i = 0; i < endCol; i++)
            {
                IndestructibleBlock leftWall = new IndestructibleBlock(new MatrixCoords(i, 0));

                engine.AddObject(leftWall);
            }

            //RightWall
            for (int i = 0; i < endCol; i++)
            {
                IndestructibleBlock rightWall = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));

                engine.AddObject(rightWall);
            }

            //Ceiling
            for (int i = 1; i < WorldCols - 1; i++)
            {
                IndestructibleBlock rightWall = new IndestructibleBlock(new MatrixCoords(0, i));

                engine.AddObject(rightWall);
            }

            //10. Testing the exploding block.
            for (int i = startCol; i < endCol; i++)
            {
                //if (i == 7)
                //{
                //    ExplodingBlock boomBlock = new ExplodingBlock(new MatrixCoords(startRow, i));
                //
                //    engine.AddObject(boomBlock);
                //}
                //else
                //{
                    Block currBlock = new Block(new MatrixCoords(startRow, i));

                    engine.AddObject(currBlock);
                //}
            }

            //12. Testing Gift and GiftBlock
            for (int i = startCol; i < endCol; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow + 5, i));

                engine.AddObject(currBlock);
            }

            //7. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            //MeteoriteBall theBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //
            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //5. Testing TrailObject
            //TrailObject trail = new TrailObject(new MatrixCoords(10, 10), 5);
            //
            //engine.AddObject(trail);

            //9. Test the UnpassableBlock and the UnstopableBall by adding them to the engine in AcademyPopcornMain.cs file.
            //for (int i = 5; i < 20; i++)
            //{
            //    UnpassableBlock unpassableBlock = new UnpassableBlock(new MatrixCoords(8, i));
            //
            //    engine.AddObject(unpassableBlock);
            //}
            //
            //UnstopableBall theBall = new UnstopableBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));
            //
            //engine.AddObject(theBall);

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            //13. Changed gameEngine from Engine to ShootingEngine.
            ShootingEngine gameEngine = new ShootingEngine(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            //13. Event for shooting.
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
