using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007A3 RID: 1955
	[Token(Token = "0x20007A3")]
	[ProtoContract]
	public class CSGetTreasureBoxPRReq
	{
		// Token: 0x060024B2 RID: 9394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024B2")]
		[Address(RVA = "0x21B5F88", Offset = "0x21B5F88", VA = "0x7BBC9B5F88")]
		public CSGetTreasureBoxPRReq()
		{
		}

		// Token: 0x040025C0 RID: 9664
		[Token(Token = "0x40025C0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E678", Offset = "0x110E678")]
		public uint treasure_id;

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E68C", Offset = "0x110E68C")]
		public uint box_type;
	}
}
