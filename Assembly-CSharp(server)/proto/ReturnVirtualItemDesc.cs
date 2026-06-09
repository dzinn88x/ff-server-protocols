using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA6 RID: 2726
	[Token(Token = "0x2000AA6")]
	[ProtoContract]
	public class ReturnVirtualItemDesc
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x24A0190", Offset = "0x24A0190", VA = "0x7BBCCA0190")]
		public ReturnVirtualItemDesc()
		{
		}

		// Token: 0x04003317 RID: 13079
		[Token(Token = "0x4003317")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125FA8", Offset = "0x1125FA8")]
		public uint item_id;

		// Token: 0x04003318 RID: 13080
		[Token(Token = "0x4003318")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125FBC", Offset = "0x1125FBC")]
		public EInventory.ItemSourceType source;

		// Token: 0x04003319 RID: 13081
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125FD0", Offset = "0x1125FD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125FD0", Offset = "0x1125FD0")]
		public string region;

		// Token: 0x0400331A RID: 13082
		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126020", Offset = "0x1126020")]
		public EInventory.AwardType return_type;

		// Token: 0x0400331B RID: 13083
		[Token(Token = "0x400331B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126034", Offset = "0x1126034")]
		public uint return_id;

		// Token: 0x0400331C RID: 13084
		[Token(Token = "0x400331C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126048", Offset = "0x1126048")]
		public uint return_num;
	}
}
