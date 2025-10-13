
namespace EternalQuest
{
    abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        protected Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string Name => _shortName;
        public string Description => _description;
        public int BasePoints => _points;

        public abstract int RecordEvent();
        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            return $"({_shortName}) {_description}";
        }

        public virtual string GetStringRepresentation()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_shortName} — {_description}";
        }

        public abstract string Serialize();
    }
}
