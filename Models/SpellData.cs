namespace felpf2e.Models.Spells;
public class SpellData
{
    public string _id { get; set; }
    public string img { get; set; }
    public string name { get; set; }
    public System system { get; set; }
    public string type { get; set; }
}

public class System
{
    //public Ability ability { get; set; }
    public Area area { get; set; }
    public Category category { get; set; }
    public Components components { get; set; }
    //public Cost cost { get; set; }
    public Damage damage { get; set; }
    public Description description { get; set; }
    public Duration duration { get; set; }
    public HasCounteractCheck hasCounteractCheck { get; set; }
    public Heightening heightening { get; set; }
    public Level level { get; set; }
    public Materials materials { get; set; }
    public Prepared prepared { get; set; }
    public Primarycheck primarycheck { get; set; }
    public Range range { get; set; }
    public object[] rules { get; set; }
    public Save save { get; set; }
    public School school { get; set; }
    public Secondarycasters secondarycasters { get; set; }
    public Secondarycheck secondarycheck { get; set; }
    public Source source { get; set; }
    public SpellType spellType { get; set; }
    public Sustained sustained { get; set; }
    public Target target { get; set; }
    public Time time { get; set; }
    public Traditions traditions { get; set; }
    public Traits traits { get; set; }
}

public class Ability
{
    public string value { get; set; }
}

public class RootObject
{
    public Area area { get; set; }
}

public class Area
{
    public string details { get; set; }
    public string type { get; set; }
    public int value { get; set; }
}

public class Category
{
    public string value { get; set; }
}

public class Components
{
    public bool focus { get; set; }
    public bool material { get; set; }
    public bool somatic { get; set; }
    public bool verbal { get; set; }
}

public class Cost
{
    public string value { get; set; }
}

// this is wrong but value is very weird TODO 

public class Type
{
    public object[] categories { get; set; }
    public string subtype { get; set; }
    public string value { get; set; }
}

public class Damage
{
    public Dictionary<string, DamageValue> DamageValue { get; set; }
}

public class DamageValue
{
    public bool applyMod { get; set; }
    public Type type { get; set; }
    public string value { get; set; }
}


public class Description
{
    public string value { get; set; }
}

public class Duration
{
    public string value { get; set; }
}

public class HasCounteractCheck
{
    public bool value { get; set; }
}

public class Heightening
{
    public Dictionary<string,string> damage { get; set; }
    public int interval { get; set; }
    public string type { get; set; }
}

public class Level
{
    public int value { get; set; }
}

public class Materials
{
    public string value { get; set; }
}

public class Prepared
{
    public string value { get; set; }
}

public class Primarycheck
{
    public string value { get; set; }
}

public class Range
{
    public string value { get; set; }
}

public class Save
{
    public string basic { get; set; }
    public string value { get; set; }
}

public class School
{
    public string value { get; set; }
}

public class Secondarycasters
{
    public string value { get; set; }
}

public class Secondarycheck
{
    public string value { get; set; }
}

public class Source
{
    public string value { get; set; }
}

public class SpellType
{
    public string value { get; set; }
}

public class Sustained
{
    public bool value { get; set; }
}

public class Target
{
    public string value { get; set; }
}

public class Time
{
    public string value { get; set; }
}

public class Traditions
{
    public string[] value { get; set; }
}

public class Traits
{
    public string rarity { get; set; }
    public string[] value { get; set; }
}

