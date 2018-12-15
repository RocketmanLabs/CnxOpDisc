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

    // ScaleLists
    [Table("ScaleLists", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public partial class ScaleList : EntityBaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_ScaleList", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; } // Id (Primary key)

        [Column(@"Title", Order = 2, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 100)

        [Column(@"Deleted", Order = 3, TypeName = "bit")]
        [Required]
        [Display(Name = "Deleted")]
        public bool Deleted { get; set; } = false; // Deleted

        // Reverse navigation

        /// <summary>
        /// Child ScaleEntries where [ScaleEntry].[ScaleListId] point to this entity (FK_ScaleEntry_ScaleList)
        /// </summary>
        [JsonIgnore]
        public virtual System.Collections.Generic.ICollection<ScaleEntry> ScaleEntries { get; set; } = new System.Collections.Generic.List<ScaleEntry>(); // ScaleEntry.FK_ScaleEntry_ScaleList
    }

}
// </auto-generated>
