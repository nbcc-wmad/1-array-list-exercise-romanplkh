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

  public partial class Form1: Form
  {

    private ArrayList sentenceArr = new ArrayList();


    public Form1( )
    {
      InitializeComponent();
    }
    

     //DISPLAY MESSAGE 
    private string showMessage(ArrayList myArrList )
    {

      //create var for string to output
      string textToDisplay = "";

      //Build sentence from arraylist
      foreach ( string word in myArrList )
      {
        textToDisplay += $"{word} ";
      }

      //Return string to display
      return textToDisplay;
    }


    //ADD WORDS TO ARRAY_LIST
    private void Form1_Load( object sender, EventArgs e )
    {

      //Split string into array
      string [ ] myStentence = "I love programming so much".Split( ' ' );

      //Loop through sentence and add each word to arrayList
      foreach ( string word in myStentence )
      {
        sentenceArr.Add( word );
      }

    }

    // SHOW NORMAL MESSAGE
    private void BtnShowMsg_Click( object sender, EventArgs e ) => lblMessage.Text = showMessage(sentenceArr);


    //SHOW REVERSE MESSAGE
    private void BtnReverse_Click( object sender, EventArgs e )
    {
      //Reverse arrayList
      sentenceArr.Reverse();
      //Show message
      lblMessage.Text = showMessage( sentenceArr );
      //Put arrayList in normal form
      sentenceArr.Reverse();
    }

    //Add word at second position
    private void BtnAdd_Click( object sender, EventArgs e ) => sentenceArr.Insert( 1, txtSecondPos.Text );
    //Remove word at second position
    private void Button1_Click( object sender, EventArgs e ) => sentenceArr.RemoveAt( 1 );
   
  }
}
