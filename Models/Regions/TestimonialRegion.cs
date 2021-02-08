using Piranha.Extend;
using Piranha.Extend.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPiranhaExamples.Models.Regions
{
    public class TestimonialRegion
    {
        [Field(Title = "Title")]
        public StringField Title { get; set; }

        [Field(Title = "Image")]
        public ImageField Image { get; set; }

        [Field(Title = "Body")]
        public TextField Body { get; set; }
    }
}
