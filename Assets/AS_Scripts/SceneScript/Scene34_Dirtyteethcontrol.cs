using UnityEngine;

public class TextureBlendController : MonoBehaviour
{
    public Material material; // ���̴��� ����� ��Ƽ����
    public float duration = 2.0f; // ��ȯ �ִϸ��̼��� ���� �ð�
    private float elapsedTime = 0.0f; // ��� �ð�
    private bool isBlending = true; // �ִϸ��̼� ���� ����

    void Update()
    {
        if (material != null && isBlending)
        {
            elapsedTime += Time.deltaTime;

            // Blend �Ķ���� ��� (0���� 1����)
            float t = Mathf.Clamp01(elapsedTime / duration);

            material.SetFloat("_Blend", t);

            // �ִϸ��̼��� �������� Ȯ��
            if (t >= 1.0f)
            {
                isBlending = false; // �ִϸ��̼��� �Ϸ��
            }
        }
    }
}