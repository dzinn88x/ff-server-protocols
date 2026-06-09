using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B5 RID: 9141
	[Token(Token = "0x20023B5")]
	public class UIHudWereWolvesVoteSpeakerItemView : UIBaseView
	{
		// Token: 0x0600C27A RID: 49786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27A")]
		[Address(RVA = "0x1D202C0", Offset = "0x1D202C0", VA = "0x7BBC5202C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C27B RID: 49787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27B")]
		[Address(RVA = "0x1D204A0", Offset = "0x1D204A0", VA = "0x7BBC5204A0")]
		public UIHudWereWolvesVoteSpeakerItemView()
		{
		}

		// Token: 0x0400DE0B RID: 56843
		[Token(Token = "0x400DE0B")]
		[FieldOffset(Offset = "0x20")]
		public UISprite CountBG;

		// Token: 0x0400DE0C RID: 56844
		[Token(Token = "0x400DE0C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountLabel;

		// Token: 0x0400DE0D RID: 56845
		[Token(Token = "0x400DE0D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnSpeaker;

		// Token: 0x0400DE0E RID: 56846
		[Token(Token = "0x400DE0E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SpeakerOn;

		// Token: 0x0400DE0F RID: 56847
		[Token(Token = "0x400DE0F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SpeakerOff;

		// Token: 0x0400DE10 RID: 56848
		[Token(Token = "0x400DE10")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NameLabel;
	}
}
