using System;
namespace InterfacesAndAbstractClasses
{
    public interface IFeline
    {
        string Type { get; set; }
        bool IsShortHair { get; set; }
        bool CanPurr { get; set; }
        bool HasKittens { get; set; }
        bool HasNails { get; set; }

        public string ScratchFurniture(string furniture)
        {
            return "I scratched all the things";
        }

    }
}
