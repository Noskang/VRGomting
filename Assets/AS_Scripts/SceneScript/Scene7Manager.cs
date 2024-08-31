using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7Manager : MonoBehaviour
{
    public SC_Animator animator;
    public float walkspeed;
    public Transform characterTransform;
    public Transform triggerTransform;
    public GameObject educationVideo;
    private Vector3 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        characterTransform = animator.gameObject.GetComponent<Transform>();
        animator.ChangeAnimationEvent(7);
        moveVector = new Vector3(0, 0, walkspeed);
    }

    // Update is called once per frame
    void Update()
    {

        if(characterTransform.gameObject.activeSelf == true)
        {
            characterTransform.Translate(moveVector);
        }

        if(characterTransform.position.z > triggerTransform.position.z)
        {
            characterTransform.gameObject.SetActive(false);

            if(educationVideo.activeSelf == false)
            {
                educationVideo.SetActive(true);
            }
        }
    }

    
}
