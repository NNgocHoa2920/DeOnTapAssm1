using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WEB_ONTAP.Models;

namespace WEB_ONTAP.Configuration
{
    public class DuAnConfig : IEntityTypeConfiguration<DuAn>
    {
        public void Configure(EntityTypeBuilder<DuAn> builder)
        {
            //builder.HasKey(x => x.MaDA);
        }
    }
}
