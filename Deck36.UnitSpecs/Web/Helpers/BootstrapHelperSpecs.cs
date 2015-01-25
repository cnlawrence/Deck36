using System.Web;
using Deck36.Web.Helpers;
using NUnit.Framework;
using SpecsFor;
using SpecsFor.Helpers.Web.Mvc;

namespace Deck36.UnitSpecs.Web.Helpers
{
    public class BootstrapHelperSpecs
    {
        public class when_creating_a_bootstrap_label : SpecsFor<FakeHtmlHelper>
        {
            private IHtmlString _label;

            protected override void When()
            {
                _label = SUT.BootstrapLabel("FirstName");
            }

            [Test]
            public void then_it_creates_label()
            {
                _label.ToHtmlString();
            }
        }
    }
}