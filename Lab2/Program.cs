using System;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Collections collections = new Collections();

            Console.WriteLine("*** Storing using array ***");
            collections.Arrays();

            Console.WriteLine("\n*** Storing using generic collection ***");
            collections.GenericCollection();

            Console.WriteLine("\n*** Storing using arrays non-generic collection ***");
            collections.NonGenericCollection();

            Console.WriteLine("\n*** Storing using binary tree ***");
            BinaryTree<Circle> tree = new BinaryTree<Circle>();

            tree.Add(new Circle("Red", "Black", 5));
            tree.Add(new Circle("Blue", "White", 2.5));
            tree.Add(new Circle("Green", "Gray", 1.5));
            tree.Add(new Circle("Yellow", "Red", 3.14));
            tree.Add(new Circle("Purple", "Yellow", 5.12));
            tree.Add(new Circle("Pink", "White", 2.18));

            Console.WriteLine("Pre-order tree traversal");
            tree.PreOrder();
            tree.Print();

            Console.WriteLine("Traversing using foreach");
            foreach (var circle in tree)
            {
                Console.WriteLine(circle.ToString());
            }
        }
    }
}