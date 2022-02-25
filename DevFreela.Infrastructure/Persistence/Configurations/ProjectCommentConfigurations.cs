using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectCommentConfigurations : IEntityTypeConfiguration<ProjectComment>
    {
        public void Configure(EntityTypeBuilder<ProjectComment> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id);

            modelBuilder
                .HasOne(p => p.Project)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.IdUser);

        }
    }
}
