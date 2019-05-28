﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MyCompanyName.MyProjectName.Pages
{
    public class IndexModel : MyProjectNamePageModelBase
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}