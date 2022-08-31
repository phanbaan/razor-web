using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor02.Models;

namespace razor02.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly BlogContext _context;

    public IndexModel(ILogger<IndexModel> logger, BlogContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {
        var posts = (from a in _context.articles
                     orderby a.Created descending
                     select a).ToList();

        ViewData["posts"] = posts;
    }
}
