using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000995 RID: 2453
	[Token(Token = "0x2000995")]
	[ProtoContract]
	public class CSTokenToAccelerateSupercarRes
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x21B7A8C", Offset = "0x21B7A8C", VA = "0x7BBC9B7A8C")]
		public CSTokenToAccelerateSupercarRes()
		{
		}

		// Token: 0x04002C5A RID: 11354
		[Token(Token = "0x4002C5A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119FDC", Offset = "0x1119FDC")]
		public uint drive_sum;

		// Token: 0x04002C5B RID: 11355
		[Token(Token = "0x4002C5B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119FF0", Offset = "0x1119FF0")]
		public uint cur_exchange_tokens;

		// Token: 0x04002C5C RID: 11356
		[Token(Token = "0x4002C5C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A004", Offset = "0x111A004")]
		public long speed_change_time;
	}
}
