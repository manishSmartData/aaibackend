using System;
using System.Reflection;

namespace AAI.DataContract.Enums
{
    public class CommonEnums
    {
        public class StringValue : System.Attribute
        {
            private readonly string _value;

            public StringValue(string value)
            {
                _value = value;
            }

            public string Value
            {
                get
                {
                    return _value;
                }
            }

        }
        public static class StringEnum
        {
            public static string GetStringValue(Enum value)
            {
                string output = null;
                Type type = value.GetType();

                FieldInfo fi = type.GetField(value.ToString());
                StringValue[] attrs = fi.GetCustomAttributes(typeof(StringValue), false) as StringValue[];

                if (attrs.Length > 0)
                    output = attrs[0].Value;

                return output;
            }
        }

        public enum IHEDescriptionActiveStatus
        {
            Active = 1,
            InActive = 2
        }
  
        public enum RoleType
        {
            [StringValue("60")]
            Manage_Employee_Deficiencies = 60,

            [StringValue("67")]
            Manage_All_Employee_Deficiencies = 67,

            [StringValue("1")]
            Administrator = 1,

            [StringValue("73")]
            Manage_Employee_Time_Off = 73,

            [StringValue("48")]
            TimeCardAdmin = 48,

            [StringValue("69")]
            OutsidePracticeManager = 69,

            [StringValue("68")]
            ClinicalAdministrator = 68,

            [StringValue("12")]
            ReferralAdmin = 12,

            [StringValue("60")]
            AddEmployeeDeficiencies = 60,

            [StringValue("88")]
            ManageTemperatureLog = 88,

            [StringValue("89")]
            ManageUploadedDocuments = 89,

            [StringValue("70")]
            BillingReports = 70,

            [StringValue("62")]
            Bypass_Patient_Registration_Validation = 62,

            [StringValue("91")]
            Void_Prescriptions_Past_3_days = 91,

            [StringValue("99")]
            DeleteDocumentSearchItems = 99,

            [StringValue("100")]
            ManageCallRecords = 100,

            [StringValue("66")]
            CrossPracticePatientSearch = 66,

            [StringValue("84")]
            HEDIS = 84,

            [StringValue("6")]
            SiteAdministrator = 6,

            [StringValue("8")]
            ProviderServices = 8,

            [StringValue("110")]
            EditEncounter = 110,

            [StringValue("113")]
            PatientHomePractice = 113,

            [StringValue("108")]
            CertificationAdmin = 108,

            [StringValue("109")]
            CertificationRestricted = 109,

            [StringValue("104")]
            RegionalManager = 104,

            [StringValue("115")]
            SearchByClinician = 115,

            [StringValue("116")]
            BillingDepartment = 116,

            [StringValue("20")]
            Finance = 20,

            [StringValue("117")]
            PharmacyAdmin = 117,

            [StringValue("55")]
            ReferralApproveSubmitToHMO = 55,

            [StringValue("122")]
            ManageEncounterTimes = 122,

            [StringValue("105")]
            HumanResources = 105,

            [StringValue("28")]
            ERS_Admin = 28,

            [StringValue("32")]
            ERS_AccessAssociate = 32,

            [StringValue("92")]
            Enrollment_Manager = 92,

            [StringValue("130")]
            PayrollProcessingAndStaffing = 130,

            [StringValue("131")]
            EditReferralComments = 131,

            [StringValue("132")]
            PayrollProcessingAndStaffingViewOnly = 132,

            [StringValue("23")]
            IPHESAdmin = 23,

            [StringValue("137")]
            Employee_Document_HR_016 = 137,

            [StringValue("134")]
            CreateMedicalRecord = 134,

            [StringValue("135")]
            CreateMemberRecord = 135,

            [StringValue("161")]
            AllPracticeAppointments = 161,

            [StringValue("139")]
            CloseEncounters = 139,

            [StringValue("151")]
            Time_and_attendance = 151,

            [StringValue("141")]
            AddEditProjectTracking = 141,

            [StringValue("142")]
            ProjectTrackingAdministrator = 142,

            [StringValue("143")]
            ProjectTrackingManager = 143,

            [StringValue("144")]
            ProjectTrackingUser = 144,

            [StringValue("153")]
            ClinicalInfoMessagingSystem = 153,

            [StringValue("156")]
            UpdateExamStatusGeneral = 156,

            [StringValue("157")]
            ManagePersonalClinician = 157,

            [StringValue("154")]
            EditUserAccounts = 154,

            [StringValue("158")]
            ChangeUserPasswords = 158,

            [StringValue("160")]
            ManageOperationsLogs = 160,

            [StringValue("147")]
            PropertyManagementUser = 147,

            [StringValue("148")]
            CompanyManagementUser = 148,

            [StringValue("162")]
            IncidentReportingAdministrator = 162,

            [StringValue("163")]
            IncidentReportingManager = 163,

            [StringValue("164")]
            IncidentReportingUser = 164,

            [StringValue("162")]
            IPHESAPPLICATIONAdministrator = 162,

            [StringValue("163")]
            IPHESAPPLICATIONManager = 163,

            [StringValue("164")]
            IPHESAPPLICATIONUser = 164,

            [StringValue("166")]
            LegalDocumentsView = 166,

            [StringValue("167")]
            LegalDocumentsEdit = 167,

            [StringValue("174")]
            EditTelemedicineApptsForAllPractices = 174,

            [StringValue("179")]
            AddSecondaryPracticeToPatient = 179,

            [StringValue("180")]
            FaxAdmin = 180,

            [StringValue("59")]
            LicenseAndCredentialingAdmin = 59,

            [StringValue("52")]
            ManageDuplicatePatients = 52,

            [StringValue("181")]
            Purchasing_Manage_Products_and_Related = 181
        }
        public enum PositionType
        {

            [StringValue("0")]
            All = 0,

            [StringValue("4")]
            MedicalAssistant = 4,

            [StringValue("12")]
            FrontDesk = 12,

            [StringValue("16")]
            MedicalAssistantDMP = 16,

            [StringValue("25")]
            RegionalManager = 25,

            [StringValue("78")]
            MedicalCenterCoordinator = 78,

            [StringValue("39")]
            HumanResourcesCoordinator = 39,

            [StringValue("28")]
            MedicalDirector = 28,

            [StringValue("143")]
            MedicalRecordsCoordinator = 143,

            [StringValue("199")]
            CustomerServCoordinator = 199,

            [StringValue("48")]
            CustomerServManager = 48,

            [StringValue("49")]
            CustomerServRep = 49,

            [StringValue("167")]
            OperationsManager = 167,

       
            [StringValue("247")]
            CareTeamMedicalCenterCoordinatorEvenings = 247, //Care Team - Medical Center Coordinator, Evenings

            [StringValue("252")]
            EnrollmentAssociate = 252, // live: 252 254local

            [StringValue("265")]
            CareTeamSpecialtyCenterCoordinator = 265

        }
        public enum UserPositionRoleType
        {
            Position = 1,
            Role = 2
        }


        public enum InsuranceTypeCode
        {
            PrimaryInsurance = 1,
            SecondaryInsurance = 2
        }

        public enum AddressTypes
        {
            Home = 1,
            Work = 2,
            Designated_Representative = 3,
            Emergency_Contact = 4,
            Healthcare_Surrogate = 5,
            Legal_Guardian = 6,
            Preferred_pharmacy = 7,
            Preferred_hospital = 8,
            Primary_Caregiver = 9,
            Mobile = 10
        }
        public enum ContactMethods
        {
            Phone = 0,
            Email = 0,
            SMS = 0
        }

        public enum ProviderDefaultPatientServiceStatus
        {
            Yes = 1,
            No = 0
        }

        public enum PatientPracticeStatus
        {
            Active = 1,
            Expired_Deceased = 2,
            Out_of_Area = 3,
            Changed_Insurance = 4,
            Changed_Practice = 5,
            Lost_Eligibility = 6,
            DuplicatePatient = 7,
            Inactive = 8,
            Never_Been_Seen = 9,
        }

        public enum RequestSource
        {
            MissingInfo = 1
        }

        public enum DuplicatePatientsStatus
        {
            [StringValue("found")]
            Duplicate_Patients_Found,

            [StringValue("notfound")]
            Duplicate_Patients_NotFound,
        }

        /// <summary>
        /// <Description>This enum returns date format</Description>
        /// </summary>
        public enum DateFormat
        {
            //Slash(/) represent by SL
            //Desh(-) represent by D
            //Colon(:) repesent by Col

            [StringValue("ddMMyyyy")]
            ddMMyyyy,
            [StringValue("MMddyyyy")]
            MMddyyyy,
            [StringValue("yyyyMMdd")]
            yyyyMMdd,
            [StringValue("dd/MM/yyyy")]
            dd_SL_MM_SL_yyyy,
            [StringValue("MM/dd/yyyy")]
            MM_SL_dd_SL_yyyy,
            [StringValue("yyyy/MM/dd")]
            yyyy_SL_MM_SL_dd,
            [StringValue("dd-MM-yyyy")]
            dd_D_MM_D_yyyy,
            [StringValue("MM-dd-yyyy")]
            MM_D_dd_D_yyyy,
            [StringValue("yyyy-MM-dd")]
            yyyy_D_MM_D_dd,
            [StringValue("yyyyMMddHH:mm:")]
            yyyyMMddHH_Col_mm_Col,

            [StringValue("MM/dd/yyyy hh:mm:ss tt")]
            MM_SL_dd_SL_yyyy_hh_Col_mm_Col_ss_tt,
            [StringValue("yyyyMMddhhmmss")]
            yyyyMMddhhmmss

        }
        public enum HL7CompletionStatus
        {
            [StringValue("CP")]
            CP = 1,
            [StringValue("RE")]
            RE = 2,
            [StringValue("NA")]
            NA = 3,
            [StringValue("PA")]
            PA = 4
        }
        public enum HL7CompletionText
        {
            [StringValue("Complete")]
            CP = 1,
            [StringValue("Refused")]
            RE = 2,
            [StringValue("Not Administered")]
            NA = 3,
            [StringValue("Partially Administered")]
            PA = 4
        }
        public enum HL7Acknowledgement
        {
            [StringValue("AA")]
            Application_Accept = 1,
            [StringValue("AE")]
            Application_Error = 2,
            [StringValue("AR")]
            Application_Reject = 3
        }
        public enum PCPProviderID
        {
            Jose_E_Garcia_Jr_MD = 1
        }

        public enum CallAttributes
        {
            [StringValue("Office- Provider call-back requested")]
            Office_Provider_call_back_requested = 12,
            [StringValue("After Hours - Request for Staff call back")]
            After_Hours_Request_for_Staff_call_back = 53,
            [StringValue("After Hours - Request for Provider call back")]
            After_Hours_Request_for_Provider_call_back = 54,
            [StringValue("Office- Appointment Reminder")]
            Office_Appointment_Reminder = 24,
            [StringValue("Office- Appointment Rescheduling")]
            Office_Appointment_Rescheduling = 25,
            [StringValue("Office- Staff call-back requested ")]
            Office_Staff_Call_Back_Request = 90
        }

        public enum StartYear
        {
            VerifyEnrollments = 2009,
            MonthlyMembership = 2010,
            Membership = 2008,
            NonMembersActiveReport = 2008,
            MedicationUtilizationReport = 2008,
            MRADroppedFunding = 2010,
            PCMHPracticeRankingRpt = 2008,
            CapitationYearStart = 2014,
            InternalRatingSystem = 2010,
            HealthPlanDataFiles = 2008
        }

        public enum OrderStatusType
        {
            Invoice_Paid = 6
        }
    }
}
