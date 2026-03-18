namespace CEntidades
{
    public class Persona
    {
        public int id { get; set; }
        public int? age { get; set; }
        public string birthdate { get; set; }
        public string gender { get; set; }
        public string name { get; set; }
        public string occupation { get; set; }
        public string portrait_path { get; set; }
        public IList<string> phrases { get; set; }
        public string status { get; set; }
    }
}
