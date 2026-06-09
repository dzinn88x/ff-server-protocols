using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020BF RID: 8383
	[Token(Token = "0x20020BF")]
	internal class HUDPVEMissionItemView : UIBaseView
	{
		// Token: 0x0600BC8F RID: 48271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8F")]
		[Address(RVA = "0x18581BC", Offset = "0x18581BC", VA = "0x7BBC0581BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC90")]
		[Address(RVA = "0x18582AC", Offset = "0x18582AC", VA = "0x7BBC0582AC")]
		public HUDPVEMissionItemView()
		{
		}

		// Token: 0x0400BD3D RID: 48445
		[Token(Token = "0x400BD3D")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Container;

		// Token: 0x0400BD3E RID: 48446
		[Token(Token = "0x400BD3E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ContentLabel;
	}
}
