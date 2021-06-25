using System;
namespace InterfacesAndAbstractClasses
{
    public class Cat : IAnimal, IFeline
    {
        public Cat()
        {
        }

        public string Name { get ; set ; }
        public int Weight { get ; set ; }
        public bool HasMouth { get ; set ; }
        public string Type { get ; set ; }
        public bool IsShortHair { get ; set; }
        public bool CanPurr { get ; set ; }
        public bool HasKittens { get ; set; }
        public bool HasNails { get; set; }

        public void Consume()
        {
            
        }

        public void MakeNoise()
        {
            
        }
        //This is how you override Interface default Implementations
        string IFeline.ScratchFurniture(string furniture)
        {
            //By Default this is added :) 
            // throw new NotImplementedException();
            //if (HasNails)
            //{
            //    return $"I scratched the {furniture}";
            //}
            //else
            //{
            //    return "sike";
            //}
            //Turnary Operator :) 
            return HasNails ? $"I scratched the {furniture}" : "Sike";
        }
    }
}
