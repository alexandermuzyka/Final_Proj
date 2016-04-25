using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc.Html;


namespace InternetApp.Models.ModelLogick
{
    public abstract class Question
    {
        protected string mText;
        public string Text
        {
            get { return mQuestionText; }
            set { mQuestionText = value; }
        }

        protected ICollection<Answer> mAnswers;
        public ICollection<Answer> Answers
        {
            get { return mAnswers; }
        }

        public Question()
        {
            mAnswers = new List<Answer>();
        }

        public abstract bool CheckIsQuestionRight(Question question);
        public abstract void AddAnswer(Answer answer);
        public abstract string GetControlWay();
    }

        public class OpenQuestion : Question
    {
        public OpenQuestion()
        {
            mAnswers.Add(new Answer());
        }

        public override bool CheckIsQuestionRight(Question question)
        {
            return true;
        }
        public override void AddAnswer(Answer answer)
        {
            mAnswers[0] = answer;
        }
        public override string GetControlWay()
        {
            return "_OpenQuestionAnswer";
        }
    }
        public abstract class ClosedQuestion : Question
        {
            public ClosedQuestion()
            {

            }

            public override bool CheckIsQuestionRight(Question question)
            {
                for (int i = 0; i < question.Answers.Count; ++i)
                    if (Answers[i].IsRight != question.Answers[i].IsRight)
                        return false;
                return true;
            }
            public override void AddAnswer(Answer answer)
            {
                if(!mAnswers.Contains(answer))
                    mAnswers.Add(answer);
            }
        }

            public class SingleClosedQuestion : ClosedQuestion
            {
                public override string GetControlWay()
                {
                    return "_SingleClosedQuestionAnswers";
                }
            }
            public class MultyClosedQuestion : ClosedQuestion
            {
                public override string GetControlWay()
                {
                    return "_MultyClosedQuestionAnswers";
                }
            }
}