﻿namespace GalaxyStorm.ViewModels.Fleet
{
    using Logic.Core.Ships;

    public class UnitViewModel
    {
        public UnitViewModel()
        {
        }

        public UnitViewModel(int onPlanet, int dispatched, IShip ship)
        {
            this.Name = ship.Name;
            this.Description = ship.Description;
            this.Attack = ship.Attack;
            this.Armor = ship.Armor;
            this.BuildTime = ship.BuildTime.TotalMinutes;
            this.CargoCapacity = ship.CargoCapacity;

            var requiredResources = ship.RequiredResourcesToBuild;
            this.RequiredEnergy = requiredResources[0];
            this.RequiredCrystals = requiredResources[1];
            this.RequiredMetal = requiredResources[2];

            this.AmountDispatched = dispatched;
            this.AmountOnPlanet = onPlanet;
        }

        public UnitViewModel(int onPlanet, int dispatched, string shipName)
        {
            this.Name = shipName;

            this.AmountDispatched = dispatched;
            this.AmountOnPlanet = onPlanet;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Attack { get; set; }

        public int Armor { get; set; }

        public int CargoCapacity { get; set; }

        public int Prerequisite { get; set; }

        public double BuildTime { get; set; }

        public int RequiredEnergy { get; set; }

        public int RequiredCrystals { get; set; }

        public int RequiredMetal { get; set; }

        public int AmountOnPlanet { get; set; }

        public int AmountDispatched { get; set; }
    }
}