using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueuesExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
    int test = 0;
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();
        /* queue.Enqueue("x");
         queue.Enqueue("y");
         queue.Enqueue("z");
         queue.Enqueue("a");
         queue.Enqueue("b");*/
        queue.Enqueue(prefabs[0]);
        queue.Enqueue(prefabs[1]);
        queue.Enqueue(prefabs[2]);
        queue.Enqueue(prefabs[3]);
        showinformationInQueue(queue);
        queue.Dequeue();
        showinformationInQueue(queue);
        queue.Dequeue();
        showinformationInQueue(queue);



    }
    private void showinformationInQueue(Queue queue)
    {
        queueDebug.text = ".............\n";
        foreach (GameObject queueitem in queue)
        {
            queueDebug.text += $"{queueitem}\n";
            Instantiate(queueitem, transform.position + new Vector3(test, 0, 0), Quaternion.identity);
            test = test + 2;
            print($"{queueitem}\n");
        }

       
      
    }
}
