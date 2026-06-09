using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	[ProtoContract]
	public class locationKill
	{
		// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x24A1C64", Offset = "0x24A1C64", VA = "0x7BBCCA1C64")]
		public locationKill()
		{
		}

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B3EC", Offset = "0x110B3EC")]
		public uint trigger_name;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B400", Offset = "0x110B400")]
		public uint kills;
	}
}
