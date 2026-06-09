using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	[ProtoContract]
	public class CSActivityTriggerReq
	{
		// Token: 0x060024D3 RID: 9427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x21B0280", Offset = "0x21B0280", VA = "0x7BBC9B0280")]
		public CSActivityTriggerReq()
		{
		}

		// Token: 0x04002611 RID: 9745
		[Token(Token = "0x4002611")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EFEC", Offset = "0x110EFEC")]
		public uint event_type;

		// Token: 0x04002612 RID: 9746
		[Token(Token = "0x4002612")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F000", Offset = "0x110F000")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F000", Offset = "0x110F000")]
		public string language;
	}
}
