using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E9 RID: 9449
	[Token(Token = "0x20024E9")]
	public class UIRoomQuadPlayerWithTeamItemView : UIBaseView
	{
		// Token: 0x0600C4E2 RID: 50402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E2")]
		[Address(RVA = "0x1A22E00", Offset = "0x1A22E00", VA = "0x7BBC222E00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E3")]
		[Address(RVA = "0x1A2307C", Offset = "0x1A2307C", VA = "0x7BBC22307C")]
		public UIRoomQuadPlayerWithTeamItemView()
		{
		}

		// Token: 0x0400F062 RID: 61538
		[Token(Token = "0x400F062")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Selected;

		// Token: 0x0400F063 RID: 61539
		[Token(Token = "0x400F063")]
		[FieldOffset(Offset = "0x28")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F064 RID: 61540
		[Token(Token = "0x400F064")]
		[FieldOffset(Offset = "0x30")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F065 RID: 61541
		[Token(Token = "0x400F065")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TeamName;

		// Token: 0x0400F066 RID: 61542
		[Token(Token = "0x400F066")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Id;

		// Token: 0x0400F067 RID: 61543
		[Token(Token = "0x400F067")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlayerGo1;

		// Token: 0x0400F068 RID: 61544
		[Token(Token = "0x400F068")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PlayerGo2;

		// Token: 0x0400F069 RID: 61545
		[Token(Token = "0x400F069")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PlayerGo3;

		// Token: 0x0400F06A RID: 61546
		[Token(Token = "0x400F06A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject PlayerGo4;
	}
}
