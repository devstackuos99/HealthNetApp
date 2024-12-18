using System.Security.Claims;

namespace HealthNet.Business.Infrastructure
{
    public static class Extensions
    {
        public static string GetUsername(this ClaimsPrincipal principal)
        {
            return principal.Claims.Where(c => c.Type == ClaimTypes.Name).FirstOrDefault()?.Value ?? string.Empty;
        }
        public static int GetUserId(this ClaimsPrincipal principal)
        {
            if (principal.Claims.Where(c => c.Type == "Id").FirstOrDefault() != null)
            {
                return int.Parse(principal.Claims.Where(c => c.Type == "Id").FirstOrDefault().Value);
            }

            return 0;
        }
    }
}
