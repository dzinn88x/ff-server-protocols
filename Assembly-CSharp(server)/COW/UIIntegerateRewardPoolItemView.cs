using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C6 RID: 9158
	[Token(Token = "0x20023C6")]
	public class UIIntegerateRewardPoolItemView : UIBaseView
	{
		// Token: 0x0600C29C RID: 49820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C29C")]
		[Address(RVA = "0x1910B28", Offset = "0x1910B28", VA = "0x7BBC110B28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C29D")]
		[Address(RVA = "0x1910C18", Offset = "0x1910C18", VA = "0x7BBC110C18")]
		public UIIntegerateRewardPoolItemView()
		{
		}

		// Token: 0x0400DEF7 RID: 57079
		[Token(Token = "0x400DEF7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ItemPos;

		// Token: 0x0400DEF8 RID: 57080
		[Token(Token = "0x400DEF8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountLabel;
	}
}
