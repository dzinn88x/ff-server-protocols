using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B46 RID: 2886
	[Token(Token = "0x2000B46")]
	[ProtoContract]
	public class AndroidApplicationToDetectDesc
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x21AEF5C", Offset = "0x21AEF5C", VA = "0x7BBC9AEF5C")]
		public AndroidApplicationToDetectDesc()
		{
		}

		// Token: 0x040036C8 RID: 14024
		[Token(Token = "0x40036C8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D5B4", Offset = "0x112D5B4")]
		public uint id;

		// Token: 0x040036C9 RID: 14025
		[Token(Token = "0x40036C9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D5C8", Offset = "0x112D5C8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D5C8", Offset = "0x112D5C8")]
		public string bundle_identifier;
	}
}
