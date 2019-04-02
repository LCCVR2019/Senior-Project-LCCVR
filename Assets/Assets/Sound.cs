using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sound : MonoBehaviour
{
	AudioSource audioData;
	// Start is called before the first frame update
	void Start()
	{
		Button play_ = gameObject.GetComponent<Button>();
		Button pause_ = gameObject.GetComponent<Button>();

		audioData = GetComponent<AudioSource>();
		if (play_.onClick.Equals(true))
		{
			audioData.Play();
			Debug.Log("started");
			if (pause_.onClick.Equals(true))
			{
				audioData.Pause();
				Debug.Log("Pause");
			}
			else
			{
				audioData.UnPause();
			}
		}
	}







	// Update is called once per frame
	void Update()
	{

	}
}
