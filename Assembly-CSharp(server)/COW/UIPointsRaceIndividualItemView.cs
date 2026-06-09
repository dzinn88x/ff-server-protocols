using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002492 RID: 9362
	[Token(Token = "0x2002492")]
	public class UIPointsRaceIndividualItemView : UIBaseView
	{
		// Token: 0x0600C434 RID: 50228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C434")]
		[Address(RVA = "0x20E76C0", Offset = "0x20E76C0", VA = "0x7BBC8E76C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C435")]
		[Address(RVA = "0x20E79B8", Offset = "0x20E79B8", VA = "0x7BBC8E79B8")]
		public UIPointsRaceIndividualItemView()
		{
		}

		// Token: 0x0400EB8C RID: 60300
		[Token(Token = "0x400EB8C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject LargeGreyMask;

		// Token: 0x0400EB8D RID: 60301
		[Token(Token = "0x400EB8D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GreyMask;

		// Token: 0x0400EB8E RID: 60302
		[Token(Token = "0x400EB8E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GreyNumberText;

		// Token: 0x0400EB8F RID: 60303
		[Token(Token = "0x400EB8F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TitleText;

		// Token: 0x0400EB90 RID: 60304
		[Token(Token = "0x400EB90")]
		[FieldOffset(Offset = "0x40")]
		public UIButton TipsBtn;

		// Token: 0x0400EB91 RID: 60305
		[Token(Token = "0x400EB91")]
		[FieldOffset(Offset = "0x48")]
		public BaseItemView Item;

		// Token: 0x0400EB92 RID: 60306
		[Token(Token = "0x400EB92")]
		[FieldOffset(Offset = "0x50")]
		public UISprite QualityBG;

		// Token: 0x0400EB93 RID: 60307
		[Token(Token = "0x400EB93")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Quality;

		// Token: 0x0400EB94 RID: 60308
		[Token(Token = "0x400EB94")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ClaimBtn;

		// Token: 0x0400EB95 RID: 60309
		[Token(Token = "0x400EB95")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ClaimedObj;
	}
}
