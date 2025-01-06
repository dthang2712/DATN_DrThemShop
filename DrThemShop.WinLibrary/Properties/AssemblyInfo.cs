using log4net.Config;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DrThemShop.WinLibrary")]
[assembly: AssemblyDescription("Thư viện DrThemShop.WinLibrary")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("FastManager")]
[assembly: AssemblyProduct("DrThemShop.WinLibrary")]
[assembly: AssemblyCopyright("Copyright ©  2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("cbe53d43-17f4-46e9-9e77-22c95b466610")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2023.05.30.1")]
[assembly: AssemblyFileVersion("2023.05.30.1")]
[assembly: XmlConfigurator(ConfigFile = @"Config\DrThemShopAdmin.log4net.config", Watch = true)]