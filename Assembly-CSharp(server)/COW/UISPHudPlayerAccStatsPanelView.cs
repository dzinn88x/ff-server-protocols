using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002523 RID: 9507
	[Token(Token = "0x2002523")]
	internal class UISPHudPlayerAccStatsPanelView : UIBaseView
	{
		// Token: 0x0600C556 RID: 50518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C556")]
		[Address(RVA = "0x1EED658", Offset = "0x1EED658", VA = "0x7BBC6ED658", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C557 RID: 50519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C557")]
		[Address(RVA = "0x1EED870", Offset = "0x1EED870", VA = "0x7BBC6ED870")]
		public UISPHudPlayerAccStatsPanelView()
		{
		}

		// Token: 0x0400F2F6 RID: 62198
		[Token(Token = "0x400F2F6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400F2F7 RID: 62199
		[Token(Token = "0x400F2F7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DamageGo;

		// Token: 0x0400F2F8 RID: 62200
		[Token(Token = "0x400F2F8")]
		[FieldOffset(Offset = "0x30")]
		public UISPHudPlayerAccStatsItemView DamageView;

		// Token: 0x0400F2F9 RID: 62201
		[Token(Token = "0x400F2F9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HeadShotGo;

		// Token: 0x0400F2FA RID: 62202
		[Token(Token = "0x400F2FA")]
		[FieldOffset(Offset = "0x40")]
		public UISPHudPlayerAccStatsItemView HeadShotView;

		// Token: 0x0400F2FB RID: 62203
		[Token(Token = "0x400F2FB")]
		[FieldOffset(Offset = "0x48")]
		public GameObject KillGo;

		// Token: 0x0400F2FC RID: 62204
		[Token(Token = "0x400F2FC")]
		[FieldOffset(Offset = "0x50")]
		public UISPHudPlayerAccStatsItemView KillVIew;
	}
}
