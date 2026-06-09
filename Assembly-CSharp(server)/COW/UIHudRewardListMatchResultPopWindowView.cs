using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002359 RID: 9049
	[Token(Token = "0x2002359")]
	internal class UIHudRewardListMatchResultPopWindowView : UIBaseView
	{
		// Token: 0x0600C1C2 RID: 49602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C2")]
		[Address(RVA = "0x17FC2FC", Offset = "0x17FC2FC", VA = "0x7BBBFFC2FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C3")]
		[Address(RVA = "0x17FC470", Offset = "0x17FC470", VA = "0x7BBBFFC470")]
		public UIHudRewardListMatchResultPopWindowView()
		{
		}

		// Token: 0x0400DB2E RID: 56110
		[Token(Token = "0x400DB2E")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400DB2F RID: 56111
		[Token(Token = "0x400DB2F")]
		[FieldOffset(Offset = "0x28")]
		public MatchResultRewardItemView RewardItem;

		// Token: 0x0400DB30 RID: 56112
		[Token(Token = "0x400DB30")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg;

		// Token: 0x0400DB31 RID: 56113
		[Token(Token = "0x400DB31")]
		[FieldOffset(Offset = "0x38")]
		public UIButton CloseBtn;
	}
}
