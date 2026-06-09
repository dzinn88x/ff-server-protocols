using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227C RID: 8828
	[Token(Token = "0x200227C")]
	public class UIHudBombCountDownTimeView : UIBaseView
	{
		// Token: 0x0600C009 RID: 49161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C009")]
		[Address(RVA = "0x1897E28", Offset = "0x1897E28", VA = "0x7BBC097E28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00A")]
		[Address(RVA = "0x1897F40", Offset = "0x1897F40", VA = "0x7BBC097F40")]
		public UIHudBombCountDownTimeView()
		{
		}

		// Token: 0x0400D3FE RID: 54270
		[Token(Token = "0x400D3FE")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label;

		// Token: 0x0400D3FF RID: 54271
		[Token(Token = "0x400D3FF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject IconNormal;

		// Token: 0x0400D400 RID: 54272
		[Token(Token = "0x400D400")]
		[FieldOffset(Offset = "0x30")]
		public GameObject IconBomb;
	}
}
