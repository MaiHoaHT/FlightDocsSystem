namespace DocumentsService.Models
{
    public class DocumentPermission
    {
        public int PermissionID { get; set; }
        public int DocumentTypeID { get; set; }
        public DocumentType DocumentType { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public bool CanView { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanConfirm { get; set; }
    }
}
