using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002404 RID: 9220
	[Token(Token = "0x2002404")]
	public class UILobbyWeaponRackItemView : UIBaseView
	{
		// Token: 0x0600C318 RID: 49944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C318")]
		[Address(RVA = "0x19DF1D8", Offset = "0x19DF1D8", VA = "0x7BBC1DF1D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C319")]
		[Address(RVA = "0x19DF534", Offset = "0x19DF534", VA = "0x7BBC1DF534")]
		public UILobbyWeaponRackItemView()
		{
		}

		// Token: 0x0400E33A RID: 58170
		[Token(Token = "0x400E33A")]
		[FieldOffset(Offset = "0x20")]
		public WeaponRackDragDropItem DragDropItem;

		// Token: 0x0400E33B RID: 58171
		[Token(Token = "0x400E33B")]
		[FieldOffset(Offset = "0x28")]
		public UIDragDropContainer DragDropContainer;

		// Token: 0x0400E33C RID: 58172
		[Token(Token = "0x400E33C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ItemButton;

		// Token: 0x0400E33D RID: 58173
		[Token(Token = "0x400E33D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GunRoot;

		// Token: 0x0400E33E RID: 58174
		[Token(Token = "0x400E33E")]
		[FieldOffset(Offset = "0x40")]
		public UISprite GunIcon;

		// Token: 0x0400E33F RID: 58175
		[Token(Token = "0x400E33F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GrenadeRoot;

		// Token: 0x0400E340 RID: 58176
		[Token(Token = "0x400E340")]
		[FieldOffset(Offset = "0x50")]
		public UISprite GrenadeIcon;

		// Token: 0x0400E341 RID: 58177
		[Token(Token = "0x400E341")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Selected;

		// Token: 0x0400E342 RID: 58178
		[Token(Token = "0x400E342")]
		[FieldOffset(Offset = "0x60")]
		public UISprite OtherIcon;

		// Token: 0x0400E343 RID: 58179
		[Token(Token = "0x400E343")]
		[FieldOffset(Offset = "0x68")]
		public UISprite QualityBg;

		// Token: 0x0400E344 RID: 58180
		[Token(Token = "0x400E344")]
		[FieldOffset(Offset = "0x70")]
		public UISprite QulityLine;

		// Token: 0x0400E345 RID: 58181
		[Token(Token = "0x400E345")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Equiped;
	}
}
