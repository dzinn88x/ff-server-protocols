using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000615 RID: 1557
	[Token(Token = "0x2000615")]
	[ProtoContract]
	public class PlatformProfileRes
	{
		// Token: 0x06002390 RID: 9104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x249F520", Offset = "0x249F520", VA = "0x7BBCC9F520")]
		public PlatformProfileRes()
		{
		}

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11077C4", Offset = "0x11077C4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11077C4", Offset = "0x11077C4")]
		public string external_id;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107814", Offset = "0x1107814")]
		public uint external_type;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107828", Offset = "0x1107828")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107828", Offset = "0x1107828")]
		public string external_name;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107878", Offset = "0x1107878")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107878", Offset = "0x1107878")]
		public string external_icon;
	}
}
