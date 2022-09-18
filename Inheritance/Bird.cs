using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Feathered { get ; set; }
        public bool Flightless { get; set; }
        public string PreferredFood { get; set; }
        public bool LikesWater { get; set; }

        public Bird()
        {

        }

        public Bird(string name, double age, bool isHealthy, int extremities, bool feathered, bool flightless, string preferredFood, bool likesWater)
        {
            Name = name;
            Age = age;
            IsHealthy = isHealthy;
            Extremities = extremities;
            Feathered = feathered;
            Flightless = flightless;
            PreferredFood = preferredFood;
            LikesWater = likesWater;
        }
    }
}
