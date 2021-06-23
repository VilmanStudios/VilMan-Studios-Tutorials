using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject Coin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter()
    {
        int wait_time = Random.Range(3, 3);
        yield return new WaitForSeconds (wait_time);
        print ("I waited for" + wait_time + "sec");
        Coin.SetActive(true);
    }
}
