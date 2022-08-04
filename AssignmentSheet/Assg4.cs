//This is the refactored code to avoid violation of SRP

public abstract class Requirement
{
    public virtual void Spin() { }
    public virtual void Slide() { }
    public virtual void Hop() { }

}
public class Spinner: Requirement
{
    bool clockwise; // need for spinner

    bool expand; // need for spinner
    public override void Spin() { }
}

public class Slider: Requirement
{
    bool vertical; // need for slider

    int distance; // need for slider
    public override void Slide() { }
}

public class Hopper: Requirement
{
    bool visible; // need for hopper

    int xcoord, ycoord; // need for hopper
    public override void Hop() { }
}

class Icon

{

    float speed, glow, energy;

    int x, y;

    Requirement subtype; // spinner, slider or hopper

    // constructor must set subtype: client must pass value

    public Icon(Requirement value)

    {

        subtype = value; // use enum for readability

        // and then use conditional to set associated fields

    }

    public void Move()

    {

        if (subtype is Spinner spinner) { spinner.Spin(); }

        else if (subtype is Slider slider)

        {

            slider.Slide();

        }

        else

        {

            subtype.Hop();

        }

    }

}
