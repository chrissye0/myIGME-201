using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Q8_10
{
    // Author: Christine Espeleta
    // Purpose: Unit Test 2 Questions #8-10. Create a data model based on one of my favorite hobbies.
    // Restrictions: N/A
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of the 2 child classes
            Digital digitalArt = new Digital();
            Physical physicalArt = new Physical();
            // Call MakeArt method, which demonstrates polymorphism and accepts an object as a parameter
            MakeArt(digitalArt);
            MakeArt(physicalArt);
        }

        static void MakeArt(object obj)
        {
            // If the object is of the Digital class
            if(obj.GetType() == typeof(Digital))
            {
                // Call the IDigital interface and the Digital class methods
                IDigital artInterface = (IDigital)obj;
                artInterface.Undo();
                Digital digital = (Digital)obj;
                digital.Draw();
            }
            // If the object is of the Physical class
            if (obj.GetType() == typeof(Physical))
            {
                // Call the IPhysical interface and Physical class methods
                IPhysical artInterface = (IPhysical)obj;
                artInterface.Sketch();
                Physical physical = (Physical)obj;
                physical.Draw();
            }
        }
    }

    // Public IDigital interface (corresponds with Digital class)
    public interface IDigital
    {
        void Draw();
        void Share();
        void Undo();
        void Redo();
    }

    // Public IPhysical interface (corresponds with Physical class)
    public interface IPhysical
    {
        void Draw();
        void Share();
        void Sketch();
        void Erase();
    }

    // Abstract class ArtMediums
    // Contains an abstract method and a virtual method
    public abstract class ArtMediums
    {
        public abstract void Draw();
        public virtual void Share()
        {
            Console.WriteLine("Sharing art!");
        }
    }

    // Public child class Digital (inherits from ArtMediums abstract class and IDigital interface)
    // Contains a property and method overrides (polymorphism)
    public class Digital: ArtMediums, IDigital
    {
        public string tablet;
        public void Undo()
        {
            Console.WriteLine("Ctrl+Z!");
        }

        public void Redo()
        {
            Console.WriteLine("Ctrl+Y!");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing digitally!");
        }

        public override void Share()
        {
            Console.WriteLine("Sharing an art file!");
        }
    }

    // Public child class Physical (inherits from ArtMediums abstract class and IPhysical interface)
    // Contains properties and method overrides (polymorphism)
    public class Physical: ArtMediums, IPhysical
    {
        public bool ink;
        public bool paint;

        public void Sketch()
        {
            Console.WriteLine("Sketching with pencil!");
        }

        public void Erase()
        {
            Console.WriteLine("Using an eraser!");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing on paper!");
        }

        public override void Share()
        {
            Console.WriteLine("Sharing paper sketches with friends!");
        }
    }
}
