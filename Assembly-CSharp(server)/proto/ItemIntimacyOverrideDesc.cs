using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABB RID: 2747
	[Token(Token = "0x2000ABB")]
	[ProtoContract]
	public class ItemIntimacyOverrideDesc
	{
		// Token: 0x060027C5 RID: 10181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x21BB76C", Offset = "0x21BB76C", VA = "0x7BBC9BB76C")]
		public ItemIntimacyOverrideDesc()
		{
		}

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11271B4", Offset = "0x11271B4")]
		public uint item_id;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11271C8", Offset = "0x11271C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11271C8", Offset = "0x11271C8")]
		public string item_name;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127218", Offset = "0x1127218")]
		public uint item_intimacy_value;
	}
}
