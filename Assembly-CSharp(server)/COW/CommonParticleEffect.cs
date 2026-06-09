using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012B1 RID: 4785
	[Token(Token = "0x20012B1")]
	internal class CommonParticleEffect : ReusableObject
	{
		// Token: 0x06004AF5 RID: 19189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x15FC0B0", Offset = "0x15FC0B0", VA = "0x7BBBDFC0B0")]
		private void Start()
		{
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x15FC124", Offset = "0x15FC124", VA = "0x7BBBDFC124", Slot = "6")]
		protected virtual void Update()
		{
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00016890 File Offset: 0x00014A90
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x15FC1C0", Offset = "0x15FC1C0", VA = "0x7BBBDFC1C0")]
		public bool IsParticleAlive()
		{
			return default(bool);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x15FC244", Offset = "0x15FC244", VA = "0x7BBBDFC244")]
		public void Play()
		{
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x15FC340", Offset = "0x15FC340", VA = "0x7BBBDFC340")]
		public void Stop()
		{
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x15FC43C", Offset = "0x15FC43C", VA = "0x7BBBDFC43C")]
		public CommonParticleEffect()
		{
		}

		// Token: 0x04007326 RID: 29478
		[Token(Token = "0x4007326")]
		[FieldOffset(Offset = "0x29")]
		public bool AutoDestory;

		// Token: 0x04007327 RID: 29479
		[Token(Token = "0x4007327")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected ParticleSystem[] m_Particles;
	}
}
