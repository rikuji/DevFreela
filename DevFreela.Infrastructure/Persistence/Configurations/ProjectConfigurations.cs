using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id);

            modelBuilder
                 .HasOne(p => p.Freelancer)
                 .WithMany(f => f.FreelanceProjects)
                 .HasForeignKey(p => p.IdFreelancer)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(p => p.Client)
                .WithMany(f => f.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
