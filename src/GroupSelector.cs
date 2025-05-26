using System;
using System.Collections.Generic;

namespace KendoNET.DynamicLinq
{
    public class GroupSelector<TElement>
    {
        public Func<TElement, object>? Selector { get; set; }
        public string Field { get; set; } = string.Empty;
        public IEnumerable<Aggregator> Aggregates { get; set; } = [];
    }
}
