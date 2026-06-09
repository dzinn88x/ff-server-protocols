using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002466 RID: 9318
	[Token(Token = "0x2002466")]
	public class UIOBSettingView : UIBaseView
	{
		// Token: 0x0600C3DC RID: 50140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DC")]
		[Address(RVA = "0x16E04A0", Offset = "0x16E04A0", VA = "0x7BBBEE04A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3DD RID: 50141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DD")]
		[Address(RVA = "0x16E0A6C", Offset = "0x16E0A6C", VA = "0x7BBBEE0A6C")]
		public UIOBSettingView()
		{
		}

		// Token: 0x0400E975 RID: 59765
		[Token(Token = "0x400E975")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButtonGroup DelayOBEnabled;

		// Token: 0x0400E976 RID: 59766
		[Token(Token = "0x400E976")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButton DelayOBOn;

		// Token: 0x0400E977 RID: 59767
		[Token(Token = "0x400E977")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton DelayOBOff;

		// Token: 0x0400E978 RID: 59768
		[Token(Token = "0x400E978")]
		[FieldOffset(Offset = "0x38")]
		public UISettingSliderItem DelayOB;

		// Token: 0x0400E979 RID: 59769
		[Token(Token = "0x400E979")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButtonGroup ReplayEnabled;

		// Token: 0x0400E97A RID: 59770
		[Token(Token = "0x400E97A")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton ReplayOn;

		// Token: 0x0400E97B RID: 59771
		[Token(Token = "0x400E97B")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton ReplayOff;

		// Token: 0x0400E97C RID: 59772
		[Token(Token = "0x400E97C")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButtonGroup PerspectiveType;

		// Token: 0x0400E97D RID: 59773
		[Token(Token = "0x400E97D")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButton NormalMode;

		// Token: 0x0400E97E RID: 59774
		[Token(Token = "0x400E97E")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton TeamMode;

		// Token: 0x0400E97F RID: 59775
		[Token(Token = "0x400E97F")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButtonGroup PerspectiveColoring;

		// Token: 0x0400E980 RID: 59776
		[Token(Token = "0x400E980")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton StuffedColor;

		// Token: 0x0400E981 RID: 59777
		[Token(Token = "0x400E981")]
		[FieldOffset(Offset = "0x80")]
		public UIToggleButton HollowColor;

		// Token: 0x0400E982 RID: 59778
		[Token(Token = "0x400E982")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButtonGroup PlayerSightEnabled;

		// Token: 0x0400E983 RID: 59779
		[Token(Token = "0x400E983")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButton PlayerSightOn;

		// Token: 0x0400E984 RID: 59780
		[Token(Token = "0x400E984")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton PlayerSightOff;

		// Token: 0x0400E985 RID: 59781
		[Token(Token = "0x400E985")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggleButtonGroup OpeningCamEnabled;

		// Token: 0x0400E986 RID: 59782
		[Token(Token = "0x400E986")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton OpeningCamOn;

		// Token: 0x0400E987 RID: 59783
		[Token(Token = "0x400E987")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButton OpeningCamOff;

		// Token: 0x0400E988 RID: 59784
		[Token(Token = "0x400E988")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggleButtonGroup SpHudCsPlayerInfoEnabled;

		// Token: 0x0400E989 RID: 59785
		[Token(Token = "0x400E989")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggleButton SpHudCsPlayerInfoOn;

		// Token: 0x0400E98A RID: 59786
		[Token(Token = "0x400E98A")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButton SpHudCsPlayerInfoOff;

		// Token: 0x0400E98B RID: 59787
		[Token(Token = "0x400E98B")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel MatchIDTxt;

		// Token: 0x0400E98C RID: 59788
		[Token(Token = "0x400E98C")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel cameraSpeedText;
	}
}
