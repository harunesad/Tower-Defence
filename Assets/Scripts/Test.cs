using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Tower tower1 = new Tower();
        tower1.name = "a";
        Debug.Log(tower1.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Tower
{
    public string name { get; set; }
}
