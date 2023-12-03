using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{

    private LineRenderer lineRendere;
    private GameObject Checkpoints;

    public GameObject LocalPlayer;
    public GameObject MiniMapCam;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        lineRendere = GetComponent<LineRenderer>();
        Checkpoints = this.gameObject;

        int num_of_walls = Checkpoints.transform.childCount;
        lineRendere.positionCount = num_of_walls + 1;

        for(int x = 0; x < num_of_walls; x++){
            lineRendere.SetPosition(x,new Vector3(Checkpoints.transform.GetChild(x).transform.position.x,4, Checkpoints.transform.GetChild(x).transform.position.z));
        }

        lineRendere.SetPosition(num_of_walls, lineRendere.GetPosition(0));
        
        lineRendere.startWidth = 7f;
        lineRendere.endWidth = 7f;

    }

    // Update is called once per frame
    void Update()
    {
        MiniMapCam.transform.position = (new Vector3(LocalPlayer.transform.position.x, MiniMapCam.transform.position.y, LocalPlayer.transform.position.z));

        Player.transform.position = (new Vector3(LocalPlayer.transform.position.x, Player.transform.position.y, LocalPlayer.transform.position.z));
    }
}
