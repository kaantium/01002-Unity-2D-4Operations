/*
 * This application was developed by Kaan Iþýk(kaantium) in Unity course. "Score" and "Best Score" features in the application have been developed by kaantium.
 * Course Link:https://www.udemy.com/course/unity-oyun-gelistirme/
 */



using UnityEngine;
using UnityEngine.UI;



public class FourOperations : MonoBehaviour
{
    public Text _firstNumber, _secondNumber, _operation, _answer, _result, _combo, _bestScore; 

    public InputField _answerInput;

    int num1, num2, opr;

    int oprResult;

    int combo = 0, bestScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        New_Question();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Control_Answer()
    {
        //Is the answer correct?
        if (int.Parse(_answer.text)==oprResult)   //YES
        {
            _result.text = "Correct!";
            New_Question();
            combo++;
            _combo.text = combo + "";
        }
        else                                      //NO
        {
            _result.text = "Mistake!";
            if (combo >= bestScore)
            {
                _bestScore.text = combo + "";
            }
            combo = 0;
            _combo.text = combo + "";
        }
    }

    public void New_Question()
    {
        _answer.text = "";
        _answerInput.text = "";
        num2 = Random.Range(1, 10);
        num1 = Random.Range(1, 10);
        opr = Random.Range(1, 5);
        switch (opr)
        {
            case 1:
                _operation.text = "+";
                oprResult = num1 + num2;
                break;
            case 2:
                _operation.text = "-";
                oprResult = num1 - num2;
                break;
            case 3:
                _operation.text = "*";
                oprResult = num1 * num2;
                break;
            case 4:
                _operation.text = "/";
                oprResult = num1 / num2;
                break;
        }
        _firstNumber.text = num1 + "";
        _secondNumber.text = num2 + "";
    }

}
