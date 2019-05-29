using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject Player;
    private Vector3 PosINI;

    // Start is called before the first frame update
    void Start()
    {
        PosINI=this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Player.transform.position + PosINI;
    }
}
