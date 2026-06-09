using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001152 RID: 4434
	[Token(Token = "0x2001152")]
	public class PaymentConfigDataManager : SingletonModule<PaymentConfigDataManager>
	{
		// Token: 0x0600452B RID: 17707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x204B490", Offset = "0x204B490", VA = "0x7BBC84B490", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x204B4F0", Offset = "0x204B4F0", VA = "0x7BBC84B4F0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x000151B0 File Offset: 0x000133B0
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x204B730", Offset = "0x204B730", VA = "0x7BBC84B730")]
		private int SortByWeight(PaymentConfigData a, PaymentConfigData b)
		{
			return 0;
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x600452E")]
		[Address(RVA = "0x204B77C", Offset = "0x204B77C", VA = "0x7BBC84B77C")]
		public UIModelPayment.PaymentButtonStyle GetStyleByID(int index)
		{
			return (UIModelPayment.PaymentButtonStyle)0;
		}

		// Token: 0x0600452F RID: 17711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452F")]
		[Address(RVA = "0x204B82C", Offset = "0x204B82C", VA = "0x7BBC84B82C")]
		public PaymentConfigDataManager()
		{
		}

		// Token: 0x040055D6 RID: 21974
		[Token(Token = "0x40055D6")]
		[FieldOffset(Offset = "0x18")]
		private List<uint> m_PaymentButtonStylesSort;
	}
}
