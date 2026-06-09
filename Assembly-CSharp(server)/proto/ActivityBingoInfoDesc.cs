using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009FC RID: 2556
	[Token(Token = "0x20009FC")]
	[ProtoContract]
	public class ActivityBingoInfoDesc
	{
		// Token: 0x06002706 RID: 9990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002706")]
		[Address(RVA = "0x21AEA84", Offset = "0x21AEA84", VA = "0x7BBC9AEA84")]
		public ActivityBingoInfoDesc()
		{
		}

		// Token: 0x04002E73 RID: 11891
		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D40C", Offset = "0x111D40C")]
		public uint level;

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D420", Offset = "0x111D420")]
		public uint key_id;

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D434", Offset = "0x111D434")]
		public uint init_key_num;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D448", Offset = "0x111D448")]
		public uint cost_key_num;

		// Token: 0x04002E77 RID: 11895
		[Token(Token = "0x4002E77")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D45C", Offset = "0x111D45C")]
		public uint cost_diamond;

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D470", Offset = "0x111D470")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D470", Offset = "0x111D470")]
		public string start_time;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111D4C0", Offset = "0x111D4C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111D4C0", Offset = "0x111D4C0")]
		public string end_time;
	}
}
