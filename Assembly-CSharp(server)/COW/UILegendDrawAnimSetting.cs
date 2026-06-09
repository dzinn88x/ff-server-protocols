using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001832 RID: 6194
	[Token(Token = "0x2001832")]
	public class UILegendDrawAnimSetting : MonoBehaviour
	{
		// Token: 0x0600791C RID: 31004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600791C")]
		[Address(RVA = "0x1CB4B84", Offset = "0x1CB4B84", VA = "0x7BBC4B4B84")]
		public UILegendDrawAnimSetting()
		{
		}

		// Token: 0x04008E9F RID: 36511
		[Token(Token = "0x4008E9F")]
		[FieldOffset(Offset = "0x18")]
		public float TotalTime;

		// Token: 0x04008EA0 RID: 36512
		[Token(Token = "0x4008EA0")]
		[FieldOffset(Offset = "0x1C")]
		public float StayTimeAfterAnimEnd;

		// Token: 0x04008EA1 RID: 36513
		[Token(Token = "0x4008EA1")]
		[FieldOffset(Offset = "0x20")]
		public int PrizeListLength;
	}
}
