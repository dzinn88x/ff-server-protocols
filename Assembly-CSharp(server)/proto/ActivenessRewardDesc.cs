using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	[ProtoContract]
	public class ActivenessRewardDesc
	{
		// Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002708")]
		[Address(RVA = "0x21AE92C", Offset = "0x21AE92C", VA = "0x7BBC9AE92C")]
		public ActivenessRewardDesc()
		{
		}

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D5C4", Offset = "0x111D5C4")]
		public uint group_id;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D5D8", Offset = "0x111D5D8")]
		public uint box_id;

		// Token: 0x04002E7F RID: 11903
		[Token(Token = "0x4002E7F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D5EC", Offset = "0x111D5EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D5EC", Offset = "0x111D5EC")]
		public string box;

		// Token: 0x04002E80 RID: 11904
		[Token(Token = "0x4002E80")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D63C", Offset = "0x111D63C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D63C", Offset = "0x111D63C")]
		public string box_icon1;

		// Token: 0x04002E81 RID: 11905
		[Token(Token = "0x4002E81")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D68C", Offset = "0x111D68C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D68C", Offset = "0x111D68C")]
		public string box_icon2;

		// Token: 0x04002E82 RID: 11906
		[Token(Token = "0x4002E82")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D6DC", Offset = "0x111D6DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D6DC", Offset = "0x111D6DC")]
		public string VFX;

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D72C", Offset = "0x111D72C")]
		public uint activeness;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D740", Offset = "0x111D740")]
		public List<AwardDesc> awards;
	}
}
