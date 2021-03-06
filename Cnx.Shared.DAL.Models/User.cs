// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cnx.Shared.DAL.Models
{
    using Newtonsoft.Json;

    // Users
    [Table("Users", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class User : EntityBaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Users", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Column(@"UserXId", Order = 2, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "User xi d")]
        public System.Guid UserXId { get; set; } = System.Guid.NewGuid(); // UserXId

        [Column(@"LastName", Order = 3, TypeName = "varchar")]
        [Index(@"IX_Users", 1, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 50)

        [Column(@"FirstName", Order = 4, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 50)

        [Column(@"Email", Order = 5, TypeName = "varchar")]
        [Index(@"IX_Users_1", 1, IsUnique = false, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // Email (length: 100)

        [Column(@"Username", Order = 6, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; } // Username (length: 50)

        [Column(@"HashedPassword", Order = 7, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Hashed password")]
        public string HashedPassword { get; set; } // HashedPassword (length: 50)

        [Column(@"IsFacilitator", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Is facilitator")]
        public bool IsFacilitator { get; set; } = false; // IsFacilitator

        [Column(@"DoNotInvite", Order = 9, TypeName = "bit")]
        [Required]
        [Display(Name = "Do not invite")]
        public bool DoNotInvite { get; set; } = false; // DoNotInvite

        [Column(@"Deleted", Order = 10, TypeName = "bit")]
        [Required]
        [Display(Name = "Deleted")]
        public bool Deleted { get; set; } = false; // Deleted

        // Reverse navigation

        /// <summary>
        /// Child Members where [Members].[UserId] point to this entity (FK_Members_Users)
        /// </summary>
        [JsonIgnore]
        public virtual System.Collections.Generic.ICollection<Member> Members { get; set; } = new System.Collections.Generic.List<Member>(); // Members.FK_Members_Users
        /// <summary>
        /// Child Participants where [Participants].[UserId] point to this entity (FK_Participants_Users)
        /// </summary>
        [JsonIgnore]
        public virtual System.Collections.Generic.ICollection<Participant> Participants { get; set; } = new System.Collections.Generic.List<Participant>(); // Participants.FK_Participants_Users
    }

}
// </auto-generated>
