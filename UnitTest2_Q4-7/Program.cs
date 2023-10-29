using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q4_7
{
    // Author: Christine Espeleta
    // Purpose: Unit Test 2: Questions #4-7
    // Convert yUML to C#
    // Restrictions: N/A
    internal class Program
    {
        static void Main(string[] args)
        {
            // #6-7
            // Create Tardis and PhoneBooth objects
            // Pass each object to the UsePhone method
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);

        }

        static void UsePhone(object obj)
        {
            // UsePhone method that takes an object as a parameter
            // Use PhoneInterface to call MakeCall and HangUp methods
            // Depending on object type, if it is a PhoneBooth call OpenDoor and if it is Tardis call TimeTravel
            PhoneInterface phoneInterface = (PhoneInterface)obj;
            phoneInterface.MakeCall();
            phoneInterface.HangUp();

            if (obj.GetType() == typeof(PhoneBooth)) {
                PhoneBooth phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }

            if (obj.GetType() == typeof(Tardis))
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
    }
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }
        public abstract void Connect();
        public abstract void Disconnect();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return this.whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return this.femaleSideKick;
            }
        }

        public void TimeTravel()
        {

        }

        // #5 - overload boolean operators
        // If whichDrWho == 10, that numbered Dr Who is greater than any other Dr Who
        public static bool operator ==(Tardis DrWhoA, Tardis DrWhoB)
        {
            return DrWhoA.whichDrWho == DrWhoB.whichDrWho;
        }

        public static bool operator !=(Tardis DrWhoA, Tardis DrWhoB)
        {
            return DrWhoA.whichDrWho != DrWhoB.whichDrWho;
        }

        public static bool operator >(Tardis DrWhoA, Tardis DrWhoB)
        {
            if ((DrWhoA.whichDrWho == 10) && (DrWhoB.whichDrWho != 10))
            {
                return true;
            }
            else if ((DrWhoB.whichDrWho == 10) && (DrWhoA.whichDrWho != 10))
            {
                return false;
            }
            else
            {
                return DrWhoA.whichDrWho > DrWhoB.whichDrWho;
            }
        }
        public static bool operator <(Tardis DrWhoA, Tardis DrWhoB)
        {
            if ((DrWhoA.whichDrWho == 10) && (DrWhoB.whichDrWho != 10))
            {
                return false;
            }
            else if ((DrWhoB.whichDrWho == 10) && (DrWhoA.whichDrWho != 10))
            {
                return true;
            }
            else
            {
                return DrWhoA.whichDrWho < DrWhoB.whichDrWho;
            }
        }

        public static bool operator <=(Tardis DrWhoA, Tardis DrWhoB)
        {
            if ((DrWhoA.whichDrWho == 10) && (DrWhoB.whichDrWho != 10))
            {
                return false;
            }
            else if ((DrWhoB.whichDrWho == 10) && (DrWhoA.whichDrWho != 10))
            {
                return true;
            }
            else
            {
                return DrWhoA.whichDrWho <= DrWhoB.whichDrWho;
            }
        }

        public static bool operator >=(Tardis DrWhoA, Tardis DrWhoB)
        {
            if ((DrWhoA.whichDrWho == 10) && (DrWhoB.whichDrWho != 10))
            {
                return true;
            }
            else if ((DrWhoB.whichDrWho == 10) && (DrWhoA.whichDrWho != 10))
            {
                return false;
            }
            else
            {
                return DrWhoA.whichDrWho >= DrWhoB.whichDrWho;
            }
        }
    }



    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }
}
