using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A26 RID: 2598
	[Token(Token = "0x2000A26")]
	[ProtoContract]
	public class NewPlayerLevelUpTasksDesc
	{
		// Token: 0x06002730 RID: 10032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x249E9BC", Offset = "0x249E9BC", VA = "0x7BBCC9E9BC")]
		public NewPlayerLevelUpTasksDesc()
		{
		}

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F284", Offset = "0x111F284")]
		public uint task_id;

		// Token: 0x04002F58 RID: 12120
		[Token(Token = "0x4002F58")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F298", Offset = "0x111F298")]
		public EActivity.ConditionType cdt_type;

		// Token: 0x04002F59 RID: 12121
		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F2AC", Offset = "0x111F2AC")]
		public uint cdt_value;

		// Token: 0x04002F5A RID: 12122
		[Token(Token = "0x4002F5A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F2C0", Offset = "0x111F2C0")]
		public List<AwardDesc> awards;
	}
}
