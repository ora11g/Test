using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Contract.Messages.Mapping
{
    public class BsUserMap : EntityTypeConfiguration<BsUserInfo>
    {
        public BsUserMap()
            : this("dbo")
        {
        }

        public BsUserMap(string schema)
        {
            ToTable("BsUser", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Password).HasColumnName(@"Password").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.Reason).HasColumnName(@"Reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.LsInputWay).HasColumnName(@"LsInputWay").IsRequired().HasColumnType("smallint");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.IsUserInputWb).HasColumnName(@"IsUserInputWB").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputPy).HasColumnName(@"IsUserInputPY").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputCode).HasColumnName(@"IsUserInputCode").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputName).HasColumnName(@"IsUserInputName").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputStrokeCode).HasColumnName(@"IsUserInputStrokeCode").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputEngDesc).HasColumnName(@"IsUserInputEngDesc").IsOptional().HasColumnType("bit");
            Property(x => x.Introduce).HasColumnName(@"Introduce").IsOptional().HasColumnType("nvarchar").HasMaxLength(4000);
            Property(x => x.PicturePath).HasColumnName(@"PicturePath").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Mobile).HasColumnName(@"Mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.LevelId).HasColumnName(@"LevelId").IsOptional().HasColumnType("int");
            Property(x => x.DocLevId).HasColumnName(@"DocLevId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.CareGroupId).HasColumnName(@"CareGroupId").IsOptional().HasColumnType("int");
            Property(x => x.CareGroupId1).HasColumnName(@"CareGroupId1").IsOptional().HasColumnType("int");
            Property(x => x.CertIdNo).HasColumnName(@"CertIdNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.IsUserInputF1).HasColumnName(@"IsUserInputF1").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserInputList).HasColumnName(@"IsUserInputList").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserWordPad).HasColumnName(@"IsUserWordPad").IsOptional().HasColumnType("bit");
            Property(x => x.IsUserSelectOnly).HasColumnName(@"IsUserSelectOnly").IsOptional().HasColumnType("bit");
        }
    }
}
