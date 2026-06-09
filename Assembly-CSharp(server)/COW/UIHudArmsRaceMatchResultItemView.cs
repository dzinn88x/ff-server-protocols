using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002268 RID: 8808
	[Token(Token = "0x2002268")]
	public class UIHudArmsRaceMatchResultItemView : UIBaseView
	{
		// Token: 0x0600BFE1 RID: 49121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE1")]
		[Address(RVA = "0x18866EC", Offset = "0x18866EC", VA = "0x7BBC0866EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFE2 RID: 49122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE2")]
		[Address(RVA = "0x1886A20", Offset = "0x1886A20", VA = "0x7BBC086A20")]
		public UIHudArmsRaceMatchResultItemView()
		{
		}

		// Token: 0x0400D37C RID: 54140
		[Token(Token = "0x400D37C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject bg;

		// Token: 0x0400D37D RID: 54141
		[Token(Token = "0x400D37D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject selfBg;

		// Token: 0x0400D37E RID: 54142
		[Token(Token = "0x400D37E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TopBG;

		// Token: 0x0400D37F RID: 54143
		[Token(Token = "0x400D37F")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HeadIcon;

		// Token: 0x0400D380 RID: 54144
		[Token(Token = "0x400D380")]
		[FieldOffset(Offset = "0x40")]
		public UILabel nickname;

		// Token: 0x0400D381 RID: 54145
		[Token(Token = "0x400D381")]
		[FieldOffset(Offset = "0x48")]
		public UILabel clanName;

		// Token: 0x0400D382 RID: 54146
		[Token(Token = "0x400D382")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Kill;

		// Token: 0x0400D383 RID: 54147
		[Token(Token = "0x400D383")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Death;

		// Token: 0x0400D384 RID: 54148
		[Token(Token = "0x400D384")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Assist;

		// Token: 0x0400D385 RID: 54149
		[Token(Token = "0x400D385")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Damage;

		// Token: 0x0400D386 RID: 54150
		[Token(Token = "0x400D386")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Rank;

		// Token: 0x0400D387 RID: 54151
		[Token(Token = "0x400D387")]
		[FieldOffset(Offset = "0x78")]
		public UIButton AddFriendBtn;
	}
}
