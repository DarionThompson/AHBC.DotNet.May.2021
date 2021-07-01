using System;
namespace InterfacesAndAbstractClasses
{
    public class Monkey : IAnimal
    {
        public Monkey()
        {
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HasMouth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Consume()
        {
            throw new NotImplementedException();
        }

        public void MakeNoise()
        {
            throw new NotImplementedException();
        }
    }
}
