using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200242A RID: 9258
	[Token(Token = "0x200242A")]
	internal class UIManualMapSupplyItemView : UIBaseView
	{
		// Token: 0x0600C364 RID: 50020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C364")]
		[Address(RVA = "0x18E6CE8", Offset = "0x18E6CE8", VA = "0x7BBC0E6CE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C365")]
		[Address(RVA = "0x18E6E84", Offset = "0x18E6E84", VA = "0x7BBC0E6E84")]
		public UIManualMapSupplyItemView()
		{
		}

		// Token: 0x0400E60A RID: 58890
		[Token(Token = "0x400E60A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400E60B RID: 58891
		[Token(Token = "0x400E60B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400E60C RID: 58892
		[Token(Token = "0x400E60C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel QuestionLabel;

		// Token: 0x0400E60D RID: 58893
		[Token(Token = "0x400E60D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SelectBg;

		// Token: 0x0400E60E RID: 58894
		[Token(Token = "0x400E60E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Tag;
	}
}
