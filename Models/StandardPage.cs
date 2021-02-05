using Piranha.AttributeBuilder;
using Piranha.Models;

namespace MyPiranhaExamples.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [PageType(Title = "Standard Page")]
    [PageTypeRoute(Title = "Default", Route = "/page")]
    public class StandardPage : Page<StandardPage>
    {
    }
}
