using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009BC RID: 2492
	[Token(Token = "0x20009BC")]
	[ProtoContract]
	public class CSStartFFWSGuessingReq
	{
		// Token: 0x060026CA RID: 9930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x21B7700", Offset = "0x21B7700", VA = "0x7BBC9B7700")]
		public CSStartFFWSGuessingReq()
		{
		}

		// Token: 0x04002CBE RID: 11454
		[Token(Token = "0x4002CBE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A9A0", Offset = "0x111A9A0")]
		public uint session;

		// Token: 0x04002CBF RID: 11455
		[Token(Token = "0x4002CBF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A9B4", Offset = "0x111A9B4")]
		public uint team_id;
	}
}
