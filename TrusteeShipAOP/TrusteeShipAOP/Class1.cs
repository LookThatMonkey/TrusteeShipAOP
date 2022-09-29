using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrusteeShipAOP.Core;
using TrusteeShipAOP.Core.Attribute;

namespace TrusteeShipAOP
{
    [ClassAspect]
    public class Class1
    {
        static int s1 = 0;

        [DemoPropertyAspect]
        public int aabbc { get; set; } = 0;
        protected int ia = 0;
        int ic = 11;
        int ib = 22;
        [DemoMethodAspect]
        public int Add(int i1, int i2)
        {
            s1 = 2;
            ib = s1;
            aa(0, 0);
            aa2(0, 0);
            aabbc = 1;
            return i1 + i2;
        }

        private int aa(int i1, float f2)
        {
            return 123;
        }

        private static int aa2(int i1, float f2)
        {
            return 123;
        }
    }

    class DemoMethodAspectAttribute : AspectAttribute
    {
        public override void OnEntry(object sender, AspectEventArgs args)
        {
            args.Name = "OnEntry " + args.Name;
            Form1.OnEntry?.Invoke(sender, args);
        }

        public override void OnExit(object sender, AspectEventArgs args)
        {
            args.Name = "OnExit " + args.Name;
            Form1.OnExit?.Invoke(sender, args);
        }
    }

    class DemoPropertyAspectAttribute : AspectAttribute
    {
        public override void OnEntry(object sender, AspectEventArgs args)
        {
            args.Name = "OnEntry " + args.Name;
            Form1.OnEntry?.Invoke(sender, args);
        }

        public override void OnExit(object sender, AspectEventArgs args)
        {
            args.Name = "OnExit " + args.Name;
            Form1.OnExit?.Invoke(sender, args);
        }
    }
}
