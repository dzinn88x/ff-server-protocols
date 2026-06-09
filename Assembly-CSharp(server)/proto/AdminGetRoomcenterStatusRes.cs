using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000685 RID: 1669
	[Token(Token = "0x2000685")]
	[ProtoContract]
	public class AdminGetRoomcenterStatusRes
	{
		// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x21AEE80", Offset = "0x21AEE80", VA = "0x7BBC9AEE80")]
		public AdminGetRoomcenterStatusRes()
		{
		}

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108A5C", Offset = "0x1108A5C")]
		public uint room_node_cnt;

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108A70", Offset = "0x1108A70")]
		public List<VersionInfo> versions;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108A84", Offset = "0x1108A84")]
		public bool is_roomcenter_ready;
	}
}
