using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B1 RID: 9137
	[Token(Token = "0x20023B1")]
	public class UIHudWereWolvesVoiceEngineView : UIBaseView
	{
		// Token: 0x0600C272 RID: 49778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C272")]
		[Address(RVA = "0x1D18E08", Offset = "0x1D18E08", VA = "0x7BBC518E08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C273 RID: 49779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C273")]
		[Address(RVA = "0x1D18FD8", Offset = "0x1D18FD8", VA = "0x7BBC518FD8")]
		public UIHudWereWolvesVoiceEngineView()
		{
		}

		// Token: 0x0400DDEA RID: 56810
		[Token(Token = "0x400DDEA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnMic;

		// Token: 0x0400DDEB RID: 56811
		[Token(Token = "0x400DDEB")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MicOn;

		// Token: 0x0400DDEC RID: 56812
		[Token(Token = "0x400DDEC")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MicOff;

		// Token: 0x0400DDED RID: 56813
		[Token(Token = "0x400DDED")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnSpeaker;

		// Token: 0x0400DDEE RID: 56814
		[Token(Token = "0x400DDEE")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SpeakerOn;

		// Token: 0x0400DDEF RID: 56815
		[Token(Token = "0x400DDEF")]
		[FieldOffset(Offset = "0x48")]
		public GameObject SpeakerOff;
	}
}
