using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;
using Unity.Android.Types;


public class Operations : MonoBehaviour
{
   public TextMeshProUGUI firstNum, secondNum, operation,true_false;
   public TMP_InputField _InputField;
   private int num1, num2, operations;
   private float result;

   private void Start()
   {
      newQuest();
   }
   
   public void answerControl()
   {
      if (int.Parse(_InputField.text) == result)
      {
         true_false.text = "TRUE";
      }
      else
      {
         true_false.text = "FALSE";
      }
   }

   public void newQuest()
   {
      _InputField.text = " ";
      true_false.text = " ";
      num1 = Random.Range(1, 10);
      num2 = Random.Range(1, 10);
      operations = Random.Range(1, 5);
      
      if(operations == 4 && num1 < num2)
      {
         do
         {
            num1 = Random.Range(1, 10);
            num2 = Random.Range(1, 10);
         } while (num1 < num2);
      }
     
      switch (operations)
      {
         case 1:
            operation.text = "+";
            result = num1 + num2;
            break;
         case 2:
            operation.text = "-";
            result = num1 - num2;
            break;
         case 3:
            operation.text = "x";
            result = num1 * num2;
            break;
         case 4:
            operation.text = "/";
            result = num1 / num2;
            break;
      }

      firstNum.text = num1 + "";
      secondNum.text = num2 + "";
   }
}
