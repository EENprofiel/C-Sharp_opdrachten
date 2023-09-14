namespace C_Sharp_opdrachten.College2;

// Enumerations voor slot en kleur
public enum SlotType {
    GeenSlot,
    Kabelslot,
    Kettingslot
}

public enum Kleur {
    Rood,
    Blauw,
    Groen
}

// Class Bicycle
public class Bicycle {

    // Properties
    public SlotType Slot { get; set; }
    public int FrameHoogte { get; set; }
    public Kleur Kleur { get; set; }

    // Status variabele
    private bool IsGesloten { get; set; }

    // Constructor
    public Bicycle(SlotType slot, int framehoogte, Kleur kleur) {
        this.Slot = slot;
        this.FrameHoogte = framehoogte;
        this.Kleur = kleur;
        this.IsGesloten = false;
    }

    // Methodes
    public void Lock() {
        this.IsGesloten = true;
    }

    public void Unlock() {
        this.IsGesloten = false;
    }

    // ToString() methode
    public override string ToString() {
        return $"Slot: {this.Slot} | Framehoogte: {this.FrameHoogte} | Kleur: {this.Kleur} | IsGesloten: {this.IsGesloten}";
    }
}

public class Program {

    public static void Execute() {

        // Creëer drie Bicycle objecten
        Bicycle racefiets = new Bicycle(SlotType.Kabelslot, 58, Kleur.Rood);
        Bicycle mountainbike = new Bicycle(SlotType.Kettingslot, 48, Kleur.Blauw);
        Bicycle stadsfiets = new Bicycle(SlotType.GeenSlot, 56, Kleur.Groen);

        // Print de drie Bicycle objecten
        Console.WriteLine(racefiets);
        Console.WriteLine(mountainbike);
        Console.WriteLine(stadsfiets);
    }
}
