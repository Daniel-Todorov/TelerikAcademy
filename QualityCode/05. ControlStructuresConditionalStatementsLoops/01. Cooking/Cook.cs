﻿using System;

class Cook
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable vegitable)
        {

        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            Bowl bowl = GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }
    }
}
