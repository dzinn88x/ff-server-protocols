using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	[ProtoContract]
	public class GameDrop
	{
		// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x21BA6BC", Offset = "0x21BA6BC", VA = "0x7BBC9BA6BC")]
		public GameDrop()
		{
		}

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B414", Offset = "0x110B414")]
		public uint drop_id;

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B428", Offset = "0x110B428")]
		public Item item;
	}
}
