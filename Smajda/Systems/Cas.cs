using Lepenka;
using Smajda.Components;

namespace Smajda.Systems;

[System(TvorbaKompotov.Stonks)]
public static class Cas
{
    public static Task Update()
    {
        Console.WriteLine("Prebehol rok");
        return Task.Delay(1000);
    }

    
}