using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Interceptors;
using CareerGuidance.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data
{
    public class CareerGuidanceDBContext : DbContext
    {
        private readonly EnviromentSetting _setting = EnviromentSetting.Instance;
        private readonly AuditSaveChangesInterceptor _auditInterceptor = new AuditSaveChangesInterceptor();
        public CareerGuidanceDBContext()
        : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CareerGuidanceDBContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_setting.ConnectionString);
            optionsBuilder.AddInterceptors(_auditInterceptor);
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogComment> BlogComment { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Industry> Industry { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<QnAComment> QnAComment { get; set; }
        public DbSet<QnAPost> QnAPost { get; set; }
        public DbSet<QnAPostInteraction> QnAPostInteraction { get; set; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Tour> Tour { get; set; }
        public DbSet<TourReview> TourReview { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserEnrollCourse> UserEnrollCourse { get; set; }
        public DbSet<UserEnrollTour> UserEnrollTour { get; set; }
        public DbSet<UserEnrollWorkshop> UserEnrollWorkshop { get; set; }
        public DbSet<CompanyIndustry> UserIndustry { get; set; }
        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<WorkshopReview> WorkshopReview { get; set; }
        public DbSet<EmailVerification> EmailVerification { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Template> Template { get; set; }
        public DbSet<TemplateVersion> TemplateVersion { get; set; }
        public DbSet<TemplateField> TemplateField { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
    }
}
