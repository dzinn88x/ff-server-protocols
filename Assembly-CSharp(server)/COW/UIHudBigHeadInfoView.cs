using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227A RID: 8826
	[Token(Token = "0x200227A")]
	internal class UIHudBigHeadInfoView : UIBaseView
	{
		// Token: 0x0600C005 RID: 49157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C005")]
		[Address(RVA = "0x1894E74", Offset = "0x1894E74", VA = "0x7BBC094E74", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C006")]
		[Address(RVA = "0x1894F8C", Offset = "0x1894F8C", VA = "0x7BBC094F8C")]
		public UIHudBigHeadInfoView()
		{
		}

		// Token: 0x0400D3F2 RID: 54258
		[Token(Token = "0x400D3F2")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Time;

		// Token: 0x0400D3F3 RID: 54259
		[Token(Token = "0x400D3F3")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Score;

		// Token: 0x0400D3F4 RID: 54260
		[Token(Token = "0x400D3F4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LeadingScore;
	}
}
