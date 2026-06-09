using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B5 RID: 8629
	[Token(Token = "0x20021B5")]
	public class UIElitePassDocumentView : UIBaseView
	{
		// Token: 0x0600BE7A RID: 48762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7A")]
		[Address(RVA = "0x1AE7CC4", Offset = "0x1AE7CC4", VA = "0x7BBC2E7CC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE7B RID: 48763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE7B")]
		[Address(RVA = "0x1AE7E38", Offset = "0x1AE7E38", VA = "0x7BBC2E7E38")]
		public UIElitePassDocumentView()
		{
		}

		// Token: 0x0400CA29 RID: 51753
		[Token(Token = "0x400CA29")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView ScrollView;

		// Token: 0x0400CA2A RID: 51754
		[Token(Token = "0x400CA2A")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList EasyList;

		// Token: 0x0400CA2B RID: 51755
		[Token(Token = "0x400CA2B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400CA2C RID: 51756
		[Token(Token = "0x400CA2C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Sprite;
	}
}
