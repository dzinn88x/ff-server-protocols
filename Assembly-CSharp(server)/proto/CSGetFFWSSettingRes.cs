using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009BA RID: 2490
	[Token(Token = "0x20009BA")]
	[ProtoContract]
	public class CSGetFFWSSettingRes
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x21B3558", Offset = "0x21B3558", VA = "0x7BBC9B3558")]
		public CSGetFFWSSettingRes()
		{
		}

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A874", Offset = "0x111A874")]
		public FFWSSettingDesc setting;

		// Token: 0x04002CB6 RID: 11446
		[Token(Token = "0x4002CB6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A888", Offset = "0x111A888")]
		public List<FFWSTeamInfoDesc> team_infos;

		// Token: 0x04002CB7 RID: 11447
		[Token(Token = "0x4002CB7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A89C", Offset = "0x111A89C")]
		public List<FFWSGuessingAwardDesc> awards;

		// Token: 0x04002CB8 RID: 11448
		[Token(Token = "0x4002CB8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A8B0", Offset = "0x111A8B0")]
		public List<FFWSDailyTaskTextDesc> daily_task;

		// Token: 0x04002CB9 RID: 11449
		[Token(Token = "0x4002CB9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A8C4", Offset = "0x111A8C4")]
		public List<FFWSSpecialTaskTextDesc> special_task;
	}
}
