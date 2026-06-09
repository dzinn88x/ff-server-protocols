using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002391 RID: 9105
	[Token(Token = "0x2002391")]
	public class UIHudTweenTipsView : UIBaseView
	{
		// Token: 0x0600C232 RID: 49714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C232")]
		[Address(RVA = "0x15EDB18", Offset = "0x15EDB18", VA = "0x7BBBDEDB18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C233")]
		[Address(RVA = "0x15EDC38", Offset = "0x15EDC38", VA = "0x7BBBDEDC38")]
		public UIHudTweenTipsView()
		{
		}

		// Token: 0x0400DD09 RID: 56585
		[Token(Token = "0x400DD09")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Message;

		// Token: 0x0400DD0A RID: 56586
		[Token(Token = "0x400DD0A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Messageshow;

		// Token: 0x0400DD0B RID: 56587
		[Token(Token = "0x400DD0B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg;
	}
}
