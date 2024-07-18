using CreatePartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreatePartialView.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<Blog> blogs = new List<Blog>() { 
            new Blog{Id=1,Url="../images/slider/s1.jpg",Title="Title 1",Description="Description 1 ...."},
            new Blog{Id=2,Url="../images/slider/s2.jpg",Title="Title 2",Description="Description 2 ...."},
            new Blog{Id=3,Url="../images/slider/s3.jpg",Title="Title 3",Description="Description 3 ...."},
            new Blog{Id=4,Url="../images/slider/s4.jpg",Title="Title 4",Description="Description 4 ...."},
            new Blog{Id=5,Url="../images/slider/s5.jpg",Title="Title 5",Description="Description 5 ...."},
            new Blog{Id=6,Url="../images/slider/s6.jpg",Title="Title 6",Description="Description 6 ...."},
            new Blog{Id=7,Url="../images/slider/s7.jpg",Title="Title 7",Description="Description 7 ...."},
            new Blog{Id=8,Url="../images/slider/s8.jpg",Title="Title 8",Description="Description 8 ...."},
            };
            return View(blogs);
        }
    }
}
