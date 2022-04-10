using Smajda.Components;
using Lepenka;
using Lepenka.Entity;

namespace Smajda.Systems;

[System(TvorbaKompotov.CistenieHrnca)]
[With(typeof(Vek))]
public static class Starnutie
{
    public static Task Update(ref Vek vek)
    {
        vek.Value++;
        return Task.CompletedTask;
    }
}

