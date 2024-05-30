using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Створення першого покоління
            Virus parentVirus = new Virus(1.2, 5, "Parent Virus", "Type A");

            // Створення другого покоління
            Virus childVirus1 = new Virus(0.8, 3, "Child Virus 1", "Type A");
            Virus childVirus2 = new Virus(0.9, 2, "Child Virus 2", "Type A");

            parentVirus.AddChild(childVirus1);
            parentVirus.AddChild(childVirus2);

            // Створення третього покоління
            Virus grandChildVirus1 = new Virus(0.5, 1, "Grandchild Virus 1", "Type A");
            Virus grandChildVirus2 = new Virus(0.4, 1, "Grandchild Virus 2", "Type A");

            childVirus1.AddChild(grandChildVirus1);
            childVirus2.AddChild(grandChildVirus2);

            // Клонування віруса-батька
            Virus clonedParentVirus = (Virus)parentVirus.Clone();

            // Виведення інформації про оригінальний та клонований віруси
            Console.WriteLine("Original Virus Family:");
            parentVirus.PrintInfo();

            Console.WriteLine("\nCloned Virus Family:");
            clonedParentVirus.PrintInfo();
            Console.ReadKey();
        }
    }
}
