using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.AccountsModel;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Models.WebsiteModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Context
{
    public class DbSchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;database=dbSchoolSAAS; Trusted_Connection=True;MultipleActiveResultSets=True;trustservercertificate=true;");

            return new SchoolContext(optionsBuilder.Options);
        }//User id=sa;password=123;
    }
    public class SchoolContext:IdentityDbContext<ApplicationUser,Role,string>
    {
        
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Module>().Ignore(m => m.CustomAttributes);

            //modelBuilder.Entity<CustomAttributeData>().HasNoKey();
            base.OnModelCreating(modelBuilder);
            // Additional model configurations can go here
        }
        #region security

        public virtual DbSet<LoginModel> LoginModels { get; set; } = null!;
        #endregion
        public DbSet<Institute> Institutes { get; set; } = null!;
        public DbSet<InstituteType> InstituteTypes { get; set; } = null!;
        public DbSet<InsBranch> InsBranches { get; set; } = null!;
        #region Academic Settings
        public DbSet<AcademicSession> AcademicSessions { get; set; } = null!;
        public DbSet<AcademicDepartment> AcademicDepartments { get; set; } = null!;
        public DbSet<ProgramGroup> ProgramGroups { get; set; } = null!;
        public DbSet<Program1> Programs { get; set; } = null!;
        public DbSet<AcademyClass> AcademyClasses { get; set; } = null!;
        public DbSet<SubjectInfo> SubjectInfos { get; set; } = null!;
        public DbSet<EducationalGroup> EducationalGroups { get; set; } = null!;
        public DbSet<ClassSubjectInst> ClassWiseSubjects { get; set; } = null!;
        public DbSet<Shift> Shifts { get; set; } = null!;
        public DbSet<ClassSection> ClassSections { get; set; } = null!;
        public DbSet<ClassSubjecTeacherIns> ClassSubjecTeacherIns { get; set; } = null!;
        public DbSet<ShiftwiseClass> ShiftwiseClasses { get; set; } = null!;

        #endregion

        #region Employee Settings
            public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<AdministrativeDepartment> AdministrativeDepartments { get; set; } = null!;
        public DbSet<Designation> Designations { get; set; } = null!;
        public DbSet<Religion> Religions { get; set; } = null!;
        public  DbSet<EmployeesGroup> EmployeesGroups { get; set; } = null!;
        public DbSet<EmployeeWithGroup> EmployeeWithGroups { get; set; } = null!;
        public DbSet<Directors> Directors { get; set; } = null!;
        public DbSet<Staff> Staffs { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<EmployeeExperience> EmployeeExperiences { get; set; } = null!;
        public DbSet<EmployeesEducation> EmployeesEducations { get; set; } = null!;
        public  DbSet<EmployeeSalary> EmployeeSalaries { get; set; } = null!;
        public DbSet<EmployeeQualification> EmployeeQualification { get; set; } = null!;
        #endregion 
        #region Accounts Settings
        public DbSet<ShareHolderInformation> ShareHolderInformations { get; set; } = null!;
        public DbSet<AccountChart> AccountCharts { get; set; } = null!;
        public DbSet<AccountGroupTop> AccountGroupTops { get; set; } = null!;
        public DbSet<AccountGroupMid> AccountGroupMides { get; set; } = null!;
        public DbSet<AccountGroupLower> AccountGroupLowers { get; set; } = null!;
        public DbSet<ClassWiseFee>ClassWiseFees { get; set; } = null!;
        public DbSet<TransactionMaster> TransactionMasters { get; set; } = null!;
        public DbSet<TransactionDetails> TransactionDetails { get; set; } = null!;
        public DbSet<VoucherType> VoucherTypes { get; set; } = null!;
        //public DbSet<ShareHolderTransaction> ShareHolderTransactions { get; set; } = null!;
        //public DbSet<ShareHolderTransactionDetails> ShareHolderTransactionDetails { get; set; } = null!;
        //    public DbSet<ShareHolderTransactionType> ShareHolderTransactionTypes { get; set; } = null!;
        #endregion

        #region Student Settings
        public DbSet<StudentBasicInfo> StudentBasicInfos { get; set; } = null!;
        public DbSet<StdtAcademicInfo> StdtAcademicInfos { get; set; } = null!;
        #endregion

        #region Student PAyment
        public DbSet<StdPayment> StdPayments { get; set; } = null!;
        public DbSet<StdInvoice> StdInvoices { get; set; } = null!;
        public DbSet<StdPaymentSettings> StdPaymentSettings { get; set; } = null!;
        public DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;

        #endregion

        #region Exam
        public DbSet<ExamType> ExamTypes { get; set; } = null!;
        public DbSet<ExamTitle> ExamTitles { get; set; } = null!;
        public DbSet<MarksEntry> MarksEntries { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;
       public DbSet<Result> Results { get; set; } = null!;
        public DbSet<ExamwithSubject> ExamwithSubject { get; set; } = null!;
        public DbSet<ExamAttendance> ExamAttendances { get; set; } = null!;

        public DbSet<ExamRoutine> ExamRoutines { get; set; } = null!;

        #endregion

        #region website
        public DbSet<PhotoGallery> PhotoGalleries { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<MediaCat> MediaCats { get; set; } = null!;
        public DbSet<Message> Messages   { get; set; } = null!;
        public DbSet<Room> Room { get; set; } = null!;
        public DbSet<RulesRegulation> RulesRegulation { get; set; } = null!;
        public DbSet<MissionVission> MissionVission { get; set; } = null!;
        public DbSet<VideoGallery> VideoGalleries { get; set; } = null!;
        public DbSet<SocialMedia> SocialMedia { get; set; } = null!;
        public DbSet<History> History { get; set; } = null!;
        public DbSet<Facility> Facility { get; set; } = null!;
        public DbSet<ClassRoutine> ClassRoutines { get; set; } = null!;
        public DbSet<BookList> BookLists { get; set; } = null!;
        public DbSet<Album> Albums { get; set; } = null!;
        public DbSet<AboutUs> AboutUs { get; set; } = null!;
        public DbSet<Achievements> Achievements { get; set; } = null!;
        #endregion
    }
}
