using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D8 RID: 2520
	[Token(Token = "0x20009D8")]
	[ProtoContract]
	public class LoadoutDesc
	{
		// Token: 0x060026E2 RID: 9954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x21BBE00", Offset = "0x21BBE00", VA = "0x7BBC9BBE00")]
		public LoadoutDesc()
		{
		}

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B724", Offset = "0x111B724")]
		public uint item_id;

		// Token: 0x04002D8B RID: 11659
		[Token(Token = "0x4002D8B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B738", Offset = "0x111B738")]
		public EInventory.LoadoutType type;

		// Token: 0x04002D8C RID: 11660
		[Token(Token = "0x4002D8C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B74C", Offset = "0x111B74C")]
		public uint play_card_id;
	}
}
