using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002405 RID: 9221
	[Token(Token = "0x2002405")]
	public class UILobbyWeaponRackView : UIBaseView
	{
		// Token: 0x0600C31A RID: 49946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31A")]
		[Address(RVA = "0x19DF53C", Offset = "0x19DF53C", VA = "0x7BBC1DF53C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C31B")]
		[Address(RVA = "0x19DF8A8", Offset = "0x19DF8A8", VA = "0x7BBC1DF8A8")]
		public UILobbyWeaponRackView()
		{
		}

		// Token: 0x0400E346 RID: 58182
		[Token(Token = "0x400E346")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Guide;

		// Token: 0x0400E347 RID: 58183
		[Token(Token = "0x400E347")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition RightTween;

		// Token: 0x0400E348 RID: 58184
		[Token(Token = "0x400E348")]
		[FieldOffset(Offset = "0x30")]
		public Transform PopMenuGun;

		// Token: 0x0400E349 RID: 58185
		[Token(Token = "0x400E349")]
		[FieldOffset(Offset = "0x38")]
		public Transform PopMenuRare;

		// Token: 0x0400E34A RID: 58186
		[Token(Token = "0x400E34A")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ScrollView;

		// Token: 0x0400E34B RID: 58187
		[Token(Token = "0x400E34B")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList Grid;

		// Token: 0x0400E34C RID: 58188
		[Token(Token = "0x400E34C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Empty;

		// Token: 0x0400E34D RID: 58189
		[Token(Token = "0x400E34D")]
		[FieldOffset(Offset = "0x58")]
		public UIButton GoShopButton;

		// Token: 0x0400E34E RID: 58190
		[Token(Token = "0x400E34E")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid Slots;

		// Token: 0x0400E34F RID: 58191
		[Token(Token = "0x400E34F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject NaviPage;

		// Token: 0x0400E350 RID: 58192
		[Token(Token = "0x400E350")]
		[FieldOffset(Offset = "0x70")]
		public UIButton HelpBtn;

		// Token: 0x0400E351 RID: 58193
		[Token(Token = "0x400E351")]
		[FieldOffset(Offset = "0x78")]
		public UIButton leaveBtn;
	}
}
