using UnityEngine;
using System.Collections;
using UnityEngine.UI;



	public class OptionsMenuNew : MonoBehaviour {


		

		public GameObject musicSlider;
		public GameObject sensitivityXSlider;
		public GameObject sensitivityYSlider;
		public GameObject mouseSmoothSlider;

		private float sliderValue = 0.0f;
		private float sliderValueXSensitivity = 0.0f;
		private float sliderValueYSensitivity = 0.0f;
		private float sliderValueSmoothing = 0.0f;
		

		public void  Start (){

		}

		public void  Update (){
			sliderValue = musicSlider.GetComponent<Slider>().value;
			
		}

	

		public void MusicSlider (){
			PlayerPrefs.SetFloat("MusicVolume", sliderValue);
		}
    public void SensitivityXSlider()
    {
        PlayerPrefs.SetFloat("XSensitivity", sliderValueXSensitivity);
    }
		public void  SensitivityYSlider (){
			PlayerPrefs.SetFloat("YSensitivity", sliderValueYSensitivity);
		}
		public void  SensitivitySmoothing (){
			PlayerPrefs.SetFloat("MouseSmoothing", sliderValueSmoothing);
			Debug.Log(PlayerPrefs.GetFloat("MouseSmoothing"));
		}
		}

		
	
