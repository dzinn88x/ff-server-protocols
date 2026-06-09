using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002125 RID: 8485
	[Token(Token = "0x2002125")]
	public class UIBroadcastView : UIBaseView
	{
		// Token: 0x0600BD5A RID: 48474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5A")]
		[Address(RVA = "0x1C1CEB4", Offset = "0x1C1CEB4", VA = "0x7BBC41CEB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD5B")]
		[Address(RVA = "0x1C1CFD4", Offset = "0x1C1CFD4", VA = "0x7BBC41CFD4")]
		public UIBroadcastView()
		{
		}

		// Token: 0x0400C2FA RID: 49914
		[Token(Token = "0x400C2FA")]
		[FieldOffset(Offset = "0x20")]
		public Transform Notice;

		// Token: 0x0400C2FB RID: 49915
		[Token(Token = "0x400C2FB")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RollNoticeBtn;

		// Token: 0x0400C2FC RID: 49916
		[Token(Token = "0x400C2FC")]
		[FieldOffset(Offset = "0x30")]
		public RollNoticeView RollMessage;
	}
}
