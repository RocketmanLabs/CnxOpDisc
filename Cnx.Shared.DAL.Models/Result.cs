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

    // Results
    [Table("Results", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class Result : EntityBaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Results", 1, IsUnique = true, IsClustered = true)]
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

        ///<summary>
        /// X, Weights, Z, Effort, Opportunity, Worth, Value
        ///</summary>
        [Column(@"AxisType", Order = 4, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Axis type")]
        public string AxisType { get; set; } // AxisType (length: 12)

        [Column(@"AxisId", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Axis ID")]
        public int AxisId { get; set; } // AxisId

        [Column(@"TopicId", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Topic ID")]
        public int TopicId { get; set; } // TopicId

        [Column(@"Raw", Order = 7, TypeName = "int")]
        [Required]
        [Display(Name = "Raw")]
        public int Raw { get; set; } // Raw

        [Column(@"Weighted", Order = 8, TypeName = "decimal")]
        [Display(Name = "Weighted")]
        public decimal? Weighted { get; set; } // Weighted

        [Column(@"Scaled100", Order = 9, TypeName = "decimal")]
        [Display(Name = "Scaled 100")]
        public decimal? Scaled100 { get; set; } // Scaled100

        [Column(@"Normalized", Order = 10, TypeName = "decimal")]
        [Display(Name = "Normalized")]
        public decimal? Normalized { get; set; } // Normalized

        // Foreign keys

        /// <summary>
        /// Parent Inquiry pointed by [Results].([InquiryId]) (FK_Results_Inquiries)
        /// </summary>
        [JsonIgnore]
        [ForeignKey("InquiryId"), Required] public virtual Inquiry Inquiry { get; set; } // FK_Results_Inquiries
    }

}
// </auto-generated>
