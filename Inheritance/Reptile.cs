using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsWarmBlooded { get; set; }
        public bool HasToughSkin { get; set; }
        public bool IsAmphibian { get; set; }
        public string EvolutionaryAdvantage { get; set; }

        public Reptile()
        {

        }

        public Reptile(string name, double age, bool isHealthy, int extremities, bool isWarmBlooded, bool hasToughSkin, bool isAmphibian, string evolutionaryAdvantange)
        {
            Name = name;
            Age = age;
            IsHealthy = isHealthy;
            Extremities = extremities;
            IsWarmBlooded = isWarmBlooded;
            HasToughSkin = hasToughSkin;
            IsAmphibian = isAmphibian;
            EvolutionaryAdvantage = evolutionaryAdvantange;
        }
    }
}
