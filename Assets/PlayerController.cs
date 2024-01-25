using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameDirector director;
    // Start is called before the first frame update
    void Start()
    {
        director = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(director.gameOver == false)
        {
            float move = Input.GetAxis("Horizontal");
            transform.Translate(move *12.0f * Time.deltaTime, 0, 0);
        }
        
    }

    public void LButtonDown()
    {
        if(director.gameOver == false)
        {
            transform.Translate(-1, 0, 0);
        }
        
    }

    public void RButtonDown()
    {
        if (director.gameOver == false)
        {
            transform.Translate(1, 0, 0);
        }
    }
}
