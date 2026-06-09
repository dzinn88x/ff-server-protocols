using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002572 RID: 9586
	[Token(Token = "0x2002572")]
	internal class UITeamBaseProfileView : UIBaseView
	{
		// Token: 0x0600C5F4 RID: 50676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F4")]
		[Address(RVA = "0x1F52F70", Offset = "0x1F52F70", VA = "0x7BBC752F70", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5F5")]
		[Address(RVA = "0x1F530E4", Offset = "0x1F530E4", VA = "0x7BBC7530E4")]
		public UITeamBaseProfileView()
		{
		}

		// Token: 0x0400F628 RID: 63016
		[Token(Token = "0x400F628")]
		[FieldOffset(Offset = "0x20")]
		public UIEffectSprite Callsign;

		// Token: 0x0400F629 RID: 63017
		[Token(Token = "0x400F629")]
		[FieldOffset(Offset = "0x28")]
		public UIEffectSprite HeadPic;

		// Token: 0x0400F62A RID: 63018
		[Token(Token = "0x400F62A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Name;

		// Token: 0x0400F62B RID: 63019
		[Token(Token = "0x400F62B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Flag;
	}
}
