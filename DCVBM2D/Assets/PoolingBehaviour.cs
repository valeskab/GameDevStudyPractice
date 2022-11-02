using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingBehaviour : MonoBehaviour
{
    //this scripts only handles transform
    public List<Transform> poolList;
    public float seconds = 2f;
    private WaitForSeconds wfsObj;
    private int i;
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        while (true)
        {
            yield return wfsObj; //hold until this happens
            poolList[i].position = Vector3.zero;
            poolList[i].gameObject.SetActive(true);
            i++;
            if (i > poolList.Count - 1)
            {
                i = 0;
            }
        }
    }
}
