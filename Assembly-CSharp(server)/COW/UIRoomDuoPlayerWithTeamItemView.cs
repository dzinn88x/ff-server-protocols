using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DF RID: 9439
	[Token(Token = "0x20024DF")]
	public class UIRoomDuoPlayerWithTeamItemView : UIBaseView
	{
		// Token: 0x0600C4CE RID: 50382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CE")]
		[Address(RVA = "0x1A11FE4", Offset = "0x1A11FE4", VA = "0x7BBC211FE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CF")]
		[Address(RVA = "0x1A121F4", Offset = "0x1A121F4", VA = "0x7BBC2121F4")]
		public UIRoomDuoPlayerWithTeamItemView()
		{
		}

		// Token: 0x0400EFF9 RID: 61433
		[Token(Token = "0x400EFF9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Selected;

		// Token: 0x0400EFFA RID: 61434
		[Token(Token = "0x400EFFA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TeamName;

		// Token: 0x0400EFFB RID: 61435
		[Token(Token = "0x400EFFB")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400EFFC RID: 61436
		[Token(Token = "0x400EFFC")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400EFFD RID: 61437
		[Token(Token = "0x400EFFD")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Id;

		// Token: 0x0400EFFE RID: 61438
		[Token(Token = "0x400EFFE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PlayerGo1;

		// Token: 0x0400EFFF RID: 61439
		[Token(Token = "0x400EFFF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PlayerGo2;
	}
}
