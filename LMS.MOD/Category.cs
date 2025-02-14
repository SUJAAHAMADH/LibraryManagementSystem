
namespace LMS.MOD
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int? ParentID { get; set; }
        public int UserID { get; set; }
        public string ParentName { get; set; }

    }
}
