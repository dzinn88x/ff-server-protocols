using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000962 RID: 2402
	[Token(Token = "0x2000962")]
	[ProtoContract]
	public class CSAccelerateCashPrinterByTokenRes
	{
		// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x21B0098", Offset = "0x21B0098", VA = "0x7BBC9B0098")]
		public CSAccelerateCashPrinterByTokenRes()
		{
		}

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119514", Offset = "0x1119514")]
		public uint deposit;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119528", Offset = "0x1119528")]
		public uint current_speed_from_tokens;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111953C", Offset = "0x111953C")]
		public uint speed_change_time;
	}
}
