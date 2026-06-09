using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002335 RID: 9013
	[Token(Token = "0x2002335")]
	internal class UIHudPVEBossInfoView : UIBaseView
	{
		// Token: 0x0600C17A RID: 49530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17A")]
		[Address(RVA = "0x17C0C18", Offset = "0x17C0C18", VA = "0x7BBBFC0C18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C17B RID: 49531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C17B")]
		[Address(RVA = "0x17C0D38", Offset = "0x17C0D38", VA = "0x7BBBFC0D38")]
		public UIHudPVEBossInfoView()
		{
		}

		// Token: 0x0400DA8B RID: 55947
		[Token(Token = "0x400DA8B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DA8C RID: 55948
		[Token(Token = "0x400DA8C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel WarningTxt;

		// Token: 0x0400DA8D RID: 55949
		[Token(Token = "0x400DA8D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject EnterWarningInfo;
	}
}
