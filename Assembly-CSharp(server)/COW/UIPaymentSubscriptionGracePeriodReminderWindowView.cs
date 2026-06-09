using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247D RID: 9341
	[Token(Token = "0x200247D")]
	public class UIPaymentSubscriptionGracePeriodReminderWindowView : UIBaseView
	{
		// Token: 0x0600C40A RID: 50186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40A")]
		[Address(RVA = "0x1F32944", Offset = "0x1F32944", VA = "0x7BBC732944", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40B")]
		[Address(RVA = "0x1F32A34", Offset = "0x1F32A34", VA = "0x7BBC732A34")]
		public UIPaymentSubscriptionGracePeriodReminderWindowView()
		{
		}

		// Token: 0x0400EAA2 RID: 60066
		[Token(Token = "0x400EAA2")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ConfirmButton;

		// Token: 0x0400EAA3 RID: 60067
		[Token(Token = "0x400EAA3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelButton;
	}
}
