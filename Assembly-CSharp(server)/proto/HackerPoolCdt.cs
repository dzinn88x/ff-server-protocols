using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A11 RID: 2577
	[Token(Token = "0x2000A11")]
	[ProtoContract]
	public class HackerPoolCdt
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x21BB1E0", Offset = "0x21BB1E0", VA = "0x7BBC9BB1E0")]
		public HackerPoolCdt()
		{
		}

		// Token: 0x04002F0B RID: 12043
		[Token(Token = "0x4002F0B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E794", Offset = "0x111E794")]
		public EHacker.HackerPoolCdt cdt_type;

		// Token: 0x04002F0C RID: 12044
		[Token(Token = "0x4002F0C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E7A8", Offset = "0x111E7A8")]
		public EHacker.HackerCdtManner cdt_manner;

		// Token: 0x04002F0D RID: 12045
		[Token(Token = "0x4002F0D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E7BC", Offset = "0x111E7BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E7BC", Offset = "0x111E7BC")]
		public string cdt_value;
	}
}
