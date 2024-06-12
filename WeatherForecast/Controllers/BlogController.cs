using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Index()
        {
            
            var posts = new List<BlogPostViewModel>
            {
                new BlogPostViewModel { Id = 1, Title = "პირველი ბლოგი", Content = "ეს არის ბლოგის პირველი პოსტი." },
                new BlogPostViewModel { Id = 2, Title = "მეორე ბლოგი", Content = "ეს არის ბლოგის მეორე პოსტი." }
               
            };

            return View(posts);
        }

        
        public IActionResult Details(int id)
        {
            
            var post = new BlogPostViewModel { Id = id, Title = "ბლოგი", Content = "ეს არის ბლოგის პოსტის ნიმუში" };

            return View(post);
        }
    }
}
