using CareerGuidance.Data;
using CareerGuidance.Data.Entity;
using CareerGuidance.DataAccess.Data.Interface;
using CareerGuidance.DataAccess.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess
{
    public interface IDataAccessFacade
    {
        public IBlogCommentData BlogCommentData { get; }
        public IBlogData BlogData { get; }
        public IChapterData ChapterData { get;      }
        public ICourseData CourseData { get; }
        public IIndustryData IndustryData { get; }
        public ILessonData LessonData { get; }
        public IMentorData MentorData { get; }
        public IResourceData ResourceData { get; }
        public IUserData UserData { get; }
        public IUserEnrollCourseData UserEnrollCourseData { get; }
        public IUserEnrollWorkshopData UserEnrollWorkshop { get; } 
        public IWorkshopData WorkshopData { get; }
        public IWorkshopReviewData WorkshopReviewData { get; }
        public IEmailVerificationData EmailVerificationData { get; }    
        public IRefreshTokenData RefreshTokenData { get; }
        public Task<bool> CommitAsync();
    }

    public class DataAccessFacade : IDataAccessFacade
    {
        private readonly CareerGuidanceDBContext _context;

        public DataAccessFacade(CareerGuidanceDBContext context)
        {
            _context = context;
        }

        private BlogCommentData _blogCommentData;
        public IBlogCommentData BlogCommentData
        {
            get
            {
                _blogCommentData ??= new BlogCommentData(_context);
                return _blogCommentData;
            }
        }
        private BlogData _blogData;
        public IBlogData BlogData
        {
            get
            {
                _blogData ??= new BlogData(_context);
                return _blogData;
            }
        }
        private ChapterData _chapterData;
        public IChapterData ChapterData
        {
            get
            {
                _chapterData ??= new ChapterData(_context);
                return _chapterData;
            }
        }

        private CourseData _courseData;
        public ICourseData CourseData
        {
            get
            {
                _courseData ??= new CourseData(_context);
                return _courseData;
            }
        }
        private IndustryData _industryData;
        public IIndustryData IndustryData
        {
            get
            {
                _industryData ??= new IndustryData(_context);
                return _industryData;
            }
        }
        public ILessonData LessonData
        {
            get
            {
                return new LessonData(_context);
            }
        }
        private MentorData _mentorData;
        public IMentorData MentorData
        {
            get
            {
                _mentorData ??= new MentorData(_context);
                return _mentorData;
            }
        }
      
        private ResourceData _resourceData;
        public IResourceData ResourceData
        {
            get
            {
                _resourceData ??= new ResourceData(_context);
                return _resourceData;
            }
        }

        private UserData _userData;
        public IUserData UserData
        {
            get
            {
                _userData ??= new UserData(_context);
                return _userData;
            }
        }
        private UserEnrollCourseData _userEnrollCourseData;
        public IUserEnrollCourseData UserEnrollCourseData
        {
            get
            {
                _userEnrollCourseData ??= new UserEnrollCourseData(_context);
                return _userEnrollCourseData;
            }
        }

        private UserEnrollWorkshopData _userEnrollWorkshop;
        public IUserEnrollWorkshopData UserEnrollWorkshop
        {
            get
            {
                _userEnrollWorkshop ??= new UserEnrollWorkshopData(_context);
                return _userEnrollWorkshop;
            }
        }
        private WorkshopData _workshopData;
        public IWorkshopData WorkshopData
        {
            get
            {
                _workshopData ??= new WorkshopData(_context);
                return _workshopData;
            }
        }
        private WorkshopReviewData _workshopReviewData;
        public IWorkshopReviewData WorkshopReviewData
        {
            get
            {
                _workshopReviewData ??= new WorkshopReviewData(_context);
                return _workshopReviewData;
            }
        }
        private EmailVerificationData _emailVerificationData;
        public IEmailVerificationData EmailVerificationData
        {
            get
            {
                _emailVerificationData ??= new EmailVerificationData(_context);
                return _emailVerificationData;
            }
        }

        private RefreshTokenData _refreshTokenData;
        public IRefreshTokenData RefreshTokenData { 
            get
            {
                _refreshTokenData ??= new RefreshTokenData(_context);
                return _refreshTokenData;
            }
        }

        public async Task<bool> CommitAsync()
        {
            if (!_context.ChangeTracker.HasChanges()) return false;
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
