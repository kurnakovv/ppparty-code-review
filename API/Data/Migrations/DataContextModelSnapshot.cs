﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InstagramLink")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LinkedInLink")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<double>("Rating")
                        .HasColumnType("double precision");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("ShowEmail")
                        .HasColumnType("boolean");

                    b.Property<string>("TwitterLink")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("WebsiteLink")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUserFriend", b =>
                {
                    b.Property<int>("AddingToFriendsUserId")
                        .HasColumnType("integer");

                    b.Property<int>("AddedToFriendsUserId")
                        .HasColumnType("integer");

                    b.HasKey("AddingToFriendsUserId", "AddedToFriendsUserId");

                    b.HasIndex("AddedToFriendsUserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.Property<string>("ConnectionId")
                        .HasColumnType("text");

                    b.Property<string>("GroupName")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ConnectionId");

                    b.HasIndex("GroupName");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("API.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EventOwnerId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EventOwnerId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("API.Entities.EventDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventDate");
                });

            modelBuilder.Entity("API.Entities.EventNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NotificationMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Read")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EventNotifications");
                });

            modelBuilder.Entity("API.Entities.EventPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("integer");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("EventPhotos");
                });

            modelBuilder.Entity("API.Entities.EventTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EventTagName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.ToTable("EventTags");
                });

            modelBuilder.Entity("API.Entities.Group", b =>
                {
                    b.Property<string>("GroupName")
                        .HasColumnType("text");

                    b.HasKey("GroupName");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("API.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("RecipientId")
                        .HasColumnType("integer");

                    b.Property<string>("RecipientUsername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("SenderUsername")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("API.Entities.UserInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("InterestName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("Id");

                    b.ToTable("UserInterests");
                });

            modelBuilder.Entity("API.Entities.UserPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("AppUserEvent", b =>
                {
                    b.Property<int>("ParticipantsId")
                        .HasColumnType("integer");

                    b.Property<int>("ParticipateInEventsId")
                        .HasColumnType("integer");

                    b.HasKey("ParticipantsId", "ParticipateInEventsId");

                    b.HasIndex("ParticipateInEventsId");

                    b.ToTable("AppUserEvent");
                });

            modelBuilder.Entity("AppUserEvent1", b =>
                {
                    b.Property<int>("InvitedToEventId")
                        .HasColumnType("integer");

                    b.Property<int>("InvitedToEventsId")
                        .HasColumnType("integer");

                    b.HasKey("InvitedToEventId", "InvitedToEventsId");

                    b.HasIndex("InvitedToEventsId");

                    b.ToTable("AppUserEvent1");
                });

            modelBuilder.Entity("AppUserEventNotification", b =>
                {
                    b.Property<int>("EventNotificationsId")
                        .HasColumnType("integer");

                    b.Property<int>("RecipientsId")
                        .HasColumnType("integer");

                    b.HasKey("EventNotificationsId", "RecipientsId");

                    b.HasIndex("RecipientsId");

                    b.ToTable("AppUserEventNotification");
                });

            modelBuilder.Entity("AppUserUserInterest", b =>
                {
                    b.Property<int>("AppUsersId")
                        .HasColumnType("integer");

                    b.Property<int>("UserInterestsId")
                        .HasColumnType("integer");

                    b.HasKey("AppUsersId", "UserInterestsId");

                    b.HasIndex("UserInterestsId");

                    b.ToTable("AppUserUserInterest");
                });

            modelBuilder.Entity("EventEventTag", b =>
                {
                    b.Property<int>("EventTagsId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsId")
                        .HasColumnType("integer");

                    b.HasKey("EventTagsId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("EventEventTag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUserFriend", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AddedToFriendsUser")
                        .WithMany("AddedToFriendsByUsers")
                        .HasForeignKey("AddedToFriendsUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "AddingToFriendsUser")
                        .WithMany("AddedToFriendsUsers")
                        .HasForeignKey("AddingToFriendsUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddedToFriendsUser");

                    b.Navigation("AddingToFriendsUser");
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.HasOne("API.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Entities.Connection", b =>
                {
                    b.HasOne("API.Entities.Group", null)
                        .WithMany("Connections")
                        .HasForeignKey("GroupName");
                });

            modelBuilder.Entity("API.Entities.Event", b =>
                {
                    b.HasOne("API.Entities.AppUser", "EventOwner")
                        .WithMany("OwnedEvents")
                        .HasForeignKey("EventOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventOwner");
                });

            modelBuilder.Entity("API.Entities.EventDate", b =>
                {
                    b.HasOne("API.Entities.Event", "Event")
                        .WithMany("EventDates")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("API.Entities.EventPhoto", b =>
                {
                    b.HasOne("API.Entities.Event", "Event")
                        .WithOne("EventPhoto")
                        .HasForeignKey("API.Entities.EventPhoto", "EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("API.Entities.Message", b =>
                {
                    b.HasOne("API.Entities.AppUser", "Recipient")
                        .WithMany("MessagesRecieved")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("API.Entities.UserPhoto", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithOne("UserPhoto")
                        .HasForeignKey("API.Entities.UserPhoto", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("AppUserEvent", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("ParticipantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("ParticipateInEventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserEvent1", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("InvitedToEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("InvitedToEventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserEventNotification", b =>
                {
                    b.HasOne("API.Entities.EventNotification", null)
                        .WithMany()
                        .HasForeignKey("EventNotificationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("RecipientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserUserInterest", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("AppUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.UserInterest", null)
                        .WithMany()
                        .HasForeignKey("UserInterestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventEventTag", b =>
                {
                    b.HasOne("API.Entities.EventTag", null)
                        .WithMany()
                        .HasForeignKey("EventTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("AddedToFriendsByUsers");

                    b.Navigation("AddedToFriendsUsers");

                    b.Navigation("MessagesRecieved");

                    b.Navigation("MessagesSent");

                    b.Navigation("OwnedEvents");

                    b.Navigation("UserPhoto")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.Entities.Event", b =>
                {
                    b.Navigation("EventDates");

                    b.Navigation("EventPhoto")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.Group", b =>
                {
                    b.Navigation("Connections");
                });
#pragma warning restore 612, 618
        }
    }
}
