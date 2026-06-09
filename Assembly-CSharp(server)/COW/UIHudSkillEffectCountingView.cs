using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002365 RID: 9061
	[Token(Token = "0x2002365")]
	public class UIHudSkillEffectCountingView : UIBaseView
	{
		// Token: 0x0600C1DA RID: 49626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DA")]
		[Address(RVA = "0x1669478", Offset = "0x1669478", VA = "0x7BBBE69478", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1DB")]
		[Address(RVA = "0x166961C", Offset = "0x166961C", VA = "0x7BBBE6961C")]
		public UIHudSkillEffectCountingView()
		{
		}

		// Token: 0x0400DBC1 RID: 56257
		[Token(Token = "0x400DBC1")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SkillIcon;

		// Token: 0x0400DBC2 RID: 56258
		[Token(Token = "0x400DBC2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Tips;

		// Token: 0x0400DBC3 RID: 56259
		[Token(Token = "0x400DBC3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Effect;

		// Token: 0x0400DBC4 RID: 56260
		[Token(Token = "0x400DBC4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Mask;

		// Token: 0x0400DBC5 RID: 56261
		[Token(Token = "0x400DBC5")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnTip;
	}
}
