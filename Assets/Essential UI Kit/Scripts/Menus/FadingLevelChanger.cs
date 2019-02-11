using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using MA.EaseNTween;

namespace MA{
	public class FadingLevelChanger : MonoBehaviour, ILevelChangeRequest{
		public EasingTypes easing;
		public float animationLength = 0.7f;

		#region ILevelChangeRequest implementation

		public void changeLevelTo (int levelID)
		{
			SimpleFader.instance.fade(1f, animationLength, easing, ()=>{
				TweenManager.Dispose();
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(levelID);
#pragma warning restore CS0618 // Type or member is obsolete
            });
		}

		public void changeLevelTo (string levelName)
		{
			SimpleFader.instance.fade(1f, animationLength, easing, ()=>{
				TweenManager.Dispose();
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(levelName);
#pragma warning restore CS0618 // Type or member is obsolete
            });
		}


		#endregion
	}
}
