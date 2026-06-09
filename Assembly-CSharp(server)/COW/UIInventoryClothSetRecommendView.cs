using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023CB RID: 9163
	[Token(Token = "0x20023CB")]
	internal class UIInventoryClothSetRecommendView : UIBaseView
	{
		// Token: 0x0600C2A6 RID: 49830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A6")]
		[Address(RVA = "0x191840C", Offset = "0x191840C", VA = "0x7BBC11840C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A7")]
		[Address(RVA = "0x1918604", Offset = "0x1918604", VA = "0x7BBC118604")]
		public UIInventoryClothSetRecommendView()
		{
		}

		// Token: 0x0400DF10 RID: 57104
		[Token(Token = "0x400DF10")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIInventoryClothSetRecommend;

		// Token: 0x0400DF11 RID: 57105
		[Token(Token = "0x400DF11")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid ClothSetList;

		// Token: 0x0400DF12 RID: 57106
		[Token(Token = "0x400DF12")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Cloth;

		// Token: 0x0400DF13 RID: 57107
		[Token(Token = "0x400DF13")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Descargar;

		// Token: 0x0400DF14 RID: 57108
		[Token(Token = "0x400DF14")]
		[FieldOffset(Offset = "0x40")]
		public UIButton DressUp;

		// Token: 0x0400DF15 RID: 57109
		[Token(Token = "0x400DF15")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget BG;
	}
}
