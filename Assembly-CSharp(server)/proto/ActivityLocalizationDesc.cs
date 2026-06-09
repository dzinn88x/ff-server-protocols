using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	[ProtoContract]
	public class ActivityLocalizationDesc
	{
		// Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002702")]
		[Address(RVA = "0x21AEDB4", Offset = "0x21AEDB4", VA = "0x7BBC9AEDB4")]
		public ActivityLocalizationDesc()
		{
		}

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CBC4", Offset = "0x111CBC4")]
		public uint activity_id;

		// Token: 0x04002E51 RID: 11857
		[Token(Token = "0x4002E51")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CBD8", Offset = "0x111CBD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CBD8", Offset = "0x111CBD8")]
		public string act_title;

		// Token: 0x04002E52 RID: 11858
		[Token(Token = "0x4002E52")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CC28", Offset = "0x111CC28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CC28", Offset = "0x111CC28")]
		public string act_text;

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CC78", Offset = "0x111CC78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CC78", Offset = "0x111CC78")]
		public string image_url;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CCC8", Offset = "0x111CCC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CCC8", Offset = "0x111CCC8")]
		public string image_url_for_lobby;

		// Token: 0x04002E55 RID: 11861
		[Token(Token = "0x4002E55")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CD18", Offset = "0x111CD18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CD18", Offset = "0x111CD18")]
		public string award_context;

		// Token: 0x04002E56 RID: 11862
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CD68", Offset = "0x111CD68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CD68", Offset = "0x111CD68")]
		public string language;

		// Token: 0x04002E57 RID: 11863
		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CDB8", Offset = "0x111CDB8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CDB8", Offset = "0x111CDB8")]
		public string image_url_for_top_up;
	}
}
