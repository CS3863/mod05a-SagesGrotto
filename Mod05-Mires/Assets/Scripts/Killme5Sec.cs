using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Killme5Sec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Kill", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Kill()
    {
        Destroy(gameObject);
    }
}
