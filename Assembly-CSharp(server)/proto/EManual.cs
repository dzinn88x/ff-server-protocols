using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200066E RID: 1646
	[Token(Token = "0x200066E")]
	[ProtoContract]
	public class EManual
	{
		// Token: 0x060023BD RID: 9149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x21B9868", Offset = "0x21B9868", VA = "0x7BBC9B9868")]
		public EManual()
		{
		}

		// Token: 0x0200066F RID: 1647
		[Token(Token = "0x200066F")]
		[ProtoContract]
		public enum State
		{
			// Token: 0x04002072 RID: 8306
			[Token(Token = "0x4002072")]
			State_COLLECTING,
			// Token: 0x04002073 RID: 8307
			[Token(Token = "0x4002073")]
			State_FINISHED,
			// Token: 0x04002074 RID: 8308
			[Token(Token = "0x4002074")]
			State_AWARDED
		}

		// Token: 0x02000670 RID: 1648
		[Token(Token = "0x2000670")]
		[ProtoContract]
		public enum EventType
		{
			// Token: 0x04002076 RID: 8310
			[Token(Token = "0x4002076")]
			EventType_NONE,
			// Token: 0x04002077 RID: 8311
			[Token(Token = "0x4002077")]
			EventType_WEAPON,
			// Token: 0x04002078 RID: 8312
			[Token(Token = "0x4002078")]
			EventType_MAP,
			// Token: 0x04002079 RID: 8313
			[Token(Token = "0x4002079")]
			EventType_SUP,
			// Token: 0x0400207A RID: 8314
			[Token(Token = "0x400207A")]
			EventType_MOV,
			// Token: 0x0400207B RID: 8315
			[Token(Token = "0x400207B")]
			EventType_EVE
		}
	}
}
