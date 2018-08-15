** Getting IIS running Locally **

Under Control Panel -> Programs and Features -> Turn Windows Features On or Off, make sure that IIS and Windows Process Activation Service are activated.
Under Control Panel -> Programs and Features -> Turn Windows Features On or Off, expand Internet Information Services IIS -> World Wide Web Service -> Application Development Features, select ASP.NET 4.7 (or proper version).

Run Visual Studio as Administrator
In Visual Studio, in project properties, set Properties.Web to Local IIS
I Visual Studio, in project properties, Create Virtual Directory
In C:\Windows\System32\drivers\etc, Add line to hosts file for url spoof
in IIS, add the IIS_IUSRS user to the site via Edit Permissions
Add DbUser to SSMS as a Login with Password
In the SSMS Server Properties -> Security, make sure that authentication is set to Windows and SQL Server Authentication

