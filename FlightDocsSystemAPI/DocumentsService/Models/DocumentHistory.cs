namespace DocumentsService.Models
{
    public class DocumentHistory
    {
        public int HistoryID { get; set; }
        public int DocumentID { get; set; }
        public Document Document { get; set; }
        public DateTime ChangeDate { get; set; }
        public int ChangedBy { get; set; }
        public string OldContent { get; set; }
        public string NewContent { get; set; }
    }
}
