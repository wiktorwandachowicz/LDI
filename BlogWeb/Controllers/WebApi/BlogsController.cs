using BlogData;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BlogWeb.Controllers.WebApi
{
    public class BlogsController : ApiController
    {
        public IEnumerable<Blog> GetAllBlogs()
        {
            using (var repository = new BlogRepository())
            {
                return repository.GetAll()
                    .OrderBy((b) => b.BlogId)
                    .ToList();
            }
        }
    }
}
