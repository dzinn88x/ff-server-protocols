using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002456 RID: 9302
	[Token(Token = "0x2002456")]
	public class UIMysteryMallShareView : UIBaseView
	{
		// Token: 0x0600C3BC RID: 50108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BC")]
		[Address(RVA = "0x14D673C", Offset = "0x14D673C", VA = "0x7BBBCD673C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BD")]
		[Address(RVA = "0x14D68E0", Offset = "0x14D68E0", VA = "0x7BBBCD68E0")]
		public UIMysteryMallShareView()
		{
		}

		// Token: 0x0400E885 RID: 59525
		[Token(Token = "0x400E885")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelLuckNum;

		// Token: 0x0400E886 RID: 59526
		[Token(Token = "0x400E886")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CndBgTexture;

		// Token: 0x0400E887 RID: 59527
		[Token(Token = "0x400E887")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnShare;

		// Token: 0x0400E888 RID: 59528
		[Token(Token = "0x400E888")]
		[FieldOffset(Offset = "0x38")]
		public Animator ShareIconAnimator;

		// Token: 0x0400E889 RID: 59529
		[Token(Token = "0x400E889")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClose;
	}
}
