using AS_Coursework._Helpers;
using AS_Coursework.View.QuizView;
using Csv;
using System.Text;

namespace AS_Coursework.Model.Quiz;
public class MatchingQuestion : Question {
    public override string QuestionDescription => base.QuestionDescription + " - " + string.Join(", ", _answerPairs.Keys);
    private readonly Dictionary<string, string> _answerPairs;
    public MatchingQuestion(string questionName, Dictionary<string, string> answerPairs) : base(questionName) {
        _answerPairs = answerPairs;
    }

    // Select random key value pairs from the dictionary
    public (List<string> keys, List<string> values) GetAnswerPairs(int count = 4) {
        // Get the key and shuffle them, then select the count required
        List<string> keyOptions = _answerPairs.Keys.ToList();
        keyOptions.Shuffle();
        IEnumerable<string> pickedKeys = keyOptions.Take(count);

        List<string> keys = new();
        List< string > values = new();
        foreach (string key in pickedKeys) {
            keys.Add(key);
            values.Add(_answerPairs[key]);
        }

        return (keys, values);
    }

    // Check an answer pair and allocate experience accordingly
    public bool CheckAnswerPair(string? key, string? value) {
        Correct ??= true;

        if (key is null || value is null) {
            Correct = false;
            return false;
        }
        else if (_answerPairs[key] == value) {
            AllocatedExperience += QuestionDataManager.MatchingExperienceAllocation;
            return true;
        }
        else return false;
    }

    public override Form DisplayQuestion() => new formMatchingQuestion(this);

    public override string ToString() {
        StringBuilder matchingPairs = new();

        foreach (string key in _answerPairs.Keys) {
            matchingPairs.Append(Stringer.Stringify(key));
            matchingPairs.Append(',');
            matchingPairs.Append(Stringer.Stringify(_answerPairs[key]));
            matchingPairs.Append(',');
        }

        matchingPairs.Remove(matchingPairs.Length - 1, 1);

        return base.ToString() + "," + matchingPairs.ToString();
    }
}
