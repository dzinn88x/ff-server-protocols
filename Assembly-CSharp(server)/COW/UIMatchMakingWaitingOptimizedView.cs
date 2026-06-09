using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002438 RID: 9272
	[Token(Token = "0x2002438")]
	public class UIMatchMakingWaitingOptimizedView : UIBaseView
	{
		// Token: 0x0600C380 RID: 50048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C380")]
		[Address(RVA = "0x1478CB4", Offset = "0x1478CB4", VA = "0x7BBBC78CB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C381")]
		[Address(RVA = "0x1478E9C", Offset = "0x1478E9C", VA = "0x7BBBC78E9C")]
		public UIMatchMakingWaitingOptimizedView()
		{
		}

		// Token: 0x0400E6FA RID: 59130
		[Token(Token = "0x400E6FA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DefaultViewContent;

		// Token: 0x0400E6FB RID: 59131
		[Token(Token = "0x400E6FB")]
		[FieldOffset(Offset = "0x28")]
		public GameObject OtherViewContent;

		// Token: 0x0400E6FC RID: 59132
		[Token(Token = "0x400E6FC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel OtherTime;

		// Token: 0x0400E6FD RID: 59133
		[Token(Token = "0x400E6FD")]
		[FieldOffset(Offset = "0x38")]
		public UIButton OtherCancelBtn;

		// Token: 0x0400E6FE RID: 59134
		[Token(Token = "0x400E6FE")]
		[FieldOffset(Offset = "0x40")]
		public GameObject OtherEstimateContent;

		// Token: 0x0400E6FF RID: 59135
		[Token(Token = "0x400E6FF")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OtherEstimateTime;
	}
}
