using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay
{
	// Token: 0x020026C4 RID: 9924
	[Token(Token = "0x20026C4")]
	[Serializable]
	public class SkillAnim
	{
		// Token: 0x0600CD93 RID: 52627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD93")]
		[Address(RVA = "0x16C314C", Offset = "0x16C314C", VA = "0x7BBBEC314C")]
		public SkillAnim()
		{
		}

		// Token: 0x0401013B RID: 65851
		[Token(Token = "0x401013B")]
		[FieldOffset(Offset = "0x10")]
		public \u0081}\u0082XTuu m_SkillType;

		// Token: 0x0401013C RID: 65852
		[Token(Token = "0x401013C")]
		[FieldOffset(Offset = "0x18")]
		public List<PhaseAnim> m_PhaseAnims;
	}
}
