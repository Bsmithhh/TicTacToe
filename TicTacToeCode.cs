using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class NewBehaviourScript : MonoBehaviour
{
   bool checker;
   int plusone;
   public Text btnText1 = null;
   public Text btnText2 = null;
   public Text btnText3 = null;
   public Text btnText4 = null;
   public Text btnText5 = null;
   public Text btnText6 = null;
   public Text btnText7 = null;
   public Text btnText8 = null;
   public Text btnText9 = null;
   public Text btnResetGame = null;
   public Text btnNewGame = null;
   public Text msgFeedback = null;
   public Text txtPlayerO;
   public Text txtPlayerX;
   public void score (){
   // Check for row wins for Player X
if (btnText1.text == "X" && btnText8.text == "X" && btnText6.text == "X") {
    // Set color to red for winning buttons
    btnText1.color = Color.red;
    btnText8.color = Color.red;
    btnText6.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

if (btnText3.text == "X" && btnText4.text == "X" && btnText2.text == "X") {
    // Set color to red for winning buttons
    btnText3.color = Color.red;
    btnText4.color = Color.red;
    btnText2.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

if (btnText5.text == "X" && btnText9.text == "X" && btnText7.text == "X") {
    // Set color to red for winning buttons
    btnText5.color = Color.red;
    btnText9.color = Color.red;
    btnText7.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

// Check for column wins for Player X
if (btnText1.text == "X" && btnText3.text == "X" && btnText5.text == "X") {
    // Set color to red for winning buttons
    btnText1.color = Color.red;
    btnText3.color = Color.red;
    btnText5.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

if (btnText8.text == "X" && btnText4.text == "X" && btnText9.text == "X") {
    // Set color to red for winning buttons
    btnText8.color = Color.red;
    btnText4.color = Color.red;
    btnText9.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

if (btnText6.text == "X" && btnText2.text == "X" && btnText7.text == "X") {
    // Set color to red for winning buttons
    btnText6.color = Color.red;
    btnText2.color = Color.red;
    btnText7.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

// Check for diagonal wins for Player X
if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X") {
    // Set color to red for winning buttons
    btnText1.color = Color.red;
    btnText4.color = Color.red;
    btnText7.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

if (btnText3.text == "X" && btnText5.text == "X" && btnText6.text == "X") {
    // Set color to red for winning buttons
    btnText3.color = Color.red;
    btnText5.color = Color.red;
    btnText6.color = Color.red;
    msgFeedback.text = "The Winner is Player X";
    int plusone = int.Parse(txtPlayerX.text);
    txtPlayerX.text = Convert.ToString(plusone + 1);
}

// Repeat the above blocks for Player O and change colors accordingly
// Check for row wins for Player O
if (btnText1.text == "O" && btnText8.text == "O" && btnText6.text == "O") {
    // Set color to blue for winning buttons
    btnText1.color = Color.blue;
    btnText8.color = Color.blue;
    btnText6.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

if (btnText3.text == "O" && btnText4.text == "O" && btnText2.text == "O") {
    // Set color to blue for winning buttons
    btnText3.color = Color.blue;
    btnText4.color = Color.blue;
    btnText2.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

if (btnText5.text == "O" && btnText9.text == "O" && btnText7.text == "O") {
    // Set color to blue for winning buttons
    btnText5.color = Color.blue;
    btnText9.color = Color.blue;
    btnText7.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

// Check for column wins for Player O
if (btnText1.text == "O" && btnText3.text == "O" && btnText5.text == "O") {
    // Set color to blue for winning buttons
    btnText1.color = Color.blue;
    btnText3.color = Color.blue;
    btnText5.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

if (btnText8.text == "O" && btnText4.text == "O" && btnText9.text == "O") {
    // Set color to blue for winning buttons
    btnText8.color = Color.blue;
    btnText4.color = Color.blue;
    btnText9.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

if (btnText6.text == "O" && btnText2.text == "O" && btnText7.text == "O") {
    // Set color to blue for winning buttons
    btnText6.color = Color.blue;
    btnText2.color = Color.blue;
    btnText7.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

// Check for diagonal wins for Player O
if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O") {
    // Set color to blue for winning buttons
    btnText1.color = Color.blue;
    btnText4.color = Color.blue;
    btnText7.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}

if (btnText3.text == "O" && btnText5.text == "O" && btnText6.text == "O") {
    // Set color to blue for winning buttons
    btnText3.color = Color.blue;
    btnText5.color = Color.blue;
    btnText6.color = Color.blue;
    msgFeedback.text = "The Winner is Player O";
    int plusone = int.Parse(txtPlayerO.text);
    txtPlayerO.text = Convert.ToString(plusone + 1);
}


   }
    public void btnText1_Click(){
        if (checker == false){
            btnText1.text = "X";
            checker = true;
     }else{
            btnText1. text = "0";
            checker = false;
            score();
        }
    }
            

    public void btnText2_Click(){
        if (checker == false){
            btnText2.text = "X";
            checker = true;
     }else{
            btnText2. text = "0";
            checker = false;
            score();
        }
    }
        
        public void btnText3_Click(){
            if (checker == false){
            btnText3.text = "X";
            checker = true;
     }else{
            btnText3. text = "0";
            checker = false;
            score();
        }
        }
        
        public void btnText4_Click(){
            if (checker == false){
            btnText4.text = "X";
            checker = true;
     }else{
            btnText4. text = "0";
            checker = false;
            score();
        }
        }
        
        public void btnText5_Click(){
            if (checker == false){
            btnText5.text = "X";
            checker = true;
     }else{
            btnText5. text = "0";
            checker = false;
            score();
        }
        }
        
        public void btnText6_Click(){
            if (checker == false){
            btnText6.text = "X";
            checker = true;
     }else{
            btnText6. text = "0";
            checker = false;
            score();
        }
        }
        
        public void btnText7_Click(){
            if (checker == false){
            btnText7.text = "X";
            checker = true;
     }else{
            btnText7. text = "0";
            checker = false;
            score();
        }
        }
        
        public void btnText8_Click(){
            if (checker == false){
            btnText8.text = "X";
            checker = true;
     }else{
            btnText8. text = "0";
            checker = false;
            score();
     }
        }
        
        public void btnText9_Click(){
            if (checker == false){
            btnText9.text = "X";
            checker = true;
     }else{
            btnText9. text = "0";
            checker = false;
            score();
     }
        }
        
    
        


     public void btnResetGame_Click(){
        btnText1.text = "";
        btnText2.text = "";
        btnText3. text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
     }

    public void btnNewGame_Click(){
        btnResetGame_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }


}


