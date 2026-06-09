using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002341 RID: 9025
	[Token(Token = "0x2002341")]
	public class UIHudRangeShopCatagoryItemView : UIBaseView
	{
		// Token: 0x0600C192 RID: 49554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C192")]
		[Address(RVA = "0x17E8180", Offset = "0x17E8180", VA = "0x7BBBFE8180", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C193")]
		[Address(RVA = "0x17E82F4", Offset = "0x17E82F4", VA = "0x7BBBFE82F4")]
		public UIHudRangeShopCatagoryItemView()
		{
		}

		// Token: 0x0400DAB1 RID: 55985
		[Token(Token = "0x400DAB1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400DAB2 RID: 55986
		[Token(Token = "0x400DAB2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HighLight;

		// Token: 0x0400DAB3 RID: 55987
		[Token(Token = "0x400DAB3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Sprite;

		// Token: 0x0400DAB4 RID: 55988
		[Token(Token = "0x400DAB4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NewTagLabel;
	}
}
