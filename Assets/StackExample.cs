using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    int test = 0;
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        Stack stack = new Stack();
        //Prep our data
        /* int firstPlayerScore = 12;
         int secondplayerscore = 10;
         int thirdplayerscore = 100;
         //push a new player score in to the stack
         stack.Push(firstPlayerScore);
         stack.Push(secondplayerscore);
         stack.Push(thirdplayerscore);*/
        stack.Push(prefabs[0]);
        stack.Push(prefabs[1]);
        stack.Push(prefabs[2]);
        stack.Push(prefabs[3]);


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
        foreach(GameObject stackitem in stack)
        {
            Debug.Log(stack.Count);
           //stackDebug.text += "\n";
            stackDebug.text += $"{stackitem}\n";
            Instantiate(stackitem, transform.position + new Vector3(test, 0, 0), Quaternion.identity);
            test = test + 2;
            print($"{stackitem}\n");
            //stackDebug.text = "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
