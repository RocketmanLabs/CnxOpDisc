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

    // Votes
    [Table("Votes", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class Vote : EntityBaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Votes", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Column(@"InquiryId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Inquiry ID")]
        public int InquiryId { get; set; } // InquiryId

        [Column(@"ParticipantId", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Participant ID")]
        public int ParticipantId { get; set; } // ParticipantId

        [Column(@"AxisId", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Axis ID")]
        public int AxisId { get; set; } // AxisId

        [Column(@"TopicId", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Topic ID")]
        public int TopicId { get; set; } // TopicId

        [Column(@"PointsOrChoiceId", Order = 6, TypeName = "int")]
        [Display(Name = "Points or choice ID")]
        public int? PointsOrChoiceId { get; set; } // PointsOrChoiceId

        // Foreign keys

        /// <summary>
        /// Parent Inquiry pointed by [Votes].([InquiryId]) (FK_Votes_Inquiries)
        /// </summary>
        [JsonIgnore]
        [ForeignKey("InquiryId"), Required] public virtual Inquiry Inquiry { get; set; } // FK_Votes_Inquiries
    }

}
// </auto-generated>
