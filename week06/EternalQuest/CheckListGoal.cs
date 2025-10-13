
using System.Globalization;

namespace EternalQuest
{
    class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
            : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted;
        }

        public override int RecordEvent()
        {
            _amountCompleted++;
            int earned = _points;
            if (_amountCompleted == _target)
            {
                earned += _bonus;
            }
            return earned;
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetDetailsString()
        {
            return $"({_shortName}) {_description} — Completed {_amountCompleted}/{_target}, Bonus: {_bonus}";
        }

        public override string GetStringRepresentation()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {_shortName} — {_description} (Completed {_amountCompleted}/{_target})";
        }

        public override string Serialize()
        {
            return string.Join("|", new[]
            {
                "ChecklistGoal",
                _shortName,
                _description,
                _points.ToString(CultureInfo.InvariantCulture),
                _amountCompleted.ToString(CultureInfo.InvariantCulture),
                _target.ToString(CultureInfo.InvariantCulture),
                _bonus.ToString(CultureInfo.InvariantCulture)
            });
        }
    }
}
