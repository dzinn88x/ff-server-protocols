using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A91 RID: 10897
	[Token(Token = "0x2002A91")]
	[Serializable]
	public class ActSkillPhaseConfig
	{
		// Token: 0x0600EECA RID: 61130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EECA")]
		[Address(RVA = "0x1881ED0", Offset = "0x1881ED0", VA = "0x7BBC081ED0")]
		public ActSkillPhaseConfig()
		{
		}

		// Token: 0x04011607 RID: 71175
		[Token(Token = "0x4011607")]
		[FieldOffset(Offset = "0x10")]
		public swXlqcd PhaseType;

		// Token: 0x04011608 RID: 71176
		[Token(Token = "0x4011608")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x1131764", Offset = "0x1131764")]
		public bool m_IsFinishingPhase;

		// Token: 0x04011609 RID: 71177
		[Token(Token = "0x4011609")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x113179C", Offset = "0x113179C")]
		public float m_MoveSpeedScale;

		// Token: 0x0401160A RID: 71178
		[Token(Token = "0x401160A")]
		[FieldOffset(Offset = "0x1C")]
		public float m_PhaseDuration;

		// Token: 0x0401160B RID: 71179
		[Token(Token = "0x401160B")]
		[FieldOffset(Offset = "0x20")]
		public string m_AnimName;

		// Token: 0x0401160C RID: 71180
		[Token(Token = "0x401160C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TextAreaAttribute", RVA = "0x11317D4", Offset = "0x11317D4")]
		public string m_CustomParams;

		// Token: 0x0401160D RID: 71181
		[Token(Token = "0x401160D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x11317EC", Offset = "0x11317EC")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x11317EC", Offset = "0x11317EC")]
		public bool m_IsSetAutoNextPhaseManually;

		// Token: 0x0401160E RID: 71182
		[Token(Token = "0x401160E")]
		[FieldOffset(Offset = "0x34")]
		public int m_AutoNextPhaseIndex;

		// Token: 0x0401160F RID: 71183
		[Token(Token = "0x401160F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x113184C", Offset = "0x113184C")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x113184C", Offset = "0x113184C")]
		public bool m_IsSupportCombo;

		// Token: 0x04011610 RID: 71184
		[Token(Token = "0x4011610")]
		[FieldOffset(Offset = "0x3C")]
		public int m_ComboNextPhaseIndex;

		// Token: 0x04011611 RID: 71185
		[Token(Token = "0x4011611")]
		[FieldOffset(Offset = "0x40")]
		public float m_ComboTriggerStartTime;

		// Token: 0x04011612 RID: 71186
		[Token(Token = "0x4011612")]
		[FieldOffset(Offset = "0x44")]
		public float m_comboTriggerEndTime;

		// Token: 0x04011613 RID: 71187
		[Token(Token = "0x4011613")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x11318AC", Offset = "0x11318AC")]
		public bool IsUseSkillAutoMove;

		// Token: 0x04011614 RID: 71188
		[Token(Token = "0x4011614")]
		[FieldOffset(Offset = "0x4C")]
		public float AutoMoveMAXSpeed;

		// Token: 0x04011615 RID: 71189
		[Token(Token = "0x4011615")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve AutoMoveSpeedCurve;

		// Token: 0x04011616 RID: 71190
		[Token(Token = "0x4011616")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x11318E4", Offset = "0x11318E4")]
		public float AutoMoveMAXSpeedY;

		// Token: 0x04011617 RID: 71191
		[Token(Token = "0x4011617")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve AutoMoveSpeedYCurve;
	}
}
