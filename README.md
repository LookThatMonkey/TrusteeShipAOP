# TrusteeShipAOP
C# AOP


    [ClassAspect]
    public class Class1
    {
        [DemoMethodAspect]
        public int Add(int i1, int i2)
        {
        }
    }

    class DemoMethodAspectAttribute : MPAspectAttribute
    {
        public override void OnEntry(object sender, AspectEventArgs args)
        {
        }

        public override void OnExit(object sender, AspectEventArgs args)
        {
        }
    }
    
    
     Class1 Class1 = new Class1();
     Class1.Add(1, 1);
