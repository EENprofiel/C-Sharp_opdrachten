namespace C_Sharp_opdrachten.College2;

public class Opdracht2
{
    // overgenomen van brightspace
    public class Bicycle
    {
        const int frameHeightUnknown = -1;
        const int rangeUnknown = -1; // Electric range unknown
        const int rangeInfinite = -2; // Standard bike
        const double mileConversion = 0.621371192; // 1 km = mileConversion miles

        public enum Types
        {
            Unknown,
            Standard,
            Electric
        }

        public enum LockTypes
        {
            None,
            Ring,
            Chain,
            Cable,
            DLock
        }

        public enum Colors
        {
            None = -1,
            Red = 0xFF0000,
            Green = 0x00FF00,
            Blue = 0x0000FF
        }

        public Bicycle(Colors color, Types type = Types.Unknown)
            : this(type, color, LockTypes.None, frameHeightUnknown, rangeUnknown)
        {
        }

        public Bicycle(LockTypes lockType, Types type = Types.Unknown)
            : this(type, Colors.None, lockType, frameHeightUnknown, rangeUnknown)
        {
        }

        public Bicycle(int frameHeight, Types type = Types.Unknown)
            : this(type, Colors.None, LockTypes.None, frameHeight, rangeUnknown)
        {
        }

        public Bicycle(Types type, Colors color = Colors.None, LockTypes lockTypes = LockTypes.None,
            int frameHeight = frameHeightUnknown, int range = rangeUnknown)
        {
            Type = type;
            Color = color;
            Locktype = lockTypes;
            FrameHeight = frameHeight;
            Range = (type == Types.Standard ? rangeInfinite : range);
            _isLocked = false;
        }

        private bool _isLocked { get; set; }

        public Types Type { get; set; }
        public Colors Color { get; set; }
        public LockTypes Locktype { get; set; }

        public int FrameHeight { get; set; } // in mm
        public int Range { get; set; } // in km
        public int GetRangeinMiles() => (int)(Range * mileConversion); // Extra getter
        public void SetRangeinMiles(int value) => Range = (int)(value / mileConversion); // Extra setter

        public int
            RangeInMiles // Of met een extra property, verhuld wel eventuele conversies (mogelijk risico voor conversie errors)
        {
            get => (int)(Range * mileConversion);
            set => Range = (int)(value / mileConversion);
        }

        public string Description() =>
            $"Bike with type {Enum.GetName(Type)} with color{Enum.GetName(Color)} with {Enum.GetName(Locktype)} lock with frameHeight {(FrameHeight == frameHeightUnknown ? "unknown" : FrameHeight)} {(Type == Types.Standard ? string.Empty : $"with range of {(Range == rangeUnknown ? "unknown" : Range)} km")}";

        public string DescriptionShort() =>
            $"Bike({Enum.GetName(Type)}, {Enum.GetName(Color)}, {Enum.GetName(Locktype)}, {(FrameHeight == frameHeightUnknown ? "unknown" : FrameHeight)}{(Type == Types.Standard ? string.Empty : $", {(Range == rangeUnknown ? "unknown" : Range)} km")})";

        public string Lock()
        {
            if (Locktype == LockTypes.None)
            {
                return "cannot be locked";
            }

            if (_isLocked)
            {
                return "is already locked";
            }

            _isLocked = true;
            return "has been locked";
        }

        public string Unlock()
        {
            if (Locktype == LockTypes.None)
            {
                return "cannot be unlocked";
            }

            if (!_isLocked)
            {
                return "is already unlocked";
            }

            _isLocked = false;
            return "has been unlocked";
        }
    }

    public static void Execute()
    {
        // Minimaal 3 variabelen van het type Bicycle
        Bicycle a = new Bicycle(Bicycle.Types.Unknown, Bicycle.Colors.Red, Bicycle.LockTypes.Ring);
        Bicycle b = new Bicycle(Bicycle.LockTypes.Cable);
        Bicycle c = new Bicycle(550, Bicycle.Types.Standard);
        Bicycle d = new Bicycle(Bicycle.Types.Electric, Bicycle.Colors.Green, Bicycle.LockTypes.DLock, 450);
        Bicycle e = new Bicycle(Bicycle.Types.Electric, Bicycle.Colors.Blue, Bicycle.LockTypes.None, 470, 50);

        Console.WriteLine(a.Description());
        Console.WriteLine(b.Description());
        Console.WriteLine(c.Description());
        Console.WriteLine(d.Description());
        Console.WriteLine(e.Description());
        Console.WriteLine();

        Console.WriteLine(a.DescriptionShort() + " " + a.Lock());
        Console.WriteLine(b.DescriptionShort() + " " + b.Lock());
        Console.WriteLine(c.DescriptionShort() + " " + c.Lock());
        Console.WriteLine(d.DescriptionShort() + " " + d.Lock());
        Console.WriteLine(e.DescriptionShort() + " " + e.Lock());
        Console.WriteLine();

        Console.WriteLine(a.DescriptionShort() + " " + a.Unlock());
        Console.WriteLine(b.DescriptionShort() + " " + b.Unlock());
        Console.WriteLine(c.DescriptionShort() + " " + c.Unlock());
        Console.WriteLine(d.DescriptionShort() + " " + d.Unlock());
        Console.WriteLine(e.DescriptionShort() + " " + e.Unlock());
        Console.WriteLine();
    }
}


// public class Opdracht2
// {
// // // Enumerations voor slot en kleur
// //     public enum SlotType
// //     {
// //         GeenSlot,
// //         Kabelslot,
// //         Kettingslot
// //     }
// //
// //     public enum Kleur
// //     {
// //         None = -1,
// //         Rood = 0xFF0000,
// //         Blauw = 0x0000FF,
// //         Groen = 0x00FF00
// //     }
// //
// //     public enum FietsType
// //     {
// //         Onbekend,
// //         Standaard,
// //         Elektrisch
// //     }
// //
// // // Class Bicycle
// //     public class Bicycle
// //     {
// //         // Properties
// //         public SlotType Slot { get; set; }
// //         public int FrameHoogte { get; set; }
// //         public Kleur Kleur { get; set; }
// //         public FietsType FietsType { get; set; }
// //
// //
// //         // Status variabele
// //         private bool IsGesloten { get; set; }
// //
// //         // Constructor
// //         public Bicycle(SlotType slot, int framehoogte, Kleur kleur, FietsType FietsType)
// //         {
// //             this.Slot = slot;
// //             this.FrameHoogte = framehoogte;
// //             this.Kleur = kleur;
// //             this.IsGesloten = false;
// //             this.FietsType = FietsType;
// //         }
// //
// //         // Methodes
// //         public void Lock()
// //         {
// //             this.IsGesloten = true;
// //         }
// //
// //         public void Unlock()
// //         {
// //             this.IsGesloten = false;
// //         }
// //
// //         // ToString() methode
// //         public override string ToString()
// //         {
// //             return
// //                 $"Slot: {this.Slot} | Framehoogte: {this.FrameHoogte} | Kleur: {this.Kleur} | IsGesloten: {this.IsGesloten} | Type fiets: {this.FietsType}";
// //         }
// //     }
// //
// //
// //     public static void Execute()
// //     {
// //         // Creëer drie Bicycle objecten
// //         Bicycle racefiets = new Bicycle(SlotType.Kabelslot, 58, Kleur.Rood, FietsType.Standaard);
// //         Bicycle mountainbike = new Bicycle(SlotType.Kettingslot, 48, Kleur.Blauw, FietsType.Standaard);
// //         Bicycle stadsfiets = new Bicycle(SlotType.GeenSlot, 56, Kleur.Groen, FietsType.Elektrisch);
// //
// //         // Print de drie Bicycle objecten
// //         Console.WriteLine(racefiets);
// //         Console.WriteLine(mountainbike);
// //         Console.WriteLine(stadsfiets);
// //     }
// }