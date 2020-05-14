using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class RenderSortTest : MonoBehaviour
{
    public Renderer render1;
    public Renderer render2;

    public int sortingOrder1 = 0;
    public int sortingOrder2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        render1.sortingOrder = sortingOrder1;
        render2.sortingOrder = sortingOrder2;
    }
}
