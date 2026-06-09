using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B5 RID: 9397
	[Token(Token = "0x20024B5")]
	public class UIPVEStartGameView : UIBaseView
	{
		// Token: 0x0600C47A RID: 50298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47A")]
		[Address(RVA = "0x16E6AC8", Offset = "0x16E6AC8", VA = "0x7BBBEE6AC8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47B")]
		[Address(RVA = "0x16E6E98", Offset = "0x16E6E98", VA = "0x7BBBEE6E98")]
		public UIPVEStartGameView()
		{
		}

		// Token: 0x0400EECC RID: 61132
		[Token(Token = "0x400EECC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnBox;

		// Token: 0x0400EECD RID: 61133
		[Token(Token = "0x400EECD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BigRewardIcon;

		// Token: 0x0400EECE RID: 61134
		[Token(Token = "0x400EECE")]
		[FieldOffset(Offset = "0x30")]
		public UILabel FinishCounts;

		// Token: 0x0400EECF RID: 61135
		[Token(Token = "0x400EECF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BoxUnFinished;

		// Token: 0x0400EED0 RID: 61136
		[Token(Token = "0x400EED0")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BoxFinished;

		// Token: 0x0400EED1 RID: 61137
		[Token(Token = "0x400EED1")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BoxRewarded;

		// Token: 0x0400EED2 RID: 61138
		[Token(Token = "0x400EED2")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnSoloGame;

		// Token: 0x0400EED3 RID: 61139
		[Token(Token = "0x400EED3")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnGroupGame;

		// Token: 0x0400EED4 RID: 61140
		[Token(Token = "0x400EED4")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnClose;

		// Token: 0x0400EED5 RID: 61141
		[Token(Token = "0x400EED5")]
		[FieldOffset(Offset = "0x68")]
		public UICountDownLabel CountDownLabel;

		// Token: 0x0400EED6 RID: 61142
		[Token(Token = "0x400EED6")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid RewardList;

		// Token: 0x0400EED7 RID: 61143
		[Token(Token = "0x400EED7")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DailyPorgress;

		// Token: 0x0400EED8 RID: 61144
		[Token(Token = "0x400EED8")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Finished;

		// Token: 0x0400EED9 RID: 61145
		[Token(Token = "0x400EED9")]
		[FieldOffset(Offset = "0x88")]
		public UINetworkTexture Role;
	}
}
