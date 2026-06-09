using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002149 RID: 8521
	[Token(Token = "0x2002149")]
	internal class UIChannelItemView : UIBaseView
	{
		// Token: 0x0600BDA2 RID: 48546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA2")]
		[Address(RVA = "0x1BDF790", Offset = "0x1BDF790", VA = "0x7BBC3DF790", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDA3")]
		[Address(RVA = "0x1BDFA80", Offset = "0x1BDFA80", VA = "0x7BBC3DFA80")]
		public UIChannelItemView()
		{
		}

		// Token: 0x0400C498 RID: 50328
		[Token(Token = "0x400C498")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClickButton;

		// Token: 0x0400C499 RID: 50329
		[Token(Token = "0x400C499")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Tips;

		// Token: 0x0400C49A RID: 50330
		[Token(Token = "0x400C49A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Selected;

		// Token: 0x0400C49B RID: 50331
		[Token(Token = "0x400C49B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ChannelName;

		// Token: 0x0400C49C RID: 50332
		[Token(Token = "0x400C49C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Title;

		// Token: 0x0400C49D RID: 50333
		[Token(Token = "0x400C49D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject WhisperName;

		// Token: 0x0400C49E RID: 50334
		[Token(Token = "0x400C49E")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Head;

		// Token: 0x0400C49F RID: 50335
		[Token(Token = "0x400C49F")]
		[FieldOffset(Offset = "0x58")]
		public UILabel UserName;

		// Token: 0x0400C4A0 RID: 50336
		[Token(Token = "0x400C4A0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject OnlineHint;

		// Token: 0x0400C4A1 RID: 50337
		[Token(Token = "0x400C4A1")]
		[FieldOffset(Offset = "0x68")]
		public GameObject IngameHint;

		// Token: 0x0400C4A2 RID: 50338
		[Token(Token = "0x400C4A2")]
		[FieldOffset(Offset = "0x70")]
		public GameObject OfflineHint;
	}
}
