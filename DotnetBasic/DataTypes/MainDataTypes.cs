using DataTypes.Abstract;
using DataTypes.CustomType;
using DataTypes.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public override string ToString()
        {
            return "Coord (" + x + "," + y + ")";
        }
    }
    public class MainDataType
    {
        public static void Main()
        {
            SampleEnum();
            Console.WriteLine();
            SampleClass();
            Console.WriteLine();
            BankAccountSample();
            Console.WriteLine();
            ShapeExample();
        }
        #region Abstract Example Shape
        public static void ShapeExample()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(5), new Circle(3) };
            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                                  $"perimeter, {Shape.GetPerimeter(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                if (shape is Square sq)
                {
                    Console.WriteLine($"   Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }
        #endregion

        #region Sample BankAccount
        public static void BankAccountSample()
        {
            var account = new BankAccount("Richcy", 500000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            var account2 = new BankAccount("Shidqi", 30000000000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");
            var account3 = new BankAccount("Ningsih", 75000000);
            Console.WriteLine($"Account {account3.Number} was created for {account3.Owner} with {account3.Balance} initial balance.");
        }
        #endregion

        #region Sample Class
        public static void SampleClass()
        {
            SampleClass sampleClass;

            sampleClass = new SampleClass();
            Console.WriteLine("After call constructor");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass(3, 6);
            Console.WriteLine("After call constructor with params");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());
        }
        #endregion

        #region Sample Enum
        public static void SampleEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Days: {0}", item);
            }
            Type fieldModel = typeof(EnumFileMode);
            foreach (var item in Enum.GetNames(fieldModel))
            {
                Console.WriteLine("FieldMode: {0}", item);
            }
            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Color Red: {0}, GetName: {1}", Colors.Red, Enum.GetName(Colors.Red));
            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));
        }
        #endregion

        #region Sample Coords
        public static void SampleCoords()
        {
            Coords point1 = new Coords(2, 5);
            Console.WriteLine("Point 1: " + point1);
            Coords point2 = new Coords(5, 5);
            Console.WriteLine("Point 2: " + point2);
        }
        #endregion

        #region Sample Data Types
        public static void SampleDataTypes()
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 13, 15, 18, 21 };
            //ini linQ
            var query = from item in source where item <= limit select item;
            Console.WriteLine("Query Result: " + query);
            foreach (var item in query)
            {
                Console.WriteLine("Item value: " + item);
            }
            var query2 = from item in source where item % 2 == 1 select item;
            Console.WriteLine("Write item with odd");
            foreach (var item in query2)
            {
                Console.WriteLine("item value: " + item);
            }
            var query3 = from item in source where item % 2 == 0 select item;
            Console.WriteLine("Write item with even");
            foreach (var item in query3)
            {
                Console.WriteLine("item value: " + item);
            }
            var query4 = from item in source where item % 3 == 0 select item;
            Console.WriteLine("Write item with multiple 3");
            foreach (var item in query4)
            {
                Console.WriteLine("Item value: " + item);
            }
            #endregion
        }
    }
}
