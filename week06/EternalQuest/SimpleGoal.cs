
using System.Globalization;

namespace EternalQuest
{
    class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isComplete = false)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return _points;
            }
            return 0;
        }

        public override bool IsComplete() => _isComplete;

        public override string Serialize()
        {
            return string.Join("|", new[]
            {
                "SimpleGoal",
                _shortName,
                _description,
                _points.ToString(CultureInfo.InvariantCulture),
                _isComplete.ToString()
            });
        }
    }
}
