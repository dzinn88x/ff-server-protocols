using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002277 RID: 8823
	[Token(Token = "0x2002277")]
	internal class UIHudBattleFlagView : UIBaseView
	{
		// Token: 0x0600BFFF RID: 49151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFFF")]
		[Address(RVA = "0x1893874", Offset = "0x1893874", VA = "0x7BBC093874", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C000 RID: 49152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C000")]
		[Address(RVA = "0x1893910", Offset = "0x1893910", VA = "0x7BBC093910")]
		public UIHudBattleFlagView()
		{
		}

		// Token: 0x0400D3DD RID: 54237
		[Token(Token = "0x400D3DD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnBattleFlag;
	}
}
