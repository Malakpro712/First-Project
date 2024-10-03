using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//библиотеки

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public int doubleSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * doubleSpeed);
    }
}
