using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Email { get; set; }

    public string Message { get; private set; }

    public void OnGet()
    {
        // Initialization code, if any.
    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            Message = $"Thank you, {Name}. We have received your message.";
        }
    }
}
