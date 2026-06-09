using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098C RID: 2444
	[Token(Token = "0x200098C")]
	[ProtoContract]
	public class CSGetSuperFighterSettingRes
	{
		// Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x21B5DD4", Offset = "0x21B5DD4", VA = "0x7BBC9B5DD4")]
		public CSGetSuperFighterSettingRes()
		{
		}

		// Token: 0x04002C3D RID: 11325
		[Token(Token = "0x4002C3D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119D5C", Offset = "0x1119D5C")]
		public SuperFighterSettingDesc setting_desc;

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119D70", Offset = "0x1119D70")]
		public List<SuperFighterBoxingDesc> boxing_descs;

		// Token: 0x04002C3F RID: 11327
		[Token(Token = "0x4002C3F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119D84", Offset = "0x1119D84")]
		public List<SuperFighterEnemyDesc> enemy_descs;
	}
}
