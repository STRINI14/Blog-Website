using Blog_Website.Data;
using Blog_Website.Models.Domain;
using Blog_Website.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Website.Controllers
{
    public class AdminTagsController : Controller
    {

        private BlogDbContext _blogDbContext;
        public AdminTagsController(BlogDbContext blogDbContext)
        {
               this._blogDbContext = blogDbContext; 
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

           _blogDbContext.Tags.Add(tag);
           _blogDbContext.SaveChanges();
            return View("Add");
        }
    }
}
