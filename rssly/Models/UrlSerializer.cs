namespace RSSly.Backend.Models
{
    public class UrlSerializer : ScalarSerializer<String>
    {
        public UrlSerializer()
            : base(
                // the name of the scalar
                "URL")
        {
        }
    }

}
