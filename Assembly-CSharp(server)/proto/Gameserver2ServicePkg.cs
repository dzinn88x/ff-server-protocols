using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E9 RID: 1513
	[Token(Token = "0x20005E9")]
	[ProtoContract]
	public class Gameserver2ServicePkg
	{
		// Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x21BA960", Offset = "0x21BA960", VA = "0x7BBC9BA960")]
		public Gameserver2ServicePkg()
		{
		}

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106338", Offset = "0x1106338")]
		public EGameServerManager.Proto cmd;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110634C", Offset = "0x110634C")]
		public uint match_mode;

		// Token: 0x04001E34 RID: 7732
		[Token(Token = "0x4001E34")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106360", Offset = "0x1106360")]
		public ulong account_id;

		// Token: 0x04001E35 RID: 7733
		[Token(Token = "0x4001E35")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106374", Offset = "0x1106374")]
		public ulong real_group_id;

		// Token: 0x04001E36 RID: 7734
		[Token(Token = "0x4001E36")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106388", Offset = "0x1106388")]
		public ulong auto_group_id;

		// Token: 0x04001E37 RID: 7735
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110639C", Offset = "0x110639C")]
		public byte[] data;

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11063B0", Offset = "0x11063B0")]
		public uint room_id;
	}
}
