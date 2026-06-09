using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	[ProtoContract]
	public class CSVeteranTaskTriggerReq
	{
		// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x21B7D64", Offset = "0x21B7D64", VA = "0x7BBC9B7D64")]
		public CSVeteranTaskTriggerReq()
		{
		}

		// Token: 0x04002BB8 RID: 11192
		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11190C8", Offset = "0x11190C8")]
		public uint event_type;

		// Token: 0x04002BB9 RID: 11193
		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11190DC", Offset = "0x11190DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11190DC", Offset = "0x11190DC")]
		public string language;
	}
}
