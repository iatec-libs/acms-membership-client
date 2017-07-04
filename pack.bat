set PROJNAME=Iatec.Apis.Acms.Membership.v1.Client
set CONFIGURATION=Release
nuget install src\%PROJNAME%\packages.config -OutputDirectory src\packages
msbuild src\%PROJNAME%\%PROJNAME%.csproj /p:Configuration=%CONFIGURATION%
nuget pack src\%PROJNAME%\%PROJNAME%.csproj -Prop Configuration=%CONFIGURATION%
