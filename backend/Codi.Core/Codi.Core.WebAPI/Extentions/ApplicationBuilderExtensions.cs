using Codi.Core.DAL;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.WebAPI.Extentions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseCodiCoreContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<CodiCoreContext>();
            context?.Database.Migrate();
        }
    }
}
