using UnityEngine;

public struct Operations
{
    public Vector2 input { get; set; }

    public static Operations operator +(Operations value1, Operations value2)
    {
        return new Operations { input = value1.input + value2.input };
    }

    public static Operations operator -(Operations value1, Operations value2)
    {
        return new Operations { input = value1.input - value2.input };
    }

    public static Operations operator *(Operations value1, Operations value2)
    {
        return new Operations { input = value1.input * value2.input };
    }

    public static Operations operator /(Operations value1, Operations value2)
    {
        return new Operations { input = value1.input / value2.input };
    }
}

public class Operators : MonoBehaviour
{
    static Operations solve1 = new Operations { input = new Vector2(5, 0) };
    static Operations solve2 = new Operations { input = new Vector2(7, 4) };
    static Operations solve3 = new Operations { input = new Vector2(-1, -6) };

    Operations sum = solve1 + solve3;

    Operations minus = solve2 - solve3;

    Operations multi = solve1 * solve2;

    Operations divide = solve3 / solve2;
}
