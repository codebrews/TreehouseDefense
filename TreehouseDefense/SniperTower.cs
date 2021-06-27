using System;
namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 1;

        public SniperTower(MapLocation location) : base(location)
        {
        }
    }
}
