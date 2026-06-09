using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E1 RID: 8929
	[Token(Token = "0x20022E1")]
	internal class UIHudGrenadeSubBtnView : UIBaseView
	{
		// Token: 0x0600C0D2 RID: 49362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D2")]
		[Address(RVA = "0x197D54C", Offset = "0x197D54C", VA = "0x7BBC17D54C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0D3 RID: 49363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0D3")]
		[Address(RVA = "0x197D66C", Offset = "0x197D66C", VA = "0x7BBC17D66C")]
		public UIHudGrenadeSubBtnView()
		{
		}

		// Token: 0x0400D6F3 RID: 55027
		[Token(Token = "0x400D6F3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnGrenade;

		// Token: 0x0400D6F4 RID: 55028
		[Token(Token = "0x400D6F4")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400D6F5 RID: 55029
		[Token(Token = "0x400D6F5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel count;
	}
}
