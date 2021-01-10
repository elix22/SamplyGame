using Urho;

//dotnet publish -r win-x64 -c release /p:PublishSingleFile=true /p:PublishTrimmed=true -p:PublishReadyToRun=true
//dotnet publish -r osx-x64 -c release /p:PublishSingleFile=true /p:PublishTrimmed=true -p:PublishReadyToRun=true

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

