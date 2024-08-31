using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Animator : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeAnimationEvent(int aniNum)
    {
        myAnimator.SetInteger("Scene", aniNum);
    }
}
