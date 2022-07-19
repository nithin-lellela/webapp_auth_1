using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace webapp_auth_1.Pages
{
    [Authorize(Policy = "MustBelongsToHROnly")]
    public class HumanResourceModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
