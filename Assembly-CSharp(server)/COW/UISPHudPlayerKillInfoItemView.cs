using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002524 RID: 9508
	[Token(Token = "0x2002524")]
	public class UISPHudPlayerKillInfoItemView : UIBaseView
	{
		// Token: 0x0600C558 RID: 50520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C558")]
		[Address(RVA = "0x1EEE208", Offset = "0x1EEE208", VA = "0x7BBC6EE208", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C559")]
		[Address(RVA = "0x1EEE320", Offset = "0x1EEE320", VA = "0x7BBC6EE320")]
		public UISPHudPlayerKillInfoItemView()
		{
		}

		// Token: 0x0400F2FD RID: 62205
		[Token(Token = "0x400F2FD")]
		[FieldOffset(Offset = "0x20")]
		public UILabel PlayerName;

		// Token: 0x0400F2FE RID: 62206
		[Token(Token = "0x400F2FE")]
		[FieldOffset(Offset = "0x28")]
		public UISprite WeaponIcon;

		// Token: 0x0400F2FF RID: 62207
		[Token(Token = "0x400F2FF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HeadIcon;
	}
}
