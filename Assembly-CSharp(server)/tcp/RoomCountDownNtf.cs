using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000526 RID: 1318
	[Token(Token = "0x2000526")]
	[ProtoContract]
	public class RoomCountDownNtf
	{
		// Token: 0x06002174 RID: 8564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002174")]
		[Address(RVA = "0x24A609C", Offset = "0x24A609C", VA = "0x7BBCCA609C")]
		public RoomCountDownNtf()
		{
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158DB0", Offset = "0x1158DB0")]
		public uint count_down_seconds
		{
			[Token(Token = "0x6002175")]
			[Address(RVA = "0x24A60A4", Offset = "0x24A60A4", VA = "0x7BBCCA60A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139884", Offset = "0x1139884")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002176")]
			[Address(RVA = "0x24A60AC", Offset = "0x24A60AC", VA = "0x7BBCCA60AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139894", Offset = "0x1139894")]
			set
			{
			}
		}

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104204", Offset = "0x1104204")]
		private uint <count_down_seconds>k__BackingField;
	}
}
