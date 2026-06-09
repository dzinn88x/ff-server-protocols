using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A92 RID: 10898
	[Token(Token = "0x2002A92")]
	public class InspectorActSkillConfig : ScriptableObject
	{
		// Token: 0x0600EECB RID: 61131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EECB")]
		[Address(RVA = "0x194363C", Offset = "0x194363C", VA = "0x7BBC14363C")]
		public InspectorActSkillConfig()
		{
		}

		// Token: 0x04011618 RID: 71192
		[Token(Token = "0x4011618")]
		[FieldOffset(Offset = "0x18")]
		public [JfMv\u0082} m_SkillType;

		// Token: 0x04011619 RID: 71193
		[Token(Token = "0x4011619")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x113191C", Offset = "0x113191C")]
		public bool m_IsComboInputSkill;

		// Token: 0x0401161A RID: 71194
		[Token(Token = "0x401161A")]
		[FieldOffset(Offset = "0x1D")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1131954", Offset = "0x1131954")]
		public bool m_IsForceCastSkill;

		// Token: 0x0401161B RID: 71195
		[Token(Token = "0x401161B")]
		[FieldOffset(Offset = "0x20")]
		public float m_CoolDown;

		// Token: 0x0401161C RID: 71196
		[Token(Token = "0x401161C")]
		[FieldOffset(Offset = "0x24")]
		public bool m_IsLockPlayerMove;

		// Token: 0x0401161D RID: 71197
		[Token(Token = "0x401161D")]
		[FieldOffset(Offset = "0x25")]
		public bool m_IsLockPlayerJump;

		// Token: 0x0401161E RID: 71198
		[Token(Token = "0x401161E")]
		[FieldOffset(Offset = "0x26")]
		public bool IsLockAimRotationUpdate;

		// Token: 0x0401161F RID: 71199
		[Token(Token = "0x401161F")]
		[FieldOffset(Offset = "0x27")]
		public bool IsForwardFollowAimRot;

		// Token: 0x04011620 RID: 71200
		[Token(Token = "0x4011620")]
		[FieldOffset(Offset = "0x28")]
		public bool IsFowardFollowMoveDirection;

		// Token: 0x04011621 RID: 71201
		[Token(Token = "0x4011621")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x113198C", Offset = "0x113198C")]
		public List<ActSkillPhaseConfig> m_PhaseConfig;
	}
}
