using DoozyUI;
using System.Collections.Generic;
using UnityEngine;

public class DoozyUI_Data : ScriptableObject
{
	public List<UIElement.ElementName> elementNames;

	public List<UIAnimator.SoundDetails> elementSounds;

	public List<UIButton.ButtonName> buttonNames;

	public List<UIButton.ButtonSound> buttonSounds;
}
