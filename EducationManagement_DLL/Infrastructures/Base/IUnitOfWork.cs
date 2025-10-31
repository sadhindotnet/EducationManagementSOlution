



using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Repositories;
using EducationManagement_DLL.Models.AccountsModel;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public interface IUnitOfWork:IDisposable
    {
        public SchoolContext Context { get;  }
        public IUserRepo UserRepo { get; }

        public IConvertionRule ConvertionRuleRepo { get; }
       
        public IAcademyClass AcademyClassRepo { get; }
        public IAdmitCard AdmitCardRepo { get; }
        public IExamAttendance ExamAttendanceRepo { get; }

        public IExamRoutine ExamRoutineRepo { get; }
        public IExamTitle ExamTitleRepo { get; }
        public IExamType ExamTypeRepo { get; }
        public IExamwithSubject ExamwithSubjectRepo { get; }
        public IGrade GradeRepo { get; }
        public IMarksEntry MarksEntryRepo { get; }
        public IResult ResultRepo { get; }
        public IAccountChart AccountChartRepo { get; }
        public IAccountGroupLower AccountGroupLowerRepo { get; }
        public IAccountGroupMid AccountGroupMidRepo { get; }
        public IAccountGroupTop AccountGroupTopRepo { get; }
        public IClassWiseFee ClassWiseFeeRepo { get; }
        public IShareHolderInformation ShareHolderInformationRepo { get; }
        public ITransactionDetails TransactionDetailsRepo { get; }
        public ITransactionMaster TransactionMasterRepo { get; }
        public IVoucherType VoucherTypeRepo { get; }
        public ILoginModel LoginModelRepo { get; }
        public IRole RoleRepo { get; }
        public ITokenApiModel TokenApiModelRepo { get; }
        public IAboutUs AboutUsRepo { get; }
        public IAchievements AchievementsRepo { get; }
        public IAlbum AlbumRepo { get; }
        public IBookList BookListRepo { get; }
        public IClassRoutine ClassRoutineRepo { get; }
        public IInstituteChartAcct InstituteChartAcctRepo { get; }
        public IFacility FacilityRepo { get; }
        public IHistory HistoryRepo { get; }
        public IMediaCat MediaCatRepo { get; }
        public IMessage MessageRepo { get; }
        public IMissionVission MissionVissionRepo { get; }
        public INews NewsRepo { get; }
        public IPhotoGallery PhotoGalleryRepo { get; }
        public IRoom RoomRepo { get; }
        public IRulesRegulation RulesRegulationRepo { get; }
        public ISocialMedia SocialMediaRepo { get; }
        public IVideoGallery VideoGalleryRepo { get; }
        public IAttendance AttendanceRepo { get; }
        public IAcademicSession AcademicSessionRepo { get; }
        public IAcademicDepartment AcademicDepartmentRepo { get; }
        public IProgramGroup ProgramGroupRepo { get; }
        public IProgram ProgramRepo { get; }
        public ISubjectInfo SubjectInfoRepo { get; }
        public IEducationalGroup EducationalGroupRepo { get; }
        public IClassSubjectInst ClassSubjectInstRepo { get; }
        public IShift ShiftRepo { get; }
        public IClassSection ClassSectionRepo { get; }
        public IReligion ReligionRepo { get; }
        public IClassSubjecTeacherIns ClassSubjecTeacherInsRepo { get; }
        public IShiftwiseClass ShiftwiseClassRepo { get; }
        public IAdministrativeDepartment AdministrativeDepartmentRepo { get; }
        public IDesignation DesignationRepo { get; }
        public IEmployee EmployeeRepo { get; }
        public ITeacher TeacherRepo { get; }
        public IEmployeesGroup EmployeesGroupRepo { get; }
        public IEmployeeWithGroup EmployeeWithGroupRepo { get; }
        public IDirectors DirectorsRepo { get; }
        public IStaff StaffRepo { get; }
        public IEmployeeQualification EmployeeQualificationRepo { get; }
        public IEmployeeExperience EmployeeExperienceRepo { get; }
        public IEmployeesEducation EmployeesEducationRepo { get; }
        public IEmployeesJobHistroy EmployeesJobHistroyRepo { get; }
        
        public INationalCertificate NationalCertificateRepo { get; }
        public IInstituteType InstituteTyperepo { get; }
        public IInstitute InstituteRepo { get; }
        public IInsBranch InsBranchRepo { get; }
        public IStdInvoice StdInvoiceRepo { get; }
        public IStdPayment StdPaymentRepo { get; }
        public IStdPaymentSettings StdPaymentRepoRepo { get; }
        public IPaymentMethod PaymentMethodRepo { get; }
        public IStdtAcademicInfo StdtAcademicInfoRepo { get; }
        public IStudentBasicInfo StudentBasicInfoRepo { get; }







        ModelMessage Save();
    }
}
