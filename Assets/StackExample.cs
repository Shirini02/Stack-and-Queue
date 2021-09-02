using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    // Start is called before the first frame update
    void Start()
    {
        Stack stack = new Stack();
        //Prep our data
        int firstPlayerScore = 12;
        int secondplayerscore = 10;
        int thirdplayerscore = 100;
        //push a new player score in to the stack
        stack.Push(firstPlayerScore);
        stack.Push(secondplayerscore);
        stack.Push(thirdplayerscore);

        //show information in stack
        showinformationInstack(stack);
        //pop player score from stack
        stack.Pop();
        showinformationInstack(stack);
        stack.Pop();
        showinformationInstack(stack);
        stack.Pop();
        showinformationInstack(stack);
    }
    void showinformationInstack(Stack stack)
    {
        stackDebug.text += "......................\n";
        foreach(var stackitem in stack)
        {
            Debug.Log(stack.Count);
           //stackDebug.text += "\n";
            stackDebug.text += $"{stackitem}\n";
            //stackDebug.text = "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
