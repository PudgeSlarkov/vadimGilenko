using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
namespace _02_Миллионер
{
    public partial class Form1 : Form, IMainFormView
    {
       
        int n = 14;
        public Form1()
        {
            InitializeComponent();

            SwichDimka = false;
            TextDimka = "";
            SwichCallFriend = false;
            TextCallFriend = "";
            
            labelTheEnd.Visible = false;

        }

        #region IMainFormView Implementation (реализация интерфейса IMainFormView)
       public string TextCurrentQuestion 
        { 
            get {return labelQuestion.Text;}
            set { labelQuestion.Text = value; }
        }
       public string TextButtonAnsw1 
        {
            get{return butAnswer1.Text;}
            set 
            {
                butAnswer1.Text =value;
               butAnswer1.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw2
        {
            get { return butAnswer2.Text; }
            set 
            {
                butAnswer2.Text = value;
                butAnswer2.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw3
        {
            get { return butAnswer3.Text; }
            set 
            {
                butAnswer3.Text = value;
                butAnswer3.BackColor = Color.Black;
            }
        }
       public string TextButtonAnsw4 
        {
            get { return butAnswer4.Text; }
            set 
            {
                butAnswer4.Text = value;
                butAnswer4.BackColor = Color.Black;
            }
        }
       public string ButtonAnswers 
       {
           get;
           set;
       }
       public void ChangeColorButt(Button obj)
       {
          obj.BackColor = Color.Lime;
       }
       public void NotChangeColorButt(Button obj)
       {
           obj.BackColor = Color.Red;
       }
       public bool SwichDimka
        { 
           get{return pictureBox2.Visible;}
           set { pictureBox2.Visible = value; }
       }
       public string TextDimka
        {
           get { return label7.Text; }
           set { label7.Text = value; }
       }
       public bool SwichCallFriend 
       {
           get { return pictureBox1.Visible; }
           set { pictureBox1.Visible = value; }
       }
       public string TextCallFriend 
       {
           get { return label1.Text; }
           set { label1.Text = value; }
       }
      
     
       public string ListBox 
       {
           get { return labelTheEnd.Text; }
           set { labelTheEnd.Text = value; }
       }
       
        public event EventHandler<EventArgs> ClicButtonNewGame;
        public event EventHandler<EventArgs> ClicButton50on50;
        public event EventHandler<EventArgs> ClicButtonCallFriend;
       public event EventHandler<EventArgs> ClicButtonAnswers;
       public event EventHandler<EventArgs> NextQuest;
       public void GameOver(Timer t)
       {
         
           butAnswer1.Visible = false;
           butAnswer2.Visible = false;
           butAnswer3.Visible = false;
           butAnswer4.Visible = false;
           labelQuestion.Visible = false;
           labelTheEnd.Visible = true;
           labelTheEnd.Text = "Вы проиграли! Игра окончена!";
         
           listBox1.SetSelected(n, false);

          
       }
       public void Win()
       {
        
           butAnswer1.Visible = false;
           butAnswer2.Visible = false;
           butAnswer3.Visible = false;
           butAnswer4.Visible = false;
           labelQuestion.Visible = false;
           labelTheEnd.Visible = true;
     
           int index = listBox1.SelectedIndex;
           if (index >= 0)
           {
               string str = (string)listBox1.Items[n];
               int del = str.IndexOf('.');
               if (del > 0)
                   str = str.Remove(0, del + 1);
               labelTheEnd.Text = "Поздравляю,вы счастливый обладатель " + str + " рублей!!!";
           }
           else return;

       }
     
        #endregion
     
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void butNewGame_Click(object sender, EventArgs e)
        {
        
            butt50on50.Enabled = true;
            butt50on50.Visible = true;
            buttCallFriend.Visible = true;
            buttCallFriend.Enabled = true;
           
            butAnswer1.Visible = true;
            butAnswer2.Visible = true;
            butAnswer3.Visible = true;
            butAnswer4.Visible = true;
            labelQuestion.Visible = true;

            labelTheEnd.Visible = false;
            n = 14;
            listBox1.SetSelected(n, true);
          
            if (ClicButtonNewGame != null) 
                {
                    ClicButtonNewGame(this, EventArgs.Empty);
                }
        }
       
 

      
      
        private void butAnswer1_Click_1(object sender, EventArgs e)
        {
            try
            {
            
            if (n < 0)
                return;
                Button obj = (Button)sender;
                ButtonAnswers = obj.Text;
                if ( ClicButtonAnswers!= null) 
                
                {
                    ClicButtonAnswers(sender, EventArgs.Empty);
                }
                if (NextQuest != null) 
                {
                    listBox1.SetSelected(n, true); 
                    n--;
                        NextQuest(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butt50on50_Click(object sender, EventArgs e)
        {
            try
            {

                butt50on50.Visible = false;
          

                butt50on50.Enabled = false;
                if (ClicButton50on50 != null) 
                {
                    ClicButton50on50(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttCallFriend_Click(object sender, EventArgs e)
        {
            try
            {

                buttCallFriend.Visible = false;
          
               buttCallFriend.Enabled = false;

                if (ClicButtonCallFriend != null) 
                {
                    ClicButtonCallFriend(sender, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelTheEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
