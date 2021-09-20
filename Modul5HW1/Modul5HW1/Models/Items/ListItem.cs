using System.Collections.Generic;

namespace Modul5HW1.Models.Items
{
    public class ListItem<T>
    {
        public int Page { get; set; }
        public int Per_Page { get; set; }
        public int Total { get; set; }
        public int Total_Pages { get; set; }
        public List<T> Data { get; set; }
        public Support Support { get; set; }
    }
}
