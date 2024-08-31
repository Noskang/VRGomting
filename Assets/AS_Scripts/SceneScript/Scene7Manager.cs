using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Scene7Manager : MonoBehaviour
{
    public SC_Animator animator;
    public float walkspeed;
    public Transform characterTransform;
    public Transform triggerTransform;
    public GameObject educationVideo;
    public VideoPlayer video;
    private Vector3 moveVector;
    private bool canwalk;

    // 딜레이용 변수
    public float activatedelay;
    public float videoplaydelay;

    // Start is called before the first frame update
    void Start()
    {
        characterTransform = animator.gameObject.GetComponent<Transform>();
        animator.ChangeAnimationEvent(7);
        video = educationVideo.GetComponent<VideoPlayer>();
        moveVector = new Vector3(0, 0, walkspeed);
        canwalk = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(characterTransform.gameObject.activeSelf == true && canwalk == true)
        {
            characterTransform.Translate(moveVector);
        }

        if(characterTransform.position.z > triggerTransform.position.z)
        {
            animator.ChangeAnimationEvent(1);
            canwalk = false;


            if (educationVideo.activeSelf == false)
            {

                StartCoroutine(activateVideo(videoplaydelay));
            }
        }
    }

    public IEnumerator activateVideo(float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        educationVideo.SetActive(true);
        video.Pause();

        StartCoroutine(palyVideo(videoplaydelay));
    }


    public IEnumerator palyVideo(float delaytime)
    {
        yield return new WaitForSeconds(delaytime);
        video.Play();
    }

}
