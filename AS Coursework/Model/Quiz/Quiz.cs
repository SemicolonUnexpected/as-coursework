namespace AS_Coursework.Model.Quiz; 
internal class Quiz {
    private List<Question> _questions;
    private QuizStyle _quizStyle;
    private const int QUESTION_COUNT = 1;

    public Quiz(QuizStyle quizStyle) {
        _quizStyle = quizStyle;

        PopulateQuiz(quizStyle);
    }

#pragma warning disable
    private void PopulateQuiz(QuizStyle quizStyle) {
        _questions = quizStyle switch {
            QuizStyle.All => GenerateAllQuestions(QUESTION_COUNT),
            QuizStyle.MultipleChoice => GenerateMultipleChoice(QUESTION_COUNT),
            QuizStyle.Text => GenerateText(QUESTION_COUNT),
            QuizStyle.FillTheBlanks => GenerateFillTheBlanks(QUESTION_COUNT),
        };
        
        List<Question> GenerateAllQuestions(int questionCount) {
            throw new NotImplementedException();
        }

        List<Question> GenerateMultipleChoice(int questionCount) {
            throw new NotImplementedException();
        }

        List<Question> GenerateText(int questionCount) {
            throw new NotImplementedException();
        }

        List<Question> GenerateFillTheBlanks(int questionCount) {
            throw new NotImplementedException();
        }
    }
#pragma warning enable

    // The modern variation of the Fisher-Yates Shuffle
    private void ShuffleList<T>(List<T> list) {
        Random random = new();
        T[] array = list.ToArray();

        for (int i = 0; i < array.Length; i++) {
            int j = random.Next(i, array.Length);
            (array[i], array[j]) = (array[j], array[i]);
        }
    }

    public Question NextQuestion() {
        return null;
    }

    public enum QuizStyle {
        All,
        MultipleChoice,
        Text,
        FillTheBlanks
    }
}
