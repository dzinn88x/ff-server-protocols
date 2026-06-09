using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FE RID: 9214
	[Token(Token = "0x20023FE")]
	internal class UILobbyMapContainerView : UIBaseView
	{
		// Token: 0x0600C30C RID: 49932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30C")]
		[Address(RVA = "0x1442CF8", Offset = "0x1442CF8", VA = "0x7BBBC42CF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30D")]
		[Address(RVA = "0x1442EF0", Offset = "0x1442EF0", VA = "0x7BBBC42EF0")]
		public UILobbyMapContainerView()
		{
		}

		// Token: 0x0400E22B RID: 57899
		[Token(Token = "0x400E22B")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid MapModesContainer;

		// Token: 0x0400E22C RID: 57900
		[Token(Token = "0x400E22C")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButtonGroup MapModesGroup;

		// Token: 0x0400E22D RID: 57901
		[Token(Token = "0x400E22D")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ContainerBGCollider;

		// Token: 0x0400E22E RID: 57902
		[Token(Token = "0x400E22E")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ContainerBG;

		// Token: 0x0400E22F RID: 57903
		[Token(Token = "0x400E22F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnCustomRoomTest;

		// Token: 0x0400E230 RID: 57904
		[Token(Token = "0x400E230")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget CustomRoomWidget;
	}
}
