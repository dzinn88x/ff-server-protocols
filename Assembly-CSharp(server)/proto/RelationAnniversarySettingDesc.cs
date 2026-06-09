using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB7 RID: 2743
	[Token(Token = "0x2000AB7")]
	[ProtoContract]
	public class RelationAnniversarySettingDesc
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x24A0064", Offset = "0x24A0064", VA = "0x7BBCCA0064")]
		public RelationAnniversarySettingDesc()
		{
		}

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F48", Offset = "0x1126F48")]
		public uint idx;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F5C", Offset = "0x1126F5C")]
		public EFriend.RelationType relation_type;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F70", Offset = "0x1126F70")]
		public uint anniversary_day;
	}
}
