using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C4 RID: 8900
	[Token(Token = "0x20022C4")]
	public class UIHudEnermyPointView : UIBaseView
	{
		// Token: 0x0600C098 RID: 49304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C098")]
		[Address(RVA = "0x1C03C28", Offset = "0x1C03C28", VA = "0x7BBC403C28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C099 RID: 49305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C099")]
		[Address(RVA = "0x1C03D84", Offset = "0x1C03D84", VA = "0x7BBC403D84")]
		public UIHudEnermyPointView()
		{
		}

		// Token: 0x0400D656 RID: 54870
		[Token(Token = "0x400D656")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EnermyHint;

		// Token: 0x0400D657 RID: 54871
		[Token(Token = "0x400D657")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BanSkillMark;

		// Token: 0x0400D658 RID: 54872
		[Token(Token = "0x400D658")]
		[FieldOffset(Offset = "0x30")]
		public GameObject DeliveryMark;

		// Token: 0x0400D659 RID: 54873
		[Token(Token = "0x400D659")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CuringEnemyMark;
	}
}
