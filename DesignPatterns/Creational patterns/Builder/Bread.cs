using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_patterns.Builder
{
    internal class Bread
    {
        public Salt? Salt { get; set; }
        public Flour? Flour { get; set; }
        public Additive? Additive { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Bread is baked with: ");

            if (Salt is not null)
            {
                sb.Append("Salt\n");
            }

            if (Flour is not null)
            {
                sb.Append("Flour type: " + Flour.Type + "\n");
            }

            if (Additive is not null)
            {
                sb.Append("Additive name: " + Additive.Name + "\n");
            }

            return sb.ToString();
        }


    }
}
