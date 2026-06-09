using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200094A RID: 2378
	[Token(Token = "0x200094A")]
	[ProtoContract]
	public class CSGetVeteranTaskBigPrizeReq
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x21B6188", Offset = "0x21B6188", VA = "0x7BBC9B6188")]
		public CSGetVeteranTaskBigPrizeReq()
		{
		}

		// Token: 0x04002BBA RID: 11194
		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111912C", Offset = "0x111912C")]
		public EAttendance.VeteranClass veteran_class;

		// Token: 0x04002BBB RID: 11195
		[Token(Token = "0x4002BBB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119140", Offset = "0x1119140")]
		public uint big_prize_id;
	}
}
