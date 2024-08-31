using UnityEngine;

public class TextureBlendController : MonoBehaviour
{
    public Material material; // 쉐이더가 적용된 머티리얼
    public float duration = 2.0f; // 전환 애니메이션의 지속 시간
    private float elapsedTime = 0.0f; // 경과 시간
    private bool isBlending = true; // 애니메이션 진행 여부

    void Update()
    {
        if (material != null && isBlending)
        {
            elapsedTime += Time.deltaTime;

            // Blend 파라미터 계산 (0에서 1까지)
            float t = Mathf.Clamp01(elapsedTime / duration);

            material.SetFloat("_Blend", t);

            // 애니메이션이 끝났는지 확인
            if (t >= 1.0f)
            {
                isBlending = false; // 애니메이션이 완료됨
            }
        }
    }
}