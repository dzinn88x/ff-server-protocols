using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F3 RID: 8947
	[Token(Token = "0x20022F3")]
	public class UIHudItemMarkShowView : UIBaseView
	{
		// Token: 0x0600C0F6 RID: 49398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F6")]
		[Address(RVA = "0x1C4AB20", Offset = "0x1C4AB20", VA = "0x7BBC44AB20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0F7 RID: 49399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F7")]
		[Address(RVA = "0x1C4AD74", Offset = "0x1C4AD74", VA = "0x7BBC44AD74")]
		public UIHudItemMarkShowView()
		{
		}

		// Token: 0x0400D7D1 RID: 55249
		[Token(Token = "0x400D7D1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIShowContainer;

		// Token: 0x0400D7D2 RID: 55250
		[Token(Token = "0x400D7D2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite triggerImg;

		// Token: 0x0400D7D3 RID: 55251
		[Token(Token = "0x400D7D3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite triggerBG;

		// Token: 0x0400D7D4 RID: 55252
		[Token(Token = "0x400D7D4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Distance;

		// Token: 0x0400D7D5 RID: 55253
		[Token(Token = "0x400D7D5")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ArrowDown;

		// Token: 0x0400D7D6 RID: 55254
		[Token(Token = "0x400D7D6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowRight;

		// Token: 0x0400D7D7 RID: 55255
		[Token(Token = "0x400D7D7")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArrowUp;

		// Token: 0x0400D7D8 RID: 55256
		[Token(Token = "0x400D7D8")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowLeft;
	}
}
