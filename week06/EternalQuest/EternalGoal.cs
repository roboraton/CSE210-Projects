
using System.Globalization;

namespace EternalQuest
{
    class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public override int RecordEvent()
        {
            return _points;
        }

        public override bool IsComplete() => false;

        public override string Serialize()
        {
            return string.Join("|", new[]
            {
                "EternalGoal",
                _shortName,
                _description,
                _points.ToString(CultureInfo.InvariantCulture)
            });
        }
    }
}
