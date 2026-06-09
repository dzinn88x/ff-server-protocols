using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236D RID: 9069
	[Token(Token = "0x200236D")]
	public class UIHudSpeedupAreaView : UIBaseView
	{
		// Token: 0x0600C1EA RID: 49642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EA")]
		[Address(RVA = "0x167330C", Offset = "0x167330C", VA = "0x7BBBE7330C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EB")]
		[Address(RVA = "0x1673504", Offset = "0x1673504", VA = "0x7BBBE73504")]
		public UIHudSpeedupAreaView()
		{
		}

		// Token: 0x0400DBE7 RID: 56295
		[Token(Token = "0x400DBE7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SpeedupArea;

		// Token: 0x0400DBE8 RID: 56296
		[Token(Token = "0x400DBE8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton btnSpeedup;

		// Token: 0x0400DBE9 RID: 56297
		[Token(Token = "0x400DBE9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400DBEA RID: 56298
		[Token(Token = "0x400DBEA")]
		[FieldOffset(Offset = "0x38")]
		public TweenFill EnergyBar;

		// Token: 0x0400DBEB RID: 56299
		[Token(Token = "0x400DBEB")]
		[FieldOffset(Offset = "0x40")]
		public UISprite normal;

		// Token: 0x0400DBEC RID: 56300
		[Token(Token = "0x400DBEC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ActionNameTxt;
	}
}
