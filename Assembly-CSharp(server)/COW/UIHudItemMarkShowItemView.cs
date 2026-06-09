using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F2 RID: 8946
	[Token(Token = "0x20022F2")]
	public class UIHudItemMarkShowItemView : UIBaseView
	{
		// Token: 0x0600C0F4 RID: 49396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F4")]
		[Address(RVA = "0x1C4A9B4", Offset = "0x1C4A9B4", VA = "0x7BBC44A9B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0F5 RID: 49397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F5")]
		[Address(RVA = "0x1C4AB18", Offset = "0x1C4AB18", VA = "0x7BBC44AB18")]
		public UIHudItemMarkShowItemView()
		{
		}

		// Token: 0x0400D7CD RID: 55245
		[Token(Token = "0x400D7CD")]
		[FieldOffset(Offset = "0x20")]
		public UISprite ItemSprite;

		// Token: 0x0400D7CE RID: 55246
		[Token(Token = "0x400D7CE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountLabel;

		// Token: 0x0400D7CF RID: 55247
		[Token(Token = "0x400D7CF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemName;

		// Token: 0x0400D7D0 RID: 55248
		[Token(Token = "0x400D7D0")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnClick;
	}
}
