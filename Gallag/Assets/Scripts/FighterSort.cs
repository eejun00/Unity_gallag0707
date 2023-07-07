using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSort : MonoBehaviour
{
    public GameObject fighterPrefab;
    public List<Vector3> fighterList = new List<Vector3>()
    {
        new Vector3(-28f, 1.2f, 70f),
        new Vector3(-14f, 1.2f, 70f),
        new Vector3(14f, 1.2f, 70f),
        new Vector3(28f, 1.2f, 70f),
        new Vector3(-28f, 1.2f, 50f),
        new Vector3(-14f, 1.2f, 50f),
        new Vector3(14f, 1.2f, 50f),
        new Vector3(28f, 1.2f, 50f)
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
