using Lepenka;
using Smajda.Components;

namespace Smajda.Systems;

[System(TvorbaKompotov.Stonks)]
[With(typeof(Vek), typeof(Meno))]
public static class Vypis
{
    public static Task Update(ref Vek vek, ref Meno meno)
    {
        Console.WriteLine($"{meno.Krstne} {meno.Priezvisko} uz ma tolko rokov: {vek.Value}");
        
        return Task.CompletedTask;
    }
}