using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247E RID: 9342
	[Token(Token = "0x200247E")]
	internal class UIPaymentSubscriptionHubView : UIBaseView
	{
		// Token: 0x0600C40C RID: 50188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40C")]
		[Address(RVA = "0x1F3434C", Offset = "0x1F3434C", VA = "0x7BBC73434C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40D")]
		[Address(RVA = "0x1F3446C", Offset = "0x1F3446C", VA = "0x7BBC73446C")]
		public UIPaymentSubscriptionHubView()
		{
		}

		// Token: 0x0400EAA4 RID: 60068
		[Token(Token = "0x400EAA4")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ItemsScrollView;

		// Token: 0x0400EAA5 RID: 60069
		[Token(Token = "0x400EAA5")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid ItemsGrid;

		// Token: 0x0400EAA6 RID: 60070
		[Token(Token = "0x400EAA6")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget ContentContainer;
	}
}
