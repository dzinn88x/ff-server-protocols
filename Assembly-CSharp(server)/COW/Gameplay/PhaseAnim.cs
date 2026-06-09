using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026C3 RID: 9923
	[Token(Token = "0x20026C3")]
	[Serializable]
	public class PhaseAnim
	{
		// Token: 0x0600CD92 RID: 52626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD92")]
		[Address(RVA = "0x12E05D0", Offset = "0x12E05D0", VA = "0x7BBBAE05D0")]
		public PhaseAnim()
		{
		}

		// Token: 0x04010139 RID: 65849
		[Token(Token = "0x4010139")]
		[FieldOffset(Offset = "0x10")]
		public yE^UZPY m_PhaseType;

		// Token: 0x0401013A RID: 65850
		[Token(Token = "0x401013A")]
		[FieldOffset(Offset = "0x18")]
		public List<AnimationClip> m_AnimClips;
	}
}
