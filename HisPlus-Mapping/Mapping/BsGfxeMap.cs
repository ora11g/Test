
namespace HisPlus.Mapping
{
    using FluentNHibernate.Mapping;
    using HisPlus.Domain;
    using NHibernate;

    public class BsGfxeMap : ClassMap<BsGfxeInfo>
    {        
        public BsGfxeMap()
        {
            Table("BsGfxe");

            Id(x => x.Id).Column("ID").GeneratedBy.Identity();
            Map(x => x.Code, "Code");
            Map(x => x.Name, "Name");
            Map(x => x.PyCode, "PyCode");
            Map(x => x.WbCode, "WbCode");
            Map(x => x.OrderBy, "OrderBy");
            Map(x => x.IsActive, "IsActive");
            Map(x => x.IconIndex, "IconIndex");
            Cache.ReadOnly();
            Cache.Region("All");
        }
    }
}
