using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TVS.Data.Models
{
    public partial class TVSMAZTCASDBUAT03Context : DbContext
    {
        public TVSMAZTCASDBUAT03Context()
        {
        }

        public TVSMAZTCASDBUAT03Context(DbContextOptions<TVSMAZTCASDBUAT03Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminNotification> AdminNotifications { get; set; } = null!;
        public virtual DbSet<ApacheCumulative> ApacheCumulatives { get; set; } = null!;
        public virtual DbSet<ApacheNoniotcumulative> ApacheNoniotcumulatives { get; set; } = null!;
        public virtual DbSet<ApacheNoniottravelTransection> ApacheNoniottravelTransections { get; set; } = null!;
        public virtual DbSet<ApacheNoniottravelTransectionArchive> ApacheNoniottravelTransectionArchives { get; set; } = null!;
        public virtual DbSet<ApacheNoniottravelTransectionArchived> ApacheNoniottravelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<ApacheTravelTransection> ApacheTravelTransections { get; set; } = null!;
        public virtual DbSet<ApacheTravelTransectionArchived> ApacheTravelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<AppAssest> AppAssests { get; set; } = null!;
        public virtual DbSet<AppAssestBkp24082020> AppAssestBkp24082020s { get; set; } = null!;
        public virtual DbSet<AppBanner> AppBanners { get; set; } = null!;
        public virtual DbSet<AppVersion> AppVersions { get; set; } = null!;
        public virtual DbSet<AppVersion1> AppVersions1 { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<BadgeType> BadgeTypes { get; set; } = null!;
        public virtual DbSet<BikeService> BikeServices { get; set; } = null!;
        public virtual DbSet<BreakDownAssistance> BreakDownAssistances { get; set; } = null!;
        public virtual DbSet<BreakDownAssistanceType> BreakDownAssistanceTypes { get; set; } = null!;
        public virtual DbSet<Citymaster> Citymasters { get; set; } = null!;
        public virtual DbSet<ClientSecret> ClientSecrets { get; set; } = null!;
        public virtual DbSet<ContactSupport> ContactSupports { get; set; } = null!;
        public virtual DbSet<Csifeedback> Csifeedbacks { get; set; } = null!;
        public virtual DbSet<CsifeedbackReschedule> CsifeedbackReschedules { get; set; } = null!;
        public virtual DbSet<Csinpsfeedback> Csinpsfeedbacks { get; set; } = null!;
        public virtual DbSet<CustomUserProfile> CustomUserProfiles { get; set; } = null!;
        public virtual DbSet<DmsquestionAnswerMapper> DmsquestionAnswerMappers { get; set; } = null!;
        public virtual DbSet<EmergencyContact> EmergencyContacts { get; set; } = null!;
        public virtual DbSet<Faq> Faqs { get; set; } = null!;
        public virtual DbSet<FaqTemp01022021> FaqTemp01022021s { get; set; } = null!;
        public virtual DbSet<Faqcategory> Faqcategories { get; set; } = null!;
        public virtual DbSet<FaqcategoryTemp01022021> FaqcategoryTemp01022021s { get; set; } = null!;
        public virtual DbSet<FaqcategoryTemp11032022> FaqcategoryTemp11032022s { get; set; } = null!;
        public virtual DbSet<Faqtemp11032022> Faqtemp11032022s { get; set; } = null!;
        public virtual DbSet<FeedbackType> FeedbackTypes { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<GameAnswer> GameAnswers { get; set; } = null!;
        public virtual DbSet<GameCategory> GameCategories { get; set; } = null!;
        public virtual DbSet<GameContest> GameContests { get; set; } = null!;
        public virtual DbSet<GameMode> GameModes { get; set; } = null!;
        public virtual DbSet<GameProperty> GameProperties { get; set; } = null!;
        public virtual DbSet<GameQuestion> GameQuestions { get; set; } = null!;
        public virtual DbSet<GameScore> GameScores { get; set; } = null!;
        public virtual DbSet<Gear> Gears { get; set; } = null!;
        public virtual DbSet<GearArchived> GearArchiveds { get; set; } = null!;
        public virtual DbSet<HelpSupport> HelpSupports { get; set; } = null!;
        public virtual DbSet<HomeVideo> HomeVideos { get; set; } = null!;
        public virtual DbSet<HowtoVideo> HowtoVideos { get; set; } = null!;
        public virtual DbSet<InAppFeedback> InAppFeedbacks { get; set; } = null!;
        public virtual DbSet<Lap> Laps { get; set; } = null!;
        public virtual DbSet<Lap14jun2021> Lap14jun2021s { get; set; } = null!;
        public virtual DbSet<Lap28july21> Lap28july21s { get; set; } = null!;
        public virtual DbSet<LapArchived> LapArchiveds { get; set; } = null!;
        public virtual DbSet<LastLocationParked> LastLocationParkeds { get; set; } = null!;
        public virtual DbSet<LogException> LogExceptions { get; set; } = null!;
        public virtual DbSet<LogException13112019> LogException13112019s { get; set; } = null!;
        public virtual DbSet<LogException14112019> LogException14112019s { get; set; } = null!;
        public virtual DbSet<LogException15112019> LogException15112019s { get; set; } = null!;
        public virtual DbSet<LogException18112019> LogException18112019s { get; set; } = null!;
        public virtual DbSet<Maintainance> Maintainances { get; set; } = null!;
        public virtual DbSet<MasterDatum> MasterData { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<Mileage> Mileages { get; set; } = null!;
        public virtual DbSet<MileageForVehicle> MileageForVehicles { get; set; } = null!;
        public virtual DbSet<MobileNotification> MobileNotifications { get; set; } = null!;
        public virtual DbSet<MobileSetting> MobileSettings { get; set; } = null!;
        public virtual DbSet<MobileSettingInfo> MobileSettingInfos { get; set; } = null!;
        public virtual DbSet<Mode> Modes { get; set; } = null!;
        public virtual DbSet<ModeArchived> ModeArchiveds { get; set; } = null!;
        public virtual DbSet<N109cumulative> N109cumulatives { get; set; } = null!;
        public virtual DbSet<N109travelTransection> N109travelTransections { get; set; } = null!;
        public virtual DbSet<N109travelTransectionArchived> N109travelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<N251blecumulative> N251blecumulatives { get; set; } = null!;
        public virtual DbSet<N251bletravelTransection> N251bletravelTransections { get; set; } = null!;
        public virtual DbSet<N251bletravelTransectionArchiveIsDeleted> N251bletravelTransectionArchiveIsDeleteds { get; set; } = null!;
        public virtual DbSet<N251bletravelTransectionArchived> N251bletravelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<N251sppcumulative> N251sppcumulatives { get; set; } = null!;
        public virtual DbSet<N251spptravelTransection> N251spptravelTransections { get; set; } = null!;
        public virtual DbSet<N251spptravelTransectionArchived> N251spptravelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<Notificationtransection> Notificationtransections { get; set; } = null!;
        public virtual DbSet<Npsfeedback> Npsfeedbacks { get; set; } = null!;
        public virtual DbSet<NpsfeedbackReschedule> NpsfeedbackReschedules { get; set; } = null!;
        public virtual DbSet<ProvisionMarkerDss> ProvisionMarkerDsses { get; set; } = null!;
        public virtual DbSet<Repair> Repairs { get; set; } = null!;
        public virtual DbSet<RestrictedImei> RestrictedImeis { get; set; } = null!;
        public virtual DbSet<Ride> Rides { get; set; } = null!;
        public virtual DbSet<RideArchived> RideArchiveds { get; set; } = null!;
        public virtual DbSet<RideCumulative> RideCumulatives { get; set; } = null!;
        public virtual DbSet<RideTypeMapping> RideTypeMappings { get; set; } = null!;
        public virtual DbSet<RideTypeMappingArchived> RideTypeMappingArchiveds { get; set; } = null!;
        public virtual DbSet<RidingTip> RidingTips { get; set; } = null!;
        public virtual DbSet<Safety> Safeties { get; set; } = null!;
        public virtual DbSet<SchemaInfoDss> SchemaInfoDsses { get; set; } = null!;
        public virtual DbSet<ScopeConfigDss> ScopeConfigDsses { get; set; } = null!;
        public virtual DbSet<ScopeInfoDss> ScopeInfoDsses { get; set; } = null!;
        public virtual DbSet<ServiceFeedback> ServiceFeedbacks { get; set; } = null!;
        public virtual DbSet<ServiceHistory> ServiceHistories { get; set; } = null!;
        public virtual DbSet<Test123> Test123s { get; set; } = null!;
        public virtual DbSet<ThirdPartyApihitCount> ThirdPartyApihitCounts { get; set; } = null!;
        public virtual DbSet<Tour> Tours { get; set; } = null!;
        public virtual DbSet<TourArchived> TourArchiveds { get; set; } = null!;
        public virtual DbSet<TourPoint> TourPoints { get; set; } = null!;
        public virtual DbSet<TourPointArchived> TourPointArchiveds { get; set; } = null!;
        public virtual DbSet<U347cumulative> U347cumulatives { get; set; } = null!;
        public virtual DbSet<U347travelTransection> U347travelTransections { get; set; } = null!;
        public virtual DbSet<U347travelTransectionArchived> U347travelTransectionArchiveds { get; set; } = null!;
        public virtual DbSet<UserAdditionalSetting> UserAdditionalSettings { get; set; } = null!;
        public virtual DbSet<UserAddress> UserAddresses { get; set; } = null!;
        public virtual DbSet<UserAuthToken> UserAuthTokens { get; set; } = null!;
        public virtual DbSet<UserBadge> UserBadges { get; set; } = null!;
        public virtual DbSet<UserConsent> UserConsents { get; set; } = null!;
        public virtual DbSet<UserConsent2> UserConsent2s { get; set; } = null!;
        public virtual DbSet<UserDeleteReason> UserDeleteReasons { get; set; } = null!;
        public virtual DbSet<UserFeedback> UserFeedbacks { get; set; } = null!;
        public virtual DbSet<UserFeedback1> UserFeedback1s { get; set; } = null!;
        public virtual DbSet<UserFeedbackForm> UserFeedbackForms { get; set; } = null!;
        public virtual DbSet<UserGuide> UserGuides { get; set; } = null!;
        public virtual DbSet<UserGuide23022021> UserGuide23022021s { get; set; } = null!;
        public virtual DbSet<UserImage> UserImages { get; set; } = null!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public virtual DbSet<UserProfilesDssTracking> UserProfilesDssTrackings { get; set; } = null!;
        public virtual DbSet<UserRsakey> UserRsakeys { get; set; } = null!;
        public virtual DbSet<UserServiceFeedback> UserServiceFeedbacks { get; set; } = null!;
        public virtual DbSet<UserSettingConfiguration> UserSettingConfigurations { get; set; } = null!;
        public virtual DbSet<UserSupport> UserSupports { get; set; } = null!;
        public virtual DbSet<UserSurvey> UserSurveys { get; set; } = null!;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null!;
        public virtual DbSet<UserVehicle> UserVehicles { get; set; } = null!;
        public virtual DbSet<UserVehicleDssTracking> UserVehicleDssTrackings { get; set; } = null!;
        public virtual DbSet<UserVehicleMacActivation> UserVehicleMacActivations { get; set; } = null!;
        public virtual DbSet<UserVoiceCommand> UserVoiceCommands { get; set; } = null!;
        public virtual DbSet<VUserSetting> VUserSettings { get; set; } = null!;
        public virtual DbSet<VehicleAssistanceTypeMapping> VehicleAssistanceTypeMappings { get; set; } = null!;
        public virtual DbSet<VehicleOtp> VehicleOtps { get; set; } = null!;
        public virtual DbSet<VehicleServiceDatum> VehicleServiceData { get; set; } = null!;
        public virtual DbSet<VehicleServiceHistoryDatum> VehicleServiceHistoryData { get; set; } = null!;
        public virtual DbSet<VehicleSetting> VehicleSettings { get; set; } = null!;
        public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;
        public virtual DbSet<VinSampleImage> VinSampleImages { get; set; } = null!;
        public virtual DbSet<VoiceAction> VoiceActions { get; set; } = null!;
        public virtual DbSet<VoiceActionsBkp01112021> VoiceActionsBkp01112021s { get; set; } = null!;
        public virtual DbSet<VoiceActionsU458> VoiceActionsU458s { get; set; } = null!;
        public virtual DbSet<VoiceCommand> VoiceCommands { get; set; } = null!;
        public virtual DbSet<VoiceCommandsBkp01112021> VoiceCommandsBkp01112021s { get; set; } = null!;
        public virtual DbSet<VoiceCommandsU458> VoiceCommandsU458s { get; set; } = null!;
        public virtual DbSet<Widget> Widgets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=tvsmobile-appstg-db.database.windows.net;initial catalog=TVSMAZTCASDBUAT03;user id=tvsmobile-appstgusr;password=AppDB!usR@108ku;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminNotification>(entity =>
            {
                entity.ToTable("AdminNotification");

                entity.Property(e => e.AdminnotificationId).HasColumnName("adminnotificationId");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imageurl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsNotification)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isNotification");

                entity.Property(e => e.IsProcessed)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isProcessed");

                entity.Property(e => e.LastUpdatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdatedOn");

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");
            });

            modelBuilder.Entity<ApacheCumulative>(entity =>
            {
                entity.ToTable("ApacheCumulative");

                entity.Property(e => e.BikeAverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeAverageSpeed");

                entity.Property(e => e.BikeBestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeBestShortestTime");

                entity.Property(e => e.BikeMaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeMaxGforce");

                entity.Property(e => e.BikeMaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeMaxLeanAngle");

                entity.Property(e => e.BikeTopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeTopSpeed");

                entity.Property(e => e.BikeTotalDrivenTime).HasColumnName("bikeTotalDrivenTime");

                entity.Property(e => e.FifthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgRPM");

                entity.Property(e => e.FifthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgSpeed");

                entity.Property(e => e.FirstGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgRPM");

                entity.Property(e => e.FirstGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgSpeed");

                entity.Property(e => e.FourthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgRPM");

                entity.Property(e => e.FourthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgSpeed");

                entity.Property(e => e.SecondGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("secondGearAvgRPM");

                entity.Property(e => e.SecondGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("secondGearAvgSpeed");

                entity.Property(e => e.ThirdGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgRPM");

                entity.Property(e => e.ThirdGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgSpeed");

                entity.Property(e => e.TotalDistanceTravelled)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceTravelled");

                entity.Property(e => e.TotalRides).HasColumnName("totalRides");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ApacheCumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheCumulative_UserVehicle");
            });

            modelBuilder.Entity<ApacheNoniotcumulative>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApacheNONIOTCumulative");

                entity.Property(e => e.ApacheCumulativeId).ValueGeneratedOnAdd();

                entity.Property(e => e.BikeAverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeAverageSpeed");

                entity.Property(e => e.BikeBestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeBestShortestTime");

                entity.Property(e => e.BikeMaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeMaxAltitude");

                entity.Property(e => e.BikeMaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeMaxGforce");

                entity.Property(e => e.BikeMaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeMaxLeanAngle");

                entity.Property(e => e.BikeTopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bikeTopSpeed");

                entity.Property(e => e.BikeTotalDrivenTime).HasColumnName("bikeTotalDrivenTime");

                entity.Property(e => e.TotalDistanceTravelled)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceTravelled");

                entity.Property(e => e.TotalRides).HasColumnName("totalRides");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany()
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheNONIOTCumulative_UserVehicle");
            });

            modelBuilder.Entity<ApacheNoniottravelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId);

                entity.ToTable("ApacheNONIOTTravelTransection");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxAltitude");

                entity.Property(e => e.MaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxGforce");

                entity.Property(e => e.MaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxLeanAngle");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelRouteSnapshotLink");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.WayPoints)
                    .IsUnicode(false)
                    .HasColumnName("wayPoints");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ApacheNoniottravelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheNONIOTTravelTransection_UserVehicle");
            });

            modelBuilder.Entity<ApacheNoniottravelTransectionArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ApacheNONIOTTravelTransection_Archive");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime");

                entity.Property(e => e.BikeModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bikeModelName");

                entity.Property(e => e.FifthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgRPM");

                entity.Property(e => e.FifthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgSpeed");

                entity.Property(e => e.FirstGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgRPM");

                entity.Property(e => e.FirstGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgSpeed");

                entity.Property(e => e.FourthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgRPM");

                entity.Property(e => e.FourthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgSpeed");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRideType).HasColumnName("isRideType");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxAltitude");

                entity.Property(e => e.MaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxGforce");

                entity.Property(e => e.MaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxLeanAngle");

                entity.Property(e => e.MaxRpm).HasColumnName("maxRPM");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.SecondGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("secondGearAvgRPM");

                entity.Property(e => e.SecondGearAvgSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirdGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgRPM");

                entity.Property(e => e.ThirdGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgSpeed");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelId).ValueGeneratedOnAdd();

                entity.Property(e => e.TravelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelRouteSnapshotLink");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.WayPoints)
                    .IsUnicode(false)
                    .HasColumnName("wayPoints");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany()
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheNONIOTTravelTransection_Archive_UserVehicle");
            });

            modelBuilder.Entity<ApacheNoniottravelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("ApacheNONIOTTravelTransection_Archived");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxAltitude");

                entity.Property(e => e.MaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxGforce");

                entity.Property(e => e.MaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxLeanAngle");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelRouteSnapshotLink");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.WayPoints)
                    .IsUnicode(false)
                    .HasColumnName("wayPoints");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ApacheNoniottravelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheNONIOTTravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<ApacheTravelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId);

                entity.ToTable("ApacheTravelTransection");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime");

                entity.Property(e => e.BikeModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bikeModelName");

                entity.Property(e => e.FifthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgRPM");

                entity.Property(e => e.FifthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgSpeed");

                entity.Property(e => e.FirstGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgRPM");

                entity.Property(e => e.FirstGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgSpeed");

                entity.Property(e => e.FourthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgRPM");

                entity.Property(e => e.FourthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgSpeed");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRideType).HasColumnName("isRideType");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxAltitude");

                entity.Property(e => e.MaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxGforce");

                entity.Property(e => e.MaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxLeanAngle");

                entity.Property(e => e.MaxRpm).HasColumnName("maxRPM");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.SecondGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("secondGearAvgRPM");

                entity.Property(e => e.SecondGearAvgSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirdGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgRPM");

                entity.Property(e => e.ThirdGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgSpeed");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelRouteSnapshotLink");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.WayPoints)
                    .IsUnicode(false)
                    .HasColumnName("wayPoints");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ApacheTravelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheTravelTransection_UserVehicle");
            });

            modelBuilder.Entity<ApacheTravelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId)
                    .HasName("PK__ApacheTr__E3AD2D8AF2BC184A");

                entity.ToTable("ApacheTravelTransection_Archived");

                entity.Property(e => e.ArchivedInserDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime");

                entity.Property(e => e.BikeModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bikeModelName");

                entity.Property(e => e.FifthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgRPM");

                entity.Property(e => e.FifthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fifthGearAvgSpeed");

                entity.Property(e => e.FirstGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgRPM");

                entity.Property(e => e.FirstGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("firstGearAvgSpeed");

                entity.Property(e => e.FourthGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgRPM");

                entity.Property(e => e.FourthGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fourthGearAvgSpeed");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRideType).HasColumnName("isRideType");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxAltitude");

                entity.Property(e => e.MaxGforce)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxGforce");

                entity.Property(e => e.MaxLeanAngle)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("maxLeanAngle");

                entity.Property(e => e.MaxRpm).HasColumnName("maxRPM");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.SecondGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("secondGearAvgRPM");

                entity.Property(e => e.SecondGearAvgSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ThirdGearAvgRpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgRPM");

                entity.Property(e => e.ThirdGearAvgSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("thirdGearAvgSpeed");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelRouteSnapshotLink");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.WayPoints)
                    .IsUnicode(false)
                    .HasColumnName("wayPoints");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ApacheTravelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_ApacheTravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<AppAssest>(entity =>
            {
                entity.ToTable("AppAssest");

                entity.Property(e => e.AppAssestId).HasColumnName("appAssestId");

                entity.Property(e => e.Android)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("android");

                entity.Property(e => e.AndroidAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("androidAppVersionNumber");

                entity.Property(e => e.AppVersionId).HasColumnName("appVersionId");

                entity.Property(e => e.Ios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ios");

                entity.Property(e => e.IosAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("iosAppVersionNumber");

                entity.Property(e => e.IsForcefullyupdate).HasColumnName("isForcefullyupdate");

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Plateform)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plateform");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resolution");

                entity.Property(e => e.Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theme");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");
            });

            modelBuilder.Entity<AppAssestBkp24082020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppAssest_bkp_24-08-2020");

                entity.Property(e => e.Android)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("android");

                entity.Property(e => e.AndroidAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("androidAppVersionNumber");

                entity.Property(e => e.AppAssestId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("appAssestId");

                entity.Property(e => e.AppVersionId).HasColumnName("appVersionId");

                entity.Property(e => e.Ios)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ios");

                entity.Property(e => e.IosAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("iosAppVersionNumber");

                entity.Property(e => e.IsForcefullyupdate).HasColumnName("isForcefullyupdate");

                entity.Property(e => e.Link)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Plateform)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("plateform");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resolution");

                entity.Property(e => e.Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theme");

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");
            });

            modelBuilder.Entity<AppBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId);

                entity.ToTable("AppBanner");

                entity.Property(e => e.BannerId).HasColumnName("bannerId");

                entity.Property(e => e.BannerImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bannerImageLink");

                entity.Property(e => e.BannerRedirectLink)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bannerRedirectLink");
            });

            modelBuilder.Entity<AppVersion>(entity =>
            {
                entity.ToTable("AppVersion");

                entity.Property(e => e.AppVersionId).HasColumnName("appVersionId");

                entity.Property(e => e.AndroidAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("androidAppVersionNumber");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate");

                entity.Property(e => e.IosAppVersionNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("iosAppVersionNumber");

                entity.Property(e => e.IsForcefullyupdate).HasColumnName("isForcefullyupdate");
            });

            modelBuilder.Entity<AppVersion1>(entity =>
            {
                entity.HasKey(e => e.AppVersionId);

                entity.ToTable("AppVersions");

                entity.Property(e => e.AndroidAppVersionId).HasColumnName("androidAppVersionId");

                entity.Property(e => e.AndroidForcefullyupdate).HasColumnName("androidForcefullyupdate");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IosAppVersionId).HasColumnName("iosAppVersionId");

                entity.Property(e => e.IosForcefullyupdate).HasColumnName("iosForcefullyupdate");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_RoleId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<BadgeType>(entity =>
            {
                entity.ToTable("BadgeType");

                entity.Property(e => e.BadgeTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BikeService>(entity =>
            {
                entity.ToTable("BikeService");

                entity.Property(e => e.Bookingid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bookingid");

                entity.Property(e => e.CityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_id");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.DealerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dealer_id");

                entity.Property(e => e.Dealername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dealername");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emailid");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registration_number");

                entity.Property(e => e.RemarksComplaints)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("remarks_complaints");

                entity.Property(e => e.ServiceDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("service_date_time");

                entity.Property(e => e.ServiceTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("service_type_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.BikeServices)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_BikeService_UserVehicle");
            });

            modelBuilder.Entity<BreakDownAssistance>(entity =>
            {
                entity.HasKey(e => e.BreakDownAssitanceId);

                entity.ToTable("BreakDownAssistance");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Landmark)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Lat)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Long)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.BreakDownAssistances)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_BreakDownAssistance_UserVehicle");
            });

            modelBuilder.Entity<BreakDownAssistanceType>(entity =>
            {
                entity.ToTable("BreakDownAssistanceType");

                entity.Property(e => e.AssistanceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Citymaster>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_tbl_citymaster");

                entity.ToTable("citymaster");

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientSecret>(entity =>
            {
                entity.ToTable("ClientSecret");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Key)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Platform)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactSupport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactSupport");

                entity.Property(e => e.ContactSupportId).ValueGeneratedOnAdd();

                entity.Property(e => e.FeatureDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Csifeedback>(entity =>
            {
                entity.ToTable("CSIFeedback");

                entity.Property(e => e.CsifeedbackId).HasColumnName("CSIFeedbackId");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CsifeedbackRescheduleId).HasColumnName("CSIFeedbackRescheduleId");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.IsSavedInDms)
                    .HasColumnName("IsSavedInDMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Jcstatus).HasColumnName("JCStatus");

                entity.Property(e => e.Jctype).HasColumnName("JCType");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseFromDms).HasColumnName("ResponseFromDMS");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.HasOne(d => d.CsifeedbackReschedule)
                    .WithMany(p => p.Csifeedbacks)
                    .HasForeignKey(d => d.CsifeedbackRescheduleId)
                    .HasConstraintName("FK_CSIFeedback_CSIFeedbackReschedule");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Csifeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSIFeedback_UserProfiles");
            });

            modelBuilder.Entity<CsifeedbackReschedule>(entity =>
            {
                entity.ToTable("CSIFeedbackReschedule");

                entity.Property(e => e.CsifeedbackRescheduleId).HasColumnName("CSIFeedbackRescheduleId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.IsRescheduledMaxLimitReached).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RescheduleDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CsifeedbackReschedules)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSIFeedbackReschedule_UserProfiles");
            });

            modelBuilder.Entity<Csinpsfeedback>(entity =>
            {
                entity.ToTable("CSINPSFeedback");

                entity.Property(e => e.CsinpsfeedbackId).HasColumnName("CSINPSFeedbackId");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.Csicreated)
                    .HasColumnType("datetime")
                    .HasColumnName("CSICreated");

                entity.Property(e => e.CsifeedbackRescheduleId).HasColumnName("CSIFeedbackRescheduleId");

                entity.Property(e => e.CsirescheduledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CSIRescheduledDate");

                entity.Property(e => e.FrameNumber).HasMaxLength(50);

                entity.Property(e => e.IsCsirecheduled).HasColumnName("IsCSIRecheduled");

                entity.Property(e => e.IsNpsrecheduled).HasColumnName("IsNPSRecheduled");

                entity.Property(e => e.NpscreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("NPSCreatedOn");

                entity.Property(e => e.NpsrescheduledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NPSRescheduledDate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Csinpsfeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CSINPSFeedback_UserProfiles");
            });

            modelBuilder.Entity<CustomUserProfile>(entity =>
            {
                entity.HasKey(e => e.CustomUserId)
                    .HasName("PK_dbo.[CustomUserId");

                entity.Property(e => e.AllergicContent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AndroidToken)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("androidToken");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrashAlertDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GooglePlusId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IosToken)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("iosToken");

                entity.Property(e => e.IsOtpverified).HasColumnName("IsOTPVerified");

                entity.Property(e => e.IsRegistered).HasColumnName("isRegistered");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.OtpgenerateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPGenerateTime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.ProfileImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("registrationId");

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmsquestionAnswerMapper>(entity =>
            {
                entity.ToTable("DMSQuestionAnswerMapper");

                entity.Property(e => e.DmsanswerId).HasColumnName("DMSAnswerId");

                entity.Property(e => e.DmsquestionId).HasColumnName("DMSQuestionId");

                entity.Property(e => e.MapKey).HasMaxLength(50);

                entity.Property(e => e.MapValue).HasMaxLength(50);
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.ToTable("EmergencyContact");

                entity.Property(e => e.ContactImagePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmergencyContacts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_EmergencyContact_UserProfiles");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Faqid).HasColumnName("FAQId");

                entity.Property(e => e.AccessVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Answers).HasColumnType("ntext");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryId");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Questions)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faqcategory)
                    .WithMany(p => p.Faqs)
                    .HasForeignKey(d => d.FaqcategoryId)
                    .HasConstraintName("FK__tbl_Categ__Categ__17F790F9");
            });

            modelBuilder.Entity<FaqTemp01022021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FAQ_temp01-02-2021");

                entity.Property(e => e.Answers).HasColumnType("ntext");

                entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryId");

                entity.Property(e => e.Faqid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAQId");

                entity.Property(e => e.Questions)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Faqcategory>(entity =>
            {
                entity.ToTable("FAQCategory");

                entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryId");

                entity.Property(e => e.AccessVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FaqcategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryName");

                entity.Property(e => e.FaqcategoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryType");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FaqcategoryTemp01022021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FAQCategory_temp01-02-2021");

                entity.Property(e => e.FaqcategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAQCategoryId");

                entity.Property(e => e.FaqcategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryName");

                entity.Property(e => e.FaqcategoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryType");
            });

            modelBuilder.Entity<FaqcategoryTemp11032022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FAQCategoryTemp11032022");

                entity.Property(e => e.AccessVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FaqcategoryId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAQCategoryId");

                entity.Property(e => e.FaqcategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryName");

                entity.Property(e => e.FaqcategoryType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FAQCategoryType");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Faqtemp11032022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FAQTemp11032022");

                entity.Property(e => e.AccessVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Answers).HasColumnType("ntext");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FaqcategoryId).HasColumnName("FAQCategoryId");

                entity.Property(e => e.Faqid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FAQId");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Questions)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FeedbackType>(entity =>
            {
                entity.ToTable("FeedbackType");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsVehicleRelatedFeedback).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Games", "Gaming");

                entity.Property(e => e.GameName).HasMaxLength(50);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<GameAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK_Answers");

                entity.ToTable("GameAnswers", "Gaming");

                entity.Property(e => e.AnswerText).HasMaxLength(50);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameAnswerInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_Answers_InsertedBy");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.GameAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Answers_Questions");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameAnswerUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Answers_UpdatedBy");
            });

            modelBuilder.Entity<GameCategory>(entity =>
            {
                entity.ToTable("GameCategories", "Gaming");

                entity.Property(e => e.GameCategoryName).HasMaxLength(50);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameCategories)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK_GameCategories_Games");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameCategoryInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_GameCategories_InsertedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameCategoryUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_GameCategories_UpdatedBy");
            });

            modelBuilder.Entity<GameContest>(entity =>
            {
                entity.HasKey(e => e.ContestId)
                    .HasName("PK_Contests");

                entity.ToTable("GameContests", "Gaming");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameContestInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_Contests_InsertedBy");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.GameContests)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Contests_Questions");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameContestUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Contests_UpdatedBy");
            });

            modelBuilder.Entity<GameMode>(entity =>
            {
                entity.ToTable("GameModes", "Gaming");

                entity.Property(e => e.GameModeName).HasMaxLength(50);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameModeInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_GameModes_InsertedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameModeUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_GameModes_UpdatedBy");
            });

            modelBuilder.Entity<GameProperty>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .HasName("PK_Properties");

                entity.ToTable("GameProperties", "Gaming");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.PropertyName).HasMaxLength(50);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GamePropertyInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_Properties_InsertedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GamePropertyUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Properties_UpdatedBy");
            });

            modelBuilder.Entity<GameQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_Questions");

                entity.ToTable("GameQuestions", "Gaming");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.QuestionImageUrl).HasColumnName("QuestionImageURL");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.GameCategory)
                    .WithMany(p => p.GameQuestions)
                    .HasForeignKey(d => d.GameCategoryId)
                    .HasConstraintName("FK_Questions_GameCategories");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameQuestionInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_Questions_InsertedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameQuestionUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Questions_UpdatedBy");
            });

            modelBuilder.Entity<GameScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId);

                entity.ToTable("GameScores", "Gaming");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.GameScores)
                    .HasForeignKey(d => d.BadgeId)
                    .HasConstraintName("FK_GameScores_Properties");

                entity.HasOne(d => d.GameCategory)
                    .WithMany(p => p.GameScores)
                    .HasForeignKey(d => d.GameCategoryId)
                    .HasConstraintName("FK_GameScores_GameCategories");

                entity.HasOne(d => d.GameMode)
                    .WithMany(p => p.GameScores)
                    .HasForeignKey(d => d.GameModeId)
                    .HasConstraintName("FK_GameScores_GameModes");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.GameScoreInsertedByNavigations)
                    .HasForeignKey(d => d.InsertedBy)
                    .HasConstraintName("FK_GameScores_InsertedBy");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.GameScoreUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_GameScores_UpdatedBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GameScoreUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GameScores_UserProfiles");
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.ToTable("Gear");

                entity.Property(e => e.AverageDownShiftRpm).HasColumnName("AverageDownShiftRPM");

                entity.Property(e => e.AverageDownShiftSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageRpm).HasColumnName("AverageRPM");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageUpShiftRpm).HasColumnName("AverageUpShiftRPM");

                entity.Property(e => e.AverageUpShiftSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TotalDistanceCovered).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ride)
                    .WithMany(p => p.Gears)
                    .HasForeignKey(d => d.RideId)
                    .HasConstraintName("FK_Gear_Ride");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Gears)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Gear_Tour");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Gears)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gear_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Gears)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gear_VehicleType");
            });

            modelBuilder.Entity<GearArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PK_GearGear_Archived");

                entity.ToTable("Gear_Archived");

                entity.Property(e => e.AverageDownShiftRpm).HasColumnName("AverageDownShiftRPM");

                entity.Property(e => e.AverageDownShiftSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageRpm).HasColumnName("AverageRPM");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AverageUpShiftRpm).HasColumnName("AverageUpShiftRPM");

                entity.Property(e => e.AverageUpShiftSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TotalDistanceCovered).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HelpSupport>(entity =>
            {
                entity.ToTable("HelpSupport");

                entity.Property(e => e.DateTime)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HelpCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HelpDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HelpImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HelpTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HomeVideo>(entity =>
            {
                entity.HasKey(e => e.VideoLinkId)
                    .HasName("PK_tbl_HomeVideo");

                entity.ToTable("HomeVideo");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoThumbnailLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HowtoVideo>(entity =>
            {
                entity.HasKey(e => e.VedioId)
                    .HasName("PK__HowtoVid__041161C5C0B641F2");

                entity.Property(e => e.Application)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbNailPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VideoName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InAppFeedback>(entity =>
            {
                entity.ToTable("InAppFeedback");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Feedback).HasMaxLength(500);

                entity.Property(e => e.PlatformType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReviewTopic).HasMaxLength(500);

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InAppFeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InAppFeedback_UserProfiles");
            });

            modelBuilder.Entity<Lap>(entity =>
            {
                entity.ToTable("Lap");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LapDistance).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ride)
                    .WithMany(p => p.Laps)
                    .HasForeignKey(d => d.RideId)
                    .HasConstraintName("FK_Lap_Ride");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Laps)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lap_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Laps)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lap_VehicleType");
            });

            modelBuilder.Entity<Lap14jun2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lap_14Jun2021");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LapDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LapId).ValueGeneratedOnAdd();

                entity.Property(e => e.LeanAngle).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rpm).HasColumnName("RPM");

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Lap28july21>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lap_28July21");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LapDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LapId).ValueGeneratedOnAdd();

                entity.Property(e => e.LeanAngle).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rpm).HasColumnName("RPM");

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<LapArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("Lap_Archived");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LapDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.LapArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lap_Archived_UserVehicle2");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.LapArchiveds)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lap_Archived_VehicleType2");
            });

            modelBuilder.Entity<LastLocationParked>(entity =>
            {
                entity.HasKey(e => e.LastLocationPathId)
                    .HasName("PK_LastLocationPath");

                entity.ToTable("LastLocationParked");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedDate");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogException>(entity =>
            {
                entity.ToTable("LogException");

                entity.Property(e => e.Enterydate)
                    .HasColumnType("datetime")
                    .HasColumnName("enterydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modulename).HasColumnName("modulename");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogException13112019>(entity =>
            {
                entity.HasKey(e => e.LogExceptionId)
                    .HasName("PK__LogExcep__9FB8CB361EEDD5B5");

                entity.ToTable("LogException_13112019");

                entity.Property(e => e.Enterydate)
                    .HasColumnType("datetime")
                    .HasColumnName("enterydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modulename).HasColumnName("modulename");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogException14112019>(entity =>
            {
                entity.HasKey(e => e.LogExceptionId)
                    .HasName("PK__LogExcep__9FB8CB36BFE96C78");

                entity.ToTable("LogException_14112019");

                entity.Property(e => e.Enterydate)
                    .HasColumnType("datetime")
                    .HasColumnName("enterydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Extra1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extra3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modulename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modulename");

                entity.Property(e => e.PageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace).HasColumnType("text");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<LogException15112019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogException_15112019");

                entity.Property(e => e.Enterydate)
                    .HasColumnType("datetime")
                    .HasColumnName("enterydate");

                entity.Property(e => e.Modulename).HasColumnName("modulename");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<LogException18112019>(entity =>
            {
                entity.HasKey(e => e.LogExceptionId)
                    .HasName("PK__LogExcep__9FB8CB3603895D8E");

                entity.ToTable("LogException_18112019");

                entity.Property(e => e.Enterydate)
                    .HasColumnType("datetime")
                    .HasColumnName("enterydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Extra1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Extra2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Extra3)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Modulename)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("modulename");

                entity.Property(e => e.PageName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSystem)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Maintainance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Maintainance");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaintainanceId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterDatum>(entity =>
            {
                entity.HasKey(e => new { e.MasterDataId, e.Type })
                    .HasName("PK__MasterDa__867627657168CA2F");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Mileage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mileage");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MileageId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MileageForVehicle>(entity =>
            {
                entity.HasKey(e => e.MileageVehicleId)
                    .HasName("PK_MileageVehicleId");

                entity.ToTable("MileageForVehicle");

                entity.Property(e => e.AverageRunningPerDay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FuelQuantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fuelQuantity");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedDateTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MiterReading).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MobileNotification>(entity =>
            {
                entity.ToTable("MobileNotification");

                entity.Property(e => e.Acknowledge)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsRead)
                    .HasColumnName("isRead")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSent).HasColumnName("isSent");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");
            });

            modelBuilder.Entity<MobileSetting>(entity =>
            {
                entity.ToTable("MobileSetting");

                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InfoUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OptimizationCatagory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MobileSettingInfo>(entity =>
            {
                entity.ToTable("MobileSettingInfo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InfoHeader)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Platform)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mode>(entity =>
            {
                entity.ToTable("Mode");

                entity.Property(e => e.CruisingRange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LiterPer100Km)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LiterPer100KM");

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDistanceCovered).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Ride)
                    .WithMany(p => p.Modes)
                    .HasForeignKey(d => d.RideId)
                    .HasConstraintName("FK_Mode_Ride");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Modes)
                    .HasForeignKey(d => d.TourId)
                    .HasConstraintName("FK_Mode_Tour");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Modes)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Modes)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_VehicleType");
            });

            modelBuilder.Entity<ModeArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("Mode_Archived");

                entity.Property(e => e.CruisingRange).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LiterPer100Km)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LiterPer100KM");

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TotalDistanceCovered).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.ModeArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_Archived_UserVehicle1");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.ModeArchiveds)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_Archived_VehicleType1");
            });

            modelBuilder.Entity<N109cumulative>(entity =>
            {
                entity.ToTable("N109Cumulative");

                entity.Property(e => e.N109cumulativeId).HasColumnName("N109CumulativeId");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeBatteryDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeBatteryDistance");

                entity.Property(e => e.EcoModeEngineDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeEngineDistance");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.PowerModeCombinedBedistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeCombinedBEDistance");

                entity.Property(e => e.PowerModeOnlyEngDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeOnlyEngDistance");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.Totalrides).HasColumnName("totalrides");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N109cumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N109Cumulative_UserVehicle");
            });

            modelBuilder.Entity<N109travelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId);

                entity.ToTable("N109TravelTransection");

                entity.Property(e => e.TravelId).HasColumnName("travelId");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeBatteryDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeBatteryDistance");

                entity.Property(e => e.EcoModeEngineDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeEngineDistance");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.PowerModeCombinedBedistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeCombinedBEDistance");

                entity.Property(e => e.PowerModeOnlyEngDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeOnlyEngDistance");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N109travelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N109TravelTransection_UserVehicle");
            });

            modelBuilder.Entity<N109travelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId);

                entity.ToTable("N109TravelTransection_Archived");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeBatteryDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeBatteryDistance");

                entity.Property(e => e.EcoModeEngineDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeEngineDistance");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.PowerModeCombinedBedistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeCombinedBEDistance");

                entity.Property(e => e.PowerModeOnlyEngDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeOnlyEngDistance");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelId).HasColumnName("travelId");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N109travelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N109TravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<N251blecumulative>(entity =>
            {
                entity.ToTable("N251BLECumulative");

                entity.HasIndex(e => e.UserId, "NonClusteredIndex-UserId");

                entity.HasIndex(e => e.UserVehicleId, "NonClusteredIndex-UserVehicleID");

                entity.HasIndex(e => e.TopSpeedOverAll, "NonClusteredIndex-topSpeedOverAll");

                entity.Property(e => e.N251blecumulativeId).HasColumnName("N251BLECumulativeId");

                entity.Property(e => e.AverageSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedOverAll");

                entity.Property(e => e.AverageSpeedRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedRaceMode");

                entity.Property(e => e.AverageSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedSportMode");

                entity.Property(e => e.AverageSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedStreetMode");

                entity.Property(e => e.Best0to60RaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60RaceMode");

                entity.Property(e => e.Best0to60StreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60StreetMode");

                entity.Property(e => e.BestShortestTimeSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTimeSportMode");

                entity.Property(e => e.IdleTime).HasColumnName("idleTime");

                entity.Property(e => e.LapDistanceSportMode).HasColumnName("lapDistanceSportMode");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.OdometerReading)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("odometerReading");

                entity.Property(e => e.RaceModeRides).HasColumnName("raceModeRides");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.RideTimeRaceMode).HasColumnName("rideTimeRaceMode");

                entity.Property(e => e.RideTimeStreetMode).HasColumnName("rideTimeStreetMode");

                entity.Property(e => e.SportModeRides).HasColumnName("sportModeRides");

                entity.Property(e => e.StreetModeRides).HasColumnName("streetModeRides");

                entity.Property(e => e.TopRpm).HasColumnName("topRPM");

                entity.Property(e => e.TopRpmraceMode).HasColumnName("topRPMRaceMode");

                entity.Property(e => e.TopRpmstreetMode).HasColumnName("topRPMStreetMode");

                entity.Property(e => e.TopSpeedOverAll).HasColumnName("topSpeedOverAll");

                entity.Property(e => e.TopSpeedRaceMode).HasColumnName("topSpeedRaceMode");

                entity.Property(e => e.TopSpeedSportMode).HasColumnName("topSpeedSportMode");

                entity.Property(e => e.TopSpeedStreetMode).HasColumnName("topSpeedStreetMode");

                entity.Property(e => e.TotalDistanceOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceOverAll");

                entity.Property(e => e.TotalDistanceRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceRaceMode");

                entity.Property(e => e.TotalDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceSportMode");

                entity.Property(e => e.TotalDistanceStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceStreetMode");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.Totalrides).HasColumnName("totalrides");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserVehicleId).HasColumnName("userVehicleId");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251blecumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251BLECumulative_UserVehicle");
            });

            modelBuilder.Entity<N251bletravelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("PK__N251BLET__E93152355ED39751");

                entity.ToTable("N251BLETravelTransection");

                entity.Property(e => e.AchievementList)
                    .HasMaxLength(10)
                    .HasColumnName("achievementList");

                entity.Property(e => e.AchievementType).HasColumnName("achievementType");

                entity.Property(e => e.AverageRpm).HasColumnName("averageRPM");

                entity.Property(e => e.AverageSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedOverAll");

                entity.Property(e => e.AverageSpeedRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedRaceMode");

                entity.Property(e => e.AverageSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedSportMode");

                entity.Property(e => e.AverageSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedStreetMode");

                entity.Property(e => e.Best0to60RaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60RaceMode");

                entity.Property(e => e.Best0to60StreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60StreetMode");

                entity.Property(e => e.BestShortestTimeSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTimeSportMode");

                entity.Property(e => e.IdleTime).HasColumnName("idleTime");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRaceMode).HasColumnName("isRaceMode");

                entity.Property(e => e.IsSportMode).HasColumnName("isSportMode");

                entity.Property(e => e.IsStreetMode).HasColumnName("isStreetMode");

                entity.Property(e => e.LapDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lapDistanceSportMode");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.OdometerReading)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("odometerReading");

                entity.Property(e => e.RaceModeRides).HasColumnName("raceModeRides");

                entity.Property(e => e.RideMmidownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("rideMMIDownloadLink");

                entity.Property(e => e.RideTag).HasColumnName("rideTag");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.RideTimeRaceMode).HasColumnName("rideTimeRaceMode");

                entity.Property(e => e.RideTimeStreetMode).HasColumnName("rideTimeStreetMode");

                entity.Property(e => e.SportModeRides).HasColumnName("sportModeRides");

                entity.Property(e => e.StreetModeRides).HasColumnName("streetModeRides");

                entity.Property(e => e.TopRpm).HasColumnName("topRPM");

                entity.Property(e => e.TopRpmraceMode).HasColumnName("topRPMRaceMode");

                entity.Property(e => e.TopRpmstreetMode).HasColumnName("topRPMStreetMode");

                entity.Property(e => e.TopSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedOverAll");

                entity.Property(e => e.TopSpeedRaceMode).HasColumnName("topSpeedRaceMode");

                entity.Property(e => e.TopSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedSportMode");

                entity.Property(e => e.TopSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedStreetMode");

                entity.Property(e => e.TotalDistanceOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceOverAll");

                entity.Property(e => e.TotalDistanceRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceRaceMode");

                entity.Property(e => e.TotalDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceSportMode");

                entity.Property(e => e.TotalDistanceStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceStreetMode");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.Property(e => e.WeatherIcon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherIcon");

                entity.Property(e => e.WeatherShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherShortDescription");

                entity.Property(e => e.WeatherTemp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherTemp");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251bletravelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251BLETravelTransection_UserVehicle");
            });

            modelBuilder.Entity<N251bletravelTransectionArchiveIsDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("N251BLETravelTransectionArchiveIsDeleted");

                entity.Property(e => e.AchievementList)
                    .HasMaxLength(10)
                    .HasColumnName("achievementList");

                entity.Property(e => e.AchievementType).HasColumnName("achievementType");

                entity.Property(e => e.AverageRpm).HasColumnName("averageRPM");

                entity.Property(e => e.AverageSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedOverAll");

                entity.Property(e => e.AverageSpeedRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedRaceMode");

                entity.Property(e => e.AverageSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedSportMode");

                entity.Property(e => e.AverageSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedStreetMode");

                entity.Property(e => e.Best0to60RaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60RaceMode");

                entity.Property(e => e.Best0to60StreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60StreetMode");

                entity.Property(e => e.BestShortestTimeSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTimeSportMode");

                entity.Property(e => e.IdleTime).HasColumnName("idleTime");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRaceMode).HasColumnName("isRaceMode");

                entity.Property(e => e.IsSportMode).HasColumnName("isSportMode");

                entity.Property(e => e.IsStreetMode).HasColumnName("isStreetMode");

                entity.Property(e => e.LapDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lapDistanceSportMode");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.OdometerReading)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("odometerReading");

                entity.Property(e => e.RaceModeRides).HasColumnName("raceModeRides");

                entity.Property(e => e.RideTag).HasColumnName("rideTag");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.RideTimeRaceMode).HasColumnName("rideTimeRaceMode");

                entity.Property(e => e.RideTimeStreetMode).HasColumnName("rideTimeStreetMode");

                entity.Property(e => e.SportModeRides).HasColumnName("sportModeRides");

                entity.Property(e => e.StreetModeRides).HasColumnName("streetModeRides");

                entity.Property(e => e.TopRpm).HasColumnName("topRPM");

                entity.Property(e => e.TopRpmraceMode).HasColumnName("topRPMRaceMode");

                entity.Property(e => e.TopRpmstreetMode).HasColumnName("topRPMStreetMode");

                entity.Property(e => e.TopSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedOverAll");

                entity.Property(e => e.TopSpeedRaceMode).HasColumnName("topSpeedRaceMode");

                entity.Property(e => e.TopSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedSportMode");

                entity.Property(e => e.TopSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedStreetMode");

                entity.Property(e => e.TotalDistanceOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceOverAll");

                entity.Property(e => e.TotalDistanceRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceRaceMode");

                entity.Property(e => e.TotalDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceSportMode");

                entity.Property(e => e.TotalDistanceStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceStreetMode");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelId).ValueGeneratedOnAdd();

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.Property(e => e.WeatherIcon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherIcon");

                entity.Property(e => e.WeatherShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherShortDescription");

                entity.Property(e => e.WeatherTemp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherTemp");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany()
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251BLETravelTransectionArchiveIsDeleted_UserVehicle");
            });

            modelBuilder.Entity<N251bletravelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId);

                entity.ToTable("N251BLETravelTransection_Archived");

                entity.Property(e => e.AchievementList)
                    .HasMaxLength(10)
                    .HasColumnName("achievementList");

                entity.Property(e => e.AchievementType).HasColumnName("achievementType");

                entity.Property(e => e.AverageRpm).HasColumnName("averageRPM");

                entity.Property(e => e.AverageSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedOverAll");

                entity.Property(e => e.AverageSpeedRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedRaceMode");

                entity.Property(e => e.AverageSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedSportMode");

                entity.Property(e => e.AverageSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeedStreetMode");

                entity.Property(e => e.Best0to60RaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60RaceMode");

                entity.Property(e => e.Best0to60StreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("best0to60StreetMode");

                entity.Property(e => e.BestShortestTimeSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTimeSportMode");

                entity.Property(e => e.IdleTime).HasColumnName("idleTime");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.IsRaceMode).HasColumnName("isRaceMode");

                entity.Property(e => e.IsSportMode).HasColumnName("isSportMode");

                entity.Property(e => e.IsStreetMode).HasColumnName("isStreetMode");

                entity.Property(e => e.LapDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lapDistanceSportMode");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.OdometerReading)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("odometerReading");

                entity.Property(e => e.RaceModeRides).HasColumnName("raceModeRides");

                entity.Property(e => e.RideMmidownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("rideMMIDownloadLink");

                entity.Property(e => e.RideTag).HasColumnName("rideTag");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.RideTimeRaceMode).HasColumnName("rideTimeRaceMode");

                entity.Property(e => e.RideTimeStreetMode).HasColumnName("rideTimeStreetMode");

                entity.Property(e => e.SportModeRides).HasColumnName("sportModeRides");

                entity.Property(e => e.StreetModeRides).HasColumnName("streetModeRides");

                entity.Property(e => e.TopRpm).HasColumnName("topRPM");

                entity.Property(e => e.TopRpmraceMode).HasColumnName("topRPMRaceMode");

                entity.Property(e => e.TopRpmstreetMode).HasColumnName("topRPMStreetMode");

                entity.Property(e => e.TopSpeedOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedOverAll");

                entity.Property(e => e.TopSpeedRaceMode).HasColumnName("topSpeedRaceMode");

                entity.Property(e => e.TopSpeedSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedSportMode");

                entity.Property(e => e.TopSpeedStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeedStreetMode");

                entity.Property(e => e.TotalDistanceOverAll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceOverAll");

                entity.Property(e => e.TotalDistanceRaceMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceRaceMode");

                entity.Property(e => e.TotalDistanceSportMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceSportMode");

                entity.Property(e => e.TotalDistanceStreetMode)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalDistanceStreetMode");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.Property(e => e.WeatherIcon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherIcon");

                entity.Property(e => e.WeatherShortDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherShortDescription");

                entity.Property(e => e.WeatherTemp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("weatherTemp");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251bletravelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251BLETravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<N251sppcumulative>(entity =>
            {
                entity.ToTable("N251SPPCumulative");

                entity.Property(e => e.N251sppcumulativeId).HasColumnName("N251SPPCumulativeId");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.Totalrides).HasColumnName("totalrides");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251sppcumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251SPPCumulative_UserVehicle");
            });

            modelBuilder.Entity<N251spptravelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("PK_N251TravelTransection");

                entity.ToTable("N251SPPTravelTransection");

                entity.HasIndex(e => e.TravelFileName, "NonClusteredIndex-TravelFileName");

                entity.HasIndex(e => e.TravelStartDateTime, "NonClusteredIndex-TravelStartDateTime");

                entity.HasIndex(e => e.UserId, "NonClusteredIndex-UserId");

                entity.HasIndex(e => e.UserVehicleId, "NonClusteredIndex-UserVehicleId");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251spptravelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251SPPTravelTransection_UserVehicle");
            });

            modelBuilder.Entity<N251spptravelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId)
                    .HasName("PK_N251TravelTransection_Archived");

                entity.ToTable("N251SPPTravelTransection_Archived");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastFuelStatus).HasColumnName("lastFuelStatus");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.N251spptravelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_N251SPPTravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<Notificationtransection>(entity =>
            {
                entity.ToTable("notificationtransection");

                entity.Property(e => e.Notificationtransectionid).HasColumnName("notificationtransectionid");

                entity.Property(e => e.AdminnotificationId).HasColumnName("adminnotificationId");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsProcessed)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isProcessed");

                entity.Property(e => e.Isread).HasColumnName("isread");

                entity.Property(e => e.Issent)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("issent");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Uservehicleid).HasColumnName("uservehicleid");
            });

            modelBuilder.Entity<Npsfeedback>(entity =>
            {
                entity.ToTable("NPSFeedback");

                entity.Property(e => e.NpsfeedbackId).HasColumnName("NPSFeedbackId");

                entity.Property(e => e.AreaOfImprovement).HasMaxLength(500);

                entity.Property(e => e.ContactInformation).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExplanationForRating).HasMaxLength(500);

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.IsSavedInDms)
                    .HasColumnName("IsSavedInDMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NpsfeedbackRescheduleId).HasColumnName("NPSFeedbackRescheduleId");

                entity.Property(e => e.ResponseFromDms).HasColumnName("ResponseFromDMS");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.HasOne(d => d.NpsfeedbackReschedule)
                    .WithMany(p => p.Npsfeedbacks)
                    .HasForeignKey(d => d.NpsfeedbackRescheduleId)
                    .HasConstraintName("FK_NPSFeedback_NPSFeedback");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Npsfeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPSFeedback_UserProfiles");
            });

            modelBuilder.Entity<NpsfeedbackReschedule>(entity =>
            {
                entity.ToTable("NPSFeedbackReschedule");

                entity.Property(e => e.NpsfeedbackRescheduleId).HasColumnName("NPSFeedbackRescheduleId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.IsRescheduledMaxLimitReached).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RescheduleDate).HasColumnType("datetime");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NpsfeedbackReschedules)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPSFeedbackReschedule_UserProfiles");
            });

            modelBuilder.Entity<ProvisionMarkerDss>(entity =>
            {
                entity.HasKey(e => new { e.OwnerScopeLocalId, e.ObjectId })
                    .HasName("PK_DataSync.provision_marker_dss");

                entity.ToTable("provision_marker_dss", "DataSync");

                entity.Property(e => e.OwnerScopeLocalId).HasColumnName("owner_scope_local_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ProvisionDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("provision_datetime");

                entity.Property(e => e.ProvisionLocalPeerKey).HasColumnName("provision_local_peer_key");

                entity.Property(e => e.ProvisionScopeLocalId).HasColumnName("provision_scope_local_id");

                entity.Property(e => e.ProvisionScopePeerKey).HasColumnName("provision_scope_peer_key");

                entity.Property(e => e.ProvisionScopePeerTimestamp).HasColumnName("provision_scope_peer_timestamp");

                entity.Property(e => e.ProvisionTimestamp).HasColumnName("provision_timestamp");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Version)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("version");
            });

            modelBuilder.Entity<Repair>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Repair");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RepairId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RestrictedImei>(entity =>
            {
                entity.HasKey(e => e.ImeinumberId);

                entity.ToTable("RestrictedIMEI");

                entity.Property(e => e.ImeinumberId).HasColumnName("IMEINumberId");

                entity.Property(e => e.Imeinumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMEINumber");
            });

            modelBuilder.Entity<Ride>(entity =>
            {
                entity.ToTable("Ride");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BikeModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RideFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RideMmidownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RideMMIDownloadLink");

                entity.Property(e => e.RideName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RideRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RideStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTravelledDistance).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Rides)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ride_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Rides)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ride_VehicleType");
            });

            modelBuilder.Entity<RideArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId);

                entity.ToTable("Ride_Archived");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BikeModelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Day)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.RideFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RideMmidownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RideMMIDownloadLink");

                entity.Property(e => e.RideName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RideRouteSnapshotLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RideStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTravelledDistance).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.RideArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ride_Archived_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.RideArchiveds)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ride_Archived_VehicleType");
            });

            modelBuilder.Entity<RideCumulative>(entity =>
            {
                entity.ToTable("RideCumulative");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTravelledDistance).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.RideCumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RideCumulative_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.RideCumulatives)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RideCumulative_VehicleType");
            });

            modelBuilder.Entity<RideTypeMapping>(entity =>
            {
                entity.ToTable("RideTypeMapping");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ride)
                    .WithMany(p => p.RideTypeMappings)
                    .HasForeignKey(d => d.RideId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RideTypeMapping_Ride");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.RideTypeMappings)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RideTypeMapping_Tour");
            });

            modelBuilder.Entity<RideTypeMappingArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("RideTypeMapping_Archived");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RidingTip>(entity =>
            {
                entity.ToTable("RidingTip");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeId).HasColumnName("vehicleTypeId");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Safety>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Safety");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SafetyId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchemaInfoDss>(entity =>
            {
                entity.HasKey(e => new { e.SchemaMajorVersion, e.SchemaMinorVersion })
                    .HasName("PK_DataSync.schema_info_dss");

                entity.ToTable("schema_info_dss", "DataSync");

                entity.Property(e => e.SchemaMajorVersion).HasColumnName("schema_major_version");

                entity.Property(e => e.SchemaMinorVersion).HasColumnName("schema_minor_version");

                entity.Property(e => e.SchemaExtendedInfo)
                    .HasMaxLength(100)
                    .HasColumnName("schema_extended_info");
            });

            modelBuilder.Entity<ScopeConfigDss>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("PK_DataSync.scope_config_dss");

                entity.ToTable("scope_config_dss", "DataSync");

                entity.Property(e => e.ConfigId)
                    .ValueGeneratedNever()
                    .HasColumnName("config_id");

                entity.Property(e => e.ConfigData)
                    .HasColumnType("xml")
                    .HasColumnName("config_data");

                entity.Property(e => e.ScopeStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("scope_status")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ScopeInfoDss>(entity =>
            {
                entity.HasKey(e => e.SyncScopeName)
                    .HasName("PK_DataSync.scope_info_dss");

                entity.ToTable("scope_info_dss", "DataSync");

                entity.Property(e => e.SyncScopeName)
                    .HasMaxLength(100)
                    .HasColumnName("sync_scope_name");

                entity.Property(e => e.ScopeConfigId).HasColumnName("scope_config_id");

                entity.Property(e => e.ScopeId)
                    .HasColumnName("scope_id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ScopeLocalId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("scope_local_id");

                entity.Property(e => e.ScopeRestoreCount).HasColumnName("scope_restore_count");

                entity.Property(e => e.ScopeSyncKnowledge).HasColumnName("scope_sync_knowledge");

                entity.Property(e => e.ScopeTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("scope_timestamp");

                entity.Property(e => e.ScopeTombstoneCleanupKnowledge).HasColumnName("scope_tombstone_cleanup_knowledge");

                entity.Property(e => e.ScopeUserComment).HasColumnName("scope_user_comment");
            });

            modelBuilder.Entity<ServiceFeedback>(entity =>
            {
                entity.HasKey(e => e.ServiceFeedback1);

                entity.ToTable("ServiceFeedback");

                entity.Property(e => e.ServiceFeedback1).HasColumnName("ServiceFeedback");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceFeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ServiceFeedback_UserProfiles");
            });

            modelBuilder.Entity<ServiceHistory>(entity =>
            {
                entity.ToTable("ServiceHistory");

                entity.Property(e => e.Action)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_2");

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_LINE_3");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Complaint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ComplaintGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Complaint_Group");

                entity.Property(e => e.CustName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUST_NAME");

                entity.Property(e => e.CustVoice)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Voice");

                entity.Property(e => e.DealerId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_ID");

                entity.Property(e => e.DealershipName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DEALERSHIP_NAME");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.EngineNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ENGINE_NO");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.FscClaimNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FSC_CLAIM_NO");

                entity.Property(e => e.InsComp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INS_COMP");

                entity.Property(e => e.InsType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("INS_TYPE");

                entity.Property(e => e.IssuedQty)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISSUED_QTY");

                entity.Property(e => e.Issuemode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ISSUEMODE");

                entity.Property(e => e.JobCardDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("JOB_CARD_DATE");

                entity.Property(e => e.JobCardNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("JOB_CARD_NO");

                entity.Property(e => e.JobTypeDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TYPE_DESC");

                entity.Property(e => e.Kilometers)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("KILOMETERS");

                entity.Property(e => e.LabQuantity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LAB_QUANTITY");

                entity.Property(e => e.LabourId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LABOUR_ID");

                entity.Property(e => e.LabourRate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LABOUR_RATE");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE_NO");

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MODEL");

                entity.Property(e => e.ModelPart)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MODEL_PART");

                entity.Property(e => e.ObservDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("OBSERV_DESC");

                entity.Property(e => e.Observation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObsrvGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Obsrv_Group");

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PART_DESC");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PART_NO");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PIN_CODE");

                entity.Property(e => e.PolicyNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("POLICY_NO");

                entity.Property(e => e.ProdMon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROD_MON");

                entity.Property(e => e.ProdYr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROD_YR");

                entity.Property(e => e.RegNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REG_NO");

                entity.Property(e => e.SaleDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SALE_DATE");

                entity.Property(e => e.Servicemode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICEMODE");

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("STATE");
            });

            modelBuilder.Entity<Test123>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test123");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Updatedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedtime");
            });

            modelBuilder.Entity<ThirdPartyApihitCount>(entity =>
            {
                entity.HasKey(e => e.HitCountId);

                entity.ToTable("ThirdPartyAPIHitCount");

                entity.Property(e => e.ApihitCountDate)
                    .HasColumnType("date")
                    .HasColumnName("APIHitCountDate");

                entity.Property(e => e.AqiapihitCount).HasColumnName("AQIAPIHitCount");

                entity.Property(e => e.CricketApihitCount).HasColumnName("CricketAPIHitCount");

                entity.Property(e => e.FootballApihitCount).HasColumnName("FootballAPIHitCount");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NewsApihitCount).HasColumnName("NewsAPIHitCount");

                entity.Property(e => e.WeatherApihitCount).HasColumnName("WeatherAPIHitCount");
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.ToTable("Tour");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HighestAltitude).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LiterPer100Km)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LiterPer100KM");

                entity.Property(e => e.LowestAltitude).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TourEndLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TourMmidownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TourMMIDownloadLink");

                entity.Property(e => e.TourName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TourStartLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Tours)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Tours)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_VehicleType");
            });

            modelBuilder.Entity<TourArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("Tour_Archived");

                entity.Property(e => e.AverageSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HighestAltitude).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LiterPer100Km)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LiterPer100KM");

                entity.Property(e => e.LowestAltitude).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TopSpeed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalDistance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TourEndLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TourMmidownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TourMMIDownloadLink");

                entity.Property(e => e.TourName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TourStartLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.TourArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_Archived_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.TourArchiveds)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tour_Archived_VehicleType");
            });

            modelBuilder.Entity<TourPoint>(entity =>
            {
                entity.ToTable("TourPoint");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceName).IsUnicode(false);

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.TourPoints)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TourPoint_Tour");
            });

            modelBuilder.Entity<TourPointArchived>(entity =>
            {
                entity.HasKey(e => e.ArchiveId);

                entity.ToTable("TourPoint_Archived");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlaceName).IsUnicode(false);
            });

            modelBuilder.Entity<U347cumulative>(entity =>
            {
                entity.HasKey(e => e.N109cumulativeId);

                entity.ToTable("U347Cumulative");

                entity.Property(e => e.N109cumulativeId).HasColumnName("N109CumulativeId");

                entity.Property(e => e.AverageSpeed).HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed).HasColumnName("topSpeed");

                entity.Property(e => e.TotalRides).HasColumnName("totalRides");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.U347cumulatives)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_U347Cumulative_UserVehicle");
            });

            modelBuilder.Entity<U347travelTransection>(entity =>
            {
                entity.HasKey(e => e.TravelId);

                entity.ToTable("U347TravelTransection");

                entity.Property(e => e.TravelId).HasColumnName("travelId");

                entity.Property(e => e.AverageSpeed).HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed).HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.U347travelTransections)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_U347TravelTransection_UserVehicle");
            });

            modelBuilder.Entity<U347travelTransectionArchived>(entity =>
            {
                entity.HasKey(e => e.ArchivedId);

                entity.ToTable("U347TravelTransection_Archived");

                entity.Property(e => e.AverageSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("averageSpeed");

                entity.Property(e => e.BestShortestTime0to30)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bestShortestTime0to30");

                entity.Property(e => e.Co2saved)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CO2Saved");

                entity.Property(e => e.EcoModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ecoModeTotalDistance");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.IsArchivable).HasColumnName("isArchivable");

                entity.Property(e => e.IsProcessed).HasColumnName("isProcessed");

                entity.Property(e => e.LastBatteryStatus).HasColumnName("lastBatteryStatus");

                entity.Property(e => e.LastDistanceToEmpty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lastDistanceToEmpty");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifiedDate");

                entity.Property(e => e.PowerModeTotalDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("powerModeTotalDistance");

                entity.Property(e => e.RideTime).HasColumnName("rideTime");

                entity.Property(e => e.TopSpeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("topSpeed");

                entity.Property(e => e.TotalTime).HasColumnName("totalTime");

                entity.Property(e => e.TotalTravelledDistance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalTravelledDistance");

                entity.Property(e => e.TravelEndDateTime).HasColumnName("travelEndDateTime");

                entity.Property(e => e.TravelFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelFileName");

                entity.Property(e => e.TravelId).HasColumnName("travelId");

                entity.Property(e => e.TravelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("travelName");

                entity.Property(e => e.TravelStartDateTime).HasColumnName("travelStartDateTime");

                entity.Property(e => e.TravelStatsDownloadLink)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("travelStatsDownloadLink");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.VehicleModelName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vehicleModelName");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.U347travelTransectionArchiveds)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_U347TravelTransection_Archived_UserVehicle");
            });

            modelBuilder.Entity<UserAdditionalSetting>(entity =>
            {
                entity.ToTable("UserAdditionalSetting");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserSettingType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserSettingValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserSettingConfiguration)
                    .WithMany(p => p.UserAdditionalSettings)
                    .HasForeignKey(d => d.UserSettingConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAdditionalSetting_UserSettingConfiguration");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .HasColumnName("latitude");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .HasColumnName("longitude");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddresses_UserAddresses");
            });

            modelBuilder.Entity<UserAuthToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserAuthToken");

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshToken)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserAuthTokenId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId);

                entity.ToTable("UserBadge");

                entity.Property(e => e.BadgeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.BadgeType)
                    .WithMany(p => p.UserBadges)
                    .HasForeignKey(d => d.BadgeTypeId)
                    .HasConstraintName("FK_UserBadge_BadgeType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBadges)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserBadge_UserProfiles");
            });

            modelBuilder.Entity<UserConsent>(entity =>
            {
                entity.ToTable("UserConsent");

                entity.Property(e => e.Application)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsentTakenDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserConsent2>(entity =>
            {
                entity.HasKey(e => e.UserConsentId);

                entity.ToTable("UserConsent2");

                entity.Property(e => e.Application)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsentTakenDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDeleteReason>(entity =>
            {
                entity.ToTable("UserDeleteReason");

                entity.Property(e => e.InserDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReasonMessage).HasMaxLength(500);
            });

            modelBuilder.Entity<UserFeedback>(entity =>
            {
                entity.HasKey(e => e.UserFeedback1);

                entity.ToTable("UserFeedback");

                entity.Property(e => e.UserFeedback1).HasColumnName("UserFeedback");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeedBackType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackSeverity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FrameNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .IsFixedLength();

                entity.Property(e => e.Platform)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFeedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserFeedback_UserProfiles");
            });

            modelBuilder.Entity<UserFeedback1>(entity =>
            {
                entity.HasKey(e => e.UserFeedback11);

                entity.ToTable("UserFeedback1");

                entity.Property(e => e.UserFeedback11).HasColumnName("UserFeedback1");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(55)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFeedback1s)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserFeedback_UserProfiles1");
            });

            modelBuilder.Entity<UserFeedbackForm>(entity =>
            {
                entity.HasKey(e => e.UserFeedbackId);

                entity.ToTable("UserFeedbackForm");

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FrameNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OsVersion)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Platform)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFeedbackForms)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserFeedbackForm_UserProfiles");
            });

            modelBuilder.Entity<UserGuide>(entity =>
            {
                entity.ToTable("UserGuide");

                entity.Property(e => e.DmpModelId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DMP_MODEL_ID");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.Theme).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserManual)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoThumbnailLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserGuide23022021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserGuide-23022021");

                entity.Property(e => e.DmpModelId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DMP_MODEL_ID");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserGuideId).ValueGeneratedOnAdd();

                entity.Property(e => e.UserManual)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoThumbnailLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VideoTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserImage>(entity =>
            {
                entity.ToTable("UserImage");

                entity.Property(e => e.ImageName).HasMaxLength(255);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.UserProfiles");

                entity.HasIndex(e => e.Email, "NonClusteredIndex-Email");

                entity.HasIndex(e => e.IsRegistered, "NonClusteredIndex-IsRegistered");

                entity.HasIndex(e => e.MobileNumber, "NonClusteredIndex-MobileNumber");

                entity.Property(e => e.AllergicContent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AndroidToken)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("androidToken");

                entity.Property(e => e.AppleId).HasMaxLength(100);

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrashAlertDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DeleteOtp).HasColumnName("DeleteOTP");

                entity.Property(e => e.DeleteOtpgenerateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DeleteOTPGenerateTime");

                entity.Property(e => e.DeleteReasonMessage).HasMaxLength(1000);

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GooglePlusId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IosToken)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("iosToken");

                entity.Property(e => e.IsDeleteOtpverified).HasColumnName("IsDeleteOTPVerified");

                entity.Property(e => e.IsOtpverified)
                    .HasColumnName("IsOTPVerified")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRegistered)
                    .HasColumnName("isRegistered")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastOtpfailedAttemptAt)
                    .HasColumnType("datetime")
                    .HasColumnName("LastOTPFailedAttemptAt");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.OtpfailedAttemptCount).HasColumnName("OTPFailedAttemptCount");

                entity.Property(e => e.OtpgenerateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPGenerateTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("registrationId");

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_UserProfiles_citymaster");
            });

            modelBuilder.Entity<UserProfilesDssTracking>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_DataSync.UserProfiles_dss_tracking");

                entity.ToTable("UserProfiles_dss_tracking", "DataSync");

                entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.UserId }, "local_update_peer_timestamp_index");

                entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");

                entity.Property(e => e.LastChangeDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_datetime");

                entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");

                entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");

                entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("local_update_peer_timestamp");

                entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");

                entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");

                entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");

                entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");

                entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");

                entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
            });

            modelBuilder.Entity<UserRsakey>(entity =>
            {
                entity.ToTable("UserRSAKey");

                entity.Property(e => e.UserRsakeyId).HasColumnName("UserRSAKeyId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrivateKey).HasMaxLength(1000);

                entity.Property(e => e.PublicKey).HasMaxLength(500);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRsakeys)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRSAKey_UserProfile");
            });

            modelBuilder.Entity<UserServiceFeedback>(entity =>
            {
                entity.HasKey(e => e.ServiceFeedbackId);

                entity.ToTable("UserServiceFeedback");

                entity.Property(e => e.Recommendation).HasMaxLength(50);

                entity.Property(e => e.ServiceId).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<UserSettingConfiguration>(entity =>
            {
                entity.HasKey(e => e.UserSettingFieldId);

                entity.ToTable("UserSettingConfiguration");

                entity.HasIndex(e => e.UserId, "NonClusteredIndex-UserId");

                entity.HasIndex(e => e.UserVehicleId, "NonClusteredIndex-UserVehicleId");

                entity.Property(e => e.AutoLaunch).HasColumnName("autoLaunch");

                entity.Property(e => e.AutoReplySms).HasColumnName("autoReplySMS");

                entity.Property(e => e.AutoReplySmstext)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("autoReplySMSText")
                    .HasDefaultValueSql("('Currently I am driving. Will call you after sometime')");

                entity.Property(e => e.BikeNickName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bikeNickName");

                entity.Property(e => e.DoNotDisturb).HasColumnName("doNotDisturb");

                entity.Property(e => e.Illumination)
                    .HasColumnName("illumination")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.ManualConnect).HasColumnName("manualConnect");

                entity.Property(e => e.OverSpeedAlert).HasColumnName("overSpeedAlert");

                entity.Property(e => e.OverSpeedLimit).HasColumnName("overSpeedLimit");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("registrationNumber");

                entity.Property(e => e.UserVehicleId).HasColumnName("userVehicleId");
            });

            modelBuilder.Entity<UserSupport>(entity =>
            {
                entity.ToTable("UserSupport");

                entity.Property(e => e.ChassisNo)
                    .HasMaxLength(2000)
                    .HasColumnName("chassisNo");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.DrivingLicence)
                    .HasMaxLength(2000)
                    .HasColumnName("drivingLicence");

                entity.Property(e => e.InsertedDate)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("insertedDate");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .HasColumnName("mobileNo");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .HasColumnName("name");

                entity.Property(e => e.Rccopy).HasColumnName("RCCopy");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<UserSurvey>(entity =>
            {
                entity.ToTable("UserSurvey");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSurveys)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSurvey_UserProfiles");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.UserSurveys)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSurvey_UserVehicle");
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserToken");

                entity.Property(e => e.ExpiredToken).IsUnicode(false);

                entity.Property(e => e.ExpiredTokenTime).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Token).IsUnicode(false);
            });

            modelBuilder.Entity<UserVehicle>(entity =>
            {
                entity.ToTable("UserVehicle");

                entity.HasIndex(e => e.IsDeleted, "NonClusteredIndex-IsDeleted");

                entity.HasIndex(e => e.UserId, "NonClusteredIndex-UserId");

                entity.HasIndex(e => e.VehicleTypeId, "NonClusteredIndex-VehicleTypeId");

                entity.Property(e => e.Active)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE");

                entity.Property(e => e.BrandCode)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_CODE");

                entity.Property(e => e.BrandDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BRAND_DESC");

                entity.Property(e => e.Color)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COLOR");

                entity.Property(e => e.Connected)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CONNECTED");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_NO");

                entity.Property(e => e.ContactType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT_TYPE");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUSTOMER_NAME");

                entity.Property(e => e.DealerId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DEALER_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.DmpModelId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DMP_MODEL_ID");

                entity.Property(e => e.DmpPartId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DMP_PART_ID");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_ADDRESS");

                entity.Property(e => e.EngineNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ENGINE_NO");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iot)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IOT");

                entity.Property(e => e.LastServiceDate)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LAST_SERVICE_DATE");

                entity.Property(e => e.LastServiceType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LAST_SERVICE_TYPE");

                entity.Property(e => e.NickName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OnGoingBooking)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REG_NO");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SALE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Series)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERIES");

                entity.Property(e => e.TovModelId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TOV_MODEL_ID");

                entity.Property(e => e.TovPartId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TOV_PART_ID");

                entity.Property(e => e.VehicleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVehicles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserVehicle_UserProfiles");
            });

            modelBuilder.Entity<UserVehicleDssTracking>(entity =>
            {
                entity.HasKey(e => e.UserVehicleId)
                    .HasName("PK_DataSync.UserVehicle_dss_tracking");

                entity.ToTable("UserVehicle_dss_tracking", "DataSync");

                entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.UserVehicleId }, "local_update_peer_timestamp_index");

                entity.HasIndex(e => new { e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp }, "tombstone_index");

                entity.Property(e => e.UserVehicleId).ValueGeneratedNever();

                entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");

                entity.Property(e => e.LastChangeDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_datetime");

                entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");

                entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");

                entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("local_update_peer_timestamp");

                entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");

                entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");

                entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");

                entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");

                entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");

                entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
            });

            modelBuilder.Entity<UserVehicleMacActivation>(entity =>
            {
                entity.ToTable("UserVehicleMacActivation");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FrameNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FRAME_NO");

                entity.Property(e => e.MacId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Response)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVehicleMacActivations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserVehicleMacActivation_UserId");

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.UserVehicleMacActivations)
                    .HasForeignKey(d => d.UserVehicleId)
                    .HasConstraintName("FK_UserVehicleMacActivation_UserVehicleId");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.UserVehicleMacActivations)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_UserVehicleMacActivation_VehicleTypeId");
            });

            modelBuilder.Entity<UserVoiceCommand>(entity =>
            {
                entity.ToTable("UserVoiceCommand");

                entity.Property(e => e.ActionTaken).HasMaxLength(256);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IntentIdentified).HasMaxLength(256);

                entity.Property(e => e.Platform)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.VoiceAudioFilePath).HasMaxLength(256);
            });

            modelBuilder.Entity<VUserSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UserSetting");

                entity.Property(e => e.AutoLaunch).HasColumnName("autoLaunch");

                entity.Property(e => e.AutoReplySms).HasColumnName("autoReplySMS");

                entity.Property(e => e.AutoReplySmstext)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("autoReplySMSText");

                entity.Property(e => e.BikeNickName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bikeNickName");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DoNotDisturb).HasColumnName("doNotDisturb");

                entity.Property(e => e.Illumination).HasColumnName("illumination");

                entity.Property(e => e.ManualConnect).HasColumnName("manualConnect");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OverSpeedAlert).HasColumnName("overSpeedAlert");

                entity.Property(e => e.OverSpeedLimit).HasColumnName("overSpeedLimit");

                entity.Property(e => e.RegistrationNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("registrationNumber");

                entity.Property(e => e.UserSettingType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserSettingValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserVehicleId).HasColumnName("userVehicleId");
            });

            modelBuilder.Entity<VehicleAssistanceTypeMapping>(entity =>
            {
                entity.ToTable("VehicleAssistanceTypeMapping");

                entity.HasOne(d => d.BreakDownAssistanceType)
                    .WithMany(p => p.VehicleAssistanceTypeMappings)
                    .HasForeignKey(d => d.BreakDownAssistanceTypeId)
                    .HasConstraintName("FK_VehicleAssistanceTypeMapping_BreakDownAssistanceType");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.VehicleAssistanceTypeMappings)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .HasConstraintName("FK_VehicleAssistanceTypeMapping_VehicleType");
            });

            modelBuilder.Entity<VehicleOtp>(entity =>
            {
                entity.ToTable("VehicleOTP");

                entity.Property(e => e.VehicleOtpid).HasColumnName("VehicleOTPId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsOtpverified).HasColumnName("IsOTPVerified");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.OtpgenerateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPGenerateTime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VehicleServiceDatum>(entity =>
            {
                entity.HasKey(e => e.BookingId);

                entity.Property(e => e.AcceptedStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Accepted_Status");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AppoinmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Appoinment_Date");

                entity.Property(e => e.AppoinmentTime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Appoinment_Time");

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.DealerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DealerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isDeleted");

                entity.Property(e => e.IsEowReq).HasColumnName("Is_EOW_Req");

                entity.Property(e => e.IsPickDropReq).HasColumnName("Is_Pick_Drop_Req");

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceMode).HasColumnName("Service_Mode");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VehicleServiceHistoryDatum>(entity =>
            {
                entity.HasKey(e => e.BookingServiceHistoryId);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("isDeleted");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCurrentDate).HasColumnType("datetime");

                entity.Property(e => e.StatusCurrentTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleSetting>(entity =>
            {
                entity.ToTable("VehicleSetting");

                entity.Property(e => e.Csvfrequency).HasColumnName("CSVFrequency");

                entity.Property(e => e.ElevationKm).HasColumnName("ElevationKM");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.VehicleSettings)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleSetting_VehicleType");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.Insertdate)
                    .HasColumnType("datetime")
                    .HasColumnName("insertdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Series)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("series");

                entity.Property(e => e.VehicleCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VinSampleImage>(entity =>
            {
                entity.ToTable("VinSampleImage");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("imagePath");
            });

            modelBuilder.Entity<VoiceAction>(entity =>
            {
                entity.Property(e => e.ClusterFeedback1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterFeedback2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DisplayText).HasMaxLength(200);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Platform)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceAction1)
                    .HasMaxLength(200)
                    .HasColumnName("VoiceAction");

                entity.Property(e => e.VoiceFeedback).HasMaxLength(200);

                entity.Property(e => e.VoiceIntent).HasMaxLength(50);
            });

            modelBuilder.Entity<VoiceActionsBkp01112021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VoiceActions_bkp01112021");

                entity.Property(e => e.ClusterFeedback1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterFeedback2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Platform)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceAction).HasMaxLength(200);

                entity.Property(e => e.VoiceActionId).ValueGeneratedOnAdd();

                entity.Property(e => e.VoiceFeedback).HasMaxLength(200);

                entity.Property(e => e.VoiceIntent).HasMaxLength(50);
            });

            modelBuilder.Entity<VoiceActionsU458>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VoiceActions_U458");

                entity.Property(e => e.ClusterFeedback1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterFeedback2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Platform)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceAction).HasMaxLength(200);

                entity.Property(e => e.VoiceActionId).ValueGeneratedOnAdd();

                entity.Property(e => e.VoiceFeedback).HasMaxLength(200);

                entity.Property(e => e.VoiceIntent).HasMaxLength(50);
            });

            modelBuilder.Entity<VoiceCommand>(entity =>
            {
                entity.Property(e => e.Command).HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.VoiceAction)
                    .WithMany(p => p.VoiceCommands)
                    .HasForeignKey(d => d.VoiceActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoiceCommands_VoiceCommands");
            });

            modelBuilder.Entity<VoiceCommandsBkp01112021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VoiceCommands_bkp01112021");

                entity.Property(e => e.Command).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VoiceCommandId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VoiceCommandsU458>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VoiceCommands_U458");

                entity.Property(e => e.Command).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VoiceCommandId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Widget>(entity =>
            {
                entity.ToTable("Widget");

                entity.Property(e => e.CardName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeftPrimaryReading).HasColumnName("leftPrimaryReading");

                entity.Property(e => e.LeftSecondaryReading).HasColumnName("leftSecondaryReading");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrimaryImageUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryImageUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserVehicle)
                    .WithMany(p => p.Widgets)
                    .HasForeignKey(d => d.UserVehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Widget_UserVehicle");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Widgets)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Widget_VehicleType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
