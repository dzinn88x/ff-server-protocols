using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	[ProtoContract]
	public class ActivityDataProtectDesc
	{
		// Token: 0x0600270B RID: 9995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x21AEBBC", Offset = "0x21AEBBC", VA = "0x7BBC9AEBBC")]
		public ActivityDataProtectDesc()
		{
		}

		// Token: 0x04002E93 RID: 11923
		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DA4C", Offset = "0x111DA4C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111DA4C", Offset = "0x111DA4C")]
		public string region;

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111DA9C", Offset = "0x111DA9C")]
		public bool is_open;
	}
}
