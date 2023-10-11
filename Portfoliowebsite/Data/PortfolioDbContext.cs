using Microsoft.EntityFrameworkCore;
using Portfoliowebsite.Models;

namespace Portfoliowebsite.Data

{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AboutModel> About { get; set; }
        public DbSet<ExperienceModel> Experiences { get; set; }
        public DbSet<EducationModel> Educations { get; set; }
        public DbSet<ProgrammingLanguageModel> ProgrammingLanguages { get; set;}
        public DbSet<WorkFLowModel> WorkFLows { get; set; }
        public DbSet<IntrestModel> Intrests { get; set; }
        public DbSet<AwardAndCertificationModel> AwardAndCertifications { get; set; }
        public DbSet<SocialMediaModel> SocialMedia { get; set; }
        public DbSet<TitleModel> Titles { get; set; }

        internal object SetAsync<T>()
        {
            throw new NotImplementedException();
        }
    }
}
