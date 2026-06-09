using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002362 RID: 9058
	[Token(Token = "0x2002362")]
	public class UIHudSingleFightMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C1D4 RID: 49620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D4")]
		[Address(RVA = "0x1667880", Offset = "0x1667880", VA = "0x7BBBE67880", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D5")]
		[Address(RVA = "0x1667D48", Offset = "0x1667D48", VA = "0x7BBBE67D48")]
		public UIHudSingleFightMatchResultItemView()
		{
		}

		// Token: 0x0400DB86 RID: 56198
		[Token(Token = "0x400DB86")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400DB87 RID: 56199
		[Token(Token = "0x400DB87")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Rank1Icon;

		// Token: 0x0400DB88 RID: 56200
		[Token(Token = "0x400DB88")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Rank2Icon;

		// Token: 0x0400DB89 RID: 56201
		[Token(Token = "0x400DB89")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Rank3Icon;

		// Token: 0x0400DB8A RID: 56202
		[Token(Token = "0x400DB8A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FakeBg;

		// Token: 0x0400DB8B RID: 56203
		[Token(Token = "0x400DB8B")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400DB8C RID: 56204
		[Token(Token = "0x400DB8C")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadIcon;

		// Token: 0x0400DB8D RID: 56205
		[Token(Token = "0x400DB8D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject IconCelebrity;

		// Token: 0x0400DB8E RID: 56206
		[Token(Token = "0x400DB8E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Nickname;

		// Token: 0x0400DB8F RID: 56207
		[Token(Token = "0x400DB8F")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ClanName;

		// Token: 0x0400DB90 RID: 56208
		[Token(Token = "0x400DB90")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info1Txt;

		// Token: 0x0400DB91 RID: 56209
		[Token(Token = "0x400DB91")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Info2Txt;

		// Token: 0x0400DB92 RID: 56210
		[Token(Token = "0x400DB92")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Info3Txt;

		// Token: 0x0400DB93 RID: 56211
		[Token(Token = "0x400DB93")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Info4Txt;

		// Token: 0x0400DB94 RID: 56212
		[Token(Token = "0x400DB94")]
		[FieldOffset(Offset = "0x90")]
		public UIButton AddFriendBtn;

		// Token: 0x0400DB95 RID: 56213
		[Token(Token = "0x400DB95")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ReportBtn;

		// Token: 0x0400DB96 RID: 56214
		[Token(Token = "0x400DB96")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton LikeBtn;

		// Token: 0x0400DB97 RID: 56215
		[Token(Token = "0x400DB97")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel LikeNum;

		// Token: 0x0400DB98 RID: 56216
		[Token(Token = "0x400DB98")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VFX_Like;
	}
}
