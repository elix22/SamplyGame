using Urho;

//dotnet publish -r win-x64 -c release /p:PublishSingleFile=true /p:PublishTrimmed=true -p:PublishReadyToRun=true
//dotnet publish -r osx-x64 -c release /p:PublishSingleFile=true /p:PublishTrimmed=true -p:PublishReadyToRun=true

//mcs  /target:exe /out:bin/Game.dll /reference:libs/dotnet/urho/desktop/UrhoDotNet.dll /platform:x64  *.cs Source/*.cs Source/Aircrafts/*.cs Source/Aircrafts/Enemies/*.cs Source/Helpers/*.cs Source/Weapons/*.cs
// mcs  /target:exe /out:bin/Game.dll /reference:libs/dotnet/urho/desktop/UrhoDotNet.dll /platform:x64 Program.cs  -recurse:'Source/*.cs'

namespace SamplyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            new SamplyGame().Run();
        }
    }
}

