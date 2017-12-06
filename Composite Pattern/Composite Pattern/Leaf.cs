using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite_Pattern
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
        }

        public override void Remove(Component c)
        {
        }

        public override List<string> Display(int depth)
        {
            List<string> list = new List<string>();
            list.Add(new String(' ', depth) + name);

            return list;
        }
    }
}
