using AutoMapper;
using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.Data;
using CareerGuidance.Shared.Util;
using Microsoft.EntityFrameworkCore;

namespace CareerGuidance.WebAPI.Extension
{
    public static class MigrationExtension
    {
        public static async void ApplyMigrations(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<CareerGuidanceDBContext>();
            await dbContext.Database.MigrateAsync();
            await Seed(dbContext);
        }
        public static async Task Seed(CareerGuidanceDBContext context)
        {
            var password = SecretUtil.HashPassword("123456");

            // Seed Industries
            var isExisIndustry = await context.User.AnyAsync();

            // --- Seed Industry nếu chưa có ---
            if (isExisIndustry) return;
            context.Industry.AddRange(
                new Industry { Id = 1, Name = "IT", Icon = "pi-microsoft" },
                new Industry { Id = 2, Name = "Finance And Accounting", Icon = "pi-money-bill" },
                new Industry { Id = 3, Name = "Design", Icon = "pi-palette" },
                new Industry { Id = 4, Name = "Film", Icon = "pi-video" },
                new Industry { Id = 5, Name = "Edu", Icon = "pi-graduation-cap" }
            );

            //Seed Users
            var isExistUser = await context.User.AnyAsync();
            if (isExistUser) return;

            var users = new List<User>
            {   
            // --- Admin ---
            new User
            {
                Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                FirstName = "Duc",
                LastName = "Nguyen",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(1995, 5, 20),
                Email = "admin@gmail.com",
                PhoneNumber = "0909000000",
                Password = password,
                Role = RoleType.Admin,
                Status = AccountStatusType.Verified,
                Position = "Administrator",
                YOE = 8,
                IndustryId = 1,
                Description = ""
            },

            // --- Students ---
            new User
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb01"),
                FirstName = "Minh", LastName = "Tran",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(2002, 3, 14),
                Email = "minh.tran@gmail.com",
                PhoneNumber = "0901000001",
                Password = password,
                Role = RoleType.Student,
                Status = AccountStatusType.Verified,
                Position = "Student",
                YOE = 0,
                IndustryId = 1, // IT,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb02"),
                FirstName = "Lan", LastName = "Pham",
                Gender = GenderType.Female,
                DateOfBirth = new DateTime(2001, 8, 22),
                Email = "lan.pham@gmail.com",
                PhoneNumber = "0901000002",
                Password = password,
                Role = RoleType.Student,
                Status = AccountStatusType.Verified,
                Position = "Student",
                YOE = 0,
                IndustryId = 2, // Finance,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb03"),
                FirstName = "Huy", LastName = "Le",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(2000, 12, 5),
                Email = "huy.le@gmail.com",
                PhoneNumber = "0901000003",
                Password = password,
                Role = RoleType.Student,
                Status = AccountStatusType.Verified,
                Position = "Student",
                YOE = 0,
                IndustryId = 3, // Design,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb04"),
                FirstName = "Thu", LastName = "Nguyen",
                Gender = GenderType.Female,
                DateOfBirth = new DateTime(2003, 6, 10),
                Email = "thu.nguyen@gmail.com",
                PhoneNumber = "0901000004",
                Password = password,
                Role = RoleType.Student,
                Status = AccountStatusType.Verified,
                Position = "Student",
                YOE = 0,
                IndustryId = 4, // Film,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb05"),
                FirstName = "Khoa", LastName = "Do",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(2002, 11, 2),
                Email = "khoa.do@gmail.com",
                PhoneNumber = "0901000005",
                Password = password,
                Role = RoleType.Student,
                Status = AccountStatusType.Verified,
                Position = "Student",
                YOE = 0,
                IndustryId = 5, // Edu,
                Description = ""

            },

            // --- Mentors ---
            new User
            {
                Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccc01"),
                FirstName = "Anh", LastName = "Vo",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(1985, 4, 9),
                Email = "anh.vo@mentor.com",
                PhoneNumber = "0912000001",
                Password = password,
                Role = RoleType.Mentor,
                Status = AccountStatusType.Verified,
                Position = "Senior Software Engineer",
                YOE = 12,
                IndustryId = 1,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccc02"),
                FirstName = "Hoa", LastName = "Nguyen",
                Gender = GenderType.Female,
                DateOfBirth = new DateTime(1988, 9, 18),
                Email = "hoa.nguyen@mentor.com",
                PhoneNumber = "0912000002",
                Password = password,
                Role = RoleType.Mentor,
                Status = AccountStatusType.Verified,
                Position = "Finance Manager",
                YOE = 10,
                IndustryId = 2,
                Description = ""

            },
            new User
            {
                Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccc03"),
                FirstName = "Quang", LastName = "Pham",
                Gender = GenderType.Male,
                DateOfBirth = new DateTime(1983, 7, 30),
                Email = "quang.pham@mentor.com",
                PhoneNumber = "0912000003",
                Password = password,
                Role = RoleType.Mentor,
                Status = AccountStatusType.Verified,
                Position = "Creative Director",
                YOE = 15,
                IndustryId = 3,
                Description = ""

            }
        };

            context.User.AddRange(users);
            context.SaveChanges();
        }
    }

}
