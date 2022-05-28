using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implementation
{
    internal class IsAssignableFromProgram : IProgram
    {
        public void Run()
        {
            // Demonstrate classes:
            Console.WriteLine("Defined Classes:");
            Room room1 = new Room();
            Kitchen kitchen1 = new Kitchen();
            Bedroom bedroom1 = new Bedroom();
            Guestroom guestroom1 = new Guestroom();
            MasterBedroom masterbedroom1 = new MasterBedroom();

            Type room1Type = room1.GetType();
            Type kitchen1Type = kitchen1.GetType();
            Type bedroom1Type = bedroom1.GetType();
            Type guestroom1Type = guestroom1.GetType();
            Type masterbedroom1Type = masterbedroom1.GetType();

            Console.WriteLine("room assignable from kitchen: {0}", room1Type.IsAssignableFrom(kitchen1Type));
            Console.WriteLine("bedroom assignable from guestroom: {0}", bedroom1Type.IsAssignableFrom(guestroom1Type));
            Console.WriteLine("kitchen assignable from masterbedroom: {0}", kitchen1Type.IsAssignableFrom(masterbedroom1Type));
            Console.WriteLine("room assignable from guestroom: {0}", room1Type.IsAssignableFrom(guestroom1Type));
        }
    }

    internal class MasterBedroom : Bedroom
    {
    }

    internal class Guestroom : Bedroom
    {
    }

    internal class Bedroom : Room
    {
    }

    internal class Kitchen :Room
    {
    }

    internal class Room
    {
    }
}
