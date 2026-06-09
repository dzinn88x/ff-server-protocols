using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F2 RID: 9458
	[Token(Token = "0x20024F2")]
	internal class UISecondRechargeView : UIBaseView
	{
		// Token: 0x0600C4F4 RID: 50420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F4")]
		[Address(RVA = "0x162FEC4", Offset = "0x162FEC4", VA = "0x7BBBE2FEC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F5")]
		[Address(RVA = "0x1630068", Offset = "0x1630068", VA = "0x7BBBE30068")]
		public UISecondRechargeView()
		{
		}

		// Token: 0x0400F0E1 RID: 61665
		[Token(Token = "0x400F0E1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F0E2 RID: 61666
		[Token(Token = "0x400F0E2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnItem;

		// Token: 0x0400F0E3 RID: 61667
		[Token(Token = "0x400F0E3")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture Tex;

		// Token: 0x0400F0E4 RID: 61668
		[Token(Token = "0x400F0E4")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid Grid;

		// Token: 0x0400F0E5 RID: 61669
		[Token(Token = "0x400F0E5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ActivityTime;
	}
}
