using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002554 RID: 9556
	[Token(Token = "0x2002554")]
	public class UIStandardTabView : UIBaseView
	{
		// Token: 0x0600C5B8 RID: 50616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B8")]
		[Address(RVA = "0x213379C", Offset = "0x213379C", VA = "0x7BBC93379C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5B9 RID: 50617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5B9")]
		[Address(RVA = "0x2133910", Offset = "0x2133910", VA = "0x7BBC933910")]
		public UIStandardTabView()
		{
		}

		// Token: 0x0400F4E2 RID: 62690
		[Token(Token = "0x400F4E2")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel TabPanel;

		// Token: 0x0400F4E3 RID: 62691
		[Token(Token = "0x400F4E3")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ScrollView;

		// Token: 0x0400F4E4 RID: 62692
		[Token(Token = "0x400F4E4")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList EasyList;

		// Token: 0x0400F4E5 RID: 62693
		[Token(Token = "0x400F4E5")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget LeftBG;
	}
}
