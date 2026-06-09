using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200231F RID: 8991
	[Token(Token = "0x200231F")]
	public class UIHudNormalMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C14E RID: 49486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14E")]
		[Address(RVA = "0x17BA898", Offset = "0x17BA898", VA = "0x7BBBFBA898", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C14F")]
		[Address(RVA = "0x17BAD50", Offset = "0x17BAD50", VA = "0x7BBBFBAD50")]
		public UIHudNormalMatchResultItemView()
		{
		}

		// Token: 0x0400D9B6 RID: 55734
		[Token(Token = "0x400D9B6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SelfBG;

		// Token: 0x0400D9B7 RID: 55735
		[Token(Token = "0x400D9B7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WinMVPGrade;

		// Token: 0x0400D9B8 RID: 55736
		[Token(Token = "0x400D9B8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FailMVPGrade;

		// Token: 0x0400D9B9 RID: 55737
		[Token(Token = "0x400D9B9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NormalGrade;

		// Token: 0x0400D9BA RID: 55738
		[Token(Token = "0x400D9BA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FakeBg;

		// Token: 0x0400D9BB RID: 55739
		[Token(Token = "0x400D9BB")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite BannerBg;

		// Token: 0x0400D9BC RID: 55740
		[Token(Token = "0x400D9BC")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadIcon;

		// Token: 0x0400D9BD RID: 55741
		[Token(Token = "0x400D9BD")]
		[FieldOffset(Offset = "0x58")]
		public GameObject IconCelebrity;

		// Token: 0x0400D9BE RID: 55742
		[Token(Token = "0x400D9BE")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Nickname;

		// Token: 0x0400D9BF RID: 55743
		[Token(Token = "0x400D9BF")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ClanName;

		// Token: 0x0400D9C0 RID: 55744
		[Token(Token = "0x400D9C0")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Info1Txt;

		// Token: 0x0400D9C1 RID: 55745
		[Token(Token = "0x400D9C1")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Info2Txt;

		// Token: 0x0400D9C2 RID: 55746
		[Token(Token = "0x400D9C2")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Info3Txt;

		// Token: 0x0400D9C3 RID: 55747
		[Token(Token = "0x400D9C3")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Info4Txt;

		// Token: 0x0400D9C4 RID: 55748
		[Token(Token = "0x400D9C4")]
		[FieldOffset(Offset = "0x90")]
		public UIButton AddFriendBtn;

		// Token: 0x0400D9C5 RID: 55749
		[Token(Token = "0x400D9C5")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ReportBtn;

		// Token: 0x0400D9C6 RID: 55750
		[Token(Token = "0x400D9C6")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton LikeBtn;

		// Token: 0x0400D9C7 RID: 55751
		[Token(Token = "0x400D9C7")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel LikeNum;

		// Token: 0x0400D9C8 RID: 55752
		[Token(Token = "0x400D9C8")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VFX_Like;
	}
}
