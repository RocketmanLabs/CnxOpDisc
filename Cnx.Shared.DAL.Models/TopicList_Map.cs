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

    // TopicLists
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class TopicList_Map : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TopicList>
    {
        public TopicList_Map()
            : this("dbo")
        {
        }

        public TopicList_Map(string schema)
        {
            Property(x => x.Title).IsUnicode(false);

        }
    }

}
// </auto-generated>
