
#tool "dotnet:?package=grate&version=1.7.3"
#addin nuget:?package=Cake.grate&version=1.7.3

///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("Deploy-Database")
.Does(() => 
{
   Grate(new GrateSettings()
   {
      ConnectionString = "Server=(local);Integrated Security=true;Database=grate_demo;TrustServerCertificate=true;",
      Silent = true,
      Version = "0.3.0",
      SqlFilesDirectory = "./sqlfiles",
   });
});

Task("Default")
   .Does(() => 
{
   Information("Hello Cake");
});

RunTarget(target);
