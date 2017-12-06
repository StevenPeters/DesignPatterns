using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override List<string> Display(int depth)
        {
            List<string> list = new List<string>();
            list.Add(new String(' ', depth) + name);

            foreach (Component component in children)
            {
                foreach (string s in component.Display(depth + 3))
                {
                    list.Add(s);
                }
            }

            return list;
        }
    }
}
