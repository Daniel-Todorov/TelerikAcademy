using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TradeAndTravel
{
    public class Engine
    {

        protected InteractionManager interactionManager;

        public Engine(InteractionManager interactionManager)
        {
            this.interactionManager = interactionManager;
        }

        public void ParseAndDispatch(string command)
        {
            this.interactionManager.HandleInteraction(command.Split(' '));
        }

        public void Start()
        {
            bool endCommandReached = false;
            StreamReader reader = new StreamReader("test.txt");
            using (reader)
            {
                while (!endCommandReached)
                {
                    string command = reader.ReadLine();
                    if (command != "end")
                    {
                        this.ParseAndDispatch(command);
                    }
                    else
                    {
                        endCommandReached = true;
                    }
                }
            }
        }
        //public void Start()
        //{
        //    bool endCommandReached = false;
        //    while (!endCommandReached)
        //    {
        //        string command = Console.ReadLine();
        //        if (command != "end")
        //        {
        //            this.ParseAndDispatch(command);
        //        }
        //        else
        //        {
        //            endCommandReached = true;
        //        }
        //    }
        //}
    }
}
