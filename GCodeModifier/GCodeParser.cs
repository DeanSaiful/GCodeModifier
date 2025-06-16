using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class GCodeParser
{
    private List<string> lines = new List<string>();
    private AffineTransform transform;

    // ✅ Expose the transformed lines
    public List<string> TransformedLines => lines;

    public GCodeParser(AffineTransform transform)
    {
        this.transform = transform;
    }

    public void Load(string path)
    {
        lines = new List<string>(File.ReadAllLines(path));
    }

    public void ApplyTransformation()
    {
        var regex = new Regex(@"X([-+]?[0-9]*\.?[0-9]+)\s*Y([-+]?[0-9]*\.?[0-9]+)", RegexOptions.IgnoreCase);
        for (int i = 0; i < lines.Count; i++)
        {
            var match = regex.Match(lines[i]);
            if (match.Success)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                var (newX, newY) = transform.Transform(x, y);
                lines[i] = regex.Replace(lines[i], $"X{newX:F4} Y{newY:F4}");
            }
        }
    }

    public void Save(string path)
    {
        File.WriteAllLines(path, lines);
    }
}
