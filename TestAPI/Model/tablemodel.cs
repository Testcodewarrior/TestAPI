namespace TestAPI.Model
{
    public class tablemodel
    {
        public string Table_Name { get; set; }
        public string Attribute_Name { get; set; }
        public string Attribute_Desc { get; set; }

    }

    public class tablesmodel
    {
        public List<tablemodel> tabsModel { get; set; }
    }
}
