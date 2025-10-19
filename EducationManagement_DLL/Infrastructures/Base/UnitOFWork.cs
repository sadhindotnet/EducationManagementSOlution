

using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Repositories;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.IdentityModels;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Identity;
using RoyalAPI.Models.AccountModels;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public class UnitOFWork : IUnitOfWork
    {
        public SchoolContext context;
        private readonly IServiceProvider _serviceProvider;

        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        public UnitOFWork(SchoolContext context,  IServiceProvider serviceProvider)
        {
            this.context = context;
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            //_userManager = userManager;
            //_signInManager = signInManager;
             
        }
        private IUserRepo userRepo;
        public IUserRepo UserRepo
        {
            get
            {
                if (userRepo == null)
                {
                    userRepo = new UserRepo(context, _serviceProvider);
                }
                return userRepo;
            }
        }

        private IAcademyClass academyClass;
        public IAcademyClass AcademyClassRepo
        {
            get
            {
                if(academyClass==null)
                {
                    academyClass = new AcademyClassRepo(context);
                }
                return academyClass;
            }
        }

        private IConvertionRule convertionRule;

        public IConvertionRule ConvertionRuleRepo
        {
            get
            {
                if (convertionRule == null)
                {
                    convertionRule = new ConvertionRuleRepo(context);
                }
                return convertionRule;
            }
        }
        private IAdmitCard admitCard;
        public IAdmitCard AdmitCardRepo => admitCard ??= new AdmitCardRepo(context);

        private IExamAttendance examAttendance;

        public IExamAttendance ExamAttendanceRepo
        {
            get
            {
                if (examAttendance == null)
                {
                    examAttendance = new ExamAttendanceRepo(context);
                }
                return examAttendance;
            }
        }

        private IExamRoutine examRoutine;

        public IExamRoutine ExamRoutineRepo
        {
            get
            {
                if (examRoutine == null)
                {
                    examRoutine = new ExamRoutineRepo(context);
                }
                return examRoutine;
            }
        }

        private IExamTitle examTitle;

        public IExamTitle ExamTitleRepo
        {
            get
            {
                if (examTitle == null)
                {
                    examTitle = new ExamTitleRepo(context);
                }
                return examTitle;
            }
        }

        private IExamType examType;

        public IExamType ExamTypeRepo
        {
            get
            {
                if (examType == null)
                {
                    examType = new ExamTypeRepo(context);
                }
                return examType;
            }
        }

        private IExamwithSubject examwithSubject;

        public IExamwithSubject ExamwithSubjectRepo
        {
            get
            {
                if (examwithSubject == null)
                {
                    examwithSubject = new ExamwithSubjectRepo(context);
                }
                return examwithSubject;
            }
        }

        private IGrade grade;

        public IGrade GradeRepo
        {
            get
            {
                if (grade == null)
                {
                    grade = new GradeRepo(context);
                }
                return grade;
            }
        }
        private IMarksEntry marksEntry;

        public IMarksEntry MarksEntryRepo
        {
            get
            {
                if (marksEntry == null)
                {
                    marksEntry = new MarksEntryRepo(context);
                }
                return marksEntry;
            }
        }
        private IResult result;

        public IResult ResultRepo
        {
            get
            {
                if (result == null)
                {
                    result = new ResultRepo(context);
                }
                return result;
            }
        }
        private IAccountChart accountChart;

        public IAccountChart AccountChartRepo
        {
            get
            {
                if (accountChart == null)
                {
                    accountChart = new AccountChartRepo(context);
                }
                return accountChart;
            }
        }
        private IAccountGroupLower accountGroupLower;

        public IAccountGroupLower AccountGroupLowerRepo
        {
            get
            {
                if (accountGroupLower == null)
                {
                    accountGroupLower = new AccountGroupLowerRepo(context);
                }
                return accountGroupLower;
            }
        }

        private IAccountGroupMid accountGroupMid;

        public IAccountGroupMid AccountGroupMidRepo
        {
            get
            {
                if (accountGroupMid == null)
                {
                    accountGroupMid = new AccountGroupMidRepo(context);
                }
                return accountGroupMid;
            }
        }
        private IAccountGroupTop accountGroupTop;

        public IAccountGroupTop AccountGroupTopRepo
        {
            get
            {
                if (accountGroupTop == null)
                {
                    accountGroupTop = new AccountGroupTopRepo(context);
                }
                return accountGroupTop;
            }
        }
        private IClassWiseFee classWiseFee;

        public IClassWiseFee ClassWiseFeeRepo
        {
            get
            {
                if (classWiseFee == null)
                {
                    classWiseFee = new ClassWiseFeeRepo(context);
                }
                return classWiseFee;
            }
        }
        private IShareHolderInformation shareHolderInformation;

        public IShareHolderInformation ShareHolderInformationRepo
        {
            get
            {
                if (shareHolderInformation == null)
                {
                    shareHolderInformation = new ShareHolderInformationRepo(context);
                }
                return shareHolderInformation;
            }
        }
        private ITransactionDetails transactionDetails;
        public ITransactionDetails TransactionDetailsRepo
        {
            get
            {
                if (transactionDetails == null)
                {
                    transactionDetails = new TransactionDetailsRepo(context);
                }
                return transactionDetails;
            }
        }
        private ITransactionMaster transactionMaster;
        public ITransactionMaster TransactionMasterRepo
        {
            get
            {
                if (transactionMaster == null)
                {
                    transactionMaster = new TransactionMasterRepo(context);
                }
                return transactionMaster;
            }
        }
        private IVoucherType voucherType;
        public IVoucherType VoucherTypeRepo
        {
            get
            {
                if (voucherType == null)
                {
                    voucherType = new VoucherTypeRepo(context);
                }
                return voucherType;
            }
        }
        private ILoginModel loginModel;
        public ILoginModel LoginModelRepo
        {
            get
            {
                if (loginModel == null)
                {
                    loginModel = new LoginModelRepo(context);
                }
                return loginModel;
            }
        }
        private IRole role;
        public IRole RoleRepo
        {
            get
            {
                if (role == null)
                {
                    role = new RoleRepo(_serviceProvider);
                }
                return role;
            }
        }
        private ITokenApiModel tokenApiModel;
        public ITokenApiModel TokenApiModelRepo
        {
            get
            {
                if (tokenApiModel == null)
                {
                    tokenApiModel = new TokenApiModelRepo(context);
                }
                return tokenApiModel;
            }
        }
        private IAboutUs aboutUs;
        public IAboutUs AboutUsRepo
        {
            get
            {
                if (aboutUs == null)
                {
                    aboutUs = new AboutUsRepo(context);
                }
                return aboutUs;
            }
        }
        private IAchievements achievements;
        public IAchievements AchievementsRepo
        {
            get
            {
                if (achievements == null)
                {
                    achievements = new AchievementsRepo(context);
                }
                return achievements;
            }
        }

        private IAlbum album;
        public IAlbum AlbumRepo
        {
            get
            {
                if (album == null)
                {
                    album = new AlbumRepo(context);
                }
                return album;
            }
        }


        private IBookList bookList;
        public IBookList BookListRepo
        {
            get
            {
                if (bookList == null)
                {
                    bookList = new BookListRepo(context);
                }
                return bookList;
            }
        }
        private IClassRoutine classRoutine;
        public IClassRoutine ClassRoutineRepo
        {
            get
            {
                if (classRoutine == null)
                {
                    classRoutine = new ClassRoutineRepo(context);
                }
                return classRoutine;
            }
        }

        private IInstituteChartAcct instituteChartAcct;
        public IInstituteChartAcct InstituteChartAcctRepo
        {
            get
            {
                if (instituteChartAcct == null)
                {
                    instituteChartAcct = new InstituteChartAcctRepo(context);
                }
                return instituteChartAcct;
            }
        }

        private IFacility facility;
        public IFacility FacilityRepo
        {
            get
            {
                if (facility == null)
                {
                    facility = new FacilityRepo(context);
                }
                return facility;
            }
        }
        private IHistory history;
        public IHistory HistoryRepo
        {
            get
            {
                if (history == null)
                {
                    history = new HistoryRepo(context);
                }
                return history;
            }
        }

        private IMediaCat mediaCat;
        public IMediaCat MediaCatRepo
        {
            get
            {
                if (mediaCat == null)
                {
                    mediaCat = new MediaCatRepo(context);
                }
                return mediaCat;
            }
        }

        private IMessage message;
        public IMessage MessageRepo
        {
            get
            {
                if (message == null)
                {
                    message = new MessageRepo(context);
                }
                return message;
            }
        }

        private IMissionVission missionVission;
        public IMissionVission MissionVissionRepo
        {
            get
            {
                if (missionVission == null)
                {
                    missionVission = new MissionVissionRepo(context);
                }
                return missionVission;
            }
        }

        private INews news;
        public INews NewsRepo
        {
            get
            {
                if (news == null)
                {
                    news = new NewsRepo(context);
                }
                return news;
            }
        }

        private IPhotoGallery photoGallery;
        public IPhotoGallery PhotoGalleryRepo
        {
            get
            {
                if (photoGallery == null)
                {
                    photoGallery = new PhotoGalleryRepo(context);
                }
                return photoGallery;
            }
        }
        private IRoom room;
        public IRoom RoomRepo
        {
            get
            {
                if (room == null)
                {
                    room = new RoomRepo(context);
                }
                return room;
            }
        }

        private IRulesRegulation regulation;
        public IRulesRegulation RulesRegulationRepo
        {
            get
            {
                if (regulation == null)
                {
                    regulation = new RulesRegulationRepo(context);
                }
                return regulation;
            }
        }
        private ISocialMedia socialMedia;
        public ISocialMedia SocialMediaRepo
        {
            get
            {
                if (socialMedia == null)
                {
                    socialMedia = new SocialMediaRepo(context);
                }
                return socialMedia;
            }
        }

        private IVideoGallery videoGallery;
        public IVideoGallery VideoGalleryRepo
        {
            get
            {
                if (videoGallery == null)
                {
                    videoGallery = new VideoGalleryRepo(context);
                }
                return videoGallery;
            }
        }

        private IAttendance attendance;
        public IAttendance AttendanceRepo
        {
            get
            {
                if (attendance == null)
                {
                    attendance = new AttendanceRepo(context);
                }
                return attendance;
            }
        }

        private IAcademicSession academicSession;
        public IAcademicSession AcademicSessionRepo
        {
            get
            {
                if (academicSession == null)
                {
                    academicSession = new AcademicSessionRepo(context);
                }
                return academicSession;
            }
        }
        private IAcademicDepartment academicDepartment;
        public IAcademicDepartment AcademicDepartmentRepo
        {
            get
            {
                if (academicDepartment == null)
                {
                    academicDepartment = new AcademicDepartmentRepo(context);
                }
                return academicDepartment;
            }
        }

        private IProgramGroup programGroup;
        public IProgramGroup ProgramGroupRepo
        {
            get
            {
                if (programGroup == null)
                {
                    programGroup = new ProgramGroupRepo(context);
                }
                return programGroup;
            }
        }
        private IProgram program;
        public IProgram ProgramRepo
        {
            get
            {
                if (program == null)
                {
                    program = new ProgramRepo(context);
                }
                return program;
            }
        }
        private ISubjectInfo subjectInfo;
        public ISubjectInfo SubjectInfoRepo
        {
            get
            {
                if (subjectInfo == null)
                {
                    subjectInfo = new SubjectInfoRepo(context);
                }
                return subjectInfo;
            }
        }
        private IEducationalGroup educationalGroup;
        public IEducationalGroup EducationalGroupRepo
        {
            get
            {
                if (educationalGroup == null)
                {
                    educationalGroup = new EducationalGroupRepo(context);
                }
                return educationalGroup;
            }
        }
        private IClassSubjectInst classSubjectInst;
        public IClassSubjectInst ClassSubjectInstRepo
        {
            get
            {
                if (classSubjectInst == null)
                {
                    classSubjectInst = new ClassSubjectInstRepo(context);
                }
                return classSubjectInst;
            }
        }
        private IShift shift;
        public IShift ShiftRepo
        {
            get
            {
                if (shift == null)
                {
                    shift = new ShiftRepo(context);
                }
                return shift;
            }
        }
        private IClassSection classSection;
        public IClassSection ClassSectionRepo
        {
            get
            {
                if (classSection == null)
                {
                    classSection = new ClassSectionRepo(context);
                }
                return classSection;
            }
        }
        private IReligion religion;
        public IReligion ReligionRepo
        {
            get
            {
                if (religion == null)
                {
                    religion = new ReligionRepo(context);
                }
                return religion;
            }
        }
        private IClassSubjecTeacherIns classSubjecTeacherIns;
        public IClassSubjecTeacherIns ClassSubjecTeacherInsRepo
        {
            get
            {
                if (classSubjecTeacherIns == null)
                {
                    classSubjecTeacherIns = new ClassSubjecTeacherInsRepo(context);
                }
                return classSubjecTeacherIns;
            }
        }
        private IShiftwiseClass shiftwiseClass;
        public IShiftwiseClass ShiftwiseClassRepo
        {
            get
            {
                if (shiftwiseClass == null)
                {
                    shiftwiseClass = new ShiftwiseClassRepo(context);
                }
                return shiftwiseClass;
            }
        }
        private IAdministrativeDepartment administrativeDepartment;
        public IAdministrativeDepartment AdministrativeDepartmentRepo
        {
            get
            {
                if (administrativeDepartment == null)
                {
                    administrativeDepartment = new AdministrativeDepartmentRepo(context);
                }
                return administrativeDepartment;
            }
        }
        private IDesignation designation;
        public IDesignation DesignationRepo
        {
            get
            {
                if (designation == null)
                {
                    designation = new DesignationRepo(context);
                }
                return designation;
            }
        }

        private IEmployee employee;
        public IEmployee EmployeeRepo
        {
            get
            {
                if (employee == null)
                {
                    employee = new EmployeeRepo(context);
                }
                return employee;
            }
        }

        private ITeacher teacher;
        public ITeacher TeacherRepo
        {
            get
            {
                if (teacher == null)
                {
                    teacher = new TeacherRepo(context);
                }
                return teacher;
            }
        }
        private IEmployeesGroup employeesGroup;
        public IEmployeesGroup EmployeesGroupRepo
        {
            get
            {
                if (employeesGroup == null)
                {
                    employeesGroup = new EmployeesGroupRepo(context);
                }
                return employeesGroup;
            }
        }
        private IEmployeeWithGroup employeeWithGroup;
        public IEmployeeWithGroup EmployeeWithGroupRepo
        {
            get
            {
                if (employeeWithGroup == null)
                {
                    employeeWithGroup = new EmployeeWithGroupRepo(context);
                }
                return employeeWithGroup;
            }
        }
        private IDirectors directors;
        public IDirectors DirectorsRepo
        {
            get
            {
                if (directors == null)
                {
                    directors = new DirectorsRepo(context);
                }
                return directors;
            }
        }
        private IStaff staff;
        public IStaff StaffRepo
        {
            get
            {
                if (staff == null)
                {
                    staff = new StaffRepo(context);
                }
                return staff;
            }
        }
        private IEmployeeQualification employeeQualification;
        public IEmployeeQualification EmployeeQualificationRepo
        {
            get
            {
                if (employeeQualification == null)
                {
                    employeeQualification = new EmployeeQualificationRepo(context);
                }
                return employeeQualification;
            }
        }
        private IEmployeeExperience employeeExperience;
        public IEmployeeExperience EmployeeExperienceRepo
        {
            get
            {
                if (employeeExperience == null)
                {
                    employeeExperience = new EmployeeExperienceRepo(context);
                }
                return employeeExperience;
            }
        }
        private IEmployeesEducation employeesEducation;
        public IEmployeesEducation EmployeesEducationRepo
        {
            get
            {
                if (employeesEducation == null)
                {
                    employeesEducation = new EmployeesEducationRepo(context);
                }
                return employeesEducation;
            }
        }
        private IEmployeesJobHistroy employeesJobHistroy;
        public IEmployeesJobHistroy EmployeesJobHistroyRepo
        {
            get
            {
                if (employeesJobHistroy == null)
                {
                    employeesJobHistroy = new EmployeesJobHistroyRepo(context);
                }
                return employeesJobHistroy;
            }
        }
        private INationalCertificate nationalCertificate;
        public INationalCertificate NationalCertificateRepo
        {
            get
            {
                if (nationalCertificate == null)
                {
                    nationalCertificate = new NationalCertificateRepo(context);
                }
                return nationalCertificate;
            }
        }
        private IInstituteType instituteType;
        public IInstituteType InstituteTyperepo
        {
            get
            {
                if (instituteType == null)
                {
                    instituteType = new InstituteTyperepo(context);
                }
                return instituteType;
            }
        }
        private IInstitute institute;
        public IInstitute InstituteRepo
        {
            get
            {
                if (institute == null)
                {
                    institute = new InstituteRepo(context);
                }
                return institute;
            }
        }
        private IInsBranch insBranch;
        public IInsBranch InsBranchRepo
        {
            get
            {
                if (insBranch == null)
                {
                    insBranch = new InsBranchRepo(context);
                }
                return insBranch;
            }
        }
        private IStdInvoice invoice;
        public IStdInvoice StdInvoiceRepo
        {
            get
            {
                if (invoice == null)
                {
                    invoice = new StdInvoiceRepo(context);
                }
                return invoice;
            }
        }
        private IStdPayment stdPayment;
        public IStdPayment StdPaymentRepo
        {
            get
            {
                if (stdPayment == null)
                {
                    stdPayment = new StdPaymentRepo(context);
                }
                return stdPayment;
            }
        }
        private IStdPaymentSettings stdPaymentSettings;
        public IStdPaymentSettings StdPaymentRepoRepo
        {
            get
            {
                if (stdPaymentSettings == null)
                {
                    stdPaymentSettings = new StdPaymentRepoRepo(context);
                }
                return stdPaymentSettings;
            }
        }
        private IPaymentMethod paymentMethod;
        public IPaymentMethod PaymentMethodRepo
        {
            get
            {
                if (paymentMethod == null)
                {
                    paymentMethod = new PaymentMethodRepo(context);
                }
                return paymentMethod;
            }
        }
        private IStudentBasicInfo studentBasicInfo;
        public IStudentBasicInfo StudentBasicInfoRepo
        {
            get
            {
                if (studentBasicInfo == null)
                {
                    studentBasicInfo = new StudentBasicInfoRepo(context);
                }
                return studentBasicInfo;
            }
        }
        private IStdtAcademicInfo stdtAcademicInfo;
        public IStdtAcademicInfo StdtAcademicInfoRepo
        {
            get
            {
                if (stdtAcademicInfo == null)
                {
                    stdtAcademicInfo = new StdtAcademicInfoRepo(context);
                }
                return stdtAcademicInfo;
            }
        }








        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

        public ModelMessage Save()
        {
            ModelMessage modelMessage = new ModelMessage();
            try
            {
                if (context.SaveChanges() > 0)
                {
                    modelMessage.Message = $"Operation Successfull";
                    modelMessage.IsSuccess = true;
                }
                else
                {
                    modelMessage.Message = $"Operation Failled";
                    modelMessage.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    modelMessage.Message = ex.InnerException.Message;
                    modelMessage.IsSuccess = false;
                }
                else
                {
                    modelMessage.Message = ex.Message;
                    modelMessage.IsSuccess = false;
                }
            }
            return modelMessage;
        }
    }
}
