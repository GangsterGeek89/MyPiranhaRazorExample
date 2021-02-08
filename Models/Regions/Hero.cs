using Piranha.Extend;
using Piranha.Extend.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPiranhaExamples.Models.Regions
{
    public class Hero
    {
        [Field(Title = "Use Page Hero", Placeholder = "Show")]
        public CheckBoxField Show { get; set; }

        [Field(Title = "Leadin")]
        public StringField Leadin { get; set; }

        [Field(Title = "Heading")]
        public StringField Heading { get; set; }

        [Field(Title = "Background Image")]
        public ImageField Image { get; set; }
    }
}
