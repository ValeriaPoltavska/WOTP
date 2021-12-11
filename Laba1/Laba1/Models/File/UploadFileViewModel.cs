using Microsoft.AspNetCore.Http;

namespace Laba1.Models.File
{
    public class UploadFileViewModel
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
