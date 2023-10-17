using UnityEngine;
using System.Collections;

public class Muwer : MonoBehaviour {
    public Animator anim;
	public Transform rob;
	public float speed = 6.0F;
    public LayerMask mask;
    public Vector3[] poses;
    public int number;
	public static Muwer rid {get; set;}

	void Awake(){
		if (rid == null) {
			rid = this;
		} else {
			Destroy (this);
		}
	}
	void OnDestroy(){
		rid = null;
	}

	void Update() {
        if (number == Mathf.Clamp(number, 0, 2))
        {
            transform.position = Vector3.Lerp(transform.position, poses[number], 1.5f * Time.deltaTime);
            var rut = (poses[number] + new Vector3(0, 0, 2)) - transform.position;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(rut), 5.5f * Time.deltaTime);
        }
        else
        {
            if (number > 2)
            {
                number = 2;
            }
            if (number < 0)
            {
                number = 0;
            }
        }
        

        //Collider[] serch = Physics.OverlapSphere(anim.transform.position, 0.3f, mask);
    }
}
