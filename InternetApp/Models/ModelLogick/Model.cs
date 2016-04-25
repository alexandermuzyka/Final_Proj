using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.ComponentModel.DataAnnotations;

namespace InternetApp.Models.ModelLogick
{
    public class Model
    {
        private Dictionary<string, Test> mTests;
        public Dictionary<string, Test> Tests
        {
            get { return mTests; }
        }



        public Test GetTest(string testName)
        {
            if(!Tests.ContainsKey(testName)) // проверка, содержится ли данный тест в модели
            { 
                // Если не содержится, выигружаем его из базы данных в модель
            }
            return mTests[testName];
        }
        public void AddTest(Test test)
        {
            if(!mTests.ContainsKey(test.TestName))
                mTests.Add(test.TestName, test);
        }

        public Model()
        {
        }
    }
}