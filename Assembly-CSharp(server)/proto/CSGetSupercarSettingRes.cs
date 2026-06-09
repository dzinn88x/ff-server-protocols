using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000993 RID: 2451
	[Token(Token = "0x2000993")]
	[ProtoContract]
	public class CSGetSupercarSettingRes
	{
		// Token: 0x060026A1 RID: 9889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x21B5EE4", Offset = "0x21B5EE4", VA = "0x7BBC9B5EE4")]
		public CSGetSupercarSettingRes()
		{
		}

		// Token: 0x04002C50 RID: 11344
		[Token(Token = "0x4002C50")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F14", Offset = "0x1119F14")]
		public SupercarSettingDesc supercar_setting;

		// Token: 0x04002C51 RID: 11345
		[Token(Token = "0x4002C51")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F28", Offset = "0x1119F28")]
		public List<SupercarSpeedDesc> cars;

		// Token: 0x04002C52 RID: 11346
		[Token(Token = "0x4002C52")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119F3C", Offset = "0x1119F3C")]
		public List<SupercarRoundAward> awards;
	}
}
