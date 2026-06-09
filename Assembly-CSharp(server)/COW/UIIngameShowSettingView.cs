using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C2 RID: 9154
	[Token(Token = "0x20023C2")]
	public class UIIngameShowSettingView : UIBaseView
	{
		// Token: 0x0600C294 RID: 49812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C294")]
		[Address(RVA = "0x190C714", Offset = "0x190C714", VA = "0x7BBC10C714", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C295")]
		[Address(RVA = "0x190CD38", Offset = "0x190CD38", VA = "0x7BBC10CD38")]
		public UIIngameShowSettingView()
		{
		}

		// Token: 0x0400DEB7 RID: 57015
		[Token(Token = "0x400DEB7")]
		[FieldOffset(Offset = "0x20")]
		public UITable Table;

		// Token: 0x0400DEB8 RID: 57016
		[Token(Token = "0x400DEB8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject extraLine;

		// Token: 0x0400DEB9 RID: 57017
		[Token(Token = "0x400DEB9")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle LowestQualityToggle;

		// Token: 0x0400DEBA RID: 57018
		[Token(Token = "0x400DEBA")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle LowQualityToggle;

		// Token: 0x0400DEBB RID: 57019
		[Token(Token = "0x400DEBB")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle HighQualityToggle;

		// Token: 0x0400DEBC RID: 57020
		[Token(Token = "0x400DEBC")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget ExtraQualitySetting;

		// Token: 0x0400DEBD RID: 57021
		[Token(Token = "0x400DEBD")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HightFPSGO;

		// Token: 0x0400DEBE RID: 57022
		[Token(Token = "0x400DEBE")]
		[FieldOffset(Offset = "0x58")]
		public UISettingToggleGroup HighFPSToggleGroup;

		// Token: 0x0400DEBF RID: 57023
		[Token(Token = "0x400DEBF")]
		[FieldOffset(Offset = "0x60")]
		public UIToggle HighFPS_off;

		// Token: 0x0400DEC0 RID: 57024
		[Token(Token = "0x400DEC0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ShadowGO;

		// Token: 0x0400DEC1 RID: 57025
		[Token(Token = "0x400DEC1")]
		[FieldOffset(Offset = "0x70")]
		public UISettingToggleGroup ShadowOpToggleGroup;

		// Token: 0x0400DEC2 RID: 57026
		[Token(Token = "0x400DEC2")]
		[FieldOffset(Offset = "0x78")]
		public UIToggle NorthUpBtn;

		// Token: 0x0400DEC3 RID: 57027
		[Token(Token = "0x400DEC3")]
		[FieldOffset(Offset = "0x80")]
		public UIToggle ViewUpBtn;

		// Token: 0x0400DEC4 RID: 57028
		[Token(Token = "0x400DEC4")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButtonGroup MiniMapScaleAssist;

		// Token: 0x0400DEC5 RID: 57029
		[Token(Token = "0x400DEC5")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButton MiniMapScaleOff;

		// Token: 0x0400DEC6 RID: 57030
		[Token(Token = "0x400DEC6")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton MiniMapScaleOn;

		// Token: 0x0400DEC7 RID: 57031
		[Token(Token = "0x400DEC7")]
		[FieldOffset(Offset = "0xA0")]
		public UITable ShowInfo;

		// Token: 0x0400DEC8 RID: 57032
		[Token(Token = "0x400DEC8")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject UseAuxAim;

		// Token: 0x0400DEC9 RID: 57033
		[Token(Token = "0x400DEC9")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject DamageSetting;

		// Token: 0x0400DECA RID: 57034
		[Token(Token = "0x400DECA")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggle DamageOn;

		// Token: 0x0400DECB RID: 57035
		[Token(Token = "0x400DECB")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggle DamageOff;

		// Token: 0x0400DECC RID: 57036
		[Token(Token = "0x400DECC")]
		[FieldOffset(Offset = "0xC8")]
		public UISettingToggleGroup IngameTipsToggleGroup;

		// Token: 0x0400DECD RID: 57037
		[Token(Token = "0x400DECD")]
		[FieldOffset(Offset = "0xD0")]
		public UIToggleButtonGroup HitHint;

		// Token: 0x0400DECE RID: 57038
		[Token(Token = "0x400DECE")]
		[FieldOffset(Offset = "0xD8")]
		public UIToggleButton HitHintEnhanced;

		// Token: 0x0400DECF RID: 57039
		[Token(Token = "0x400DECF")]
		[FieldOffset(Offset = "0xE0")]
		public UIToggleButton HitHintClassic;
	}
}
