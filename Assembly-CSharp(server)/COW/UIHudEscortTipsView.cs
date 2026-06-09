using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022CB RID: 8907
	[Token(Token = "0x20022CB")]
	public class UIHudEscortTipsView : UIBaseView
	{
		// Token: 0x0600C0A6 RID: 49318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A6")]
		[Address(RVA = "0x1C0802C", Offset = "0x1C0802C", VA = "0x7BBC40802C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A7")]
		[Address(RVA = "0x1C0814C", Offset = "0x1C0814C", VA = "0x7BBC40814C")]
		public UIHudEscortTipsView()
		{
		}

		// Token: 0x0400D680 RID: 54912
		[Token(Token = "0x400D680")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400D681 RID: 54913
		[Token(Token = "0x400D681")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BG;

		// Token: 0x0400D682 RID: 54914
		[Token(Token = "0x400D682")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Message;
	}
}
