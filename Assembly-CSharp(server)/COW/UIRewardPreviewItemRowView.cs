using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D7 RID: 9431
	[Token(Token = "0x20024D7")]
	public class UIRewardPreviewItemRowView : UIBaseView
	{
		// Token: 0x0600C4BE RID: 50366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BE")]
		[Address(RVA = "0x1E204DC", Offset = "0x1E204DC", VA = "0x7BBC6204DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BF")]
		[Address(RVA = "0x1E205CC", Offset = "0x1E205CC", VA = "0x7BBC6205CC")]
		public UIRewardPreviewItemRowView()
		{
		}

		// Token: 0x0400EFDA RID: 61402
		[Token(Token = "0x400EFDA")]
		[FieldOffset(Offset = "0x20")]
		public UILabel DescLabel;

		// Token: 0x0400EFDB RID: 61403
		[Token(Token = "0x400EFDB")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid PreviewGrid;
	}
}
