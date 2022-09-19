namespace ConsoleApp.Model
{
    /// <summary>
    /// String Request
    /// </summary>
    public class StringRequest
    {
        public int N { get; set; }
        public List<string> Strings { get; set; } = new List<string>();
    }
}