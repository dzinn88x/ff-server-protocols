using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x200099F")]
	[ProtoContract]
	public class CSGetBooyahChessConfigRes
	{
		// Token: 0x060026AD RID: 9901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AD")]
		[Address(RVA = "0x21B26C8", Offset = "0x21B26C8", VA = "0x7BBC9B26C8")]
		public CSGetBooyahChessConfigRes()
		{
		}

		// Token: 0x04002C79 RID: 11385
		[Token(Token = "0x4002C79")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A248", Offset = "0x111A248")]
		public List<BooyahChessZoneDesc> zones;

		// Token: 0x04002C7A RID: 11386
		[Token(Token = "0x4002C7A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A25C", Offset = "0x111A25C")]
		public BooyahChessSettingDesc setting;

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A270", Offset = "0x111A270")]
		public List<BooyahChessWeaponDesc> weapons;
	}
}
