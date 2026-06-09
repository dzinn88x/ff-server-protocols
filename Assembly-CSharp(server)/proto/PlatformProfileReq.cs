using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	[ProtoContract]
	public class PlatformProfileReq
	{
		// Token: 0x0600238F RID: 9103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x249F4C4", Offset = "0x249F4C4", VA = "0x7BBCC9F4C4")]
		public PlatformProfileReq()
		{
		}

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107710", Offset = "0x1107710")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107710", Offset = "0x1107710")]
		public string token;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107760", Offset = "0x1107760")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107760", Offset = "0x1107760")]
		public string external_id;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11077B0", Offset = "0x11077B0")]
		public uint platform_sdk_id;
	}
}
