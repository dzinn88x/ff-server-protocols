using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BF9 RID: 7161
	[Token(Token = "0x2001BF9")]
	public class UIVoucher : MonoBehaviour
	{
		// Token: 0x06009BA0 RID: 39840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA0")]
		[Address(RVA = "0x1683D44", Offset = "0x1683D44", VA = "0x7BBBE83D44")]
		public void InitVoucher(IVoucher voucher, EInventory.CurrencyType currencyType, int totalPrice)
		{
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA1")]
		[Address(RVA = "0x1683D78", Offset = "0x1683D78", VA = "0x7BBBE83D78")]
		public void InitVoucher(IVoucher voucher, int totalGemsPrice, int totalCoinsPrice)
		{
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA2")]
		[Address(RVA = "0x16840E4", Offset = "0x16840E4", VA = "0x7BBBE840E4")]
		public UIVoucher()
		{
		}

		// Token: 0x0400A1D6 RID: 41430
		[Token(Token = "0x400A1D6")]
		[FieldOffset(Offset = "0x18")]
		private IVoucher m_Voucher;
	}
}
