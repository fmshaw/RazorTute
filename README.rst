.NET Core SDK - Razor Tute
==========================
Purpose
-------

Follow a .NET Core tutorial to add some .NET content to my portfolio on GitHub.

https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages-vsc/razor-pages-start?view=aspnetcore-2.1

Download 
--------
Googled for the dotnet core SDK. Followed link to Linux binaries.

https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.1.302-linux-x64-binaries

Downloaded on 2018-08-13::

    generic@framer:~$ sha256sum Downloads/dotnet-sdk-2.1.302-linux-x64.tar.gz 
    2acaed79dfb54afd583a6316be63c4e497bad401e96477e4182a35960c4e1fa9  Downloads/dotnet-sdk-2.1.302-linux-x64.tar.gz

Install
-------
Prerequisites::

    generic@framer:~$ mkdir -p $HOME/dotnet && tar zxf ~/Download/dotnet-sdk-2.1.302-linux-x64.tar.gz -C $HOME/dotnet
    generic@framer:~$ export DOTNET_ROOT=$PATH:$HOME/dotnet 
    generic@framer:~$ export PATH=$PATH:$HOME/dotnet

Create project
--------------
Create a Razor web app::

    generic@framer:~/src/framer/RazorTute$ dotnet new webapp -o RazorTute
    generic@framer:~/src/framer/RazorTute$ cd RazorPagesTute
    generic@framer:~/src/framer/RazorTute$ dotnet run

Version control
---------------
Add obj/Debug to the .gitignore file

Add project to repository::

    generic@framer:~/src/framer/RazorTute$ git init .
    generic@framer:~/src/framer/RazorTute$ git add *
    generic@framer:~/src/framer/RazorTute$ git commit

Missing dependency
------------------
EntityFrameworkCore is needed::

    generic@framer:~/src/framer/RazorTute$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
