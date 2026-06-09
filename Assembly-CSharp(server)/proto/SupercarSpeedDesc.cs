using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	[ProtoContract]
	public class SupercarSpeedDesc
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x24A0C48", Offset = "0x24A0C48", VA = "0x7BBCCA0C48")]
		public SupercarSpeedDesc()
		{
		}

		// Token: 0x0400364B RID: 13899
		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C6C8", Offset = "0x112C6C8")]
		public uint id;

		// Token: 0x0400364C RID: 13900
		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C6DC", Offset = "0x112C6DC")]
		public uint item_id;

		// Token: 0x0400364D RID: 13901
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C6F0", Offset = "0x112C6F0")]
		public uint speed;

		// Token: 0x0400364E RID: 13902
		[Token(Token = "0x400364E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112C704", Offset = "0x112C704")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C704", Offset = "0x112C704")]
		public string icon;

		// Token: 0x0400364F RID: 13903
		[Token(Token = "0x400364F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C754", Offset = "0x112C754")]
		public uint gopos;

		// Token: 0x04003650 RID: 13904
		[Token(Token = "0x4003650")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C768", Offset = "0x112C768")]
		public uint sub_gopos;
	}
}
