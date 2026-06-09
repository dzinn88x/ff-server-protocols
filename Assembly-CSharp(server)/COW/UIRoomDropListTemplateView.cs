using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024DD RID: 9437
	[Token(Token = "0x20024DD")]
	public class UIRoomDropListTemplateView : UIBaseView
	{
		// Token: 0x0600C4CA RID: 50378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CA")]
		[Address(RVA = "0x1E23D1C", Offset = "0x1E23D1C", VA = "0x7BBC623D1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4CB")]
		[Address(RVA = "0x1E23E0C", Offset = "0x1E23E0C", VA = "0x7BBC623E0C")]
		public UIRoomDropListTemplateView()
		{
		}

		// Token: 0x0400EFF3 RID: 61427
		[Token(Token = "0x400EFF3")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400EFF4 RID: 61428
		[Token(Token = "0x400EFF4")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget DropListTemplatePopMenu;
	}
}
