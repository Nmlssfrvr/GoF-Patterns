namespace GoF_Patterns.Structural_Patterns
{
    public interface IHuman
    {
        public string Walk();
    }

    public interface IDriver
    {
        public string Drive();
    }

    public class Student : IHuman
    {
        public string Walk()
        {
            return "Student";
        }
    }
    
    public class TaxiDriver : IDriver
    {
        public string Drive()
        {
            return "Driver";
        }
    }

    public class Adapter : IDriver
    {
        private Student _student;

        public Adapter(Student student)
        {
            _student = student;
        }

        public string Drive()
        {
            return _student.Walk();
        }
    }
}