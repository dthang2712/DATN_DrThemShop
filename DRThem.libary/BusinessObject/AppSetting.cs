namespace DrThem.Libary.BusinessObject
{
    public class AppSettings : BaseSingleton<AppSettings>
    {
        public string Secret { get; set; }
        public string HostAddress { get; set; }
        public string DatabaseName { get; set; }
        public string EncryptUser { get; set; }
        public string EncryptPass { get; set; }
        public bool UseAdAccount { get; set; }
        public string ProxyHost { get; set; }
        public int ProxyPort { get; set; }


        public void CopyValue(AppSettings original)
        {
            this.Secret = original.Secret;
            this.HostAddress = original.HostAddress;
            this.DatabaseName = original.DatabaseName;
            this.EncryptUser = original.EncryptUser;
            this.EncryptPass = original.EncryptPass;
            this.UseAdAccount = original.UseAdAccount;
            this.ProxyHost = original.ProxyHost;
            this.ProxyPort = original.ProxyPort;
        }
    }
}
