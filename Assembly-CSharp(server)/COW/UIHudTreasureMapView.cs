using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200238D RID: 9101
	[Token(Token = "0x200238D")]
	internal class UIHudTreasureMapView : UIBaseView
	{
		// Token: 0x0600C22A RID: 49706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22A")]
		[Address(RVA = "0x15EB054", Offset = "0x15EB054", VA = "0x7BBBDEB054", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22B")]
		[Address(RVA = "0x15EB1B0", Offset = "0x15EB1B0", VA = "0x7BBBDEB1B0")]
		public UIHudTreasureMapView()
		{
		}

		// Token: 0x0400DCFB RID: 56571
		[Token(Token = "0x400DCFB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnTreasureMap;

		// Token: 0x0400DCFC RID: 56572
		[Token(Token = "0x400DCFC")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BGTreasureMap;

		// Token: 0x0400DCFD RID: 56573
		[Token(Token = "0x400DCFD")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LocateTreasureIcon;

		// Token: 0x0400DCFE RID: 56574
		[Token(Token = "0x400DCFE")]
		[FieldOffset(Offset = "0x38")]
		public UISprite DigTreasureIcon;
	}
}
