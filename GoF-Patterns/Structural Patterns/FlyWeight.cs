using System.Collections.Generic;
using System.Linq;

namespace GoF_Patterns.Structural_Patterns
{
    public class Phone
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Phone(
            string company = "default",
            string model = "default", 
            string color = "default")
        {
            Company = company;
            Model = model;
            Color = color;
        }

        #nullable enable
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Phone second))
            {
                return false;
            }

            return this.Company == second.Company &&
                   this.Model == second.Model &&
                   this.Color == second.Color;
        }
    }

    public class FlyWeight
    {
        private Phone _internalState;

        public FlyWeight(Phone phone)
        {
            _internalState = phone;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is FlyWeight second))
            {
                return false;
            }

            return _internalState.Equals(second._internalState);
        }
    }

    public class FlyWeightFactory
    {
        private Dictionary<string, FlyWeight> flyweights = new Dictionary<string, FlyWeight>();

        public FlyWeightFactory(params Phone[] phones)
        {
            foreach (var phone in phones)
            {
                flyweights.Add(GetKey(phone), new FlyWeight(phone));
            }
        }

        private string GetKey(Phone phone)
        {
            var props = phone
                .GetType()
                .GetProperties()
                .Select(p => p.GetValue(phone))
                .Where(x => x != null)
                .ToList();
            props.Sort();
            return string.Join(",", props);
        }

        public FlyWeight GetFlyweight(Phone internalState)
        {
            string key = this.GetKey(internalState);
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new FlyWeight(internalState));
            }
            return flyweights[key];
        }

        public bool Contains(Phone internalState)
        {
            return flyweights.ContainsValue(new FlyWeight(internalState));
        }
    }
}