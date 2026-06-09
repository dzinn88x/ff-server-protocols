using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DE RID: 9182
	[Token(Token = "0x20023DE")]
	public class UILegendDrawAnimPopWindowView : UIBaseView
	{
		// Token: 0x0600C2CC RID: 49868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CC")]
		[Address(RVA = "0x1CB4A08", Offset = "0x1CB4A08", VA = "0x7BBC4B4A08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2CD RID: 49869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CD")]
		[Address(RVA = "0x1CB4B7C", Offset = "0x1CB4B7C", VA = "0x7BBC4B4B7C")]
		public UILegendDrawAnimPopWindowView()
		{
		}

		// Token: 0x0400E068 RID: 57448
		[Token(Token = "0x400E068")]
		[FieldOffset(Offset = "0x20")]
		public UILegendDrawAnimSetting Setting;

		// Token: 0x0400E069 RID: 57449
		[Token(Token = "0x400E069")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition TweenPosition;

		// Token: 0x0400E06A RID: 57450
		[Token(Token = "0x400E06A")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList EasyList;

		// Token: 0x0400E06B RID: 57451
		[Token(Token = "0x400E06B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ResultVfx;
	}
}
