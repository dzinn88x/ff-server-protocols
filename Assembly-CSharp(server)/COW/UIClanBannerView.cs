using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002164 RID: 8548
	[Token(Token = "0x2002164")]
	public class UIClanBannerView : UIBaseView
	{
		// Token: 0x0600BDD8 RID: 48600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD8")]
		[Address(RVA = "0x1CEBFB8", Offset = "0x1CEBFB8", VA = "0x7BBC4EBFB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD9")]
		[Address(RVA = "0x1CEC0D8", Offset = "0x1CEC0D8", VA = "0x7BBC4EC0D8")]
		public UIClanBannerView()
		{
		}

		// Token: 0x0400C5A0 RID: 50592
		[Token(Token = "0x400C5A0")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Mask;

		// Token: 0x0400C5A1 RID: 50593
		[Token(Token = "0x400C5A1")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Close;

		// Token: 0x0400C5A2 RID: 50594
		[Token(Token = "0x400C5A2")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList EasyList;
	}
}
