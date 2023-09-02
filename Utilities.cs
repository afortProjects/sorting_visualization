using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Utilities
{
    public struct Range {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public Tuple<int, int> toTuple() {
            return new Tuple<int, int>(Value1, Value2);
        }
    }
    
    public static class RandomizeArrayUtility {
        public static void Randomize(ref List<SortableObject> list, int amountOfEntrances, Tuple<int, int> range) {
            Random random = new Random();
            for(int i=0; i < amountOfEntrances; i++) {
                list.Add(new SortableObject(random.Next(range.Item1, range.Item2)));
            }
        }
    }

    public static class EnumColorUtility {
        public static string GetColor(Enum value) {
            FieldInfo field = value.GetType().GetField(value.ToString());
             ColorAttribute attribute = field.GetCustomAttributes(typeof(ColorAttribute), false)
                                        .SingleOrDefault() as ColorAttribute;
                                         return attribute.Color;

        }
    }
}
