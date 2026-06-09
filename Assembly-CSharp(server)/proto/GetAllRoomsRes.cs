using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	[ProtoContract]
	public class GetAllRoomsRes
	{
		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x21BA970", Offset = "0x21BA970", VA = "0x7BBC9BA970")]
		public GetAllRoomsRes()
		{
		}

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11089E4", Offset = "0x11089E4")]
		public List<RoomBasicInfo> rooms;
	}
}
