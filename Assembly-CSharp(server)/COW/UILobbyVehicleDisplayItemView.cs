using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002402 RID: 9218
	[Token(Token = "0x2002402")]
	public class UILobbyVehicleDisplayItemView : UIBaseView
	{
		// Token: 0x0600C314 RID: 49940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C314")]
		[Address(RVA = "0x19DC0DC", Offset = "0x19DC0DC", VA = "0x7BBC1DC0DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C315")]
		[Address(RVA = "0x19DC2D4", Offset = "0x19DC2D4", VA = "0x7BBC1DC2D4")]
		public UILobbyVehicleDisplayItemView()
		{
		}

		// Token: 0x0400E328 RID: 58152
		[Token(Token = "0x400E328")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemButton;

		// Token: 0x0400E329 RID: 58153
		[Token(Token = "0x400E329")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Quality;

		// Token: 0x0400E32A RID: 58154
		[Token(Token = "0x400E32A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite QualityBG;

		// Token: 0x0400E32B RID: 58155
		[Token(Token = "0x400E32B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject gray;

		// Token: 0x0400E32C RID: 58156
		[Token(Token = "0x400E32C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject effectBg;

		// Token: 0x0400E32D RID: 58157
		[Token(Token = "0x400E32D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite VehicleSprite;

		// Token: 0x0400E32E RID: 58158
		[Token(Token = "0x400E32E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HL;
	}
}
