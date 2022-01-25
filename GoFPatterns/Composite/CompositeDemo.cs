using GoFPatterns.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Composite {
    public class CompositeDemo : IGoFPatternDemo {

        public void Run() {
            Folder root = new Folder("root");

            Component file1 = new File("file1.txt", 10);
            Component file2 = new File("file2.txt", 30);
            Component file3 = new File("file3.txt", 120);
            Component file4 = new File("file4.txt", 800);
            Component file5 = new File("file5.txt", 340);

            Component file6 = new File("file6.txt", 122);
            Component file7 = new File("file7.txt", 391);


            Folder dir1 = new Folder("dir1");
            Folder dir2 = new Folder("dir2");
            Folder dir3 = new Folder("dir3");

            dir1.AddChildComponent(file1);
            dir1.AddChildComponent(file6);
            dir2.AddChildComponent(file2);
            dir3.AddChildComponent(file3);
            dir3.AddChildComponent(file4);
            dir1.AddChildComponent(dir3);

            root.AddChildComponent(dir1);
            root.AddChildComponent(dir2);
            root.AddChildComponent(file5);
            root.AddChildComponent(file7);

            PrintSize(root);
            PrintSize(dir1);
            PrintSize(dir2);
            PrintSize(dir3);
            PrintSize(file1);
            PrintSize(file7);
        }
        private void PrintSize(Component component) {
            Console.WriteLine($"The size of {component.Name} folder is {component.Size}");
        }
    }
}
