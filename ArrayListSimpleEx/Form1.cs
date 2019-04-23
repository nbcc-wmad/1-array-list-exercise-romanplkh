using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{

   
    public partial class Form1 : Form
    {

    ArrayList sentenceArr = new ArrayList();
   

        public Form1()
        {
            InitializeComponent();
        }

    private void BtnShowMsg_Click( object sender, EventArgs e )
    {
      string textToDisplay = "";

      //foreach (string word in sentence )
      //{
      //  textToDisplay += $"{word} " ;
      //}


      lblMessage.Text = textToDisplay;
    }

    private void Form1_Load( object sender, EventArgs e )
    {

      string sentence =  "I love programming so much";

      string[] myStentence = sentence.Split(' ');
 
      foreach(string word in myStentence)
      {
        sentenceArr.Add(word);
      }
   
    }
  }
}
