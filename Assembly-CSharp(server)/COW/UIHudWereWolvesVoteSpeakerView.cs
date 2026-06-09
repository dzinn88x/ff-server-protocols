using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B6 RID: 9142
	[Token(Token = "0x20023B6")]
	public class UIHudWereWolvesVoteSpeakerView : UIBaseView
	{
		// Token: 0x0600C27C RID: 49788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27C")]
		[Address(RVA = "0x1D204A8", Offset = "0x1D204A8", VA = "0x7BBC5204A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27D")]
		[Address(RVA = "0x1D20690", Offset = "0x1D20690", VA = "0x7BBC520690")]
		public UIHudWereWolvesVoteSpeakerView()
		{
		}

		// Token: 0x0400DE11 RID: 56849
		[Token(Token = "0x400DE11")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSpeaker;

		// Token: 0x0400DE12 RID: 56850
		[Token(Token = "0x400DE12")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpeakerOn;

		// Token: 0x0400DE13 RID: 56851
		[Token(Token = "0x400DE13")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpeakerOff;

		// Token: 0x0400DE14 RID: 56852
		[Token(Token = "0x400DE14")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400DE15 RID: 56853
		[Token(Token = "0x400DE15")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList ContentList;

		// Token: 0x0400DE16 RID: 56854
		[Token(Token = "0x400DE16")]
		[FieldOffset(Offset = "0x48")]
		public UIButton bgmask;
	}
}
