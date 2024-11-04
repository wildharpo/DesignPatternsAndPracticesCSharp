namespace DesignPatterns.Library.Patterns.Creational.Prototype.CustomClasses
{
    public class HalfNote : MusicalNote
    {
        public override Graphic Clone()
        {
            return new HalfNote();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
