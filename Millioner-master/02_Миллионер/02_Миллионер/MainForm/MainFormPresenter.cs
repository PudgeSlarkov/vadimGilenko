using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Миллионер
{
   public class MainFormPresenter
    {
        private readonly ListQuestions AllList = new ListQuestions();
        private readonly IMainFormView _textMainForm;
        List<OneQuestionAndAnswers> q;
        ListQuestions tmp = new ListQuestions();
       public int i = 0;
      // public int countTimer = 0;

        List<string> correctAnsw = new List<string>();

        public MainFormPresenter(IMainFormView textMainForm)
        {
           
            ISerializer serializer = new XMLSerializer();
            AllList.SetSerializer(serializer);
            AllList.LoadQuestion();
          
            _textMainForm = textMainForm;
            _textMainForm.ClicButtonNewGame += new EventHandler<EventArgs>(LoadOneQuestionInLabel);
            _textMainForm.ClicButtonAnswers += new EventHandler<EventArgs>(CheckAnswerAndNext);
            _textMainForm.NextQuest += new EventHandler<EventArgs>(NextQuestion);
            _textMainForm.ClicButton50on50 += EventClicButton50on50;
            _textMainForm.ClicButtonCallFriend += EventClicButtonCallFriend;
        
        }

       
        void EventClicButtonCallFriend(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            _textMainForm.SwichCallFriend = true;
            _textMainForm.TextCallFriend = "Я думаю, правильный ответ...\nЭто ";
            
            Timer answ = new Timer();
            answ.Interval = 3000;
            answ.Enabled = true;
            answ.Tick += answTick;
            answ.Start();
        }
        void answTick(object sender, EventArgs e)
        {
            Timer tAnsw = (Timer)sender;
            tAnsw.Stop();
            _textMainForm.TextCallFriend +=" " + q[i].CorrectAnswer;
            
        }

        void EventClicButton50on50(object sender, EventArgs e)
        {
            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw1.Substring(3))
            {
                _textMainForm.TextButtonAnsw2 = "";
                _textMainForm.TextButtonAnsw3 = "";
            }
            if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw2.Substring(3))
            {
                _textMainForm.TextButtonAnsw1 = "";
                _textMainForm.TextButtonAnsw4 = "";
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw3.Substring(3))
            {
                _textMainForm.TextButtonAnsw1 = "";
                _textMainForm.TextButtonAnsw2 = "";
            } if (q[i].CorrectAnswer == _textMainForm.TextButtonAnsw4.Substring(3))
            {
                _textMainForm.TextButtonAnsw3 = "";
                _textMainForm.TextButtonAnsw2 = "";
            }
        }

        void CheckAnswerAndNext(object sender, EventArgs e)
        {
            Button obj = sender as Button;
         
            if (i == 14)
            {
                _textMainForm.Win();
                return;
            }
            if (obj.Text.Substring(3) == q[i].CorrectAnswer)
            {
                _textMainForm.SwichDimka = true;
               
                _textMainForm.TextDimka = "Правильно!!!";
                _textMainForm.ChangeColorButt(obj);
                    i++;
            }
            else 
            {
                _textMainForm.NotChangeColorButt(obj);
                _textMainForm.SwichDimka = true;
                _textMainForm.TextDimka = "Не правильно!";
                Timer t = new Timer();
                t.Interval = 1000;
                t.Enabled = true;
                t.Tick += new EventHandler(t_Tick);
                t.Start();
            }
        }
       private void NextQuestion(object sender, EventArgs e)
         {
             Timer tPause = new Timer();
             tPause.Interval = 1000;
             tPause.Enabled = true;
             tPause.Tick += tPause_Tick;
             tPause.Start();
         }
         void tPause_Tick(object sender, EventArgs e)
         {
             Timer tPause = (Timer)sender;
             tPause.Stop();
             UpdateView();
         }
         void t_Tick(object sender, EventArgs e)
         {
            
             Timer t = (Timer)sender;
             t.Stop();
             _textMainForm.GameOver(t);
                
         }
        private void LoadOneQuestionInLabel(object sender, EventArgs e)
        {
            AllList.LoadQuestion();
          q = new List<OneQuestionAndAnswers>();
     
            tmp.ListQA = tmp.ShuffleQuest(AllList.ListQA);
           
           i = 0;
            while (i < tmp.ListQA.Count)
            {
        
                 q.Add(tmp.ShuffleAnswers(tmp.ListQA[i]));
                  tmp.CurIndexOfQuest++;
                  i++;
            }
            i = 0;
           UpdateView(); 

        }

        private void UpdateView()
        {
            _textMainForm.SwichDimka = false;
            _textMainForm.TextDimka = "";
            _textMainForm.TextCurrentQuestion = q[i].Question;
            _textMainForm.TextButtonAnsw1 = "A: " + q[i].Answer1;
            _textMainForm.TextButtonAnsw2 = "B: " + q[i].Answer2;
            _textMainForm.TextButtonAnsw3 = "C: " + q[i].Answer3;
            _textMainForm.TextButtonAnsw4 = "D: " + q[i].Answer4;

            _textMainForm.SwichCallFriend = false;
            _textMainForm.TextCallFriend = "";

            
        }
    }
}
