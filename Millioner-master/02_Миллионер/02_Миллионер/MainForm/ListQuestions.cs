using System;
using System.Collections.Generic;


namespace _02_Миллионер
{
    [Serializable] 
    public class ListQuestions
    {
        Random rng;
        List<OneQuestionAndAnswers> listQA;
        List<OneQuestionAndAnswers> tmp = new List<OneQuestionAndAnswers>();
        ISerializer serialize = new XMLSerializer();

       int index, countTimer = 60;
  
       
        public ListQuestions() 
        {
            listQA = new List<OneQuestionAndAnswers>();
            index = 1;
            rng = new Random();
        }
        public void SetSerializer(ISerializer serialize)
        {
            this.serialize = serialize;
        }
        public string CurQuest 
        {
            get
            { 
                return listQA[index].Question.ToString();
            }
            set
            {
                listQA[index].Question = value;
            }
        }
        public string CurAnsw1
        {
            get
            {
                return listQA[index].Answer1.ToString();
            }
            set
            {
                listQA[index].Answer1 = value;
            }
        }
        public string CurAnsw2 
        {
            get
            {
                return listQA[index].Answer2.ToString();
            }
            set
            {
                listQA[index].Answer2 = value;
            }
        }
        public string CurAnsw3 
        {
            get
            {
                return listQA[index].Answer3.ToString();
            }
            set
            {
                listQA[index].Answer3 = value;
            }
        }
        public string CurAnsw4 
        {
            get
            {
                return listQA[index].Answer4.ToString();
            }
            set
            {
                listQA[index].Answer4 = value;
            }
        }
        public List<OneQuestionAndAnswers> ListQA
        {
            get
            {
                return listQA;
            }
            set
            {
                listQA = value;
            }
        }
        public int CurIndexOfQuest 
        {
            get;
            set;
        }
        public int CountTimer
        {
            get{return countTimer;}
            set{countTimer = value;}
        }
        
        public void AddQuest(OneQuestionAndAnswers q)
        {
           this.listQA.Add(q);
           index++;
        }
        public void DelQuest(int index)
        {
            if (index < 0 || index >= listQA.Count)
                return;
            listQA.Remove(listQA[index]);
            index--;
        }
        public void EditQuest(int index, OneQuestionAndAnswers q)
        {
            if (index < 0 || index >= listQA.Count)
                return;
            listQA.Remove(listQA[index]);
            listQA.Insert(Convert.ToInt32(CurIndexOfQuest), q);
        }
        public void SaveQuestion()
        {
            serialize.Save(listQA);
        }
        public void LoadQuestion()
        {
            listQA = serialize.Load() as List<OneQuestionAndAnswers>;
            foreach (var item in listQA)
            {
                item.CorrectAnswer = item.Answer1;
            }
        }
        public List<OneQuestionAndAnswers> ShuffleQuest(List<OneQuestionAndAnswers> allList)
        {
            List<OneQuestionAndAnswers> copyList = new List<OneQuestionAndAnswers>();
            copyList = allList;
            int n =allList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);

                OneQuestionAndAnswers value = copyList[k];
                copyList[k] = copyList[n];
                copyList[n] = value;
            }  
            return copyList;
        }
        public OneQuestionAndAnswers ShuffleAnswers(OneQuestionAndAnswers oneQuest)
        {

            List<string> copyQuest = new List<string>();
          
            int n = 4;

            copyQuest.Add(oneQuest.Answer1);
            copyQuest.Add(oneQuest.Answer2);
            copyQuest.Add(oneQuest.Answer3);
            copyQuest.Add(oneQuest.Answer4);

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = copyQuest[k];
                copyQuest[k] = copyQuest[n];
                copyQuest[n] = value;
            }
            
            copyQuest.Add(oneQuest.Question);


            return new OneQuestionAndAnswers(copyQuest[4], copyQuest[0],
                copyQuest[1], copyQuest[2], copyQuest[3], oneQuest.Answer1);
        }
    }
}
