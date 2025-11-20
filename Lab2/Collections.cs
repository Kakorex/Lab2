using System.Collections;
using System.Numerics;

namespace Lab2
{
    public class Collections
    {
        Circle circle1 = new Circle("Red", "Black", 5);
        Circle circle2 = new Circle("Blue", "White", 2.5);
        Circle circle3 = new Circle("Green", "Gray", 1.5);
        Circle circle4 = new Circle("Yellow", "Red", 3.14);
        Circle circle5 = new Circle("Purple", "Yellow", 5.12);
        Circle circle6 = new Circle("Pink", "White", 2.18);

        Circle findCircle = new Circle("White", "Black", 1);

        public void Arrays()
        {
            Circle[] circlesArray = new Circle[6];

            //Adding
            circlesArray[0] = circle1;
            circlesArray[1] = circle2;
            circlesArray[2] = circle3;
            circlesArray[3] = circle4;
            circlesArray[4] = circle5;
            circlesArray[5] = circle6;

            Array.Sort(circlesArray);

            //Traversing a data set
            foreach (Circle c in circlesArray)
            {
                Console.WriteLine(c.ToString());
            }

            //Deleting
            Array.Resize(ref circlesArray, 5);

            //Updating
            circlesArray[2] = new Circle("White", "Black", 1);

            Console.WriteLine("Array after updating:");
            foreach(Circle c in circlesArray)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine($"Searching for {findCircle.ToString()}");
            bool found = false;
            foreach(Circle c in circlesArray)
            {
                if (c.Equals(findCircle))
                {
                    Console.WriteLine($"Element found:\n{c.ToString()}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element not found");
            }
        }

        public void GenericCollection()
        {
            List<Circle> circlesList = new List<Circle>();

            //Adding
            circlesList.Add(circle1);
            circlesList.Add(circle2);
            circlesList.Add(circle3);
            circlesList.Add(circle4);
            circlesList.Add(circle5);
            circlesList.Add(circle6);

            circlesList.Sort();

            //Traversing a data set
            foreach (Circle c in circlesList)
            {
                Console.WriteLine(c.ToString());
            }

            //Deleting
            circlesList.Remove(circle3);

            //Updating
            circlesList[2] = new Circle("White", "Black", 1);

            Console.WriteLine("List after updating:");
            foreach (Circle c in circlesList)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine($"Searching for {findCircle.ToString()}");
            if (circlesList.Contains(findCircle))
            {
                Console.WriteLine($"Element found:\n{findCircle.ToString()}");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
        public void NonGenericCollection()
        {
            ArrayList arrayList = new ArrayList();

            //Adding
            arrayList.Add(circle1);
            arrayList.Add(circle2);
            arrayList.Add(circle3);
            arrayList.Add(circle4);
            arrayList.Add(circle5);
            arrayList.Add(circle6);

            arrayList.Sort();

            //Traversing a data set
            foreach (Circle c in arrayList)
            {
                Console.WriteLine(c.ToString());
            }

            //Deleting
            arrayList.Remove(circle3);

            //Updating
            arrayList[2] = new Circle("White", "Black", 1);

            Console.WriteLine("ArrayList after updating:");
            foreach (Circle c in arrayList)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine($"Searching for {findCircle.ToString()}");
            if (arrayList.Contains(findCircle))
            {
                Console.WriteLine($"Element found:\n{findCircle.ToString()}");
            }
            else
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
