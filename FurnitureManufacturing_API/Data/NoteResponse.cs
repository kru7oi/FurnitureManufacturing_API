namespace FurnitureManufacturing_API.Data
{
    public class NoteResponse
    {
        public int Id { get; set; }
        public string TitleUser { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string FormattedDate { get; set; } = string.Empty;
    }
}
