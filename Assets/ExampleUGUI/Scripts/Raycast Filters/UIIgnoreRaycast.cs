using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/Raycast Filters/Ignore Raycast Filter")]
	public class UIIgnoreRaycast : MonoBehaviour, ICanvasRaycastFilter 
	{
		void Start(){
			this.GetComponent<RectTransform> ().localScale = new Vector3 (0.1f, 0.1f, 0.1f);
			Debug.Log ("ASD");
		}

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}
	}
}
