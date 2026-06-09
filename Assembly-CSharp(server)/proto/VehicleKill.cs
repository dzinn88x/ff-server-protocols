using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	[ProtoContract]
	public class VehicleKill
	{
		// Token: 0x060023AC RID: 9132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x24A1440", Offset = "0x24A1440", VA = "0x7BBCCA1440")]
		public VehicleKill()
		{
		}

		// Token: 0x04001FB2 RID: 8114
		[Token(Token = "0x4001FB2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108354", Offset = "0x1108354")]
		public uint vehicle_id;

		// Token: 0x04001FB3 RID: 8115
		[Token(Token = "0x4001FB3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108368", Offset = "0x1108368")]
		public uint cnt;
	}
}
