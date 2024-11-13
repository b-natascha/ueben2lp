namespace ueben2lp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class DrawObject
    {
        public abstract void accept(Visitor visitor);
    }
}