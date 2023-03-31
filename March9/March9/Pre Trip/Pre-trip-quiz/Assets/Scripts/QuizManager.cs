using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<questionAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public string answer;
    public Text questiontxt;

    private void Start()
    {
        generateQuestion();
    }
    public void correct()
    {
        QnA.RemoveAt(currentQuestion);

        generateQuestion();
    }
    void setAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answer[i];

            if (QnA[currentQuestion].correctAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        questiontxt.text = QnA[currentQuestion].question;
        setAnswers();
    }
}
