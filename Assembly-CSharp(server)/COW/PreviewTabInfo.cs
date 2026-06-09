using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200158E RID: 5518
	[Token(Token = "0x200158E")]
	public class PreviewTabInfo
	{
		// Token: 0x0600606C RID: 24684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606C")]
		[Address(RVA = "0x174DD48", Offset = "0x174DD48", VA = "0x7BBBF4DD48")]
		public PreviewTabInfo(UIToggleButton tb, uint id)
		{
		}

		// Token: 0x04008096 RID: 32918
		[Token(Token = "0x4008096")]
		[FieldOffset(Offset = "0x10")]
		public UIToggleButton tb;

		// Token: 0x04008097 RID: 32919
		[Token(Token = "0x4008097")]
		[FieldOffset(Offset = "0x18")]
		public uint id;

		// Token: 0x04008098 RID: 32920
		[Token(Token = "0x4008098")]
		[FieldOffset(Offset = "0x20")]
		public UIAtlas Atlas;

		// Token: 0x04008099 RID: 32921
		[Token(Token = "0x4008099")]
		[FieldOffset(Offset = "0x28")]
		public string SpriteName;

		// Token: 0x0400809A RID: 32922
		[Token(Token = "0x400809A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite equip;

		// Token: 0x0400809B RID: 32923
		[Token(Token = "0x400809B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject normal;

		// Token: 0x0400809C RID: 32924
		[Token(Token = "0x400809C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite icon;

		// Token: 0x0400809D RID: 32925
		[Token(Token = "0x400809D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite highLight;

		// Token: 0x0400809E RID: 32926
		[Token(Token = "0x400809E")]
		[FieldOffset(Offset = "0x50")]
		public UIButton unDressBtn;
	}
}
