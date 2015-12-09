﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace SinglePlayer.UI {
	public class AttributePanelUI : MonoBehaviour {
		public DropdownFix selections;
		public CategoryHandler categoryContentObject;
		public LevelRateHandler levelingRatesObject;
		public Text equationTextObject;
		public Difficulty aiCalibrationDifficulty;
		public PresetDefault aiCalibrationPresetModeObject;
		public CustomFieldHandler aiCalibrationFieldItemObject;
	}
}
