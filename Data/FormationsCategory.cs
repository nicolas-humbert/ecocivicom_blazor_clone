using Newtonsoft.Json;

namespace ecocivicom_blazor_clone.Data
{
    public class FormationsCategory
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string? Description { get; set; }

        [JsonConstructor]
        public FormationsCategory(int id, string image, string slug, string? description)
        {
            Id = id;
            Image = image;
            Slug = slug;
            Description = description ?? String.Empty;
        }
        public FormationsCategory(int id, string image, string slug)
        {
            Id = id;
            Image = image;
            Slug = slug;
        }

        static public List<FormationsCategory> ParseAndCreateFormationsCategories()
        {
            List<FormationsCategory>? json = EcoJsonParser.ReadInitialDataJson<FormationsCategory>("Data/formations_categories.json");

            List<FormationsCategory> datas = new();

            if (json != null)
            {
                foreach (var cat in json)
                {
                    FormationsCategory fc = new(cat.Id, cat.Image, cat.Slug, cat.Description);
                    datas.Add(fc);
                }
            }

            return datas;
        }
    }
}