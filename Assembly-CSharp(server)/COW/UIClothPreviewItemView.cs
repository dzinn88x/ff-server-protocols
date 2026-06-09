using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002173 RID: 8563
	[Token(Token = "0x2002173")]
	internal class UIClothPreviewItemView : UIBaseView
	{
		// Token: 0x0600BDF6 RID: 48630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF6")]
		[Address(RVA = "0x209685C", Offset = "0x209685C", VA = "0x7BBC89685C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDF7 RID: 48631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF7")]
		[Address(RVA = "0x2096A3C", Offset = "0x2096A3C", VA = "0x7BBC896A3C")]
		public UIClothPreviewItemView()
		{
		}

		// Token: 0x0400C6CB RID: 50891
		[Token(Token = "0x400C6CB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton clothpreviewbtn;

		// Token: 0x0400C6CC RID: 50892
		[Token(Token = "0x400C6CC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Normal;

		// Token: 0x0400C6CD RID: 50893
		[Token(Token = "0x400C6CD")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400C6CE RID: 50894
		[Token(Token = "0x400C6CE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Highlight;

		// Token: 0x0400C6CF RID: 50895
		[Token(Token = "0x400C6CF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject equip;

		// Token: 0x0400C6D0 RID: 50896
		[Token(Token = "0x400C6D0")]
		[FieldOffset(Offset = "0x48")]
		public UISprite icon;
	}
}
