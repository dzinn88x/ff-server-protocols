using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BF8 RID: 7160
	[Token(Token = "0x2001BF8")]
	public interface IVoucher
	{
		// Token: 0x06009B9D RID: 39837
		[Token(Token = "0x6009B9D")]
		UIVoucherController OpenVoucherController(Transform parent);

		// Token: 0x06009B9E RID: 39838
		[Token(Token = "0x6009B9E")]
		void OnVoucherItemClick(params object[] data);

		// Token: 0x06009B9F RID: 39839
		[Token(Token = "0x6009B9F")]
		UIVoucherItemController OpenVoucherItemController(Transform parent);
	}
}
