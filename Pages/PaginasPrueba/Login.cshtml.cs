using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PruebasCodigo.Models;

namespace PruebasCodigo.Pages.PaginasPrueba
{
    public class LoginModel : PageModel
    {

        private readonly Context _db;

        public LoginModel(Context db)
        {
            _db = db;
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Add(Cliente);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}