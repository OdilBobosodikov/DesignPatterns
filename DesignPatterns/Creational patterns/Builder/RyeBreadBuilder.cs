using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Builder
{
    internal class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            this.Bread.Additive = new Additive { Name = "Baking soda" };
        }

        public override void SetFlour()
        {
            this.Bread.Flour = new Flour { Type = "Rye" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }
    }
}
