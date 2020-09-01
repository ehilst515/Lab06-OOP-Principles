using System;
namespace OOP
{
    public interface ISwim
    {
        int SwimDistance { get; }
        int SwimSpeed { get; }
        string Swim();
    }
}
