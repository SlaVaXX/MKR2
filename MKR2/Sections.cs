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
        Vector2 Line = FirstCoordinate - SecondCoordinate;
        Angle =  (float)((180 / Math.PI) * Math.Acos(Math.Cos(Vector2.Dot(Line,new Vector2(1,0)))));
    }
    public float GetAngle()
    {
        return Angle;
    }
}