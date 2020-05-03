namespace pattern_composite
{
    public class Shape : Component
    {
        public void Move()
        {
            System.Console.WriteLine("Moving Shape");
        }

        public void Render()
        {
            System.Console.WriteLine("Render Shape");
        }
    }
}