using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ArtifactDecorator : BaseDecorator
    {
        public ArtifactDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Artifact";
        }
    }
}
