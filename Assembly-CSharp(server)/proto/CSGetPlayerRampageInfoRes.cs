using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	[ProtoContract]
	public class CSGetPlayerRampageInfoRes
	{
		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x21B560C", Offset = "0x21B560C", VA = "0x7BBC9B560C")]
		public CSGetPlayerRampageInfoRes()
		{
		}

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119424", Offset = "0x1119424")]
		public ulong account_id;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119438", Offset = "0x1119438")]
		public ELimitedEvent.RampageFaction faction;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111944C", Offset = "0x111944C")]
		public ulong rampage_points;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119460", Offset = "0x1119460")]
		public uint rampage_rank;
	}
}
