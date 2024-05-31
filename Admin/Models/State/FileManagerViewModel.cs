namespace Admin.Models.State
{
    public class FileManagerViewModel
    {
        public IEnumerable<string> Directories { get; set; }
        public IEnumerable<string> Files { get; set; }
    }
}
