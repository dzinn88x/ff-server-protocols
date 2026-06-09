using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	[ProtoContract]
	public class BroadcastMessage
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002564")]
		[Address(RVA = "0x21AFF00", Offset = "0x21AFF00", VA = "0x7BBC9AFF00")]
		public BroadcastMessage()
		{
		}

		// Token: 0x040027C2 RID: 10178
		[Token(Token = "0x40027C2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112304", Offset = "0x1112304")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112304", Offset = "0x1112304")]
		public string nickname;

		// Token: 0x040027C3 RID: 10179
		[Token(Token = "0x40027C3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112354", Offset = "0x1112354")]
		public EAnnouncement.NavigationType navigation_type;

		// Token: 0x040027C4 RID: 10180
		[Token(Token = "0x40027C4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112368", Offset = "0x1112368")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1112368", Offset = "0x1112368")]
		public string source;

		// Token: 0x040027C5 RID: 10181
		[Token(Token = "0x40027C5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11123B8", Offset = "0x11123B8")]
		public uint item_id;

		// Token: 0x040027C6 RID: 10182
		[Token(Token = "0x40027C6")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11123CC", Offset = "0x11123CC")]
		public long time_stamp;

		// Token: 0x040027C7 RID: 10183
		[Token(Token = "0x40027C7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11123E0", Offset = "0x11123E0")]
		public uint source_id;

		// Token: 0x040027C8 RID: 10184
		[Token(Token = "0x40027C8")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11123F4", Offset = "0x11123F4")]
		public uint left_expire_time;
	}
}
