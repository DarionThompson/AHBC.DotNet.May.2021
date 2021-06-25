using System;
namespace InterfacesAndAbstractClasses
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Weight { get; set; }
        bool HasMouth { get; set; }

        void MakeNoise();
        void Consume();
    }
}
