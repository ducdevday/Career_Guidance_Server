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
        public IAddressData AddressData { get; }
        public IBlogCommentData BlogCommentData { get; }
        public IBlogData BlogData { get; }
        public IChapterData ChapterData { get;      }
        public ICompanyData CompanyData { get; }
        public ICourseData CourseData { get; }
        public IIndustryData IndustryData { get; }
        public ILessonData LessonData { get; }
        public IMentorData MentorData { get; }
        public IQnACommentData QnACommentData { get; }
        public IQnACommentInteractionData QnACommentInteractionData { get; }
        public IQnAPostData QnAPostData { get; }
        public IQnAPostInteractionData QnAPostInteractionData { get; }
        public IResourceData ResourceData { get; }
        public ISchoolData SchoolData { get; } 
        public ITourData TourData { get; }
        public ITourReviewData TourReviewData { get; }
        public IUserData UserData { get; }
        public IUserEnrollCourseData UserEnrollCourseData { get; }
        public IUserEnrollTourData UserEnrollTourData { get; }
        public IUserEnrollWorkshopData UserEnrollWorkshop { get; } 
        public IWorkshopData WorkshopData { get; }
        public IWorkshopReviewData WorkshopReviewData { get; }
        public Task Commit();
    }

    public class DataAccessFacade : IDataAccessFacade
    {
        private readonly CareerGuidanceDBContext _context;

        public DataAccessFacade(CareerGuidanceDBContext context)
        {
            _context = context;
        }

        private AddressData _addressData;
        public IAddressData AddressData
        {
            get { 
                _addressData ??= new AddressData(_context);
                return _addressData;
            }
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
        private CompanyData _companyData;
        public ICompanyData CompanyData
        {
            get
            {
                _companyData ??= new CompanyData(_context);
                return _companyData;
            }
        }
        private CompanyIndustryData _companyIndustryData;
        public ICompanyIndustryData CompanyIndustryData
        {
            get
            {
                _companyIndustryData ??= new CompanyIndustryData(_context);
                return _companyIndustryData;
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
        private QnACommentData _qnaCommentData;
        public IQnACommentData QnACommentData
        {
            get
            {
                _qnaCommentData ??= new QnACommentData(_context);
                return _qnaCommentData;
            }
        }
        private QnACommentInteractionData _qnaCommentInteractionData;
        public IQnACommentInteractionData QnACommentInteractionData
        {
            get
            {
                _qnaCommentInteractionData ??= new QnACommentInteractionData(_context);
                return _qnaCommentInteractionData;
            }
        }
        private QnAPostData _qnaPostData;
        public IQnAPostData QnAPostData
        {
            get
            {
                _qnaPostData ??= new QnAPostData(_context);
                return _qnaPostData;
            }
        }
        private QnAPostInteractionData _qnaPostInteractionData;
        public IQnAPostInteractionData QnAPostInteractionData
        {
            get
            {
                _qnaPostInteractionData ??= new QnAPostInteractionData(_context);
                return _qnaPostInteractionData;
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
        private SchoolData _schoolData;
        public ISchoolData SchoolData
        {
            get
            {
                _schoolData ??= new SchoolData(_context);
                return _schoolData;
            }
        }
        public ISchoolIndustryData SchoolIndustryData
        {
            get
            {
                return new SchoolIndustryData(_context);
            }
        }
        public ITourData TourData
        {
            get
            {
                return new TourData(_context);
            }
        }
        private TourReviewData _tourReviewData;
        public ITourReviewData TourReviewData
        {
            get
            {
                _tourReviewData ??= new TourReviewData(_context);
                return _tourReviewData;
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
        private UserEnrollTourData _userEnrollTourData;
        public IUserEnrollTourData UserEnrollTourData
        {
            get
            {
                _userEnrollTourData ??= new UserEnrollTourData(_context);
                return _userEnrollTourData;
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

        public Task Commit()
        {
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
