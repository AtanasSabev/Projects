using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoomSize = double.Parse(Console.ReadLine());
            double kitchensize = double.Parse(Console.ReadLine());
            double priceOfM = double.Parse(Console.ReadLine());

            double bathRoomSize = smallestRoomSize / 2;
            double secondRoomSize = smallestRoomSize + smallestRoomSize * 10 / 100;
            double thirdRoomSize = secondRoomSize + secondRoomSize * 10 / 100;

            double allRooms = smallestRoomSize + kitchensize + bathRoomSize + secondRoomSize + thirdRoomSize;
            double apartmentSize = allRooms + allRooms * 5 / 100;
            double apartmentPrice = apartmentSize * priceOfM;

            Console.WriteLine("{0:F2}", apartmentPrice );


        }
    }
}
