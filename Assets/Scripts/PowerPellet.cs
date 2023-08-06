
public class PowerPellet : Pellet
{
    protected override void Eat()
    {
        FindObjectOfType<GameManager>().EatTablet(this);
    }
}
