namespace DataAccess.Entites
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public byte[] Photo { get; set; }
    }
}
