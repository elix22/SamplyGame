using Urho;

//dotnet publish -r win-x64 -c release /p:PublishSingleFile=true /p:PublishTrimmed=true -p:PublishReadyToRun=true
//osx-x64 , 
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

