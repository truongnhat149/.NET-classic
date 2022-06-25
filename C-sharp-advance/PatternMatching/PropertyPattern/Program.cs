private static string Position(Point point)
{
    return point switch
    {
        { X: 0, Y: 0 } => "At the origin",
        { X: _, Y: 0 } => "On the X axis",
        { X: 0, Y: _ } => "On the Y axis",
        { X: var x, Y: var y } => $"({x} {y})",
        _ => "Somewhere"
    };
}