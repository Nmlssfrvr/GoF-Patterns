namespace GoF_Patterns.Behaviour_Patterns
{
    public abstract class PhoneState
    {
        public abstract void TurnOn(Phone phone);
        public abstract void TurnOff(Phone phone);
    }
    
    public class PhonePowerOn : PhoneState
    {
        public override void TurnOn(Phone phone)
        {
            phone.State = new PhonePowerOn();
        }

        public override void TurnOff(Phone phone)
        {
            phone.State = new PhonePowerOff();
        }
    }
    
    public class PhonePowerOff : PhoneState
    {
        public override void TurnOn(Phone phone)
        {
            phone.State = new PhonePowerOn();
        }

        public override void TurnOff(Phone phone)
        {
            phone.State = new PhonePowerOff();
        }
    }

    public class Phone
    {
        public PhoneState State { get; set; }

        public Phone(PhoneState state)
        {
            State = state;
        }

        public void TurnOff()
        {
            State.TurnOff(this);
        }
        
    }
}