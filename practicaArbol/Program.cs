using System.Xml.Linq;
using practicaArbol;
using static practicaArbol.Class1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        Node n5 = new Node(5);
        Node n6 = new Node(6);
        Node n7 = new Node(7);
        Node n8 = new Node(8);
        Node n9 = new Node(9);
        Node n10 = new Node(10);
        Node n11 = new Node(11);
        Node n12 = new Node(12);
        Node n13 = new Node(13);
        Node n14 = new Node(14);

        n1.Insert(n2);
        n1.Insert(n3, "right");

        n2.Insert(n4);
        n2.Insert(n5, "right");

        n3.Insert(n7);
        n3.Insert(n8, "right");

        n4.Insert(n6);
        n4.Insert(n9, "right");

        n7.Insert(n10, "right");

        n8.Insert(n11, "right");

        n9.Insert(n12);

        n11.Insert(n14);

        n12.Insert(n13, "right");

        n1.RemoveDefinitive(n5);

        n1.Transverse("inorder");

        n1.Height();

        n1.Search(13);

        n1.printTreeDefinitive();

    }
}