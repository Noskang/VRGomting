using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator myAnimator;
    public Transform myTR;
    public float walkspeed;
    void Start()
    {
        myTR = GetComponent<Transform>();
        myAnimator.SetInteger("Scene", 7);
    }

    // Update is called once per frame
    void Update()
    {
        myTR.Translate(new Vector3(0, 0, walkspeed));
    }
}
