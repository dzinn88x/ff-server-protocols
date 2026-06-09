using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002236 RID: 8758
	[Token(Token = "0x2002236")]
	internal class UIGameModeOpenDetailsView : UIBaseView
	{
		// Token: 0x0600BF7D RID: 49021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7D")]
		[Address(RVA = "0x2009A34", Offset = "0x2009A34", VA = "0x7BBC809A34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7E")]
		[Address(RVA = "0x2009C14", Offset = "0x2009C14", VA = "0x7BBC809C14")]
		public UIGameModeOpenDetailsView()
		{
		}

		// Token: 0x0400D148 RID: 53576
		[Token(Token = "0x400D148")]
		[FieldOffset(Offset = "0x20")]
		public GameObject openTime;

		// Token: 0x0400D149 RID: 53577
		[Token(Token = "0x400D149")]
		[FieldOffset(Offset = "0x28")]
		public UILabel openPeriod;

		// Token: 0x0400D14A RID: 53578
		[Token(Token = "0x400D14A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject tag;

		// Token: 0x0400D14B RID: 53579
		[Token(Token = "0x400D14B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite tagSprite;

		// Token: 0x0400D14C RID: 53580
		[Token(Token = "0x400D14C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel tagLabel;

		// Token: 0x0400D14D RID: 53581
		[Token(Token = "0x400D14D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite tagSpritebg;
	}
}
