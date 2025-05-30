using System;
using System.Collections.Generic;

namespace KendoNET.DynamicLinq
{
    public class GroupSelector<TElement>
    {
        public Func<TElement, object> Selector { get; set; } = _ => new object();
        public string Field { get; set; } = string.Empty;
        public IEnumerable<Aggregator> Aggregates { get; set; } = [];
    }
}
