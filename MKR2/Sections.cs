using System.Numerics;

namespace MKR2;

public class Sections : Lines
{
    protected float Angle;
    public Sections(Vector2 FirstCoordinate, Vector2 SecondCoordiante) : base(FirstCoordinate,SecondCoordiante)
    {
        SetAngle();
    }

    private void SetAngle()
    {
        Vector2 Line = SecondCoordinate - FirstCoordinate;
        Angle =  (float)((180 / Math.PI) * Math.Acos(Vector2.Dot(Vector2.Normalize(Line),new Vector2(1,0))));
    }
    public float GetAngle()
    {
        return Angle;
    }
}