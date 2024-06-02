namespace DocumentsService.Models
{
    public class DocumentType
    {
        public int DocumentTypeID { get; set; }
        public string TypeName { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<DocumentPermission> DocumentPermissions { get; set; }
    }
}
