using System.Collections.Generic;

namespace MultiThemeService.Server.Modal
{
    public record Tenant(int Id, string Host, bool IsActive, string ThemeName);

    public class TenantService
    {
        public List<Tenant> GetTenants()
        {
            return new List<Tenant>
            {
                new Tenant(1, "foo", true, "theme1"),
                new Tenant(2, "bar", true, "theme2"),
            };
        }
    }
}
