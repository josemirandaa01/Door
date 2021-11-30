using System;

namespace Puerta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doorOpen = true;
            bool doorLock = false;

        OpenDoor(doorOpen);
        CloseDoor(doorOpen);
         LockDoor(doorLock);
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

        static bool LockDoor(bool doorLock)
        {
            if (doorLock == true)
            {
                throw new ArgumentException("error", nameof(doorLock));
            }
            if (doorLock == false)
            {
                return true;
            }

            return false;
        }

        static bool unlockDoor(bool doorLock)
        {
            if (doorLock == true)
            {
                return false;
            }
            if (doorLock == false)
            {
                throw new ArgumentException("error", nameof(doorLock));
            }
            return false;
        }
    }
}
