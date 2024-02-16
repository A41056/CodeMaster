using CodeMaster.Data.Entities;
using CodeMaster.Data.Entities.Address;
using CodeMaster.Data.Entities.Auth;
using CodeMaster.Data.Entities.Category;
using CodeMaster.Data.Entities.Course;
using CodeMaster.Data.Entities.Dictionary;
using CodeMaster.Data.Entities.Discount;
using CodeMaster.Data.Entities.ExamToolCategory;
using CodeMaster.Data.Entities.Feedback;
using CodeMaster.Data.Entities.File;
using CodeMaster.Data.Entities.LiveClass;
using CodeMaster.Data.Entities.Mocktest;
using CodeMaster.Data.Entities.News;
using CodeMaster.Data.Entities.Notification;
using CodeMaster.Data.Entities.Order;
using CodeMaster.Data.Entities.Questionaire;
using CodeMaster.Data.Entities.Score;
using CodeMaster.Data.Entities.Unit;
using CodeMaster.Data.Entities.WebUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace CodeMaster.Data.CodeMasterDbContext
{
    public partial class CodeMasterDbContext : DbContext 
    {
        public CodeMasterDbContext(DbContextOptions<CodeMasterDbContext> options) : base(options) 
        {
        }

        public virtual DbSet<AccountBank> AccountBanks { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }

        public virtual DbSet<AddressTranslation> AddressTranslations { get; set; }

        public virtual DbSet<AdminGroup> AdminGroups { get; set; }

        public virtual DbSet<AdminGroupPermission> AdminGroupPermissions { get; set; }

        public virtual DbSet<AdminRefreshToken> AdminRefreshTokens { get; set; }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }

        public virtual DbSet<AdminUserGroup> AdminUserGroups { get; set; }

        public virtual DbSet<AdminVerificationCode> AdminVerificationCodes { get; set; }

        public virtual DbSet<Answer> Answers { get; set; }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<Banner> Banners { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<CategoryArea> CategoryAreas { get; set; }

        public virtual DbSet<CategoryTranslation> CategoryTranslations { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<CourseDetail> CourseDetails { get; set; }

        public virtual DbSet<CourseDetailTranslation> CourseDetailTranslations { get; set; }

        public virtual DbSet<CoursePrice> CoursePrices { get; set; }

        public virtual DbSet<CoursePriceTranslation> CoursePriceTranslations { get; set; }

        public virtual DbSet<CourseTeacher> CourseTeachers { get; set; }

        public virtual DbSet<CourseTeacherTranslation> CourseTeacherTranslations { get; set; }

        public virtual DbSet<CourseTest> CourseTests { get; set; }

        public virtual DbSet<CourseTestUnit> CourseTestUnits { get; set; }

        public virtual DbSet<CourseTimeOnTask> CourseTimeOnTasks { get; set; }

        public virtual DbSet<CourseTranslation> CourseTranslations { get; set; }

        public virtual DbSet<Dictionary> Dictionaries { get; set; }

        public virtual DbSet<DictionaryTranslation> DictionaryTranslations { get; set; }

        public virtual DbSet<Discount> Discounts { get; set; }

        public virtual DbSet<DiscountTranslation> DiscountTranslations { get; set; }

        public virtual DbSet<DiscountWebUser> DiscountWebUsers { get; set; }

        public virtual DbSet<Districts> Districts { get; set; }

        public virtual DbSet<ExamToolCategory> ExamToolCategories { get; set; }

        public virtual DbSet<ExtCategoryTranslation> ExtCategoryTranslations { get; set; }

        public virtual DbSet<Feedback> Feedbacks { get; set; }

        public virtual DbSet<FeedbackTranslation> FeedbackTranslations { get; set; }

        public virtual DbSet<CodeMaster.Data.Entities.File.File> Files { get; set; }

        public virtual DbSet<FileType> FileTypes { get; set; }

        public virtual DbSet<GuidingMocktest> GuidingMocktests { get; set; }

        public virtual DbSet<GuidingMocktestTranslation> GuidingMocktestTranslations { get; set; }

        public virtual DbSet<KeycodeChoose> KeycodeChooses { get; set; }

        public virtual DbSet<KeycodeResult> KeycodeResults { get; set; }

        public virtual DbSet<LanguageTag> LanguageTags { get; set; }

        public virtual DbSet<LeftSection> LeftSections { get; set; }

        public virtual DbSet<Lesson> Lessons { get; set; }

        public virtual DbSet<LiveClassBooking> LiveClassBookings { get; set; }

        public virtual DbSet<LiveClassDetail> LiveClassDetails { get; set; }

        public virtual DbSet<LiveClassDetailTest> LiveClassDetailTests { get; set; }

        public virtual DbSet<LiveClassType> LiveClassTypes { get; set; }

        public virtual DbSet<LiveCustomerSupport> LiveCustomerSupports { get; set; }

        public virtual DbSet<LiveLessonDetail> LiveLessonDetails { get; set; }

        public virtual DbSet<LiveLessonDetailAdviser> LiveLessonDetailAdvisers { get; set; }

        public virtual DbSet<LiveLessonDetailAttendance> LiveLessonDetailAttendances { get; set; }

        public virtual DbSet<LiveLessonMission> LiveLessonMissions { get; set; }

        public virtual DbSet<LiveLessonMissionQuestionnaire> LiveLessonMissionQuestionnaires { get; set; }

        public virtual DbSet<Mocktest> Mocktests { get; set; }

        public virtual DbSet<MocktestCoursePrice> MocktestCoursePrices { get; set; }

        public virtual DbSet<MocktestKeyCode> MocktestKeyCodes { get; set; }

        public virtual DbSet<MocktestObject> MocktestObjects { get; set; }

        public virtual DbSet<MocktestPart> MocktestParts { get; set; }

        public virtual DbSet<MocktestPartQuestionnaire> MocktestPartQuestionnaires { get; set; }

        public virtual DbSet<MocktestSection> MocktestSections { get; set; }

        public virtual DbSet<MocktestTranslation> MocktestTranslations { get; set; }

        public virtual DbSet<MocktestType> MocktestTypes { get; set; }

        public virtual DbSet<News> News { get; set; }

        public virtual DbSet<NewsTranslation> NewsTranslations { get; set; }

        public virtual DbSet<Notification> Notifications { get; set; }

        public virtual DbSet<NotificationTranslation> NotificationTranslations { get; set; }

        public virtual DbSet<NotificationWebUser> NotificationWebUsers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<PaymentTransaction> PaymentTransactions { get; set; }

        public virtual DbSet<Permission> Permissions { get; set; }

        public virtual DbSet<PolicyMocktestSetting> PolicyMocktestSettings { get; set; }

        public virtual DbSet<PolicyMocktestSettingTranslation> PolicyMocktestSettingTranslations { get; set; }

        //public virtual DbSet<Provinces> Provinces { get; set; }

        public virtual DbSet<Question> Questions { get; set; }

        public virtual DbSet<QuestionTranslation> QuestionTranslations { get; set; }

        public virtual DbSet<Questionnaire> Questionnaires { get; set; }

        public virtual DbSet<QuestionnaireGroup> QuestionnaireGroups { get; set; }

        public virtual DbSet<QuestionnaireQuestionView> QuestionnaireQuestionViews { get; set; }

        public virtual DbSet<RankingScore> RankingScores { get; set; }

        public virtual DbSet<ReceiveInvoice> ReceiveInvoices { get; set; }

        public virtual DbSet<Review> Reviews { get; set; }

        //public virtual DbSet<Schools> Schools { get; set; }

        public virtual DbSet<ScoreComment> ScoreComments { get; set; }

        public virtual DbSet<ScoreDetail> ScoreDetails { get; set; }

        public virtual DbSet<Setting> Settings { get; set; }

        public virtual DbSet<ShowingArea> ShowingAreas { get; set; }

        public virtual DbSet<SocialMedium> SocialMedia { get; set; }

        public virtual DbSet<Step> Steps { get; set; }

        public virtual DbSet<StepQuestionnaire> StepQuestionnaires { get; set; }

        public virtual DbSet<StoreCourse> StoreCourses { get; set; }

        //public virtual DbSet<ToeflChallengeContest> ToeflChallengeContests { get; set; }

        //public virtual DbSet<ToeflChallengeContestMocktest> ToeflChallengeContestMocktests { get; set; }

        //public virtual DbSet<ToeflChallengeRankingScore> ToeflChallengeRankingScores { get; set; }

        //public virtual DbSet<ToeflChallengeRankingScoreMocktestType> ToeflChallengeRankingScoreMocktestTypes { get; set; }

        //public virtual DbSet<ToeflChallengeScoreComment> ToeflChallengeScoreComments { get; set; }

        //public virtual DbSet<ToeflChallengeUser> ToeflChallengeUsers { get; set; }

        //public virtual DbSet<TransferExamToolHistory> TransferExamToolHistories { get; set; }

        public virtual DbSet<Unit> Units { get; set; }

        public virtual DbSet<UnitTest> UnitTests { get; set; }

        public virtual DbSet<UnitTestQuestionnaire> UnitTestQuestionnaires { get; set; }

        public virtual DbSet<VerificationCode> VerificationCodes { get; set; }

        public virtual DbSet<WebUser> WebUsers { get; set; }

        public virtual DbSet<WebUserChoose> WebUserChooses { get; set; }

        public virtual DbSet<WebUserCourseLearningPlan> WebUserCourseLearningPlans { get; set; }

        public virtual DbSet<WebUserCourseTestChoose> WebUserCourseTestChooses { get; set; }

        public virtual DbSet<WebUserCourseTestResult> WebUserCourseTestResults { get; set; }

        public virtual DbSet<WebUserLessonMissionChoose> WebUserLessonMissionChooses { get; set; }

        public virtual DbSet<WebUserLessonMissionResult> WebUserLessonMissionResults { get; set; }

        public virtual DbSet<WebUserLiveTestChoose> WebUserLiveTestChooses { get; set; }

        public virtual DbSet<WebUserLiveTestResult> WebUserLiveTestResults { get; set; }

        public virtual DbSet<WebUserPracticeHistory> WebUserPracticeHistories { get; set; }

        public virtual DbSet<WebUserUnitTestChoose> WebUserUnitTestChooses { get; set; }

        public virtual DbSet<WebUserUnitTestResult> WebUserUnitTestResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AccountBank>(entity =>
            {
                entity.ToTable("account_bank");

                entity.HasIndex(e => e.ExtCategoryId, "IX_account_bank_exam_tool_category_id");

                entity.HasIndex(e => e.Status, "IX_account_bank_status");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.ActiveDuration).HasColumnName("active_duration");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ExpiredTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_time");
                entity.Property(e => e.ExtCategoryId).HasColumnName("ext_category_id");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(511)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(concat(isnull([user_name],''),' ',isnull([keycode],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Keycode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("keycode");
                entity.Property(e => e.LearningDuration).HasColumnName("learning_duration");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Password)
                    .HasMaxLength(128)
                    .HasColumnName("password");
                entity.Property(e => e.Status).HasColumnName("status").IsConcurrencyToken();
                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.HasOne(d => d.ExtCategory).WithMany(p => p.AccountBanks).HasForeignKey(d => d.ExtCategoryId);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<AddressTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.AddressId });

                entity.ToTable("address_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.AddressId).HasColumnName("address_id");
                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.HasOne(d => d.Address).WithMany(p => p.AddressTranslations).HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.Language).WithMany(p => p.AddressTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AdminGroup>(entity =>
            {
                entity.ToTable("admin_group");

                entity.HasIndex(e => e.Name, "UQ__admin_gr__72E12F1B0B62EA8F").IsUnique();

                entity.HasIndex(e => e.Identifier, "UQ__admin_gr__D112ED48000C0E36").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(263)
                    .HasComputedColumnSql("(concat([identifier],' ',[name]))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("identifier");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AdminGroupPermission>(entity =>
            {
                entity.HasKey(e => new { e.PermissionId, e.GroupId });

                entity.ToTable("admin_group_permission");

                entity.Property(e => e.PermissionId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("permission_id");
                entity.Property(e => e.GroupId).HasColumnName("group_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.HasOne(d => d.AdminGroup).WithMany(p => p.AdminGroupPermissions)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_admin_group_permission_group_id");

                entity.HasOne(d => d.Permission).WithMany(p => p.AdminGroupPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_admin_group_permission_permission_id");
            });

            modelBuilder.Entity<AdminRefreshToken>(entity =>
            {
                entity.ToTable("admin_refresh_token");

                entity.HasIndex(e => e.JwtId, "IX_admin_refresh_token_jwt_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_at");
                entity.Property(e => e.IsUsed).HasColumnName("is_used");
                entity.Property(e => e.JwtId).HasColumnName("jwt_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token");
                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.ToTable("admin_user");

                entity.HasIndex(e => e.UserName, "IX_admin_user_user_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.AccessFailedCount).HasColumnName("access_failed_count");
                entity.Property(e => e.BirthDay)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("deleted");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");
                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(800)
                    .HasComputedColumnSql("(concat(isnull([email],''),' ',isnull([phone_number],''),' ',[user_name],' ',isnull([full_name],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("gender");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash");
                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasColumnName("password_salt");
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<AdminUserGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.ToTable("admin_user_group");

                entity.Property(e => e.GroupId).HasColumnName("group_id");
                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.HasOne(d => d.AdminGroup).WithMany(p => p.AdminUserGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_admin_user_group_group_id");

                entity.HasOne(d => d.AdminUser).WithMany(p => p.AdminUserGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_admin_user_group_user_id");
            });

            modelBuilder.Entity<AdminVerificationCode>(entity =>
            {
                entity.ToTable("admin_verification_codes");

                entity.HasIndex(e => new { e.Code, e.Email, e.Type, e.ExpiresAtTime }, "IX_admin_verification_codes_expires_at_time_code").IsDescending(false, false, false, true);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("code");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnName("created");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.ExpiresAtTime).HasColumnName("expires_at_time");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnName("modified");
                entity.Property(e => e.ServiceProvider)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("service_provider");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.IsUsed).HasColumnName("used");
                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity
                    .ToTable("answer")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("answer_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => new { e.QuestionId, e.MatchingKey }, "IX_answer_question_id_matching_key");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CorrectMatchingValues)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correct_matching_values");
                entity.Property(e => e.CorrectMcq).HasColumnName("correct_MCQ");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FakeSelectValues)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fake_select_values");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.MatchingKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matching_key");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .HasColumnName("name");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Question).WithMany(p => p.Answers).HasForeignKey(d => d.QuestionId);
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("article");

                entity.HasIndex(e => e.CategoryId, "IX_article_category_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Author)
                    .HasMaxLength(128)
                    .HasColumnName("author");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_active");
                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(500)
                    .HasColumnName("meta_description");
                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(200)
                    .HasColumnName("meta_keywords");
                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(400)
                    .HasColumnName("meta_title");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.NameNonAscii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_non_ascii");

                entity.HasOne(d => d.Category).WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_article_category_id");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("banner");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComputedColumnSql("([name])", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link_url");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.HasIndex(e => e.CategoryType, "IX_category_category_type");

                entity.HasIndex(e => e.ParentId, "IX_category_parent_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CategoryType).HasColumnName("category_type");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Deleted).HasColumnName("deleted");
                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("identifier");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_active");
                entity.Property(e => e.Level).HasColumnName("level");
                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("link_url");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NameNoneAscii)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name_non_ascii");
                entity.Property(e => e.ParentId).HasColumnName("parent_id");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<CategoryArea>(entity =>
            {
                entity.HasKey(e => new { e.AreaCode, e.CategoryId });

                entity.ToTable("category_area");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area_code");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Area).WithMany(p => p.CategoryAreas)
                    .HasForeignKey(d => d.AreaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_category_area_area_code");

                entity.HasOne(d => d.Category).WithMany(p => p.CategoryAreas)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_category_area_category_id");
            });

            modelBuilder.Entity<CategoryTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.CategoryId });

                entity.ToTable("category_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.HasOne(d => d.Category).WithMany(p => p.CategoryTranslations).HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Language).WithMany(p => p.CategoryTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("course");

                entity.HasIndex(e => e.CategoryId, "IX_course_category_id");

                entity.HasIndex(e => e.Code, "IX_course_code").IsUnique();

                entity.HasIndex(e => e.IsMockTestType, "IX_course_is_mocktest_type");

                entity.HasIndex(e => e.Status, "IX_course_status");

                entity.HasIndex(e => e.Code, "UC_course_code").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.BgImageFileId).HasColumnName("bg_image_file_id");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CS_AS")
                    .HasColumnName("code");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.IsFreeLearningUnit1Lession1)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_free_learning_unit1_lesson1");
                entity.Property(e => e.IsHot)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("is_hot");
                entity.Property(e => e.IsMockTestType).HasColumnName("is_mocktest_type");
                entity.Property(e => e.LearnInOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("learn_in_order");
                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(500)
                    .HasColumnName("meta_description");
                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(200)
                    .HasColumnName("meta_keywords");
                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(400)
                    .HasColumnName("meta_title");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NameNonAscii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_non_ascii");
                entity.Property(e => e.ProductType)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("product_type");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
                entity.Property(e => e.Tags)
                    .HasMaxLength(1000)
                    .HasColumnName("tags");
                entity.Property(e => e.UserGuideLink)
                    .HasMaxLength(255)
                    .HasColumnName("user_guide_link");

                entity.HasOne(d => d.Category).WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_course_category_id");

                entity.HasOne(d => d.Author).WithMany(p => p.Courses)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_course_user_id");
            });

            modelBuilder.Entity<CourseDetail>(entity =>
            {
                entity.ToTable("course_detail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Course).WithMany(p => p.CourseDetails)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_course_detail_course_id");
            });

            modelBuilder.Entity<CourseDetailTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.CourseDetailId });

                entity.ToTable("course_detail_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.CourseDetailId).HasColumnName("course_detail_id");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.TabName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("tab_name");
                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.HasOne(d => d.CourseDetail).WithMany(p => p.CourseDetailTranslations).HasForeignKey(d => d.CourseDetailId);

                entity.HasOne(d => d.Language).WithMany(p => p.CourseDetailTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CoursePrice>(entity =>
            {
                entity.ToTable("course_price");

                entity.HasIndex(e => e.ExamToolCategoryId, "IX_course_price_exam_tool_category_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.ClassTypeId).HasColumnName("class_type_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Deleted).HasColumnName("deleted");
                entity.Property(e => e.ExamToolCategoryId).HasColumnName("exam_tool_category_id");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NumberOfMonth).HasColumnName("number_of_month");
                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");
                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sale_price");
                entity.Property(e => e.SaleValidFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("sale_valid_from");
                entity.Property(e => e.SaleValidTo)
                    .HasColumnType("datetime")
                    .HasColumnName("sale_valid_to");

                entity.HasOne(d => d.Course).WithMany(p => p.CoursePrices).HasForeignKey(d => d.CourseId);
            });

            modelBuilder.Entity<CoursePriceTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.CoursePriceId });

                entity.ToTable("course_price_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.HasOne(d => d.CoursePrice).WithMany(p => p.CoursePriceTranslations).HasForeignKey(d => d.CoursePriceId);

                entity.HasOne(d => d.Language).WithMany(p => p.CoursePriceTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CourseTeacher>(entity =>
            {
                entity.ToTable("course_teacher");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.AvatarUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("avatar_url");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Course).WithMany(p => p.CourseTeachers)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_course_teacher_course_id");
            });

            modelBuilder.Entity<CourseTeacherTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.CourseTeacherId });

                entity.ToTable("course_teacher_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.CourseTeacherId).HasColumnName("course_teacher_id");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.University)
                    .HasMaxLength(255)
                    .HasColumnName("university");

                entity.HasOne(d => d.CourseTeacher).WithMany(p => p.CourseTeacherTranslations).HasForeignKey(d => d.CourseTeacherId);

                entity.HasOne(d => d.Language).WithMany(p => p.CourseTeacherTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CourseTest>(entity =>
            {
                entity.ToTable("course_test");

                entity.HasIndex(e => e.CourseId, "IX_course_test_course_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.TagName)
                    .HasMaxLength(128)
                    .HasColumnName("tag_name");
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("title");

                entity.HasOne(d => d.Course).WithMany(p => p.CourseTests).HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.ImageFile).WithMany(p => p.CourseTests).HasForeignKey(d => d.ImageFileId);

                entity.HasOne(d => d.Mocktest).WithMany(p => p.CourseTests)
                    .HasForeignKey(d => d.MocktestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CourseTestUnit>(entity =>
            {
                entity.HasKey(e => new { e.CourseTestId, e.UnitId });

                entity.ToTable("course_test_unit");

                entity.Property(e => e.CourseTestId).HasColumnName("course_test_id");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.HasOne(d => d.CourseTest).WithMany(p => p.CourseTestUnits).HasForeignKey(d => d.CourseTestId);

                entity.HasOne(d => d.Unit).WithMany(p => p.CourseTestUnits)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CourseTimeOnTask>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.WebUserId });

                entity.ToTable("course_time_on_task");

                entity.HasIndex(e => e.CourseId, "IX_course_time_on_task_course_id");

                entity.HasIndex(e => e.WebUserId, "IX_course_time_on_task_web_user_id");

                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.TimeDuration).HasColumnName("time_duration");
            });

            modelBuilder.Entity<CourseTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.CourseId });

                entity.ToTable("course_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.NumberOfAssignment)
                    .HasMaxLength(128)
                    .HasColumnName("number_of_assignment");
                entity.Property(e => e.NumberOfStudent)
                    .HasMaxLength(128)
                    .HasColumnName("number_of_student");
                entity.Property(e => e.NumberOfVideo)
                    .HasMaxLength(128)
                    .HasColumnName("number_of_video");

                entity.HasOne(d => d.Course).WithMany(p => p.CourseTranslations).HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.Language).WithMany(p => p.CourseTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.ToTable("dictionary");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.LessonId).HasColumnName("lesson_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.StepId).HasColumnName("step_id");
                entity.Property(e => e.TextEnglish)
                    .HasMaxLength(500)
                    .HasColumnName("text_english");
                entity.Property(e => e.TextFileId).HasColumnName("text_file_id");
                entity.Property(e => e.TypeOfWord).HasColumnName("type_of_word");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.WordEnglish)
                    .HasMaxLength(500)
                    .HasColumnName("word_english");
                entity.Property(e => e.WordFileId).HasColumnName("word_file_id");
                entity.Property(e => e.WordPhonetic)
                    .HasMaxLength(50)
                    .HasColumnName("word_phonetic");

                entity.HasOne(d => d.WebUser).WithMany(p => p.Dictionaries)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DictionaryTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.DictionaryId });

                entity.ToTable("dictionary_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.DictionaryId).HasColumnName("dictionary_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.WordTranslation)
                    .HasMaxLength(500)
                    .HasColumnName("word_translation");

                entity.HasOne(d => d.Dictionary).WithMany(p => p.DictionaryTranslations).HasForeignKey(d => d.DictionaryId);

                entity.HasOne(d => d.Language).WithMany(p => p.DictionaryTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("discount", tb =>
                {
                    tb.HasTrigger("after_trg_delete_discount_order");
                    tb.HasTrigger("after_trg_update_discount_order");
                });

                entity.HasIndex(e => e.Status, "IX_discount_status");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("code");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.LimitedUse).HasColumnName("limited_use");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PercentMaxPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("percent_max_price");
                entity.Property(e => e.PeriodNo).HasColumnName("period_no");
                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");
                entity.Property(e => e.ScopeApply)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("scope_apply");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.TypeUse)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("type_use");
                entity.Property(e => e.ValidFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_from");
                entity.Property(e => e.ValidTo)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_to");
            });

            modelBuilder.Entity<DiscountTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.DiscountCode });

                entity.ToTable("discount_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("discount_code");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.HasOne(d => d.Discount).WithMany(p => p.DiscountTranslations).HasForeignKey(d => d.DiscountCode);

                entity.HasOne(d => d.Language).WithMany(p => p.DiscountTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DiscountWebUser>(entity =>
            {
                entity.HasKey(e => new { e.DiscountCode, e.WebUserId });

                entity.ToTable("discount_web_user");

                entity.Property(e => e.DiscountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("discount_code");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NoUse).HasColumnName("no_use");

                entity.HasOne(d => d.DiscountCodeNavigation).WithMany(p => p.DiscountWebUsers)
                    .HasForeignKey(d => d.DiscountCode)
                    .HasConstraintName("FK_discount_web_user_discount_code");

                entity.HasOne(d => d.WebUser).WithMany(p => p.DiscountWebUsers)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_discount_web_user_web_user_id");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.ToTable("Districts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");
                entity.Property(e => e.Code)
                    .HasColumnName("Code");
                entity.Property(e => e.Name)
                    .HasColumnName("Name");
                entity.Property(e => e.ProvinceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProvinceId");
                entity.Property(e => e.CreatedByUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("CreatedByUserId");
                entity.Property(e => e.LastModifiedByUserId)
                    .ValueGeneratedNever()
                    .HasColumnName("LastModifiedByUserId");
                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastModifiedOnDate");
                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CreatedOnDate");
            });

            modelBuilder.Entity<ExamToolCategory>(entity =>
            {
                entity.ToTable("exam_tool_category");

                entity.HasIndex(e => e.Name, "UQ__exam_too__72E12F1B5CFAB1F1").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComputedColumnSql("([name])", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.IsKeycodeType).HasColumnName("is_keycode_type");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.UrlLearning)
                    .HasMaxLength(1000)
                    .HasColumnName("url_learning");
            });

            modelBuilder.Entity<ExtCategoryTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.ExtCategoryId });

                entity.ToTable("ext_category_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.ExtCategoryId).HasColumnName("ext_category_id");
                entity.Property(e => e.CourseGuide).HasColumnName("course_guide");

                entity.HasOne(d => d.ExtCategory).WithMany(p => p.ExtCategoryTranslations).HasForeignKey(d => d.ExtCategoryId);

                entity.HasOne(d => d.Language).WithMany(p => p.ExtCategoryTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("feedback");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<FeedbackTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.FeedbackId });

                entity.ToTable("feedback_translation");

                entity.HasIndex(e => e.FeedbackId, "IX_feedback_translation_feedback_id");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.FeedbackId).HasColumnName("feedback_id");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Position)
                    .HasMaxLength(128)
                    .HasColumnName("position");

                entity.HasOne(d => d.Feedback).WithMany(p => p.FeedbackTranslations).HasForeignKey(d => d.FeedbackId);

                entity.HasOne(d => d.Language).WithMany(p => p.FeedbackTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CodeMaster.Data.Entities.File.File>(entity =>
            {
                entity.ToTable("file");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.AudioDuration).HasColumnName("audio_duration");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CourseTeacherId).HasColumnName("course_teacher_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Deleted).HasColumnName("deleted");
                entity.Property(e => e.DisplayName)
                    .HasMaxLength(64)
                    .HasColumnName("display_name");
                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("extension");
                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("file_name");
                entity.Property(e => e.FileSize).HasColumnName("file_size");
                entity.Property(e => e.FileTypeId).HasColumnName("file_type_id");
                entity.Property(e => e.ImageOrder).HasColumnName("image_order");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_active");
                entity.Property(e => e.IsPublic).HasColumnName("is_public");
                entity.Property(e => e.IsMigrate).HasColumnName("is_migrate");
                entity.Property(e => e.LargeStorageLocation)
                    .HasMaxLength(1000)
                    .HasColumnName("large_storage_location");
                entity.Property(e => e.MediumStorageLocation)
                    .HasMaxLength(1000)
                    .HasColumnName("medium_storage_location");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NewsId).HasColumnName("news_id");
                entity.Property(e => e.SmallStorageLocation)
                    .HasMaxLength(1000)
                    .HasColumnName("small_storage_location");
                entity.Property(e => e.StorageLocation)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("storage_location");
                entity.Property(e => e.ThumbnailStorageLocation)
                    .HasMaxLength(1000)
                    .HasColumnName("thumbnail_storage_location");
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Course).WithMany(p => p.Files)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_file_course_id");

                entity.HasOne(d => d.FileType).WithMany(p => p.Files)
                    .HasForeignKey(d => d.FileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_file_file_type_id");

                entity.HasOne(d => d.News).WithMany(p => p.Files)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_file_news_id");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.ToTable("file_type");

                entity.HasIndex(e => e.Identifier, "IX_file_type_identifier").IsUnique();

                entity.HasIndex(e => e.Identifier, "UQ__file_typ__D112ED48D6DB010E").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DefaultStorageLocation)
                    .HasMaxLength(255)
                    .HasColumnName("default_storage_location");
                entity.Property(e => e.FileExtensions)
                    .HasMaxLength(255)
                    .HasColumnName("file_extensions");
                entity.Property(e => e.FileNamePattern)
                    .HasMaxLength(255)
                    .HasColumnName("file_name_pattern");
                entity.Property(e => e.Identifier).HasColumnName("identifier");
                entity.Property(e => e.MaxSize).HasColumnName("max_size");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GuidingMocktest>(entity =>
            {
                entity.ToTable("guiding_mocktest");

                entity.HasIndex(e => e.CategoryId, "IX_guiding_mocktest_category_id");

                entity.HasIndex(e => e.MocktestObjectId, "IX_guiding_mocktest_mocktest_object_id");

                entity.HasIndex(e => e.MocktestTypeId, "IX_guiding_mocktest_mocktest_type_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MocktestObjectId).HasColumnName("mocktest_object_id");
                entity.Property(e => e.MocktestTypeId).HasColumnName("mocktest_type_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.IsMockExam)
                    .HasColumnName("is_mock_exam");
                entity.HasOne(d => d.Category).WithMany(p => p.GuidingMocktests)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MocktestObject).WithMany(p => p.GuidingMocktests)
                    .HasForeignKey(d => d.MocktestObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MocktestType).WithMany(p => p.GuidingMocktests)
                    .HasForeignKey(d => d.MocktestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<GuidingMocktestTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.GuidingMocktestId });

                entity.ToTable("guiding_mocktest_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.GuidingMocktestId).HasColumnName("guiding_mocktest_id");
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");
                entity.Property(e => e.DesktopImageId).HasColumnName("desktop_image_id");
                entity.Property(e => e.MobileImageId).HasColumnName("mobile_image_id");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.GuidingMocktest).WithMany(p => p.GuidingMocktestTranslations)
                    .HasForeignKey(d => d.GuidingMocktestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gmt_guiding_mocktest_guiding_mocktest_id");

                entity.HasOne(d => d.Language).WithMany(p => p.GuidingMocktestTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gmt_language_tags_language_code");
            });

            modelBuilder.Entity<KeycodeChoose>(entity =>
            {
                entity.HasKey(e => new { e.Keycode, e.MocktestPartId, e.AnswerId });

                entity.ToTable("keycode_choose");

                entity.Property(e => e.Keycode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("keycode");
                entity.Property(e => e.MocktestPartId).HasColumnName("mocktest_part_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.KeycodeNavigation).WithMany(p => p.KeycodeChooses)
                    .HasForeignKey(d => d.Keycode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<KeycodeResult>(entity =>
            {
                entity.HasKey(e => e.Keycode);

                entity.ToTable("keycode_result");

                entity.Property(e => e.Keycode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("keycode");
                entity.Property(e => e.ComponentsDetails).HasColumnName("components_details");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.RankingScore)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ranking_score");
                entity.Property(e => e.TotalCorrectAnswer).HasColumnName("total_correct_answer");
                entity.Property(e => e.TotalQuestion).HasColumnName("total_question");

                entity.HasOne(d => d.KeycodeNavigation).WithOne(p => p.KeycodeResult)
                    .HasForeignKey<KeycodeResult>(d => d.Keycode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LanguageTag>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("language_tags");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.IsDefault).HasColumnName("is_default");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<LeftSection>(entity =>
            {
                entity
                    .ToTable("left_section")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("left_section_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.AudioFileId).HasColumnName("audio_file_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.TextContent).HasColumnName("text_content");
                entity.Property(e => e.TextScript).HasColumnName("text_script");
                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.LeftSections).HasForeignKey(d => d.QuestionnaireId);
            });

            modelBuilder.Entity<Lesson>(entity =>
            {
                entity.ToTable("lesson");

                entity.HasIndex(e => e.UnitId, "IX_lesson_unit_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.HasOne(d => d.Unit).WithMany(p => p.Lessons).HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<LiveClassBooking>(entity =>
            {
                entity.ToTable("live_class_booking");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.BlockEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("block_end_date");
                entity.Property(e => e.BlockStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("block_start_date");
                entity.Property(e => e.ClassTypeId).HasColumnName("class_type_id");
                entity.Property(e => e.CourseCode)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("course_code");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.CoursePriceName)
                    .HasMaxLength(128)
                    .HasColumnName("course_price_name");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Deleted).HasColumnName("deleted");
                entity.Property(e => e.LiveClassDetailId).HasColumnName("live_class_detail_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.OrderId).HasColumnName("order_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");

                entity.HasOne(d => d.LiveClassDetail).WithMany(p => p.LiveClassBookings)
                    .HasForeignKey(d => d.LiveClassDetailId)
                    .HasConstraintName("FK_live_class_booking_live_class_detail_id");
            });

            modelBuilder.Entity<LiveClassDetail>(entity =>
            {
                entity.ToTable("live_class_detail");

                entity.HasIndex(e => e.LiveClassTypeId, "IX_live_class_detail_live_class_type_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.ClassinCourseId).HasColumnName("classin_course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(296)
                    .HasComputedColumnSql("(concat(isnull([name],''),' ',isnull([live_class_type_name],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.LiveClassTypeId).HasColumnName("live_class_type_id");
                entity.Property(e => e.LiveClassTypeName)
                    .HasMaxLength(255)
                    .HasColumnName("live_class_type_name");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("name");
                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.LiveClassType).WithMany(p => p.LiveClassDetails)
                    .HasForeignKey(d => d.LiveClassTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LiveClassDetailTest>(entity =>
            {
                entity.ToTable("live_class_detail_test");

                entity.HasIndex(e => e.LiveClassDetailId, "IX_live_class_detail_test_live_class_detail_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");
                entity.Property(e => e.LiveClassDetailId).HasColumnName("live_class_detail_id");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.LiveClassDetail).WithMany(p => p.LiveClassDetailTests)
                    .HasForeignKey(d => d.LiveClassDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Mocktest).WithMany(p => p.LiveClassDetailTests)
                    .HasForeignKey(d => d.MocktestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LiveClassType>(entity =>
            {
                entity.ToTable("live_class_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.StudentNumber).HasColumnName("student_number");
                entity.Property(e => e.TimeLesson).HasColumnName("time_lesson");
                entity.Property(e => e.TotalLesson).HasColumnName("total_lesson");
            });

            modelBuilder.Entity<LiveCustomerSupport>(entity =>
            {
                entity.ToTable("live_customer_support");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(544)
                    .HasComputedColumnSql("(concat(isnull([full_name],''),' ',isnull([phone_number],''),' ',isnull([email],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
            });

            modelBuilder.Entity<LiveLessonDetail>(entity =>
            {
                entity.ToTable("live_lesson_detail", tb => tb.HasTrigger("after_trg_insert_update_live_lesson_detail"));

                entity.HasIndex(e => e.LiveClassDetailId, "IX_live_lesson_detail_live_class_detail_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.ClassinLessonId).HasColumnName("classin_lesson_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComputedColumnSql("([name])", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.LearningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("learning_date");
                entity.Property(e => e.LearningEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("learning_end_date");
                entity.Property(e => e.LiveClassDetailId).HasColumnName("live_class_detail_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
                entity.Property(e => e.NumberLesson).HasColumnName("number_lesson");
                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.LiveClassDetail).WithMany(p => p.LiveLessonDetails)
                    .HasForeignKey(d => d.LiveClassDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Teacher).WithMany(p => p.LiveLessonDetails)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LiveLessonDetailAdviser>(entity =>
            {
                entity.HasKey(e => new { e.LiveLessonDetailId, e.AdminUserId });

                entity.ToTable("live_lesson_detail_adviser");

                entity.Property(e => e.LiveLessonDetailId).HasColumnName("live_lesson_detail_id");
                entity.Property(e => e.AdminUserId).HasColumnName("admin_user_id");
                entity.Property(e => e.LessonLinkUrl)
                    .IsUnicode(false)
                    .HasColumnName("lesson_link_url");

                entity.HasOne(d => d.AdminUser).WithMany(p => p.LiveLessonDetailAdvisers)
                    .HasForeignKey(d => d.AdminUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_live_lesson_detail_adviser_admin_user_id");

                entity.HasOne(d => d.LiveLessonDetail).WithMany(p => p.LiveLessonDetailAdvisers)
                    .HasForeignKey(d => d.LiveLessonDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_live_lesson_detail_adviser_live_lesson_detail_id");
            });

            modelBuilder.Entity<LiveLessonDetailAttendance>(entity =>
            {
                entity.HasKey(e => new { e.LiveLessonDetailId, e.LiveClassBookingId });

                entity.ToTable("live_lesson_detail_attendance");

                entity.Property(e => e.LiveLessonDetailId).HasColumnName("live_lesson_detail_id");
                entity.Property(e => e.LiveClassBookingId).HasColumnName("live_class_booking_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.LessonLinkUrl)
                    .IsUnicode(false)
                    .HasColumnName("lesson_link_url");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
            });

            modelBuilder.Entity<LiveLessonMission>(entity =>
            {
                entity.ToTable("live_lesson_mission");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");
                entity.Property(e => e.IsPreMission)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_pre_mission");
                entity.Property(e => e.LiveLessonDetailId).HasColumnName("live_lesson_detail_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.LiveLessonDetail).WithMany(p => p.LiveLessonMissions)
                    .HasForeignKey(d => d.LiveLessonDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LiveLessonMissionQuestionnaire>(entity =>
            {
                entity.HasKey(e => new { e.LiveLessonMissionId, e.QuestionnaireId });

                entity.ToTable("live_lesson_mission_questionnaire");

                entity.Property(e => e.LiveLessonMissionId).HasColumnName("live_lesson_mission_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.LiveLessonDetailId).HasColumnName("live_lesson_detail_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionnaireType).HasColumnName("questionnaire_type");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.LiveLessonDetail).WithMany(p => p.LiveLessonMissionQuestionnaires)
                    .HasForeignKey(d => d.LiveLessonDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LiveLessonMission).WithMany(p => p.LiveLessonMissionQuestionnaires)
                    .HasForeignKey(d => d.LiveLessonMissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Mocktest>(entity =>
            {
                entity
                    .ToTable("mocktest")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.MocktestObjectId, "IX_mocktest_mocktest_object_id");

                entity.HasIndex(e => e.MocktestTypeId, "IX_mocktest_mocktest_type_id");

                entity.HasIndex(e => e.Status, "IX_mocktest_status");

                entity.HasIndex(e => e.VersionStatus, "IX_mocktest_version_status");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.LinkUrlViewMore)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link_url_view_more");
                entity.Property(e => e.MocktestObjectId).HasColumnName("mocktest_object_id");
                entity.Property(e => e.MocktestTypeId).HasColumnName("mocktest_type_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PublishedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("published_at");
                entity.Property(e => e.ScoreType)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("score_type");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
                entity.Property(e => e.Tags)
                    .HasMaxLength(1000)
                    .HasColumnName("tags");
                entity.Property(e => e.TextViewMore)
                    .HasMaxLength(225)
                    .HasColumnName("text_view_more");
                entity.Property(e => e.VersionStatus)
                    .HasDefaultValueSql("((3))")
                    .HasColumnName("version_status");

                entity.HasOne(d => d.MocktestObject).WithMany(p => p.Mocktests)
                    .HasForeignKey(d => d.MocktestObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MocktestType).WithMany(p => p.Mocktests)
                    .HasForeignKey(d => d.MocktestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MocktestCoursePrice>(entity =>
            {
                entity.HasKey(e => new { e.MocktestId, e.CoursePriceId });

                entity
                    .ToTable("mocktest_course_price")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_course_price_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.CoursePrice).WithMany(p => p.MocktestCoursePrices)
                    .HasForeignKey(d => d.CoursePriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Mocktest).WithMany(p => p.MocktestCoursePrices)
                    .HasForeignKey(d => d.MocktestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MocktestKeyCode>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("mocktest_key_code");

                entity.HasIndex(e => e.MocktestId, "IX_mocktest_key_code_mocktest_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("code");
                entity.Property(e => e.Browser)
                    .HasMaxLength(128)
                    .HasColumnName("browser");
                entity.Property(e => e.ChallengeName)
                    .HasMaxLength(255)
                    .HasColumnName("challenge_name");
                entity.Property(e => e.ClientIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("client_ip");
                entity.Property(e => e.Cookie).HasColumnName("cookie");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");
                entity.Property(e => e.ExpiredTriggerNotification)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("expired_trigger_notification");
                entity.Property(e => e.FullName)
                    .HasMaxLength(128)
                    .HasColumnName("full_name");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(391)
                    .HasComputedColumnSql("(concat([code],' ',isnull([identification_number],''),' ',isnull([challenge_name],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.IdentificationNumber)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("identification_number");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.MocktestPublishedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("mocktest_published_at");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.OrderId).HasColumnName("order_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
                entity.Property(e => e.StartedDoingExamDate)
                    .HasColumnType("datetime")
                    .HasColumnName("started_doing_exam_date");
                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_date");
                entity.Property(e => e.TimeRemaining).HasColumnName("time_remaining");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.IsAutoGenerate).HasColumnName("is_auto_generate");
                entity.Property(e => e.IsDelete).HasColumnName("is_delete");
                entity.Property(e => e.RegistrationToken)
                    .HasMaxLength(1000)
                    .HasColumnName("registration_token");
            });

            modelBuilder.Entity<MocktestObject>(entity =>
            {
                entity
                    .ToTable("mocktest_object")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_object_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.Name, "IX_mocktest_object_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<MocktestPart>(entity =>
            {
                entity
                    .ToTable("mocktest_part")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_part_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.MocktestSectionId, "IX_mocktest_part_mocktest_section_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DelayTimeEachQuestion).HasColumnName("delay_time_each_question");
                entity.Property(e => e.IntroAudioFileId).HasColumnName("intro_audio_file_id");
                entity.Property(e => e.MocktestSectionId).HasColumnName("mocktest_section_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");

                entity.HasOne(d => d.MocktestSection).WithMany(p => p.MocktestParts)
                    .HasForeignKey(d => d.MocktestSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MocktestPartQuestionnaire>(entity =>
            {
                entity.HasKey(e => new { e.MocktestPartId, e.QuestionnaireId });

                entity
                    .ToTable("mocktest_part_questionnaire")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_part_questionnaire_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.MocktestPartId).HasColumnName("mocktest_part_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.MocktestPart).WithMany(p => p.MocktestPartQuestionnaires)
                    .HasForeignKey(d => d.MocktestPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.MocktestPartQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MocktestSection>(entity =>
            {
                entity
                    .ToTable("mocktest_section")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_section_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.MocktestId, "IX_mocktest_section_mocktest_id");

                entity.HasIndex(e => e.RankingScoreId, "IX_mocktest_section_ranking_score_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.NumberOfQuestions).HasColumnName("number_of_questions");
                entity.Property(e => e.NumberOfTime).HasColumnName("number_of_time");
                entity.Property(e => e.RankingScoreId).HasColumnName("ranking_score_id");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");
                entity.Property(e => e.Type)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("type");

                entity.HasOne(d => d.Mocktest).WithMany(p => p.MocktestSections)
                    .HasForeignKey(d => d.MocktestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RankingScore).WithMany(p => p.MocktestSections)
                    .HasForeignKey(d => d.RankingScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MocktestTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.MocktestId });

                entity
                    .ToTable("mocktest_translation")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_translation_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.MocktestId).HasColumnName("mocktest_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Language).WithMany(p => p.MocktestTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Mocktest).WithMany(p => p.MocktestTranslations).HasForeignKey(d => d.MocktestId);
            });

            modelBuilder.Entity<MocktestType>(entity =>
            {
                entity
                    .ToTable("mocktest_type")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("mocktest_type_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.Name, "IX_mocktest_type_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.HasIndex(e => e.CategoryId, "IX_news_category_id");

                entity.HasIndex(e => e.NameNonAscii, "UQ__news__65D5AC5CA9D2D540").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Author)
                    .HasMaxLength(128)
                    .HasColumnName("author");
                entity.Property(e => e.CategoryId).HasColumnName("category_id");
                entity.Property(e => e.CategoryName)
                    .HasMaxLength(128)
                    .HasColumnName("category_name");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_active");
                entity.Property(e => e.IsHome).HasColumnName("is_home");
                entity.Property(e => e.IsHot).HasColumnName("is_hot");
                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(500)
                    .HasColumnName("meta_description");
                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(200)
                    .HasColumnName("meta_keywords");
                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(400)
                    .HasColumnName("meta_title");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NameNonAscii)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_non_ascii");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Category).WithMany(p => p.News)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_news_category_id");
            });

            modelBuilder.Entity<NewsTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.NewsId });

                entity.ToTable("news_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.NewsId).HasColumnName("news_id");
                entity.Property(e => e.Content).HasColumnName("content");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Language).WithMany(p => p.NewsTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.News).WithMany(p => p.NewsTranslations).HasForeignKey(d => d.NewsId);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notification");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DatetimeTrigger)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_trigger");
                entity.Property(e => e.FullTextSearch).HasColumnName("full_text_search");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<NotificationTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.NotificationId });

                entity.ToTable("notification_translation");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.NotificationId).HasColumnName("notification_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");
                entity.Property(e => e.LinkUrl)
                    .IsUnicode(false)
                    .HasColumnName("link_url");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("title");

                entity.HasOne(d => d.Language).WithMany(p => p.NotificationTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Notification).WithMany(p => p.NotificationTranslations).HasForeignKey(d => d.NotificationId);
            });

            modelBuilder.Entity<NotificationWebUser>(entity =>
            {
                entity.HasKey(e => new { e.NotificationId, e.WebUserId });

                entity.ToTable("notification_web_user");

                entity.Property(e => e.NotificationId).HasColumnName("notification_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.IsRead).HasColumnName("is_read");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.HasIndex(e => e.OrderCode, "IX_order_code").IsUnique();

                entity.HasIndex(e => e.OrderDate, "IX_order_date");

                entity.HasIndex(e => e.IsProvideEnoughAccount, "IX_order_is_provide_enough_account");

                entity.HasIndex(e => e.ReceiptCode, "IX_order_receipt_code");

                entity.HasIndex(e => e.Status, "IX_order_status");

                entity.HasIndex(e => e.WebUserId, "IX_order_web_user_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.ApplyDiscountCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("apply_discount_code");
                entity.Property(e => e.ApplyDiscountExpiredTime)
                    .HasColumnType("datetime")
                    .HasColumnName("apply_discount_expired_time");
                entity.Property(e => e.ApplyDiscountMethod).HasColumnName("apply_discount_method");
                entity.Property(e => e.ApplyDiscountPercent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("apply_discount_percent");
                entity.Property(e => e.ApplyDiscountPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("apply_discount_price");
                entity.Property(e => e.ApplyDiscountTypeUse).HasColumnName("apply_discount_type_use");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(595)
                    .HasComputedColumnSql("(concat([order_code],' ',isnull([web_user_full_name],''),' ',isnull([web_user_phone_number],''),' ',isnull([web_user_email],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.IsFreeOrder).HasColumnName("is_free_order");
                entity.Property(e => e.IsProvideEnoughAccount)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("is_provide_enough_account");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_code");
                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("order_date");
                entity.Property(e => e.OrderNote)
                    .HasMaxLength(300)
                    .HasColumnName("order_note");
                entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
                entity.Property(e => e.PriceShipping)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price_shipping");
                entity.Property(e => e.ReceiptCode).HasColumnName("receipt_code").IsConcurrencyToken();
                entity.Property(e => e.Shipping).HasColumnName("shipping");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
                entity.Property(e => e.TotalDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_discount");
                entity.Property(e => e.TotalPayment)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_payment");
                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_price");
                entity.Property(e => e.TotalProducts).HasColumnName("total_products");
                entity.Property(e => e.WebUserEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("web_user_email");
                entity.Property(e => e.WebUserFullName)
                    .HasMaxLength(255)
                    .HasColumnName("web_user_full_name");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.WebUserIdentifier)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("web_user_identifier");
                entity.Property(e => e.WebUserPhoneNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("web_user_phone_number");

                entity.HasOne(d => d.WebUser).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.CourseId, e.CoursePriceId });

                entity.ToTable("order_details");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.IsDraft).HasColumnName("is_draft");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Course).WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CoursePrice).WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CoursePriceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails).HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<PaymentTransaction>(entity =>
            {
                entity.ToTable("payment_transaction");

                entity.HasIndex(e => e.OrderCode, "IX_payment_transaction_order_code");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bank_code");
                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("card_type");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_code");
                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pay_date");
                entity.Property(e => e.PaymentContent)
                    .HasMaxLength(500)
                    .HasColumnName("payment_content");
                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("status");
                entity.Property(e => e.TraceId)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("trace_id");
                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("transaction_code");

                entity.HasOne(d => d.Order).WithMany(p => p.PaymentTransactions)
                    .HasPrincipalKey(p => p.OrderCode)
                    .HasForeignKey(d => d.OrderCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission");

                entity.HasIndex(e => e.Name, "IX_permission_name");

                entity.HasIndex(e => e.ParentId, "IX_permission_parent_id");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("description");
                entity.Property(e => e.IsPermission).HasColumnName("is_permission");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.ParentId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("parent_id");
                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_permission_parent_id");
            });

            modelBuilder.Entity<PolicyMocktestSetting>(entity =>
            {
                entity.ToTable("policy_mocktest_setting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SoundTestFileId).HasColumnName("sound_test_file_id");
            });

            modelBuilder.Entity<PolicyMocktestSettingTranslation>(entity =>
            {
                entity.HasKey(e => new { e.PolicyMocktestSettingId, e.LanguageCode });

                entity.ToTable("policy_mocktest_setting_translation");

                entity.Property(e => e.PolicyMocktestSettingId).HasColumnName("policy_mocktest_setting_id");
                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.GuidingContent).HasColumnName("guiding_content");
                entity.Property(e => e.GuidingName)
                    .HasMaxLength(255)
                    .HasColumnName("guiding_name");
                entity.Property(e => e.PolicyContent).HasColumnName("policy_content");
                entity.Property(e => e.PolicyName)
                    .HasMaxLength(255)
                    .HasColumnName("policy_name");
                entity.Property(e => e.SoundContent).HasColumnName("sound_content");
                entity.Property(e => e.SoundName)
                    .HasMaxLength(255)
                    .HasColumnName("sound_name");

                entity.HasOne(d => d.Language).WithMany(p => p.PolicyMocktestSettingTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pmst_language_tags_language_code");

                entity.HasOne(d => d.PolicyMocktestSetting).WithMany(p => p.PolicyMocktestSettingTranslations)
                    .HasForeignKey(d => d.PolicyMocktestSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_pmst_pms_policy_mocktest_setting_id");
            });

            //modelBuilder.Entity<Provinces>(entity =>
            //{
            //    entity.ToTable("Provinces");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("Id");
            //    entity.Property(e => e.Code)
            //        .HasColumnName("Code");
            //    entity.Property(e => e.Name)
            //        .HasColumnName("Name");
            //    entity.Property(e => e.Type)
            //        .HasColumnName("Type");
            //    entity.Property(e => e.CreatedByUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("CreatedByUserId");
            //    entity.Property(e => e.LastModifiedByUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("LastModifiedByUserId");
            //    entity.Property(e => e.LastModifiedOnDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("LastModifiedOnDate");
            //    entity.Property(e => e.CreatedOnDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("CreatedOnDate");
            //});

            modelBuilder.Entity<Question>(entity =>
            {
                entity
                    .ToTable("question")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("question_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DisplayTimestamp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("display_timestamp");
                entity.Property(e => e.Explanation).HasColumnName("explanation");
                entity.Property(e => e.FakeValues)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("fake_values");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.MatchingJson).HasColumnName("matching_json");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
                entity.Property(e => e.Note).HasColumnName("note");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.TextEnglish)
                    .HasMaxLength(500)
                    .HasColumnName("text_english");
                entity.Property(e => e.TextFileId).HasColumnName("text_file_id");
                entity.Property(e => e.TypeOfWord).HasColumnName("type_of_word");
                entity.Property(e => e.WordEnglish)
                    .HasMaxLength(500)
                    .HasColumnName("word_english");
                entity.Property(e => e.WordFileId).HasColumnName("word_file_id");
                entity.Property(e => e.WordPhonetic)
                    .HasMaxLength(50)
                    .HasColumnName("word_phonetic");

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.Questions).HasForeignKey(d => d.QuestionnaireId);
            });

            modelBuilder.Entity<QuestionTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.QuestionId });

                entity
                    .ToTable("question_translation")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("question_translation_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("language_code");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.WordTranslation)
                    .HasMaxLength(500)
                    .HasColumnName("word_translation");

                entity.HasOne(d => d.Language).WithMany(p => p.QuestionTranslations)
                    .HasForeignKey(d => d.LanguageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Question).WithMany(p => p.QuestionTranslations).HasForeignKey(d => d.QuestionId);
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity
                    .ToTable("questionnaire")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("questionnaire_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.Identifier, "UQ__question__D112ED48B5594887").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(522)
                    .HasComputedColumnSql("(concat([name],' ',[identifier],' ',[questionnaire_group_name]))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("identifier");
                entity.Property(e => e.IntroContent)
                    .HasMaxLength(128)
                    .HasColumnName("intro_content");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.QuestionnaireGroupId).HasColumnName("questionnaire_group_id");
                entity.Property(e => e.QuestionnaireGroupName)
                    .HasMaxLength(255)
                    .HasColumnName("questionnaire_group_name");
                entity.Property(e => e.SlideFileId).HasColumnName("slide_file_id");
                entity.Property(e => e.SubtitleFileId).HasColumnName("subtitle_file_id");
                entity.Property(e => e.TitleLeftSection)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title_left_section");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.VideoFileId).HasColumnName("video_file_id");

                entity.HasOne(d => d.QuestionnaireGroup).WithMany(p => p.Questionnaires).HasForeignKey(d => d.QuestionnaireGroupId);
            });

            modelBuilder.Entity<QuestionnaireGroup>(entity =>
            {
                entity
                    .ToTable("questionnaire_group", tb =>
                    {
                        tb.HasTrigger("after_trg_insert_update_questionniare_group");
                        tb.HasTrigger("after_trg_update_name_questionniare_group");
                    })
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("questionnaire_group_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.Identifier, "UQ__question__D112ED483FFB229F").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(1290)
                    .HasComputedColumnSql("(concat([name],' ',[identifier],' ',isnull([parent_name_one],''),' ',isnull([parent_name_two],''),' ',isnull([parent_name_three],''),' ',isnull([parent_name_four],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("identifier");
                entity.Property(e => e.Level).HasColumnName("level");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.ParentIdFour).HasColumnName("parent_id_four");
                entity.Property(e => e.ParentIdOne).HasColumnName("parent_id_one");
                entity.Property(e => e.ParentIdThree).HasColumnName("parent_id_three");
                entity.Property(e => e.ParentIdTwo).HasColumnName("parent_id_two");
                entity.Property(e => e.ParentNameFour)
                    .HasMaxLength(255)
                    .HasColumnName("parent_name_four");
                entity.Property(e => e.ParentNameOne)
                    .HasMaxLength(255)
                    .HasColumnName("parent_name_one");
                entity.Property(e => e.ParentNameThree)
                    .HasMaxLength(255)
                    .HasColumnName("parent_name_three");
                entity.Property(e => e.ParentNameTwo)
                    .HasMaxLength(255)
                    .HasColumnName("parent_name_two");

                entity.HasOne(d => d.ParentIdOneNavigation).WithMany(p => p.InverseParentIdOneNavigation)
                    .HasForeignKey(d => d.ParentIdOne)
                    .HasConstraintName("FK_questionnaire_group_parent_id_one");
            });

            modelBuilder.Entity<QuestionnaireQuestionView>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToView("questionnaire_question_view");

                entity.Property(e => e.NumberOfQuestions).HasColumnName("number_of_questions");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
            });

            modelBuilder.Entity<RankingScore>(entity =>
            {
                entity
                    .ToTable("ranking_score")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("ranking_score_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(501)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(concat(isnull([name],''),' '))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.MaxScore).HasColumnName("max_score");
                entity.Property(e => e.MinScore).HasColumnName("min_score");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");
                entity.Property(e => e.NumScoreRange).HasColumnName("num_score_range");
                entity.Property(e => e.NumberOfQuestions).HasColumnName("number_of_questions");
            });

            modelBuilder.Entity<ReceiveInvoice>(entity =>
            {
                entity.ToTable("receive_invoice");

                entity.HasIndex(e => e.UserId, "IX_receive_invoice_user_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(204)
                    .HasComputedColumnSql("(concat(isnull([receipt_code],''),' ',isnull([name],''),' ',isnull([tax_code],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("order_code");
                entity.Property(e => e.ReceiptCode).HasColumnName("receipt_code");
                entity.Property(e => e.Status).HasColumnName("status");
                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_code");
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User).WithMany(p => p.ReceiveInvoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_receive_invoice_web_user_id");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("review");

                entity.HasIndex(e => e.CourseId, "IX_review_course_id");

                entity.HasIndex(e => e.Status, "IX_review_status");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(544)
                    .HasComputedColumnSql("(concat(isnull([full_name],''),' ',isnull([phone_number],''),' ',isnull([email],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("rate");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("status");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");

                entity.HasOne(d => d.Course).WithMany(p => p.Reviews).HasForeignKey(d => d.CourseId);

                entity.HasOne(d => d.WebUser).WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.SetNull);
            });

            //modelBuilder.Entity<Schools>(entity =>
            //{
            //    entity.ToTable("Schools");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("Id");
            //    entity.Property(e => e.Code)
            //        .HasColumnName("Code");
            //    entity.Property(e => e.Name)
            //        .HasMaxLength(450)
            //        .HasColumnName("Name");
            //    entity.Property(e => e.Address)
            //        .HasColumnName("Address");
            //    entity.Property(e => e.Email)
            //        .HasColumnName("Email");
            //    entity.Property(e => e.Tel)
            //        .HasColumnName("Tel");
            //    entity.Property(e => e.ProvinceId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ProvinceId");
            //    entity.Property(e => e.DistrictId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("DistrictId");
            //    entity.Property(e => e.DepartmentId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("DepartmentId");
            //    entity.Property(e => e.DivisionId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("DivisionId");
            //    entity.Property(e => e.CreatedByUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("CreatedByUserId");
            //    entity.Property(e => e.LastModifiedByUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("LastModifiedByUserId");
            //    entity.Property(e => e.LastModifiedOnDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("LastModifiedOnDate");
            //    entity.Property(e => e.CreatedOnDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("CreatedOnDate");
            //    entity.Property(e => e.ParentId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ParentId");
            //    entity.Property(e => e.Description)
            //        .HasColumnName("Description");
            //    entity.Property(e => e.IsDelete)
            //        .HasColumnName("IsDelete");
            //});

            modelBuilder.Entity<ScoreComment>(entity =>
            {
                entity
                    .ToTable("score_comment")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("score_comment_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => new { e.FromScore, e.ToScore }, "IX_score_comment_from_score_to_score");

                entity.HasIndex(e => e.RankingScoreId, "IX_score_comment_ranking_score_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Comment).HasColumnName("comment");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.FromScore).HasColumnName("from_score");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.RankingScoreId).HasColumnName("ranking_score_id");
                entity.Property(e => e.SortOrder)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("sort_order");
                entity.Property(e => e.ToScore).HasColumnName("to_score");

                entity.HasOne(d => d.RankingScore).WithMany(p => p.ScoreComments)
                    .HasForeignKey(d => d.RankingScoreId)
                    .HasConstraintName("FK_score_comment_ranking_score_id");
            });

            modelBuilder.Entity<ScoreDetail>(entity =>
            {
                entity
                    .ToTable("score_detail")
                    .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("score_detail_history", "dbo");
                        ttb
                            .HasPeriodStart("ValidFrom")
                            .HasColumnName("ValidFrom");
                        ttb
                            .HasPeriodEnd("ValidTo")
                            .HasColumnName("ValidTo");
                    }));

                entity.HasIndex(e => e.ExactScore, "IX_score_detail_exact_score");

                entity.HasIndex(e => e.NumberOfCorrectQuestions, "IX_score_detail_number_of_correct_questions");

                entity.HasIndex(e => e.RankingScoreId, "IX_score_detail_ranking_score_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ExactScore).HasColumnName("exact_score");
                entity.Property(e => e.FromScore).HasColumnName("from_score");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.NumberOfCorrectQuestions).HasColumnName("number_of_correct_questions");
                entity.Property(e => e.RankingScoreId).HasColumnName("ranking_score_id");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.ToScore).HasColumnName("to_score");

                entity.HasOne(d => d.RankingScore).WithMany(p => p.ScoreDetails)
                    .HasForeignKey(d => d.RankingScoreId)
                    .HasConstraintName("FK_score_detail_ranking_score_id");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("setting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DataType).HasColumnName("data_type");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<ShowingArea>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("showing_area");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");
                entity.Property(e => e.AreaName)
                    .HasMaxLength(100)
                    .HasColumnName("area_name");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<SocialMedium>(entity =>
            {
                entity.ToTable("social_media");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.IconFileId).HasColumnName("icon_file_id");
                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("link_url");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.ToTable("step");

                entity.HasIndex(e => e.LessonId, "IX_step_lesson_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.LessonId).HasColumnName("lesson_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title");

                entity.HasOne(d => d.Lesson).WithMany(p => p.Steps).HasForeignKey(d => d.LessonId);
            });

            modelBuilder.Entity<StepQuestionnaire>(entity =>
            {
                entity.HasKey(e => new { e.StepId, e.QuestionnaireId });

                entity.ToTable("step_questionnaire");

                entity.HasIndex(e => e.CourseId, "IX_step_questionnaire_course_id");

                entity.HasIndex(e => e.LessonId, "IX_step_questionnaire_lesson_id");

                entity.HasIndex(e => e.UnitId, "IX_step_questionnaire_unit_id");

                entity.Property(e => e.StepId).HasColumnName("step_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.LessonId).HasColumnName("lesson_id");
                entity.Property(e => e.QuestionnaireType).HasColumnName("questionnaire_type");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.StepQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Step).WithMany(p => p.StepQuestionnaires).HasForeignKey(d => d.StepId);
            });

            modelBuilder.Entity<StoreCourse>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrderId });

                entity.ToTable("store_course");

                entity.HasIndex(e => e.IsMocktestType, "IX_store_course_is_mocktest_type");

                entity.HasIndex(e => new { e.WebUserId, e.CourseId, e.LearningCourseExpired }, "IX_store_course_multiple_wui_ci_lce");

                entity.HasIndex(e => e.OrderId, "IX_store_course_order_id");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.OrderId).HasColumnName("order_id");
                entity.Property(e => e.ClassTypeId).HasColumnName("class_type_id");
                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("course_code");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
                entity.Property(e => e.CoursePriceName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("course_price_name");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.ExamToolCategoryId).HasColumnName("exam_tool_category_id");
                entity.Property(e => e.IsFreeLearningUnit1Lesson1).HasColumnName("is_free_learning_unit1_lesson1");
                entity.Property(e => e.IsMocktestType).HasColumnName("is_mocktest_type");
                entity.Property(e => e.LearnInOrder).HasColumnName("learn_in_order");
                entity.Property(e => e.LearningCourseExpired)
                    .HasColumnType("datetime")
                    .HasColumnName("learning_course_expired");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
                entity.Property(e => e.NumberOfMonth).HasColumnName("number_of_month");
                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");
                entity.Property(e => e.ProductType)
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("product_type");
                entity.Property(e => e.Quantity).HasColumnName("quantity");
                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sale_price");
                entity.Property(e => e.TotalPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_price");
                entity.Property(e => e.TotalSalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_sale_price");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");

                entity.HasOne(d => d.Order).WithMany(p => p.StoreCourses).HasForeignKey(d => d.OrderId);
            });

            //modelBuilder.Entity<ToeflChallengeContest>(entity =>
            //{
            //    entity.ToTable("toefl_challenge_contest");

            //    entity.HasIndex(e => e.Name, "IX_toefl_challenge_contest_name");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .HasColumnName("name");
            //    entity.Property(e => e.IconFileId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("icon_file_id");
            //    entity.Property(e => e.StartDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("start_date");
            //    entity.Property(e => e.EndDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("end_date");
            //    entity.Property(e => e.Created)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnName("created");
            //    entity.Property(e => e.Modified)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnName("modified");
            //    entity.Property(e => e.ProvinceId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("province_id");
            //    entity.Property(e => e.Display)
            //        .HasColumnName("display");
            //    entity.Property(e => e.LastUpdateUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("last_update_user_id");
            //    entity.Property(e => e.CreatedUserId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("created_user_id");

            //    entity.HasOne(d => d.LastUpdateUser).WithMany(p => p.LastUpdateToeflChallengeContests)
            //       .HasForeignKey(d => d.LastUpdateUserId);
            //    entity.HasOne(d => d.CreatedUserUser).WithMany(p => p.CreatedToeflChallengeContests)
            //       .HasForeignKey(d => d.CreatedUserId);

            //    entity.HasOne(d => d.Province).WithMany(p => p.ToeflChallengeContests)
            //      .HasForeignKey(d => d.ProvinceId);

            //    entity.HasOne(d => d.File).WithMany(p => p.ToeflChallengeContests)
            //      .HasForeignKey(d => d.IconFileId);
            //});

            //modelBuilder.Entity<ToeflChallengeContestMocktest>(entity =>
            //{
            //    entity.HasKey(e => new { e.ContestId, e.MocktestId });

            //    entity.ToTable("toefl_challenge_contest_mocktest");

            //    entity.Property(e => e.ContestId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("contest_id");
            //    entity.Property(e => e.MocktestId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("mocktest_id");
            //    entity.Property(e => e.Created)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnName("created");
            //});

            //modelBuilder.Entity<ToeflChallengeRankingScore>(entity =>
            //{
            //    entity
            //        .ToTable("toefl_challenge_ranking_score");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.Created)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("created");
            //    entity.Property(e => e.IsActive).HasColumnName("is_active");
            //    entity.Property(e => e.MaxScore).HasColumnName("max_score");
            //    entity.Property(e => e.Modified)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("modified");
            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(500)
            //        .IsUnicode(true)
            //        .HasColumnName("name");
            //});

            //modelBuilder.Entity<ToeflChallengeRankingScoreMocktestType>(entity =>
            //{
            //    entity
            //        .ToTable("toefl_challenge_ranking_score_mocktest_type");

            //    entity.HasKey(e => new { e.RankingScoreId, e.MocktestTypeId });

            //    entity.Property(e => e.RankingScoreId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("ranking_score_id");
            //    entity.Property(e => e.MocktestTypeId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("mocktest_type_id");
            //    entity.HasOne<ToeflChallengeRankingScore>(sc => sc.RankingScore)
            //        .WithMany(s => s.RankingScoreMocktests)
            //        .HasForeignKey(sc => sc.RankingScoreId);


            //    entity.HasOne<MocktestType>(sc => sc.MocktestType)
            //        .WithMany(s => s.RankingScoreMocktests)
            //        .HasForeignKey(sc => sc.MocktestTypeId);
            //});

            //modelBuilder.Entity<ToeflChallengeScoreComment>(entity =>
            //{
            //    entity
            //        .ToTable("toefl_challenge_score_comment");

            //    entity.HasIndex(e => new { e.FromScore, e.ToScore }, "IX_toefl_challenge_score_comment_from_score_to_score");

            //    entity.HasIndex(e => e.RankingScoreId, "IX_toefl_challenge_score_comment_ranking_score_id");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.ImageId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("image_id");
            //    entity.Property(e => e.Created)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("created");
            //    entity.Property(e => e.FromScore).HasColumnName("from_score");
            //    entity.Property(e => e.Modified)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("modified");
            //    entity.Property(e => e.RankingScoreId).HasColumnName("ranking_score_id");
            //    entity.Property(e => e.ToScore).HasColumnName("to_score");

            //    entity.HasOne(d => d.RankingScore).WithMany(p => p.ScoreComments)
            //        .HasForeignKey(d => d.RankingScoreId)
            //        .HasConstraintName("FK_toefl_challenge_score_comment_ranking_score_id");
            //});

            //modelBuilder.Entity<ToeflChallengeUser>(entity =>
            //{
            //    entity.ToTable("toefl_challenge_user");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.ContestId)
            //        .ValueGeneratedNever()
            //        .HasColumnName("contest_id");
            //    entity.Property(e => e.ParentName)
            //        .HasMaxLength(50)
            //        .HasColumnName("parent_name");
            //    entity.Property(e => e.ParentPhoneNumber)
            //        .HasMaxLength(32)
            //        .IsUnicode(false)
            //        .HasColumnName("parent_phone_number");
            //    entity.Property(e => e.ParentEmail)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("parent_email");
            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .HasColumnName("name");
            //    entity.Property(e => e.Birthday)
            //        .HasColumnType("datetime")
            //        .HasColumnName("birthday");
            //    entity.Property(e => e.Gender)
            //        .HasMaxLength(1)
            //        .IsUnicode(false)
            //        .IsFixedLength()
            //        .HasColumnName("gender");
            //    entity.Property(e => e.Province)
            //        .HasMaxLength(50)
            //        .HasColumnName("province");
            //    entity.Property(e => e.District)
            //        .HasMaxLength(50)
            //        .HasColumnName("district");
            //    entity.Property(e => e.Block)
            //        .HasMaxLength(50)
            //        .HasColumnName("block");
            //    entity.Property(e => e.School)
            //        .HasMaxLength(255)
            //        .HasColumnName("school");
            //    entity.Property(e => e.Created)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnName("created");
            //    entity.Property(e => e.IsDelete)
            //        .HasColumnName("is_delete");
            //    entity.Property(e => e.FullTextSearch)
            //        .HasColumnName("full_text_search");
            //});

            //modelBuilder.Entity<TransferExamToolHistory>(entity =>
            //{
            //    entity.ToTable("transfer_exam_tool_history");

            //    entity.HasIndex(e => e.CoursePriceId, "IX_transfer_exam_tool_history_course_price_id");

            //    entity.HasIndex(e => e.OrderId, "IX_transfer_exam_tool_history_order_id");

            //    entity.Property(e => e.Id)
            //        .ValueGeneratedNever()
            //        .HasColumnName("id");
            //    entity.Property(e => e.AccountBankId).HasColumnName("account_bank_id");
            //    entity.Property(e => e.CoursePriceId).HasColumnName("course_price_id");
            //    entity.Property(e => e.Created)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("created");
            //    entity.Property(e => e.Keycode)
            //        .HasMaxLength(255)
            //        .IsUnicode(false)
            //        .HasColumnName("keycode");
            //    entity.Property(e => e.Modified)
            //        .HasDefaultValueSql("(getutcdate())")
            //        .HasColumnType("datetime")
            //        .HasColumnName("modified");
            //    entity.Property(e => e.OrderId).HasColumnName("order_id");
            //    entity.Property(e => e.Password)
            //        .HasMaxLength(128)
            //        .HasColumnName("password");
            //    entity.Property(e => e.UserName)
            //        .HasMaxLength(255)
            //        .HasColumnName("user_name");
            //});

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("unit");

                entity.HasIndex(e => e.CourseId, "IX_unit_course_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.ImageFileId).HasColumnName("image_file_id");
                entity.Property(e => e.LearnInOrder)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasColumnName("learn_in_order");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.TagName)
                    .HasMaxLength(128)
                    .HasColumnName("tag_name");
                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title");
                entity.Property(e => e.WeekLearningPlan).HasColumnName("week_learning_plan");

                entity.HasOne(d => d.Course).WithMany(p => p.Units).HasForeignKey(d => d.CourseId);
            });

            modelBuilder.Entity<UnitTest>(entity =>
            {
                entity.ToTable("unit_test");

                entity.HasIndex(e => e.UnitId, "IX_unit_test_unit_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
                entity.Property(e => e.TestTime).HasColumnName("test_time");
                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasColumnName("title");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.HasOne(d => d.Unit).WithMany(p => p.UnitTests).HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<UnitTestQuestionnaire>(entity =>
            {
                entity.HasKey(e => new { e.UnitTestId, e.QuestionnaireId });

                entity.ToTable("unit_test_questionnaire");

                entity.HasIndex(e => e.CourseId, "IX_unit_test_questionnaire_course_id");

                entity.Property(e => e.UnitTestId).HasColumnName("unit_test_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionnaireType).HasColumnName("questionnaire_type");
                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.HasOne(d => d.Course).WithMany(p => p.UnitTestQuestionnaires)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.UnitTestQuestionnaires)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UnitTest).WithMany(p => p.UnitTestQuestionnaires)
                    .HasForeignKey(d => d.UnitTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VerificationCode>(entity =>
            {
                entity.ToTable("verification_codes");

                entity.HasIndex(e => new { e.Code, e.Email, e.Type, e.ExpiresAtTime }, "IX_verification_codes_expires_at_time_code").IsDescending(false, false, false, true);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("code");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnName("created");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.ExpiresAtTime).HasColumnName("expires_at_time");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnName("modified");
                entity.Property(e => e.ServiceProvider)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("service_provider");
                entity.Property(e => e.Type).HasColumnName("type");
                entity.Property(e => e.Used).HasColumnName("used");
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User).WithMany(p => p.VerificationCodes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_verification_codes_user_id");
            });

            modelBuilder.Entity<WebUser>(entity =>
            {
                entity.ToTable("web_user");

                entity.HasIndex(e => e.Email, "IX_web_user_email");

                entity.HasIndex(e => e.PhoneNumber, "IX_web_user_phone_number");

                entity.HasIndex(e => e.UserName, "IX_web_user_user_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.AccessFailedCount).HasColumnName("access_failed_count");
                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");
                entity.Property(e => e.ClassinUserId).HasColumnName("classin_user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.CurrentAddress)
                    .HasMaxLength(500)
                    .HasColumnName("current_address");
                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("deleted");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.EmailVerified).HasColumnName("email_verified");
                entity.Property(e => e.FacebookId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("facebook_id");
                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");
                entity.Property(e => e.FullTextSearch)
                    .IsRequired()
                    .HasMaxLength(552)
                    .HasComputedColumnSql("(concat(isnull([email],''),' ',isnull([phone_number],''),' ',isnull([full_name],''),' ',isnull([identifier],'')))", false)
                    .HasColumnName("full_text_search");
                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("gender");
                entity.Property(e => e.GoogleId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("google_id");
                entity.Property(e => e.Identifier)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("identifier");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.JobName)
                    .HasMaxLength(255)
                    .HasColumnName("job_name");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash");
                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasColumnName("password_salt");
                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
                entity.Property(e => e.RegisterType)
                    .HasDefaultValueSql("((3))")
                    .HasColumnName("register_type");
                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            modelBuilder.Entity<WebUserChoose>(entity =>
            {
                entity.HasKey(e => new { e.WebUserId, e.AnswerId, e.StepId });

                entity.ToTable("web_user_choose");

                entity.HasIndex(e => e.CourseId, "IX_web_user_choose_course_id");

                entity.HasIndex(e => e.LessonId, "IX_web_user_choose_lesson_id");

                entity.HasIndex(e => e.UnitId, "IX_web_user_choose_unit_id");

                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.StepId).HasColumnName("step_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.LessonId).HasColumnName("lesson_id");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");
                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.HasOne(d => d.Answer).WithMany(p => p.WebUserChooses)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Question).WithMany(p => p.WebUserChooses).HasForeignKey(d => d.QuestionId);

                entity.HasOne(d => d.Step).WithMany(p => p.WebUserChooses).HasForeignKey(d => d.StepId);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserChooses)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserCourseLearningPlan>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.WebUserId });

                entity.ToTable("web_user_course_learning_plan");

                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DaysPerWeek).HasColumnName("days_per_week");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Course).WithMany(p => p.WebUserCourseLearningPlans)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserCourseLearningPlans)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserCourseTestChoose>(entity =>
            {
                entity.HasKey(e => new { e.WebUserId, e.AnswerId, e.CourseTestId, e.MocktestPartId });

                entity.ToTable("web_user_course_test_choose");

                entity.HasIndex(e => e.QuestionId, "IX_web_user_course_test_choose_question_id");

                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.CourseTestId).HasColumnName("course_test_id");
                entity.Property(e => e.MocktestPartId).HasColumnName("mocktest_part_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.CourseTest).WithMany(p => p.WebUserCourseTestChooses).HasForeignKey(d => d.CourseTestId);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserCourseTestChooses).HasForeignKey(d => d.WebUserId);
            });

            modelBuilder.Entity<WebUserCourseTestResult>(entity =>
            {
                entity.HasKey(e => new { e.CourseTestId, e.WebUserId });

                entity.ToTable("web_user_course_test_result");

                entity.Property(e => e.CourseTestId).HasColumnName("course_test_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.ComponentsDetails).HasColumnName("components_details");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MocktestMenu).HasColumnName("mocktest_menu");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.RankingScore)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ranking_score");
                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_date");
                entity.Property(e => e.TotalCorrectAnswer).HasColumnName("total_correct_answer");
                entity.Property(e => e.TotalQuestion).HasColumnName("total_question");

                entity.HasOne(d => d.CourseTest).WithMany(p => p.WebUserCourseTestResults).HasForeignKey(d => d.CourseTestId);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserCourseTestResults)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserLessonMissionChoose>(entity =>
            {
                entity.HasKey(e => new { e.WebUserId, e.AnswerId, e.LiveLessonMissionId });

                entity.ToTable("web_user_lesson_mission_choose");

                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.LiveLessonMissionId).HasColumnName("live_lesson_mission_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.LiveLessonMission).WithMany(p => p.WebUserLessonMissionChooses)
                    .HasForeignKey(d => d.LiveLessonMissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserLessonMissionChooses)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserLessonMissionResult>(entity =>
            {
                entity.HasKey(e => new { e.LiveLessonMissionId, e.WebUserId });

                entity.ToTable("web_user_lesson_mission_result");

                entity.Property(e => e.LiveLessonMissionId).HasColumnName("live_lesson_mission_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.CorrectPercentage).HasColumnName("correct_percentage");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.LiveLessonDetailId).HasColumnName("live_lesson_detail_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionnaireIds)
                    .IsUnicode(false)
                    .HasColumnName("questionnaire_ids");
                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_date");
                entity.Property(e => e.TotalCorrectAnswer).HasColumnName("total_correct_answer");
                entity.Property(e => e.TotalQuestion).HasColumnName("total_question");

                entity.HasOne(d => d.LiveLessonDetail).WithMany(p => p.WebUserLessonMissionResults)
                    .HasForeignKey(d => d.LiveLessonDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LiveLessonMission).WithMany(p => p.WebUserLessonMissionResults)
                    .HasForeignKey(d => d.LiveLessonMissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserLessonMissionResults)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserLiveTestChoose>(entity =>
            {
                entity.HasKey(e => new { e.WebUserId, e.AnswerId, e.LiveClassDetailTestId, e.MocktestPartId });

                entity.ToTable("web_user_live_test_choose");

                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.LiveClassDetailTestId).HasColumnName("live_class_detail_test_id");
                entity.Property(e => e.MocktestPartId).HasColumnName("mocktest_part_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.LiveClassDetailTest).WithMany(p => p.WebUserLiveTestChooses)
                    .HasForeignKey(d => d.LiveClassDetailTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserLiveTestChooses)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserLiveTestResult>(entity =>
            {
                entity.HasKey(e => new { e.LiveClassDetailTestId, e.WebUserId });

                entity.ToTable("web_user_live_test_result");

                entity.Property(e => e.LiveClassDetailTestId).HasColumnName("live_class_detail_test_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.ComponentsDetails).HasColumnName("components_details");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MocktestMenu).HasColumnName("mocktest_menu");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.RankingScore)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("ranking_score");
                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_date");
                entity.Property(e => e.TotalCorrectAnswer).HasColumnName("total_correct_answer");
                entity.Property(e => e.TotalQuestion).HasColumnName("total_question");

                entity.HasOne(d => d.LiveClassDetailTest).WithMany(p => p.WebUserLiveTestResults)
                    .HasForeignKey(d => d.LiveClassDetailTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserLiveTestResults)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserPracticeHistory>(entity =>
            {
                entity.ToTable("web_user_practice_history");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.DateViewed)
                    .HasColumnType("datetime")
                    .HasColumnName("date_viewed");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");
                entity.Property(e => e.QuestionnaireId).HasColumnName("questionnaire_id");
                entity.Property(e => e.QuestionnaireType).HasColumnName("questionnaire_type");
                entity.Property(e => e.RecordFileId).HasColumnName("record_file_id");
                entity.Property(e => e.StepId).HasColumnName("step_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");

                entity.HasOne(d => d.Questionnaire).WithMany(p => p.WebUserPracticeHistories)
                    .HasForeignKey(d => d.QuestionnaireId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Step).WithMany(p => p.WebUserPracticeHistories)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserPracticeHistories)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WebUserUnitTestChoose>(entity =>
            {
                entity.HasKey(e => new { e.WebUserId, e.AnswerId, e.UnitTestId });

                entity.ToTable("web_user_unit_test_choose");

                entity.HasIndex(e => e.QuestionId, "IX_web_user_unit_test_choose_question_id");

                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.AnswerId).HasColumnName("answer_id");
                entity.Property(e => e.UnitTestId).HasColumnName("unit_test_id");
                entity.Property(e => e.AnswerText)
                    .HasMaxLength(255)
                    .HasColumnName("answer_text");
                entity.Property(e => e.CorrectAnswer).HasColumnName("correct_answer");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.MatchingQuestionId).HasColumnName("matching_question_id");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.UnitTest).WithMany(p => p.WebUserUnitTestChooses).HasForeignKey(d => d.UnitTestId);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserUnitTestChooses).HasForeignKey(d => d.WebUserId);
            });

            modelBuilder.Entity<WebUserUnitTestResult>(entity =>
            {
                entity.HasKey(e => new { e.UnitTestId, e.WebUserId });

                entity.ToTable("web_user_unit_test_result");

                entity.HasIndex(e => e.CourseId, "IX_web_user_unit_test_result_course_id");

                entity.Property(e => e.UnitTestId).HasColumnName("unit_test_id");
                entity.Property(e => e.WebUserId).HasColumnName("web_user_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Created)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("created");
                entity.Property(e => e.Modified)
                    .HasDefaultValueSql("(getutcdate())")
                    .HasColumnType("datetime")
                    .HasColumnName("modified");
                entity.Property(e => e.QuestionnaireIds)
                    .IsUnicode(false)
                    .HasColumnName("questionnaire_ids");
                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("submitted_date");
                entity.Property(e => e.TotalCorrectAnswer).HasColumnName("total_correct_answer");
                entity.Property(e => e.TotalQuestion).HasColumnName("total_question");

                entity.HasOne(d => d.Course).WithMany(p => p.WebUserUnitTestResults)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UnitTest).WithMany(p => p.WebUserUnitTestResults)
                    .HasForeignKey(d => d.UnitTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WebUser).WithMany(p => p.WebUserUnitTestResults)
                    .HasForeignKey(d => d.WebUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            //OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

