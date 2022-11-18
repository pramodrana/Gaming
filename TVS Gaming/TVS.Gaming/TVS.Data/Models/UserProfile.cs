using System;
using System.Collections.Generic;

namespace TVS.Data.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            CsifeedbackReschedules = new HashSet<CsifeedbackReschedule>();
            Csifeedbacks = new HashSet<Csifeedback>();
            Csinpsfeedbacks = new HashSet<Csinpsfeedback>();
            EmergencyContacts = new HashSet<EmergencyContact>();
            GameAnswerInsertedByNavigations = new HashSet<GameAnswer>();
            GameAnswerUpdatedByNavigations = new HashSet<GameAnswer>();
            GameCategoryInsertedByNavigations = new HashSet<GameCategory>();
            GameCategoryUpdatedByNavigations = new HashSet<GameCategory>();
            GameContestInsertedByNavigations = new HashSet<GameContest>();
            GameContestUpdatedByNavigations = new HashSet<GameContest>();
            GameModeInsertedByNavigations = new HashSet<GameMode>();
            GameModeUpdatedByNavigations = new HashSet<GameMode>();
            GamePropertyInsertedByNavigations = new HashSet<GameProperty>();
            GamePropertyUpdatedByNavigations = new HashSet<GameProperty>();
            GameQuestionInsertedByNavigations = new HashSet<GameQuestion>();
            GameQuestionUpdatedByNavigations = new HashSet<GameQuestion>();
            GameScoreInsertedByNavigations = new HashSet<GameScore>();
            GameScoreUpdatedByNavigations = new HashSet<GameScore>();
            GameScoreUsers = new HashSet<GameScore>();
            InAppFeedbacks = new HashSet<InAppFeedback>();
            NpsfeedbackReschedules = new HashSet<NpsfeedbackReschedule>();
            Npsfeedbacks = new HashSet<Npsfeedback>();
            ServiceFeedbacks = new HashSet<ServiceFeedback>();
            UserAddresses = new HashSet<UserAddress>();
            UserBadges = new HashSet<UserBadge>();
            UserFeedback1s = new HashSet<UserFeedback1>();
            UserFeedbackForms = new HashSet<UserFeedbackForm>();
            UserFeedbacks = new HashSet<UserFeedback>();
            UserRsakeys = new HashSet<UserRsakey>();
            UserSurveys = new HashSet<UserSurvey>();
            UserVehicleMacActivations = new HashSet<UserVehicleMacActivation>();
            UserVehicles = new HashSet<UserVehicle>();
        }

        public long UserId { get; set; }
        public string? FullName { get; set; }
        public string? MobileNumber { get; set; }
        public string? Email { get; set; }
        public long? CityId { get; set; }
        public string? BloodGroup { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? EmergencyNumber1 { get; set; }
        public string? EmergencyNumber2 { get; set; }
        public string? EmergencyNumber3 { get; set; }
        public string? AllergicContent { get; set; }
        public string? Token { get; set; }
        public bool? IsOtpverified { get; set; }
        public long? Otp { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OtpgenerateTime { get; set; }
        public string? FacebookId { get; set; }
        public string? GooglePlusId { get; set; }
        public DateTime? CrashAlertDate { get; set; }
        public bool? IsRegistered { get; set; }
        public string? IosToken { get; set; }
        public string? AndroidToken { get; set; }
        public string? RegistrationId { get; set; }
        public string? AppleId { get; set; }
        public int? OtpfailedAttemptCount { get; set; }
        public DateTime? LastOtpfailedAttemptAt { get; set; }
        public string? DeleteReasonMessage { get; set; }
        public long? DeleteOtp { get; set; }
        public DateTime? DeleteOtpgenerateTime { get; set; }
        public bool? IsDeleteOtpverified { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsMasked { get; set; }

        public virtual Citymaster? City { get; set; }
        public virtual ICollection<CsifeedbackReschedule> CsifeedbackReschedules { get; set; }
        public virtual ICollection<Csifeedback> Csifeedbacks { get; set; }
        public virtual ICollection<Csinpsfeedback> Csinpsfeedbacks { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<GameAnswer> GameAnswerInsertedByNavigations { get; set; }
        public virtual ICollection<GameAnswer> GameAnswerUpdatedByNavigations { get; set; }
        public virtual ICollection<GameCategory> GameCategoryInsertedByNavigations { get; set; }
        public virtual ICollection<GameCategory> GameCategoryUpdatedByNavigations { get; set; }
        public virtual ICollection<GameContest> GameContestInsertedByNavigations { get; set; }
        public virtual ICollection<GameContest> GameContestUpdatedByNavigations { get; set; }
        public virtual ICollection<GameMode> GameModeInsertedByNavigations { get; set; }
        public virtual ICollection<GameMode> GameModeUpdatedByNavigations { get; set; }
        public virtual ICollection<GameProperty> GamePropertyInsertedByNavigations { get; set; }
        public virtual ICollection<GameProperty> GamePropertyUpdatedByNavigations { get; set; }
        public virtual ICollection<GameQuestion> GameQuestionInsertedByNavigations { get; set; }
        public virtual ICollection<GameQuestion> GameQuestionUpdatedByNavigations { get; set; }
        public virtual ICollection<GameScore> GameScoreInsertedByNavigations { get; set; }
        public virtual ICollection<GameScore> GameScoreUpdatedByNavigations { get; set; }
        public virtual ICollection<GameScore> GameScoreUsers { get; set; }
        public virtual ICollection<InAppFeedback> InAppFeedbacks { get; set; }
        public virtual ICollection<NpsfeedbackReschedule> NpsfeedbackReschedules { get; set; }
        public virtual ICollection<Npsfeedback> Npsfeedbacks { get; set; }
        public virtual ICollection<ServiceFeedback> ServiceFeedbacks { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserBadge> UserBadges { get; set; }
        public virtual ICollection<UserFeedback1> UserFeedback1s { get; set; }
        public virtual ICollection<UserFeedbackForm> UserFeedbackForms { get; set; }
        public virtual ICollection<UserFeedback> UserFeedbacks { get; set; }
        public virtual ICollection<UserRsakey> UserRsakeys { get; set; }
        public virtual ICollection<UserSurvey> UserSurveys { get; set; }
        public virtual ICollection<UserVehicleMacActivation> UserVehicleMacActivations { get; set; }
        public virtual ICollection<UserVehicle> UserVehicles { get; set; }
    }
}
