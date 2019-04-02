using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Output : MonoBehaviour
{
    public static Output Instance;

    public List<TextMesh> m_Outputs;

    private void Awake()
    {
        Instance = this;

        foreach (TextMesh output in m_Outputs)
            output.gameObject.SetActive(false);
    }

    public void SetCorrect()
    {
        StopAllCoroutines();
        StartCoroutine(Show("✓", Color.green));
    }

    public void SetWrong()
    {
        StopAllCoroutines();
        StartCoroutine(Show("X", Color.red));
    }

    private IEnumerator Show(string text, Color color)
    {
        foreach (TextMesh output in m_Outputs)
        {
            output.text = text;
            output.color = color;

            output.gameObject.SetActive(true);
        }

        yield return new WaitForSeconds(3.0f);

        foreach (TextMesh output in m_Outputs)
            output.gameObject.SetActive(false);
    }
}
