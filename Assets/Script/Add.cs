using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
    private int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        a = a + 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1)
        {
            Debug.Log("aÇÕ1Ç≈Ç∑ÅI");
            a = a + 9;
        }
        else
        {
            Debug.Log("aÇÕ1Ç≈ÇÕÇ†ÇËÇ‹ÇπÇÒÅI");
            a--;
        }
    }
}
