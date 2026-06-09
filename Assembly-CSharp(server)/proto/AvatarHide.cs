using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5E RID: 2654
	[Token(Token = "0x2000A5E")]
	[ProtoContract]
	public class AvatarHide
	{
		// Token: 0x06002768 RID: 10088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x21AF4A8", Offset = "0x21AF4A8", VA = "0x7BBC9AF4A8")]
		public AvatarHide()
		{
		}

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112132C", Offset = "0x112132C")]
		public uint avatar_id;

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121340", Offset = "0x1121340")]
		public long start_time;

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121354", Offset = "0x1121354")]
		public long end_time;
	}
}
