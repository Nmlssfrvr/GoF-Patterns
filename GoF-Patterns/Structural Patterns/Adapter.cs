namespace GoF_Patterns.Structural_Patterns
{
    public interface IHuman
    {
        public void Walk();
    }

    public interface IDriver
    {
        public void Drive();
    }

    public class Student : IHuman
    {
        public void Walk()
        {
        }
    }
    
    public class TaxiDriver : IDriver
    {
        public void Drive()
        {
        }
    }

    public class Wrapper : IDriver
    {
        private Student _student;

        public Wrapper(Student student)
        {
            _student = student;
        }

        public void Drive()
        {
            _student.Walk();
        }
    }
}