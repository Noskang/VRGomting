using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector; // Playable Director ������Ʈ
    public Button playButton; // UI Button ������Ʈ

    void Start()
    {
        // ��ư Ŭ�� �� ��� �Լ� ȣ��
        playButton.onClick.AddListener(PlayTimeline);
    }

    void PlayTimeline()
    {
        // Ÿ�Ӷ��� ���
        if (playableDirector != null)
        {
            playableDirector.Play();
        }
    }
}

