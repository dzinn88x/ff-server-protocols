using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002116 RID: 8470
	[Token(Token = "0x2002116")]
	internal class UIAwardItemView : UIBaseView
	{
		// Token: 0x0600BD3D RID: 48445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3D")]
		[Address(RVA = "0x141EA14", Offset = "0x141EA14", VA = "0x7BBBC1EA14", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD3E RID: 48446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD3E")]
		[Address(RVA = "0x141EBB0", Offset = "0x141EBB0", VA = "0x7BBBC1EBB0")]
		public UIAwardItemView()
		{
		}

		// Token: 0x0400C1CF RID: 49615
		[Token(Token = "0x400C1CF")]
		[FieldOffset(Offset = "0x20")]
		public AwardItemView AwardItem;

		// Token: 0x0400C1D0 RID: 49616
		[Token(Token = "0x400C1D0")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ItemNameLabel;

		// Token: 0x0400C1D1 RID: 49617
		[Token(Token = "0x400C1D1")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle AwardToggle;

		// Token: 0x0400C1D2 RID: 49618
		[Token(Token = "0x400C1D2")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SelectedSprite;

		// Token: 0x0400C1D3 RID: 49619
		[Token(Token = "0x400C1D3")]
		[FieldOffset(Offset = "0x40")]
		public UISprite UnSelectedSprite;
	}
}
