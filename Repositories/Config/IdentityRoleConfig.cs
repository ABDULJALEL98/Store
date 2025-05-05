using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole(){ Id ="0a8b26a8-9be7-45a2-a9cf-ab783a954392",  Name="User", NormalizedName="USER"},
                new IdentityRole(){ Id="596e30e3-ded6-4d3b-96cd-a49327b6f295", Name="Editor", NormalizedName="EDITOR"},
                new IdentityRole(){ Id ="d70f3f17-da73-4f65-93a1-deab68c23c86", Name="Admin", NormalizedName="ADMIN"}
            );
        }
    }

}