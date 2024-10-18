﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.Entities.LLMIntegration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApiEndpoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxTokens")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromptTemplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("LLMIntegrations");
                });

            modelBuilder.Entity("Domain.Entities.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("Domain.Entities.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Domain.Entities.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("Domain.Entities.QuestTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestTasks");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Domain.Entities.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Domain.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenReward")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Domain.Entities.TokenTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountTokens")
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("LectureId")
                        .HasColumnType("int");

                    b.Property<int?>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestId")
                        .HasColumnType("int");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LectureId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("QuestId");

                    b.HasIndex("QuizId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId1");

                    b.ToTable("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EarnedTokens")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.HasOne("Domain.Entities.Module", "Module")
                        .WithMany("Assignments")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Domain.Entities.LLMIntegration", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Lecture", b =>
                {
                    b.HasOne("Domain.Entities.Module", "Module")
                        .WithMany("Lectures")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Domain.Entities.Module", b =>
                {
                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany("Modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Domain.Entities.Quest", b =>
                {
                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany("Quests")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Domain.Entities.QuestTask", b =>
                {
                    b.HasOne("Domain.Entities.Quest", "Quest")
                        .WithMany("Tasks")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.HasOne("Domain.Entities.Quiz", null)
                        .WithMany("Questions")
                        .HasForeignKey("QuizId");

                    b.HasOne("Domain.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Domain.Entities.Quiz", b =>
                {
                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Domain.Entities.Test", b =>
                {
                    b.HasOne("Domain.Entities.Module", "Module")
                        .WithMany("Tests")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Domain.Entities.TokenTransaction", b =>
                {
                    b.HasOne("Domain.Entities.Assignment", "Assignment")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("Domain.Entities.Course", "Course")
                        .WithMany("TokenTransaction")
                        .HasForeignKey("CourseId");

                    b.HasOne("Domain.Entities.Lecture", "Lecture")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("LectureId");

                    b.HasOne("Domain.Entities.Module", "Module")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("ModuleId");

                    b.HasOne("Domain.Entities.Quest", "Quest")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("QuestId");

                    b.HasOne("Domain.Entities.Quiz", "Quiz")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("QuizId");

                    b.HasOne("Domain.Entities.Test", "Test")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("TestId");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("TokenTransactions")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Course");

                    b.Navigation("Lecture");

                    b.Navigation("Module");

                    b.Navigation("Quest");

                    b.Navigation("Quiz");

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Assignment", b =>
                {
                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Course", b =>
                {
                    b.Navigation("Modules");

                    b.Navigation("Quests");

                    b.Navigation("TokenTransaction");
                });

            modelBuilder.Entity("Domain.Entities.Lecture", b =>
                {
                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Module", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Lectures");

                    b.Navigation("Tests");

                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Quest", b =>
                {
                    b.Navigation("Tasks");

                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Quiz", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("TokenTransactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("TokenTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
