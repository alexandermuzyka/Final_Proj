using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApp.Models.ModelLogick
{
    public class Test
    {
        private ICollection<Question> mRightAnswers = null;

        private readonly int mId;
        public int Id
        {
            get { return mId; }
        }

        private DateTime mBeginDate;
        private DateTime mEndDate;

        public DateTime BeginDate
        {
            get { return mBeginDate; }
            set { mBeginDate = value; }
        }
        public DateTime EndDate
        {
            get { return mEndDate; }
            set { mEndDate = value; }
        }

        private bool mIsPublic;
        public bool IsPublic
        {
            get { return mIsPublic; }
            set { mIsPublic = value; }
        }

        private string mName;
        public string Name
        {
            get { return mTestName; }
            set { mTestName = value; }
        }

        private ICollection<Question> mQuestions;
        public ICollection<Question> Questions
        {
            get { return mQuestions; }
            set { mQuestions = value; }
        }

        public Test() { }
        public Test(int id, string name, List<Question> listOfQuestions)
        {
            mId = id;
            mTestName = name;
            mQuestions = listOfQuestions;
            mRightAnswers = new List<Question>(listOfQuestions);
        }
    }
}