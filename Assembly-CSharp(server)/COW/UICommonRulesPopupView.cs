using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002185 RID: 8581
	[Token(Token = "0x2002185")]
	internal class UICommonRulesPopupView : UIBaseView
	{
		// Token: 0x0600BE1A RID: 48666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1A")]
		[Address(RVA = "0x18148C0", Offset = "0x18148C0", VA = "0x7BBC0148C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1B")]
		[Address(RVA = "0x1814A34", Offset = "0x1814A34", VA = "0x7BBC014A34")]
		public UICommonRulesPopupView()
		{
		}

		// Token: 0x0400C7B9 RID: 51129
		[Token(Token = "0x400C7B9")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList TabsContainer;

		// Token: 0x0400C7BA RID: 51130
		[Token(Token = "0x400C7BA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RuleScrollViewPrefab;

		// Token: 0x0400C7BB RID: 51131
		[Token(Token = "0x400C7BB")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnConfirm;

		// Token: 0x0400C7BC RID: 51132
		[Token(Token = "0x400C7BC")]
		[FieldOffset(Offset = "0x38")]
		public UILabel title;
	}
}
