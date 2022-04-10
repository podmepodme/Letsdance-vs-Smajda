using System.Drawing;
using Lepenka;
using Lepenka.Component;

namespace Smajda.Components;



[Stage]
internal enum TvorbaKompotov {
    ZberanieOvocia,
    TriedenieOvocia, //od hnileho
    CistenieOvocia,
    KrajanieOvocia,
    CistenieHrnca,
    PrazenieOvocia,
    PripravaNalevu,
    VarenieKompotu,
    CistenieSkleniciek,
    NalievanieKomptu,
    ZatvorenieKompotu,
    PredajKompotu,
    Stonks
}

[Component]
public struct Clovek: IComponent {}

[Component]
public struct Hrniec : IComponent
{
    public List<Ovocie> OvocieVHrnci { get; init; }
}

[Component]
public struct TypHrnca : IComponent
{
    public enum Typ
    {
        Hlboky,
        Plytky,
        Panvica,
        Bystrozraky
    }
    
    public Typ Value { get; set; }
}

[Component]
public struct StavHrnca : IComponent
{
    public enum Typ
    {
        Cisty,
        Spinavy,
        Hrdzavy,
        Dieravy
    }
    
    public Typ Value { get; set; }
}

[Component]
public struct Meno : IComponent
{
    public string Krstne { get; init; }
    public string Priezvisko { get; set; }
}

[Component]
public struct Vek : IComponent
{
    public int Value { get; set; }
}

[Component]
public struct HmotnostnyLimit : IComponent
{
    public uint Value { get; init; }
}

[Component]
public struct Taska : IComponent
{
    public HmotnostnyLimit Limit { get; init; }
    public List<object> ObsahTasky { get; init; }
}



// ------------------- toto sa nepouziva
[Component]
public struct Ovocie : IComponent
{
    public string Meno { get; init; }
    public Color Farba { get; set; }
    public int Gramaz { get; set; }
}

[Component]
public struct Strom : IComponent
{
    public enum TypStromu
    {
        Breza,
        Dub,
        Skoricvnik,
        Jablon,
        Hruskovik,
        Cintronovnik,
        Jahodovnik,
        Cucoriedkovnik,
        Marhula
    }
    
    public string Meno { get; init; }
    public TypStromu Druh { get; init; }
    public List<Ovocie> OvociaNaStrome { get; init; }
}




