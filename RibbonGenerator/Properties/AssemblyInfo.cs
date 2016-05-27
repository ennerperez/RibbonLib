using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

#if !CONSOLE
[assembly: AssemblyTitle("RibbonGenerator")]
[assembly: AssemblyDescription("Windows Ribbon Generator for WinForms")]
[assembly: AssemblyProduct("RibbonGenerator")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("efa281c1-4e2f-486d-ac0c-ceea2ae85f9d")]
#else

[assembly: AssemblyTitle("RibbonGenerator Console")]
[assembly: AssemblyDescription("Windows Ribbon Generator Console for WinForms")]
[assembly: AssemblyProduct("RibbonGenerator Console")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1ac2aef2-e8b7-4663-a481-fc65bf4e618b")]
#endif

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
[assembly: AssemblyVersion("1.1.0.*")]
[assembly: AssemblyFileVersion("1.1.0.0")]