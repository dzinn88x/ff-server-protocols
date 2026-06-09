using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E1 RID: 8417
	[Token(Token = "0x20020E1")]
	internal class UIActivityIntroductionContentView : UIBaseView
	{
		// Token: 0x0600BCD3 RID: 48339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD3")]
		[Address(RVA = "0x195439C", Offset = "0x195439C", VA = "0x7BBC15439C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD4")]
		[Address(RVA = "0x1954538", Offset = "0x1954538", VA = "0x7BBC154538")]
		public UIActivityIntroductionContentView()
		{
		}

		// Token: 0x0400BF16 RID: 48918
		[Token(Token = "0x400BF16")]
		[FieldOffset(Offset = "0x20")]
		public UITable ContentTable;

		// Token: 0x0400BF17 RID: 48919
		[Token(Token = "0x400BF17")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Introduction;

		// Token: 0x0400BF18 RID: 48920
		[Token(Token = "0x400BF18")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Operation;

		// Token: 0x0400BF19 RID: 48921
		[Token(Token = "0x400BF19")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OperateBtnWhite;

		// Token: 0x0400BF1A RID: 48922
		[Token(Token = "0x400BF1A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GoToRedpoint;
	}
}
