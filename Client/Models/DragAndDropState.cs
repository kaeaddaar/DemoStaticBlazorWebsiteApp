using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Models
{
    public class DragAndDropState<T>
    {
        public T OnDragStart { get; set; }
        public T OnDragEnter { get; set; }
        public override string ToString()
        {
            return $"OnDragStart: \"{OnDragStart.ToString() ?? string.Empty}\", OnDragEnter: \"{OnDragEnter.ToString() ?? string.Empty}\"";
        }
    }
}
