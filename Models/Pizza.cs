namespace LaMiaPizzeria.Models
{
    public class Pizza
    {
   

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Pizza( string title, string description, string image)
        {
            
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
