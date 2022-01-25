using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFPatterns.Composite {
    public class Folder : Component
    {
        private List<Component> _children;
        public Folder(string name) : base(name)
        {
            _children = new List<Component>();
        }

        public void AddChildComponent(Component child)
        {
            _children.Add(child);
        }

        public IList<Component> GetChildrenComponents()
        {
            return _children.ToArray();
        }

        public override int Size
        {
            get
            {
                int t = 0;

                foreach (var item in _children)
                {
                    t += item.Size;
                }

                return t;
            }
            
        }
    }
}
