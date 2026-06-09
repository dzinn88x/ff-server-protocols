using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x2000A62")]
	[ProtoContract]
	public class AvatarLevelCardInfo
	{
		// Token: 0x0600276C RID: 10092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x21AF524", Offset = "0x21AF524", VA = "0x7BBC9AF524")]
		public AvatarLevelCardInfo()
		{
		}

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112155C", Offset = "0x112155C")]
		public uint item_id;

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121570", Offset = "0x1121570")]
		public uint max_level;
	}
}
