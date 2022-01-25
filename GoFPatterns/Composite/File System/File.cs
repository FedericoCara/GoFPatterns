using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Composite {
    public class File : Component
    {
        int size;

        public File(string name, int size) : base(name)
        {
            this.size = size;
        }

        public override int Size
        {
            get
            {
                return size;
            }
        }
    }
}
