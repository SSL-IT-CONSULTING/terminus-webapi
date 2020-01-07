using Microsoft.AspNetCore.Identity;

namespace terminus_webapi.Entities
{
    public class TerminusAppUser:IdentityUser
    {
        public Company company { get; set; }
    }
}