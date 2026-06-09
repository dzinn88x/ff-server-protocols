using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FE RID: 8958
	[Token(Token = "0x20022FE")]
	public class UIHudLocalPlayerKilledView : UIBaseView
	{
		// Token: 0x0600C10C RID: 49420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10C")]
		[Address(RVA = "0x15BB974", Offset = "0x15BB974", VA = "0x7BBBDBB974", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C10D RID: 49421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C10D")]
		[Address(RVA = "0x15BBB7C", Offset = "0x15BBB7C", VA = "0x7BBBDBBB7C")]
		public UIHudLocalPlayerKilledView()
		{
		}

		// Token: 0x0400D835 RID: 55349
		[Token(Token = "0x400D835")]
		[FieldOffset(Offset = "0x20")]
		public UISprite MaskBG;

		// Token: 0x0400D836 RID: 55350
		[Token(Token = "0x400D836")]
		[FieldOffset(Offset = "0x28")]
		public UILabel KillMsg;

		// Token: 0x0400D837 RID: 55351
		[Token(Token = "0x400D837")]
		[FieldOffset(Offset = "0x30")]
		public Animation KillInfoContainer;

		// Token: 0x0400D838 RID: 55352
		[Token(Token = "0x400D838")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ProfileContainer;

		// Token: 0x0400D839 RID: 55353
		[Token(Token = "0x400D839")]
		[FieldOffset(Offset = "0x40")]
		public UILabel killerMsg;

		// Token: 0x0400D83A RID: 55354
		[Token(Token = "0x400D83A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NormalContainer;

		// Token: 0x0400D83B RID: 55355
		[Token(Token = "0x400D83B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel NormalName;
	}
}
