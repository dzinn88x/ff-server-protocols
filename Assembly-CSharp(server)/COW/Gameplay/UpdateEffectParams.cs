using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B5E RID: 11102
	[Token(Token = "0x2002B5E")]
	[Serializable]
	public class UpdateEffectParams
	{
		// Token: 0x0600F4F6 RID: 62710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F6")]
		[Address(RVA = "0x1DCB6C4", Offset = "0x1DCB6C4", VA = "0x7BBC5CB6C4")]
		public void xY\u007FfCbs(float tjREevq)
		{
		}

		// Token: 0x0600F4F7 RID: 62711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F4F7")]
		[Address(RVA = "0x1DCB980", Offset = "0x1DCB980", VA = "0x7BBC5CB980")]
		public UpdateEffectParams()
		{
		}

		// Token: 0x040119DF RID: 72159
		[Token(Token = "0x40119DF")]
		[FieldOffset(Offset = "0x10")]
		public GameObject GameObject;

		// Token: 0x040119E0 RID: 72160
		[Token(Token = "0x40119E0")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem Effect;

		// Token: 0x040119E1 RID: 72161
		[Token(Token = "0x40119E1")]
		[FieldOffset(Offset = "0x20")]
		public bool UpdateStartSize;

		// Token: 0x040119E2 RID: 72162
		[Token(Token = "0x40119E2")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 MinSpeedStartSize;

		// Token: 0x040119E3 RID: 72163
		[Token(Token = "0x40119E3")]
		[FieldOffset(Offset = "0x2C")]
		public Vector2 MaxSpeedStartSize;

		// Token: 0x040119E4 RID: 72164
		[Token(Token = "0x40119E4")]
		[FieldOffset(Offset = "0x34")]
		public bool UpdateRotationBySpeed;

		// Token: 0x040119E5 RID: 72165
		[Token(Token = "0x40119E5")]
		[FieldOffset(Offset = "0x38")]
		public float MinSpeedVelocity;

		// Token: 0x040119E6 RID: 72166
		[Token(Token = "0x40119E6")]
		[FieldOffset(Offset = "0x3C")]
		public float MaxSpeedVelocity;

		// Token: 0x040119E7 RID: 72167
		[Token(Token = "0x40119E7")]
		[FieldOffset(Offset = "0x40")]
		public bool UpdateVelocityX;

		// Token: 0x040119E8 RID: 72168
		[Token(Token = "0x40119E8")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 MinSpeedVelocityX;

		// Token: 0x040119E9 RID: 72169
		[Token(Token = "0x40119E9")]
		[FieldOffset(Offset = "0x4C")]
		public Vector2 MaxSpeedVelocityX;
	}
}
