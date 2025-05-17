using System;
using System.Collections.Generic;

namespace HotelReservationApp
{
    class Room
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string name, double price, int personCapacity)
        {
            if (string.IsNullOrWhiteSpace(name) || price <= 0 || personCapacity <= 0)
                throw new ArgumentException("Room details are invalid");

            Id = ++_idCounter;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = true;
        }

        public string ShowInfo()
        {
            return $"Room ID: {Id}\nName: {Name}\nPrice: {Price} AZN\nCapacity: {PersonCapacity} person(s)\nAvailable: {IsAvailable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }

    class Hotel
    {
        public string Name { get; set; }
        private List<Room> rooms;

        public Hotel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Hotel name cannot be empty");

            Name = name;
            rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            if (room != null)
                rooms.Add(room);
        }

        public void MakeReservation(int roomId)
        {
            Room room = rooms.Find(r => r.Id == roomId);
            if (room == null)
            {
                Console.WriteLine("Room not found!");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is Full!");
            }
            else
            {
                room.IsAvailable = false;
                Console.WriteLine("Reservation successful.");
            }
        }

        public void ShowAllRooms()
        {
            if (rooms.Count == 0)
            {
                Console.WriteLine("No rooms in the hotel.");
                return;
            }

            foreach (var room in rooms)
            {
                Console.WriteLine(room);
                Console.WriteLine("----------------------");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = null;
            Room createdRoom = null;

            while (true)
            {
                Console.WriteLine("\n1. Create a room");
                Console.WriteLine("2. Add room");
                Console.WriteLine("3. Make reserve");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Enter room name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter room price: ");
                            double price = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter person capacity: ");
                            int capacity = Convert.ToInt32(Console.ReadLine());

                            createdRoom = new Room(name, price, capacity);
                            Console.WriteLine("Room created successfully:\n" + createdRoom);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case "2":
                        if (hotel == null)
                        {
                            Console.Write("Enter hotel name: ");
                            string hotelName = Console.ReadLine();
                            try
                            {
                                hotel = new Hotel(hotelName);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                break;
                            }
                        }

                        if (createdRoom != null)
                        {
                            hotel.AddRoom(createdRoom);
                            Console.WriteLine("Room added to hotel.");
                            createdRoom = null; // clear after adding
                        }
                        else
                        {
                            Console.WriteLine("Please create a room first.");
                        }
                        break;

                    case "3":
                        if (hotel == null)
                        {
                            Console.WriteLine("Hotel not initialized.");
                            break;
                        }

                        hotel.ShowAllRooms();
                        Console.Write("Enter Room ID to reserve: ");
                        if (int.TryParse(Console.ReadLine(), out int roomId))
                        {
                            hotel.MakeReservation(roomId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid room ID.");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
