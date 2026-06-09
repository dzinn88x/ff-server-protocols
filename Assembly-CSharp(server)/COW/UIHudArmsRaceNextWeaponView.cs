using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226A RID: 8810
	[Token(Token = "0x200226A")]
	public class UIHudArmsRaceNextWeaponView : UIBaseView
	{
		// Token: 0x0600BFE5 RID: 49125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE5")]
		[Address(RVA = "0x1886B94", Offset = "0x1886B94", VA = "0x7BBC086B94", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE6")]
		[Address(RVA = "0x1886D8C", Offset = "0x1886D8C", VA = "0x7BBC086D8C")]
		public UIHudArmsRaceNextWeaponView()
		{
		}

		// Token: 0x0400D38C RID: 54156
		[Token(Token = "0x400D38C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoContainer;

		// Token: 0x0400D38D RID: 54157
		[Token(Token = "0x400D38D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject arrow;

		// Token: 0x0400D38E RID: 54158
		[Token(Token = "0x400D38E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WeaponIcon;

		// Token: 0x0400D38F RID: 54159
		[Token(Token = "0x400D38F")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid NumGrid;

		// Token: 0x0400D390 RID: 54160
		[Token(Token = "0x400D390")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TenSprite;

		// Token: 0x0400D391 RID: 54161
		[Token(Token = "0x400D391")]
		[FieldOffset(Offset = "0x48")]
		public UISprite UnitSprite;
	}
}
