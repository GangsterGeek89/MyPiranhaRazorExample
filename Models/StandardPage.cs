using MyPiranhaExamples.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using System.Collections.Generic;

namespace MyPiranhaExamples.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [PageType(Title = "Standard Page")]
    [PageTypeRoute(Title = "Default", Route = "/page")]
    public class StandardPage : Page<StandardPage>
    {
        [Region(Title = "Hero")]
        public Hero Hero { get; set; }

        [Region(ListTitle = "Testimonials")]
        public IList<TestimonialRegion> Testimonials { get; set; }
    }
}
