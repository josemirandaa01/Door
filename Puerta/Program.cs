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
        }

        static bool OpenDoor(bool DoorOpen)
        {
            if (DoorOpen == true)
            {
                throw new ArgumentException("error", nameof(DoorOpen));
                return true;
            }
            if (DoorOpen == false)
            {
                return true;
            }

            return false;
        }
    }
}
