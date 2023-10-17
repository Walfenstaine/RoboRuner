using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Muwer.rid.number -= 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Muwer.rid.number += 1;
        }
    }
}
