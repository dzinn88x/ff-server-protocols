using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088D RID: 2189
	[Token(Token = "0x200088D")]
	[ProtoContract]
	public class WeeklyProcessStatus
	{
		// Token: 0x0600259B RID: 9627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259B")]
		[Address(RVA = "0x24A1A38", Offset = "0x24A1A38", VA = "0x7BBCCA1A38")]
		public WeeklyProcessStatus()
		{
		}

		// Token: 0x040028CC RID: 10444
		[Token(Token = "0x40028CC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A38", Offset = "0x1113A38")]
		public uint node_id;

		// Token: 0x040028CD RID: 10445
		[Token(Token = "0x40028CD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A4C", Offset = "0x1113A4C")]
		public EPProcess_Status status;
	}
}
