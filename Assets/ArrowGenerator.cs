using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    float span2 = 0.7f;
    float delta2 = 0;
    float span3 = 0.85f;
    float delta3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

        this.delta2 += Time.deltaTime;
        if (this.delta2 > this.span2)
        {
            this.delta2 = 0;
            GameObject go2 = Instantiate(arrowPrefab) as GameObject;
            int px2 = Random.Range(-6, 7);
            go2.transform.position = new Vector3(px2, 7, 0);
        }

        this.delta3 += Time.deltaTime;
        if (this.delta3 > this.span3)
        {
            this.delta3 = 0;
            GameObject go3 = Instantiate(arrowPrefab) as GameObject;
            int px3 = Random.Range(-6, 7);
            go3.transform.position = new Vector3(px3, 7, 0);
        }

    }
}
