using DocumentsService.Data;
using DocumentsService.Models;
using Microsoft.Exchange.WebServices.Data;
using Task = System.Threading.Tasks.Task;

namespace DocumentsService.Services
{
    public class DocumentService
    {
        private readonly DocumentContext _context;

        public DocumentService(DocumentContext context)
        {
            _context = context;
        }

        public async Task<Document> GetDocumentByIdAsync(int id)
        {
            return await _context.Documents.FindAsync(id);
        }

        public async Task CreateDocumentAsync(Document document)
        {
            _context.Documents.Add(document);
            await _context.SaveChangesAsync();
        }

        public async Task<ServiceResponse> UpdateDocumentAsync(int id, Document document)
        {
            // Logic for updating document and saving history
        }
    }

}
