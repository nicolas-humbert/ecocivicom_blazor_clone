using Newtonsoft.Json;

namespace ecocivicom_blazor_clone.Data
{
    public class EcoJsonParser
    {
        static public List<T>? ReadInitialDataJson<T>(string url)
        {
            StreamReader sr = new(url);

            List<T>? json = JsonConvert.DeserializeObject<List<T>>(sr.ReadToEnd());

            return json;
        }

    }
}