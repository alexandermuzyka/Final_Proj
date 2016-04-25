using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetApp.Models.ModelLogick
{
    public struct Answer
    {
        private bool mIsRight;
        private string mText;

        public bool IsRight
        {
            get { return mIsRight; }
            set { mIsRight = value; }
        }
        public string Text
        {
            get { return mText; }
            set { mText = value; }
        }  
    }
}