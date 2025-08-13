namespace ApiProjectKampi.WebApi.Dtos.FeatureDtos
{
    public class GetByIdFeatureDto
    {
        public int FeatureId { get; set; }
        public String Title { get; set; }
        public String SubTitle { get; set; }
        public String Description { get; set; }
        public String VideoUrl { get; set; }
        public String ImageUrl { get; set; }

    }
}
