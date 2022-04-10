using Lepenka;
using Lepenka.Entity;
using Smajda.Components;

namespace Smajda.Systems;


[StartupSystem]
public static class StartupSystem
{
    public static Task Startup(Commands commands)
    {
        /*
        commands.CreateResource(new GameRules {MaxRounds = 10, MaxPlayers = 4, WinningScore = 4});
        commands.CreateResource(new GameState {CurrentRound = 0, TotalPlayers = 2, WinningPlayer = null});
        
        commands.CreateEntity()
            .With(() => new Player {Name = "Alice"})
            .With(() => new Score {Value = 0})
            .Build();
        
        commands.CreateEntity()
            .With(() => new Player {Name = "Bob"})
            .With(() => new Score {Value = 0})
            .Build();
        
       
        */
        
       commands.CreateEntity()
           .With(() => new Clovek())
           .With(() => new Meno {Krstne = "Peter", Priezvisko = "Grocký"})
           .With(() => new Vek {Value = 21})
           .Build();
       
       commands.CreateEntity()
           .With(() => new Clovek())
           .With(() => new Meno {Krstne = "Tinko", Priezvisko = "Petráš"})
           .With(() => new Vek {Value = 22})
           .Build();
       
       commands.CreateEntity()
           .With(() => new Hrniec())
           .With(() => new TypHrnca {Value = TypHrnca.Typ.Bystrozraky})
           .With(() => new StavHrnca {Value = StavHrnca.Typ.Spinavy})
           .With(() => new Meno {Krstne = "Ján", Priezvisko = "Železity"})
           .With(() => new Vek {Value = 1})
           .Build();
       
       
        return Task.CompletedTask;
    }
}