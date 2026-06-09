using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F7 RID: 8951
	[Token(Token = "0x20022F7")]
	internal class UIHudJetFlyView : UIBaseView
	{
		// Token: 0x0600C0FE RID: 49406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FE")]
		[Address(RVA = "0x1C4D390", Offset = "0x1C4D390", VA = "0x7BBC44D390", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FF")]
		[Address(RVA = "0x1C4D51C", Offset = "0x1C4D51C", VA = "0x7BBC44D51C")]
		public UIHudJetFlyView()
		{
		}

		// Token: 0x0400D7E1 RID: 55265
		[Token(Token = "0x400D7E1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnJetFly;

		// Token: 0x0400D7E2 RID: 55266
		[Token(Token = "0x400D7E2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BtnSprite;

		// Token: 0x0400D7E3 RID: 55267
		[Token(Token = "0x400D7E3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite EnergyBar;

		// Token: 0x0400D7E4 RID: 55268
		[Token(Token = "0x400D7E4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite EnergyBar2;

		// Token: 0x0400D7E5 RID: 55269
		[Token(Token = "0x400D7E5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BtnName;
	}
}
