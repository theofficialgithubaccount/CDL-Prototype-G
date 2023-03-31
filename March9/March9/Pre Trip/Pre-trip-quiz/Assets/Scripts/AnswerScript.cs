using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = true;
    public QuizManager quizManager;
   public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Incorrect");
            quizManager.correct();

        }
    }
}
