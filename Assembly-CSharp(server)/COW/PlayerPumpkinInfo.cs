using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015FF RID: 5631
	[Token(Token = "0x20015FF")]
	public class PlayerPumpkinInfo : MonoBehaviour
	{
		// Token: 0x06006479 RID: 25721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006479")]
		[Address(RVA = "0x1EFEDA0", Offset = "0x1EFEDA0", VA = "0x7BBC6FEDA0")]
		public void SetNum(int num)
		{
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647A")]
		[Address(RVA = "0x1EFEE6C", Offset = "0x1EFEE6C", VA = "0x7BBC6FEE6C")]
		public PlayerPumpkinInfo()
		{
		}

		// Token: 0x040082ED RID: 33517
		[Token(Token = "0x40082ED")]
		[FieldOffset(Offset = "0x18")]
		public UILabel NumLabel;

		// Token: 0x040082EE RID: 33518
		[Token(Token = "0x40082EE")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurNum;
	}
}
