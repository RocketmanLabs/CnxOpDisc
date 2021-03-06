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
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Result_Map : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Result>
    {
        public Result_Map()
            : this("dbo")
        {
        }

        public Result_Map(string schema)
        {
            Property(x => x.AxisType).IsUnicode(false);
            Property(x => x.Weighted).IsOptional().HasPrecision(6,2);
            Property(x => x.Scaled100).IsOptional().HasPrecision(6,2);
            Property(x => x.Normalized).IsOptional().HasPrecision(6,2);

        }
    }

}
// </auto-generated>
