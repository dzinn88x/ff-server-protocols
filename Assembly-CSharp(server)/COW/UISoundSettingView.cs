using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F8 RID: 9464
	[Token(Token = "0x20024F8")]
	public class UISoundSettingView : UIBaseView
	{
		// Token: 0x0600C500 RID: 50432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C500")]
		[Address(RVA = "0x1638DA0", Offset = "0x1638DA0", VA = "0x7BBBE38DA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C501")]
		[Address(RVA = "0x1638F24", Offset = "0x1638F24", VA = "0x7BBBE38F24")]
		public UISoundSettingView()
		{
		}

		// Token: 0x0400F12D RID: 61741
		[Token(Token = "0x400F12D")]
		[FieldOffset(Offset = "0x20")]
		public UISettingSliderItem MusicSetting;

		// Token: 0x0400F12E RID: 61742
		[Token(Token = "0x400F12E")]
		[FieldOffset(Offset = "0x28")]
		public UISettingSliderItem SoundEffectSetting;

		// Token: 0x0400F12F RID: 61743
		[Token(Token = "0x400F12F")]
		[FieldOffset(Offset = "0x30")]
		public UISettingSliderItem GameVoiceSetting;

		// Token: 0x0400F130 RID: 61744
		[Token(Token = "0x400F130")]
		[FieldOffset(Offset = "0x38")]
		public UISettingSliderItem PCFireSoundSetting;

		// Token: 0x0400F131 RID: 61745
		[Token(Token = "0x400F131")]
		[FieldOffset(Offset = "0x40")]
		public UISettingSliderItem PCAchievementSoundSetting;
	}
}
