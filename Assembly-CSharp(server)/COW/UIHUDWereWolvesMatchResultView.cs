using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A7 RID: 9127
	[Token(Token = "0x20023A7")]
	public class UIHUDWereWolvesMatchResultView : UIBaseView
	{
		// Token: 0x0600C25E RID: 49758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25E")]
		[Address(RVA = "0x1D5A28C", Offset = "0x1D5A28C", VA = "0x7BBC55A28C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25F")]
		[Address(RVA = "0x1D5A7D8", Offset = "0x1D5A7D8", VA = "0x7BBC55A7D8")]
		public UIHUDWereWolvesMatchResultView()
		{
		}

		// Token: 0x0400DDBC RID: 56764
		[Token(Token = "0x400DDBC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ShareBtn;

		// Token: 0x0400DDBD RID: 56765
		[Token(Token = "0x400DDBD")]
		[FieldOffset(Offset = "0x28")]
		public UIButton QuitBtn;

		// Token: 0x0400DDBE RID: 56766
		[Token(Token = "0x400DDBE")]
		[FieldOffset(Offset = "0x30")]
		public UILabel QuitTimeLabel;

		// Token: 0x0400DDBF RID: 56767
		[Token(Token = "0x400DDBF")]
		[FieldOffset(Offset = "0x38")]
		public UIHUDWereWolvesPlayerResultItem PlayerInfoTemplate;

		// Token: 0x0400DDC0 RID: 56768
		[Token(Token = "0x400DDC0")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WinRoot;

		// Token: 0x0400DDC1 RID: 56769
		[Token(Token = "0x400DDC1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DefeatRoot;

		// Token: 0x0400DDC2 RID: 56770
		[Token(Token = "0x400DDC2")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WolfRolIconRoot;

		// Token: 0x0400DDC3 RID: 56771
		[Token(Token = "0x400DDC3")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WolfRoleWinIcon;

		// Token: 0x0400DDC4 RID: 56772
		[Token(Token = "0x400DDC4")]
		[FieldOffset(Offset = "0x60")]
		public GameObject WolfRoleDefeatIcon;

		// Token: 0x0400DDC5 RID: 56773
		[Token(Token = "0x400DDC5")]
		[FieldOffset(Offset = "0x68")]
		public GameObject HumanRoleIconRoot;

		// Token: 0x0400DDC6 RID: 56774
		[Token(Token = "0x400DDC6")]
		[FieldOffset(Offset = "0x70")]
		public GameObject HumanRoleWinIcon;

		// Token: 0x0400DDC7 RID: 56775
		[Token(Token = "0x400DDC7")]
		[FieldOffset(Offset = "0x78")]
		public GameObject HumanRoleDefeatIcon;

		// Token: 0x0400DDC8 RID: 56776
		[Token(Token = "0x400DDC8")]
		[FieldOffset(Offset = "0x80")]
		public UILabel GameOverReasonLabel;

		// Token: 0x0400DDC9 RID: 56777
		[Token(Token = "0x400DDC9")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid LeftDataGrid;

		// Token: 0x0400DDCA RID: 56778
		[Token(Token = "0x400DDCA")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid RightDataGrid;

		// Token: 0x0400DDCB RID: 56779
		[Token(Token = "0x400DDCB")]
		[FieldOffset(Offset = "0x98")]
		public UIEasyList ChatEasyList;

		// Token: 0x0400DDCC RID: 56780
		[Token(Token = "0x400DDCC")]
		[FieldOffset(Offset = "0xA0")]
		public UIInput ChatInput;

		// Token: 0x0400DDCD RID: 56781
		[Token(Token = "0x400DDCD")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnSendChat;

		// Token: 0x0400DDCE RID: 56782
		[Token(Token = "0x400DDCE")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BtnVoice;

		// Token: 0x0400DDCF RID: 56783
		[Token(Token = "0x400DDCF")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject VoiceOn;

		// Token: 0x0400DDD0 RID: 56784
		[Token(Token = "0x400DDD0")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject VoiceOff;
	}
}
