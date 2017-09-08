
namespace HisPlus.Contract.Messages.Mapping
{
    using FluentNHibernate.Mapping;
    using HisPlus.Domain;

    public class BsLocationMap : ClassMap<BsLocationInfo>
    {
        public BsLocationMap()
        {
            Table("BsLocation");

            Map(x => x.Id, "ID");
            Map(x => x.Code, "Code");
            Map(x => x.Name, "Name");
            Map(x => x.HospitalId, "HospitalId");
            Map(x => x.LsInOut, "LsInOut");
            Map(x => x.IsForwomen, "IsForwomen");
            Map(x => x.PhoneCode).HasColumnName(@"PhoneCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Map(x => x.MedicineRatio).HasColumnName(@"MedicineRatio").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Map(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Map(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Map(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Map(x => x.SpecialityId, "SpecialityId");
            Map(x => x.BedSum).HasColumnName(@"BedSum").IsOptional().HasColumnType("smallint");
            Map(x => x.BaSysCode).HasColumnName(@"BaSysCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Map(x => x.Director).HasColumnName(@"Director").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Map(x => x.DeptTypeId).HasColumnName(@"DeptTypeId").IsOptional().HasColumnType("int");
            Map(x => x.IsCostApp).HasColumnName(@"IsCostApp").IsOptional().HasColumnType("bit");
            Map(x => x.AppLevel).HasColumnName(@"AppLevel").IsOptional().HasColumnType("int");
            Map(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Map(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Map(x => x.Area).HasColumnName(@"Area").IsOptional().HasColumnType("int");
            Map(x => x.OuRoomId).HasColumnName(@"OuRoomId").IsOptional().HasColumnType("int");
            Map(x => x.InRoomId).HasColumnName(@"InRoomId").IsOptional().HasColumnType("int");
            Map(x => x.IsPriceSub, "IsPriceSub");
            Map(x => x.IsClinical, "IsClinical");
            Map(x => x.IsChinLocation, "IsChinLocation");
            Map(x => x.IsRegLocation, "IsRegLocation");
            Map(x => x.IsAllLocation, "IsAllLocation");
        }
    }
}
