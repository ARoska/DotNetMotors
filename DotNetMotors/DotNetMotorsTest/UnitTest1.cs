using DotNetMotors.Classes;
using System;
using Xunit;
using static DotNetMotors.Program;

namespace DotNetMotorsTest
{
    public class UnitTest1
    {
        [Fact]
        public void BRZHas2Doors()
        {
            BRZ brz = new BRZ();

            Assert.Equal(2, brz.NumberOfDoors);
        }

        [Fact]
        public void BRZCanHave4Doors()
        {
            BRZ brz = new BRZ();
            brz.NumberOfDoors = 4;

            Assert.Equal(4, brz.NumberOfDoors);
        }

        [Fact]
        public void BRZHas4Wheels()
        {
            BRZ brz = new BRZ();

            Assert.Equal(4, brz.NumberOfWheels);
        }

        [Fact]
        public void BRZCanHave5Wheels()
        {
            BRZ brz = new BRZ();
            brz.NumberOfWheels = 5;

            Assert.Equal(5, brz.NumberOfWheels);
        }

        [Fact]
        public void BRZHasCorrectCost()
        {
            BRZ brz = new BRZ();

            Assert.Equal(50000, brz.Cost);
        }

        [Fact]
        public void BRZCanCostEvenMore()
        {
            BRZ brz = new BRZ();
            brz.Cost = 75000;

            Assert.Equal(75000, brz.Cost);
        }

        [Fact]
        public void BRZHasNoBackSeatSpace()
        {
            BRZ brz = new BRZ();

            Assert.False(brz.BackseatSpace);
        }

        [Fact]
        public void BRZCanSomehowMagicallyHaveBackSeatSpace()
        {
            BRZ brz = new BRZ();
            brz.BackseatSpace = true;

            Assert.True(brz.BackseatSpace);
        }

        [Fact]
        public void BRZHasHorn()
        {
            BRZ brz = new BRZ();

            Assert.True(brz.HasHorn);
        }

        [Fact]
        public void BRZHasBrokenHorn()
        {
            BRZ brz = new BRZ();
            brz.HasHorn = false;

            Assert.False(brz.HasHorn);
        }

        [Fact]
        public void BRZIsSelfPropelled()
        {
            BRZ brz = new BRZ();

            Assert.True(brz.SelfPropelled);
        }

        [Fact]
        public void BRZIsNotGoingAnywhere()
        {
            BRZ brz = new BRZ();
            brz.SelfPropelled = false;

            Assert.False(brz.SelfPropelled);
        }

        [Fact]
        public void TurcellHas2Doors()
        {
            Turcell turcell = new Turcell();

            Assert.Equal(2, turcell.NumberOfDoors);
        }

        [Fact]
        public void TurcellCanHave3Doors()
        {
            Turcell turcell = new Turcell();
            turcell.NumberOfDoors = 3;

            Assert.Equal(3, turcell.NumberOfDoors);
        }

        [Fact]
        public void TurcellHas4Wheels()
        {
            Turcell turcell = new Turcell();

            Assert.Equal(4, turcell.NumberOfWheels);
        }

        [Fact]
        public void TurcellCanHave3Wheels()
        {
            Turcell turcell = new Turcell();
            turcell.NumberOfWheels = 3;

            Assert.Equal(3, turcell.NumberOfWheels);
        }

        [Fact]
        public void TurcellHasCorrectCost()
        {
            Turcell turcell = new Turcell();

            Assert.Equal(2000, turcell.Cost);
        }

        [Fact]
        public void TurcellCanCostEvenLess()
        {
            Turcell turcell = new Turcell();
            turcell.Cost = 500;

            Assert.Equal(500, turcell.Cost);
        }

        [Fact]
        public void TurcellHasBackSeatSpace()
        {
            Turcell turcell = new Turcell();

            Assert.True(turcell.BackseatSpace);
        }

        [Fact]
        public void TurcellCanHaveFullBackSeat()
        {
            Turcell turcell = new Turcell();
            turcell.BackseatSpace = false;

            Assert.False(turcell.BackseatSpace);
        }

        [Fact]
        public void TurcellHasHorn()
        {
            Turcell turcell = new Turcell();

            Assert.True(turcell.HasHorn);
        }

        [Fact]
        public void TurcellHasBrokenHorn()
        {
            Turcell turcell = new Turcell();
            turcell.HasHorn = false;

            Assert.False(turcell.HasHorn);
        }

        [Fact]
        public void TurcellIsSelfPropelled()
        {
            Turcell turcell = new Turcell();

            Assert.True(turcell.SelfPropelled);
        }

        [Fact]
        public void TurcellIsBroken()
        {
            Turcell turcell = new Turcell();
            turcell.SelfPropelled = false;

            Assert.False(turcell.SelfPropelled);
        }

        [Fact]
        public void CamryHas4Doors()
        {
            Camry camry = new Camry();

            Assert.Equal(4, camry.NumberOfDoors);
        }

        [Fact]
        public void CamryCanHave2Doors()
        {
            Camry camry = new Camry();
            camry.NumberOfDoors = 2;

            Assert.Equal(2, camry.NumberOfDoors);
        }

        [Fact]
        public void CamryHas4Wheels()
        {
            Camry camry = new Camry();

            Assert.Equal(4, camry.NumberOfWheels);
        }

        [Fact]
        public void CamryCanHave2Wheels()
        {
            Camry camry = new Camry();
            camry.NumberOfWheels = 2;

            Assert.Equal(2, camry.NumberOfWheels);
        }

        [Fact]
        public void CamryHasCorrectCost()
        {
            Camry camry = new Camry();

            Assert.Equal(15000, camry.Cost);
        }

        [Fact]
        public void CamryCanCostLess()
        {
            Camry camry = new Camry();
            camry.Cost = 10000;

            Assert.Equal(10000, camry.Cost);
        }

        [Fact]
        public void CamryHasHorn()
        {
            Camry camry = new Camry();

            Assert.True(camry.HasHorn);
        }

        [Fact]
        public void CamryHasBrokenHorn()
        {
            Camry camry = new Camry();
            camry.HasHorn = false;

            Assert.False(camry.HasHorn);
        }

        [Fact]
        public void CamryIsSelfPropelled()
        {
            Camry camry = new Camry();

            Assert.True(camry.SelfPropelled);
        }

        [Fact]
        public void CamryIsBroken()
        {
            Camry camry = new Camry();
            camry.SelfPropelled = false;

            Assert.False(camry.SelfPropelled);
        }

        [Fact]
        public void MotorcycleHas2Wheels()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.Equal(2, motorcycle.NumberOfWheels);
        }

        [Fact]
        public void MotorcycleHas3Wheels()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.NumberOfWheels = 3;

            Assert.Equal(3, motorcycle.NumberOfWheels);
        }

        [Fact]
        public void MotorcycleHasCorrectCost()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.Equal(24000, motorcycle.Cost);
        }

        [Fact]
        public void MotorcycleCanCostEvenMore()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Cost = 35000;

            Assert.Equal(35000, motorcycle.Cost);
        }

        [Fact]
        public void MotorcycleRequiresLicense()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.True(motorcycle.RequiresLicense);
        }

        [Fact]
        public void MotorcycleDoesNotRequreLicenseInSomeCountries()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.RequiresLicense = false;

            Assert.False(motorcycle.RequiresLicense);
        }

        [Fact]
        public void MotorcycleIsSelfPropelled()
        {
            Motorcycle motorcycle = new Motorcycle();

            Assert.True(motorcycle.SelfPropelled);
        }

        [Fact]
        public void MotorcycleCannotGoOnOwn()
        {
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.SelfPropelled = false;
            Assert.False(motorcycle.SelfPropelled);
        }

        [Fact]
        public void MountainBikeHas2Wheels()
        {
            MountainBike mountainBike = new MountainBike();

            Assert.Equal(2, mountainBike.NumberOfWheels);
        }

        [Fact]
        public void MountainBikeHas4Wheels()
        {
            MountainBike mountainBike = new MountainBike();
            mountainBike.NumberOfWheels = 4;

            Assert.Equal(4, mountainBike.NumberOfWheels);
        }

        [Fact]
        public void MountainBikeHasCorrectCost()
        {
            MountainBike mountainBike = new MountainBike();

            Assert.Equal(250, mountainBike.Cost);
        }

        [Fact]
        public void MountainBikeCanCostMore()
        {
            MountainBike mountainBike = new MountainBike();
            mountainBike.Cost = 500;

            Assert.Equal(500, mountainBike.Cost);
        }

        [Fact]
        public void MountainBikeDoesNotRequiresLicense()
        {
            MountainBike mountainBike = new MountainBike();

            Assert.False(mountainBike.RequiresLicense);
        }

        [Fact]
        public void MountainBikeRequresLicense()
        {
            MountainBike mountainBike = new MountainBike();
            mountainBike.RequiresLicense = true;

            Assert.True(mountainBike.RequiresLicense);
        }

        [Fact]
        public void MountainBikeIsNotSelfPropelled()
        {
            MountainBike mountainBike = new MountainBike();

            Assert.False(mountainBike.SelfPropelled);
        }

        [Fact]
        public void MountainBikeCanGoOnOwn()
        {
            MountainBike mountainBike = new MountainBike();
            mountainBike.SelfPropelled = true;

            Assert.True(mountainBike.SelfPropelled);
        }

    }
}
