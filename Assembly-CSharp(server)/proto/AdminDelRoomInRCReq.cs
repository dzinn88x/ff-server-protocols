using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000686 RID: 1670
	[Token(Token = "0x2000686")]
	[ProtoContract]
	public class AdminDelRoomInRCReq
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x21AEE24", Offset = "0x21AEE24", VA = "0x7BBC9AEE24")]
		public AdminDelRoomInRCReq()
		{
		}

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108A98", Offset = "0x1108A98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108A98", Offset = "0x1108A98")]
		public string region;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108AE8", Offset = "0x1108AE8")]
		public ulong room_id;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108AFC", Offset = "0x1108AFC")]
		public uint room_type;
	}
}
