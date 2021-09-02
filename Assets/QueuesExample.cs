using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueuesExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();
        queue.Enqueue("x");
        queue.Enqueue("y");
        queue.Enqueue("z");
        queue.Enqueue("a");
        queue.Enqueue("b");
        showinformationInQueue(queue);
        queue.Dequeue();
        showinformationInQueue(queue);

    }
    private void showinformationInQueue(Queue queue)
    {
        queueDebug.text = ".............\n";
        foreach (var queueitem in queue)
        {
            queueDebug.text += $"{queueitem}\n";
        }

       
      
    }
}
