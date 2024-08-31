using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector; // Playable Director 컴포넌트
    public Button playButton; // UI Button 컴포넌트

    void Start()
    {
        // 버튼 클릭 시 재생 함수 호출
        playButton.onClick.AddListener(PlayTimeline);
    }

    void PlayTimeline()
    {
        // 타임라인 재생
        if (playableDirector != null)
        {
            playableDirector.Play();
        }
    }
}

