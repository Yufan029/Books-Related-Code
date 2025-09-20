chapter4 

1. commandline tool
  dotnet 
    - like npm 
    - dotnet list package === npm list
    - dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    - dotnet remove package ...

  dotnet tool
    - install or uninstall the dotnet tool package like dotnet-ef, 
    - dotnet tool install --global dotnet-ef
      - after dotnet-ef tool installed, the commandline can be used like /> dotnet-ef ...
    - dotnet tool list --global

  libman tool
    - client side management tool, install css framework, image, static files, js etc.
    - first install the libman
    - dotnet tool install --global Microsoft.Web.LibraryManager.Cli
      - after this libman dotnet tool installed.
        - /> libman install bootstrap@latest -d wwwroot/lib/bootstrap