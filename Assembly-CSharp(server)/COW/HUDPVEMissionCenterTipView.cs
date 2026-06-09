using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020BE RID: 8382
	[Token(Token = "0x20020BE")]
	internal class HUDPVEMissionCenterTipView : UIBaseView
	{
		// Token: 0x0600BC8D RID: 48269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8D")]
		[Address(RVA = "0x18580C4", Offset = "0x18580C4", VA = "0x7BBC0580C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8E")]
		[Address(RVA = "0x18581B4", Offset = "0x18581B4", VA = "0x7BBC0581B4")]
		public HUDPVEMissionCenterTipView()
		{
		}

		// Token: 0x0400BD3B RID: 48443
		[Token(Token = "0x400BD3B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400BD3C RID: 48444
		[Token(Token = "0x400BD3C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ContentLabel;
	}
}
