// <auto-generated />
using System;
using APIGSF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIGSF.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221005205051_Entities_FullAuditedEntity")]
    partial class Entities_FullAuditedEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("APIGSF.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("APIGSF.Entities.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PostsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("APIGSF.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NotificationString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("APIGSF.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("APIGSF.Entities.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CreatorUserId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DeleterUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LastModifierUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Liked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Saved")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("AppUserAppUser", b =>
                {
                    b.Property<int>("FollowersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FollowingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowersId", "FollowingId");

                    b.HasIndex("FollowingId");

                    b.ToTable("AppUserAppUser");
                });

            modelBuilder.Entity("APIGSF.Entities.Comments", b =>
                {
                    b.HasOne("APIGSF.Entities.Posts", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("APIGSF.Entities.Notification", b =>
                {
                    b.HasOne("APIGSF.Entities.AppUser", null)
                        .WithMany("Notifications")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("APIGSF.Entities.Photo", b =>
                {
                    b.HasOne("APIGSF.Entities.AppUser", null)
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId");
                });

            modelBuilder.Entity("APIGSF.Entities.Posts", b =>
                {
                    b.HasOne("APIGSF.Entities.AppUser", "AppUser")
                        .WithMany("Posts")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AppUserAppUser", b =>
                {
                    b.HasOne("APIGSF.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("FollowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIGSF.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("APIGSF.Entities.AppUser", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Photos");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("APIGSF.Entities.Posts", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
