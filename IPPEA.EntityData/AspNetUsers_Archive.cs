//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPPEA.EntityData
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUsers_Archive
    {
        public int ArchiveID { get; set; }
        public string ArchiveType { get; set; }
        public string ArchiveReason { get; set; }
        public int ArchiveUserID { get; set; }
        public System.DateTimeOffset ArchiveDt { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public System.DateTime CreateDateUtc { get; set; }
        public Nullable<System.DateTime> MigrateDateUtc { get; set; }
        public Nullable<System.DateTime> LastLoginDateUtc { get; set; }
        public Nullable<System.DateTime> LastLogoutDateUtc { get; set; }
        public Nullable<System.DateTime> LastLoginAccessFailedDateUtc { get; set; }
        public Nullable<System.DateTime> LastEmailChangeDateUtc { get; set; }
        public Nullable<System.DateTime> LastForgotPasswordRequestDateUtc { get; set; }
        public Nullable<System.DateTime> LastPasswordChangeDateUtc { get; set; }
        public bool RequiresEmailConfirmation { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.DateTime> EmailConfirmedDateUtc { get; set; }
        public Nullable<System.DateTime> LastActivityUtc { get; set; }
        public Nullable<System.DateTimeOffset> PasswordResetRequiredDateUtc { get; set; }
    
        public virtual IPPEA_DATA_Employees IPPEA_DATA_Employees { get; set; }
    }
}
