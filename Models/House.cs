namespace bcw_2023summer_gregslist_csharp.Models
{
    public class House
    {
        public int Id { get; set; }
        public int? Sqft { get; set; }
        public int? Bedrooms { get; set; }
        public double? Bathrooms { get; set; }
        public string ImgUrl {get; set;}
        public string Description {get; set;}
        public int? Price {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}