using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019F9 RID: 6649
	[Token(Token = "0x20019F9")]
	public class InventoryPreviewTabInfo
	{
		// Token: 0x060089D4 RID: 35284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089D4")]
		[Address(RVA = "0x13F3E0C", Offset = "0x13F3E0C", VA = "0x7BBBBF3E0C")]
		public InventoryPreviewTabInfo(UIToggleButton tb, uint id)
		{
		}

		// Token: 0x040097B4 RID: 38836
		[Token(Token = "0x40097B4")]
		[FieldOffset(Offset = "0x10")]
		public UIToggleButton tb;

		// Token: 0x040097B5 RID: 38837
		[Token(Token = "0x40097B5")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		// Token: 0x040097B6 RID: 38838
		[Token(Token = "0x40097B6")]
		[FieldOffset(Offset = "0x20")]
		public UIAtlas Atlas;

		// Token: 0x040097B7 RID: 38839
		[Token(Token = "0x40097B7")]
		[FieldOffset(Offset = "0x28")]
		public string SpriteName;

		// Token: 0x040097B8 RID: 38840
		[Token(Token = "0x40097B8")]
		[FieldOffset(Offset = "0x30")]
		public UISprite equip;

		// Token: 0x040097B9 RID: 38841
		[Token(Token = "0x40097B9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject normal;

		// Token: 0x040097BA RID: 38842
		[Token(Token = "0x40097BA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite icon;

		// Token: 0x040097BB RID: 38843
		[Token(Token = "0x40097BB")]
		[FieldOffset(Offset = "0x48")]
		public UISprite highLight;

		// Token: 0x040097BC RID: 38844
		[Token(Token = "0x40097BC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject download;
	}
}
