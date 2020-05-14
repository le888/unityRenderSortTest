using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class REnderSortLayer : MonoBehaviour
{
    public Renderer render1;
    public Renderer render2;

    public string sortingLayer1 = "Default";
    public string sortingLayer2 = "Default";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        render1.sortingLayerID = SortingLayer.NameToID(sortingLayer1);
        render2.sortingLayerID = SortingLayer.NameToID(sortingLayer2);
    }
}
