using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Boat : Vehicle 
    {
        private double waterDrag;

        public Boat(int seats, int carryCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryCapacity = carryCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }

    }
}
