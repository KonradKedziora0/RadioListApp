using System.ComponentModel.DataAnnotations;

namespace RadioList_v._1._0
{
   public class Station
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Url { get; set; }

    }
}
