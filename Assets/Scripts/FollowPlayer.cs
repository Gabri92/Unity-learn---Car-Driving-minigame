using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Variables
    public GameObject Player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //Per evitare stuttering - Vedere effetto usando 'update'
    {
        // offset the camera behind the player by adding to the player's position
        //transform.position = Player.transform.position + new Vector3(0, 5, -7); /OLD
        transform.position = Player.transform.position + offset;
    }
}
