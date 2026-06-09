using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002260 RID: 8800
	[Token(Token = "0x2002260")]
	public class UIHudAOHLevelUpHintView : UIBaseView
	{
		// Token: 0x0600BFD1 RID: 49105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD1")]
		[Address(RVA = "0x1D6506C", Offset = "0x1D6506C", VA = "0x7BBC56506C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD2")]
		[Address(RVA = "0x1D6515C", Offset = "0x1D6515C", VA = "0x7BBC56515C")]
		public UIHudAOHLevelUpHintView()
		{
		}

		// Token: 0x0400D35D RID: 54109
		[Token(Token = "0x400D35D")]
		[FieldOffset(Offset = "0x20")]
		public UISprite HeadLevelIcon;

		// Token: 0x0400D35E RID: 54110
		[Token(Token = "0x400D35E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ScoreLabel;
	}
}
