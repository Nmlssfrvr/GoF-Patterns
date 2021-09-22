namespace GoF_Patterns.Structural_Patterns
{
    public class Creator
    {
        public string Create()
        {
            return "Create";
        }
    }
    
    public class Builder
    {
        public string Build()
        {
            return "Build";
        }
    }

    public class Executor
    {
        public string Execute()
        {
            return "Execute";
        }
    }
    
    public class Facade
    {
        private Creator _creator;
        private Builder _builder;
        private Executor _executor;

        public Facade(Creator creator, Builder builder, Executor executor)
        {
            _creator = creator;
            _builder = builder;
            _executor = executor;
        }

        public string CreateExecute()
        {
            return $"{_creator.Create()} {_executor.Execute()}";
        }

        public string CreateBuildExecute()
        {
            return $"{_creator.Create()} {_builder.Build()} {_executor.Execute()}";
        }
    }
}