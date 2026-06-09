using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C2 RID: 8386
	[Token(Token = "0x20020C2")]
	public class LadderMatchLobbyEntryView : UIBaseView
	{
		// Token: 0x0600BC95 RID: 48277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC95")]
		[Address(RVA = "0x13FACBC", Offset = "0x13FACBC", VA = "0x7BBBBFACBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC96")]
		[Address(RVA = "0x13FAF20", Offset = "0x13FAF20", VA = "0x7BBBBFAF20")]
		public LadderMatchLobbyEntryView()
		{
		}

		// Token: 0x0400BD54 RID: 48468
		[Token(Token = "0x400BD54")]
		[FieldOffset(Offset = "0x20")]
		public UISprite LadderMatchLevelSprite;

		// Token: 0x0400BD55 RID: 48469
		[Token(Token = "0x400BD55")]
		[FieldOffset(Offset = "0x28")]
		public UIButton LadderMatchEntryBtn;

		// Token: 0x0400BD56 RID: 48470
		[Token(Token = "0x400BD56")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FireEffect;

		// Token: 0x0400BD57 RID: 48471
		[Token(Token = "0x400BD57")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FireParticle_Low;

		// Token: 0x0400BD58 RID: 48472
		[Token(Token = "0x400BD58")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FireParticle_High;

		// Token: 0x0400BD59 RID: 48473
		[Token(Token = "0x400BD59")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FirstWinTip;

		// Token: 0x0400BD5A RID: 48474
		[Token(Token = "0x400BD5A")]
		[FieldOffset(Offset = "0x50")]
		public UISprite AvalibleRankCardIconTip;

		// Token: 0x0400BD5B RID: 48475
		[Token(Token = "0x400BD5B")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SeasonName;
	}
}
