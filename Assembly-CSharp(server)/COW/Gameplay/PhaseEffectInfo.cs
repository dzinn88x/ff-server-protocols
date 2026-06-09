using System;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002A4C RID: 10828
	[Token(Token = "0x2002A4C")]
	[Serializable]
	public class PhaseEffectInfo
	{
		// Token: 0x0600E8DD RID: 59613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E8DD")]
		[Address(RVA = "0x12E0640", Offset = "0x12E0640", VA = "0x7BBBAE0640")]
		public PhaseEffectInfo()
		{
		}

		// Token: 0x040113A2 RID: 70562
		[Token(Token = "0x40113A2")]
		[FieldOffset(Offset = "0x10")]
		public int Phase;

		// Token: 0x040113A3 RID: 70563
		[Token(Token = "0x40113A3")]
		[FieldOffset(Offset = "0x18")]
		public AIAttachEffects attachEffects;
	}
}
