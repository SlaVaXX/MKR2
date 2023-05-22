using System.Numerics;

namespace MKR2;

public class Lines
{
    protected Vector2 FirstCoordinate;
    protected Vector2 SecondCoordinate;

    public Lines(Vector2 FirstCoordinate, Vector2 SecondCoordinate)
    {
        this.FirstCoordinate = FirstCoordinate;
        this.SecondCoordinate = SecondCoordinate;
    }
    public float GetLineLength()
    {
        return (FirstCoordinate - SecondCoordinate).Length();
    }
}