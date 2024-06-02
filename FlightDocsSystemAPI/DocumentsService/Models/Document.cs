namespace DocumentsService.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
        public int DocumentTypeID { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public int? ConfirmedBy { get; set; }
        public ICollection<DocumentHistory> DocumentHistories { get; set; }
    }
}
