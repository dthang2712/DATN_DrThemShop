using DrThem.Libary.BusinessObject;
using DrThem.Libary.BusinessService.Common;
using DrThem.Libary.Helper;
using log4net.Config;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Directory.GetCurrentDirectory()
});

XmlConfigurator.Configure(new FileInfo("log4netcore.config")); //Configure log4net
log4net.ILog _logger = log4net.LogManager.GetLogger(typeof(Program));

try
{
    #region Config Connection

    CommonCoreUtils.SetFormatSystem();

    var settingsSection = builder.Configuration.GetSection("AppSettings");
    var settings = settingsSection.Get<AppSettings>();

    AppSettings.GetInstance().CopyValue(settings);

    DefaultConnectionFactory.DRThem.ApplicationName = "DRThem";
    DefaultConnectionFactory.DRThem.HostAddress = AppSettings.GetInstance().HostAddress;
    DefaultConnectionFactory.DRThem.DatabaseName = AppSettings.GetInstance().DatabaseName;
    DefaultConnectionFactory.DRThem.EncryptUser = AppSettings.GetInstance().EncryptUser;
    DefaultConnectionFactory.DRThem.EncryptPass = AppSettings.GetInstance().EncryptPass;

    SystemConfigConnection.GetConnection = DefaultConnectionFactory.DRThem.GetConnection;

    #endregion
    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    _logger.Error(ex.Message, ex);
    throw;
}

