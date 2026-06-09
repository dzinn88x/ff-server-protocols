using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002134 RID: 8500
	[Token(Token = "0x2002134")]
	public class UIChampionshipNoticeDotView : UIBaseView
	{
		// Token: 0x0600BD78 RID: 48504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD78")]
		[Address(RVA = "0x1EC80C4", Offset = "0x1EC80C4", VA = "0x7BBC6C80C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD79")]
		[Address(RVA = "0x1EC81B4", Offset = "0x1EC81B4", VA = "0x7BBC6C81B4")]
		public UIChampionshipNoticeDotView()
		{
		}

		// Token: 0x0400C3A1 RID: 50081
		[Token(Token = "0x400C3A1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject dotEnable;

		// Token: 0x0400C3A2 RID: 50082
		[Token(Token = "0x400C3A2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject dotDisable;
	}
}
