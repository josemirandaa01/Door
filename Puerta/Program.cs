using System;

namespace Puerta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorOpen = false;
            bool doorLock = true;

        OpenDoor(doorOpen);
        //CloseDoor(doorOpen);
        }

        static bool OpenDoor(bool doorOpen)
        {
            if (doorOpen == true)
            {
                throw new ArgumentException("error", nameof(doorOpen));
                
            }
            if (doorOpen == false)
            {
                return true;
            }

            return false;
        }

        static bool CloseDoor(bool doorOpen)
        {
            if (doorOpen == true)
            {
                return false;
            }
            if (doorOpen == false)
            {
                throw new ArgumentException("error", nameof(doorOpen));
                
            }

            return false;
        }
    }
}
