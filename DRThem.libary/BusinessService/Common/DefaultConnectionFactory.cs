namespace DrThem.Libary.BusinessService.Common
{
    public static class DefaultConnectionFactory
    {
        public static SqlConnectionFactory DRThem
        {
            get
            {
                return SqlConnectionFactory.GetInstance("DRThem");
            }
        }
    }
}
