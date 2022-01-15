using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float WaitTime;
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        WaitTime = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(WaitTime);
        Spawns();
        StartCoroutine(Spawn());
    }

    public void Spawns()
    {
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }
}
