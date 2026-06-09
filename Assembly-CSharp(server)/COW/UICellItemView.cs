using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002127 RID: 8487
	[Token(Token = "0x2002127")]
	public class UICellItemView : UIBaseView
	{
		// Token: 0x0600BD5E RID: 48478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5E")]
		[Address(RVA = "0x1C23EEC", Offset = "0x1C23EEC", VA = "0x7BBC423EEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5F")]
		[Address(RVA = "0x1C24088", Offset = "0x1C24088", VA = "0x7BBC424088")]
		public UICellItemView()
		{
		}

		// Token: 0x0400C303 RID: 49923
		[Token(Token = "0x400C303")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CellBtn;

		// Token: 0x0400C304 RID: 49924
		[Token(Token = "0x400C304")]
		[FieldOffset(Offset = "0x28")]
		public UISprite CellIcon;

		// Token: 0x0400C305 RID: 49925
		[Token(Token = "0x400C305")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LightEffect;

		// Token: 0x0400C306 RID: 49926
		[Token(Token = "0x400C306")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HL;

		// Token: 0x0400C307 RID: 49927
		[Token(Token = "0x400C307")]
		[FieldOffset(Offset = "0x40")]
		public UILabel IndexTxt;
	}
}
