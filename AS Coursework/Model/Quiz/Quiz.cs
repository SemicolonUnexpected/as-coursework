﻿using AS_Coursework._Helpers;

namespace AS_Coursework.Model.Quiz;
public class Quiz {
    private readonly List<Question> _questions;
    private int _index = 0;

    public Quiz(QuizStyle quizStyle) {
        _questions = PopulateQuiz(quizStyle, QuestionDataManager.QuestionCount);
    }

    public int AmountCorrect => _questions.Count(x => x.Correct is true);
    public int AmountAnswered => _questions.Count(x => x.Correct is not null);
    public int TotalExperienceAllocation => _questions.Sum(x => x.AllocatedExperience);

    public bool NextQuestion(out Form? questionForm) {
        if (_index < _questions.Count) {
            questionForm = _questions[_index].DisplayQuestion();
            _index++;
            return true;
        }
        else {
            questionForm = null;
            return false;
        }
    }

    public void Reset() {
        foreach (Question question in _questions) {
            question.AllocatedExperience = 0;
            question.Correct = null;
        }
    }

    private List<Question> PopulateQuiz(QuizStyle quizStyle, int questionCount) => quizStyle switch {
        QuizStyle.All => PickQuestions(QuestionDataManager.All, questionCount),
        QuizStyle.MultipleChoice => PickQuestions(QuestionDataManager.MultipleChoice, questionCount),
        QuizStyle.Text => PickQuestions(QuestionDataManager.Typing, questionCount),
        QuizStyle.Matching => PickQuestions(QuestionDataManager.Matching, questionCount),
        QuizStyle.FlashCard => PickQuestions(QuestionDataManager.Flashcard, questionCount),
        QuizStyle.Equation => PickQuestions(QuestionDataManager.Equation, questionCount),
        _ => throw new NotImplementedException(),
    };

    private List<Question> PickQuestions(List<Question> questionSource, int questionCount) {
        questionSource.Shuffle();
        return questionSource.Take(questionCount).ToList();
    }

    public enum QuizStyle {
        All,
        MultipleChoice,
        Text,
        Matching,
        FlashCard,
        Equation
    }
}
