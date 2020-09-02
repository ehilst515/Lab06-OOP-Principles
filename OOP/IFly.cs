using System;
namespace OOP
{
    public interface IFly
    {
        public int FlightDistance { get; }
        public int FlightSpeed { get; }

        string Movement();
    }
}
