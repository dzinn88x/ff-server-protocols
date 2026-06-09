using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002395 RID: 9109
	[Token(Token = "0x2002395")]
	public class UIHudVehicleBufferView : UIBaseView
	{
		// Token: 0x0600C23A RID: 49722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23A")]
		[Address(RVA = "0x15EF288", Offset = "0x15EF288", VA = "0x7BBBDEF288", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C23B")]
		[Address(RVA = "0x15EF41C", Offset = "0x15EF41C", VA = "0x7BBBDEF41C")]
		public UIHudVehicleBufferView()
		{
		}

		// Token: 0x0400DD13 RID: 56595
		[Token(Token = "0x400DD13")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400DD14 RID: 56596
		[Token(Token = "0x400DD14")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400DD15 RID: 56597
		[Token(Token = "0x400DD15")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Mask;

		// Token: 0x0400DD16 RID: 56598
		[Token(Token = "0x400DD16")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Effect;

		// Token: 0x0400DD17 RID: 56599
		[Token(Token = "0x400DD17")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Tips;
	}
}
