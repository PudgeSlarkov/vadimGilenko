using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _02_Миллионер
{
  public interface IMainFormView
    {
      string TextCurrentQuestion { get; set; }
      string TextButtonAnsw1 { get; set; }
      string TextButtonAnsw2 { get; set; }
      string TextButtonAnsw3 { get; set; }
      string TextButtonAnsw4 { get; set; }
      string ButtonAnswers { get; set; }
      bool SwichDimka { get; set; }
      string TextDimka { get; set; }
      bool SwichCallFriend { get; set; }
      string TextCallFriend { get; set; }
   
     
      string ListBox { get; set; }
      event EventHandler<EventArgs> ClicButtonNewGame;
     
      event EventHandler<EventArgs> ClicButton50on50;
      event EventHandler<EventArgs> ClicButtonCallFriend;
    
      event EventHandler<EventArgs> ClicButtonAnswers;
      event EventHandler<EventArgs> NextQuest;
     
      void ChangeColorButt(Button obj);
      void NotChangeColorButt(Button obj);
      void GameOver(Timer t);
      void Win();

    }
}
