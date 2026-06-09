using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	[ProtoContract]
	public class ActivenessTimeDesc
	{
		// Token: 0x06002707 RID: 9991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002707")]
		[Address(RVA = "0x21AEA28", Offset = "0x21AEA28", VA = "0x7BBC9AEA28")]
		public ActivenessTimeDesc()
		{
		}

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D510", Offset = "0x111D510")]
		public uint group_id;

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D524", Offset = "0x111D524")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D524", Offset = "0x111D524")]
		public string start_time;

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D574", Offset = "0x111D574")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D574", Offset = "0x111D574")]
		public string end_time;
	}
}
