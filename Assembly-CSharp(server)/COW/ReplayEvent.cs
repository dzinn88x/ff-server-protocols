using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x020012B5 RID: 4789
	[Token(Token = "0x20012B5")]
	[Serializable]
	internal class ReplayEvent
	{
		// Token: 0x06004B0D RID: 19213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B0D")]
		[Address(RVA = "0x1759C98", Offset = "0x1759C98", VA = "0x7BBBF59C98")]
		public ReplayEvent()
		{
		}

		// Token: 0x0400733E RID: 29502
		[Token(Token = "0x400733E")]
		[FieldOffset(Offset = "0x10")]
		public \u0081fXogCG Event;

		// Token: 0x0400733F RID: 29503
		[Token(Token = "0x400733F")]
		[FieldOffset(Offset = "0x14")]
		public uint PlayerID;

		// Token: 0x04007340 RID: 29504
		[Token(Token = "0x4007340")]
		[FieldOffset(Offset = "0x18")]
		public float Time;

		// Token: 0x04007341 RID: 29505
		[Token(Token = "0x4007341")]
		[FieldOffset(Offset = "0x1C")]
		public float FParam;

		// Token: 0x04007342 RID: 29506
		[Token(Token = "0x4007342")]
		[FieldOffset(Offset = "0x20")]
		public string SParam;
	}
}
