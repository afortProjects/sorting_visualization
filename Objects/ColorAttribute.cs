using System;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class ColorAttribute : Attribute {
    public string Color {get; }

    public ColorAttribute(string color) {
        Color = color;
    }
}