using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B5F RID: 11103
	[Token(Token = "0x2002B5F")]
	public class VehicleInWaterEffectParams : MonoBehaviour
	{
		// Token: 0x0600F4F8 RID: 62712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F8")]
		[Address(RVA = "0x1DE8D0C", Offset = "0x1DE8D0C", VA = "0x7BBC5E8D0C")]
		public VehicleInWaterEffectParams()
		{
		}

		// Token: 0x040119EA RID: 72170
		[Token(Token = "0x40119EA")]
		[FieldOffset(Offset = "0x18")]
		public UpdateEffectParams[] WaterEffects;
	}
}
