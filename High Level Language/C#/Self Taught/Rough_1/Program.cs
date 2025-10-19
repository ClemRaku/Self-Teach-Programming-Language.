using System;
namespace Hotel_Reservation
{
    //Create 'Room' 'Reservation' and 'guest' classes to manage a hotel.

    public class Room
    {
        public bool Available;
        public int Room_Number;

        public Room(int roomNO, bool availability)
        {
            Room_Number = roomNO;
            Available = availability;
        }

        public void BookRoom()
        {
            Available = false;
        }
        public void FreeRoom()
        {
            Available = true;
        }
    }


    public class Guest
    {
        public string Name{get; set;}
        public Guest(string name)
        {
            Name = name;
        }
    }

        public class Reservation
    {
        Room room{get; set;}
        Guest guest{get; set;}
        public Reservation(Guest GUEST, Room basha )
        {
            room = basha;
            guest = GUEST;
            if(room.Available)
        {
            Console.WriteLine($"Room {room.Room_Number}, Assigned to current Guest, {guest.Name}.");
            room.BookRoom();
        }
        else
        {
            Console.WriteLine($"Room {room.Room_Number} is Unavailable. Sorry {guest.Name}.");
        }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Room VIP = new Room(110, true);
            Room middle_class = new Room(105, false);
            Room poor_class = new Room(03, true);

            Guest one = new Guest("Raka");
            Guest two = new Guest("Debottom");

            Reservation today = new Reservation(one, VIP);
            Reservation tommorow = new Reservation(two, middle_class);


        }
    }

}