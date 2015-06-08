using System.Web;
using Deck36.Web.Helpers;
using ExpectedObjects;
using HtmlTags;
using NUnit.Framework;
using Should;
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

        public class when_creating_a_bootstrap_submit_button : SpecsFor<FakeHtmlHelper>
        {
            private HtmlTag _button;
            protected override void When()
            {
                _button = SUT.BootstrapSubmitButton("Submit!");
            }

            [Test]
            public void then_it_creates_submit_button()
            {
                _button.Attr("type").ShouldEqual("submit");
            }

            [Test]
            public void then_it_sets_the_correct_button_classes()
            {
                _button.HasClass("btn").ShouldBeTrue();
                _button.HasClass("btn-primary").ShouldBeTrue();
            }
        }
    }
}