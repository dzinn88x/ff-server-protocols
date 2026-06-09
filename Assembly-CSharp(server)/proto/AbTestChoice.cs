using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	[ProtoContract]
	public class AbTestChoice
	{
		// Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233F")]
		[Address(RVA = "0x21AE314", Offset = "0x21AE314", VA = "0x7BBC9AE314")]
		public AbTestChoice()
		{
		}

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F24", Offset = "0x1104F24")]
		public uint type;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F38", Offset = "0x1104F38")]
		public uint val;
	}
}
