namespace SamFirstWeek.Models
{
    public class HomeViewModel
    {
        public List<KeyValuePair<int, string>> basic  { get; set; }
        public List<KeyValuePair<int, string>> delux { get; set; }
        public List<KeyValuePair<int, string>> total { get; set; }
    }
}
