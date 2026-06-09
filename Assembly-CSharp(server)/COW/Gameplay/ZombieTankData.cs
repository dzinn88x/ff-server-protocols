using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A50 RID: 10832
	[Token(Token = "0x2002A50")]
	internal class ZombieTankData : MonoBehaviour
	{
		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E8E5")]
		[Address(RVA = "0x13BE5AC", Offset = "0x13BE5AC", VA = "0x7BBBBBE5AC")]
		public NetworkAIPawnAnimComponent GetAnimComponent(}un[rs~ XRbNVZh)
		{
			return null;
		}

		// Token: 0x0600E8E6 RID: 59622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8E6")]
		[Address(RVA = "0x13BE6D4", Offset = "0x13BE6D4", VA = "0x7BBBBBE6D4")]
		public ZombieTankData()
		{
		}

		// Token: 0x040113AC RID: 70572
		[Token(Token = "0x40113AC")]
		[FieldOffset(Offset = "0x18")]
		public GameObject ShieldObj;

		// Token: 0x040113AD RID: 70573
		[Token(Token = "0x40113AD")]
		[FieldOffset(Offset = "0x20")]
		public List<ZombieTankAnimComponentInfo> ExtraAnimComponents;
	}
}
