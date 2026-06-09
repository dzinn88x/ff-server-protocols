using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002334 RID: 9012
	[Token(Token = "0x2002334")]
	public class UIHudPVEBossHPView : UIBaseView
	{
		// Token: 0x0600C178 RID: 49528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C178")]
		[Address(RVA = "0x17C0200", Offset = "0x17C0200", VA = "0x7BBBFC0200", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C179 RID: 49529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C179")]
		[Address(RVA = "0x17C0364", Offset = "0x17C0364", VA = "0x7BBBFC0364")]
		public UIHudPVEBossHPView()
		{
		}

		// Token: 0x0400DA87 RID: 55943
		[Token(Token = "0x400DA87")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DA88 RID: 55944
		[Token(Token = "0x400DA88")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HPbarfg;

		// Token: 0x0400DA89 RID: 55945
		[Token(Token = "0x400DA89")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HPbarbg;

		// Token: 0x0400DA8A RID: 55946
		[Token(Token = "0x400DA8A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HPLayerCount;
	}
}
