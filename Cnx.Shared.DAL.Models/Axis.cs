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

    // Axes
    [Table("Axes", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class Axis : EntityBaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_Axis", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Column(@"AxisListId", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Axis list ID")]
        public int AxisListId { get; set; } // AxisListId

        [Column(@"Title", Order = 3, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 50)

        [Column(@"EvaluationAxis", Order = 4, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Evaluation axis")]
        public byte EvaluationAxis { get; set; } // EvaluationAxis

        [Column(@"VoteMethod", Order = 5, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Vote method")]
        public byte VoteMethod { get; set; } // VoteMethod

        [Column(@"Question", Order = 6, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Question")]
        public string Question { get; set; } // Question (length: 100)

        [Column(@"VotingScaleId", Order = 7, TypeName = "int")]
        [Required]
        [Display(Name = "Voting scale ID")]
        public int VotingScaleId { get; set; } // VotingScaleId

        [Column(@"Label", Order = 8, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Label")]
        public string Label { get; set; } // Label (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent AxisList pointed by [Axes].([AxisListId]) (FK_Axis_AxisList)
        /// </summary>
        [JsonIgnore]
        [ForeignKey("AxisListId"), Required] public virtual AxisList AxisList { get; set; } // FK_Axis_AxisList
    }

}
// </auto-generated>
