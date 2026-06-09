using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x0200269B RID: 9883
	[Token(Token = "0x200269B")]
	[Serializable]
	public class ClipEvent
	{
		// Token: 0x0600CCB7 RID: 52407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCB7")]
		[Address(RVA = "0x1B7DBB0", Offset = "0x1B7DBB0", VA = "0x7BBC37DBB0")]
		public ClipEvent()
		{
		}

		// Token: 0x04010082 RID: 65666
		[Token(Token = "0x4010082")]
		[FieldOffset(Offset = "0x10")]
		public AnimEventType m_EventType;

		// Token: 0x04010083 RID: 65667
		[Token(Token = "0x4010083")]
		[FieldOffset(Offset = "0x14")]
		public float m_Time;

		// Token: 0x04010084 RID: 65668
		[Token(Token = "0x4010084")]
		[FieldOffset(Offset = "0x18")]
		public string m_FunctionName;

		// Token: 0x04010085 RID: 65669
		[Token(Token = "0x4010085")]
		[FieldOffset(Offset = "0x20")]
		public string m_StringParameter;

		// Token: 0x04010086 RID: 65670
		[Token(Token = "0x4010086")]
		[FieldOffset(Offset = "0x28")]
		public float m_FloatParameter;

		// Token: 0x04010087 RID: 65671
		[Token(Token = "0x4010087")]
		[FieldOffset(Offset = "0x2C")]
		public int m_IntParameter;

		// Token: 0x04010088 RID: 65672
		[Token(Token = "0x4010088")]
		[FieldOffset(Offset = "0x30")]
		public UnityEngine.Object m_GameObjectParameter;
	}
}
