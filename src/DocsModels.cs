public class Documentation {
    public FunctionDoc[] functions { get; set; }
}
public class FunctionDoc {
    public string name { get; set; }
    public int argCount { get; set; }
    public ArgumentDoc[] arguments { get; set; }
    public string description { get; set; }
    public bool outdated { get; set; }
}
public class ArgumentDoc {
    public string name { get; set; }
    public string description { get; set; }
    public bool optional { get; set; }
}