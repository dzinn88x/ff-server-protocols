using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	[ProtoContract]
	public class RoomStateNtf
	{
		// Token: 0x06002093 RID: 8339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x24A6F08", Offset = "0x24A6F08", VA = "0x7BBCCA6F08")]
		public RoomStateNtf()
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158360", Offset = "0x1158360")]
		public ulong room_id
		{
			[Token(Token = "0x6002094")]
			[Address(RVA = "0x24A6F10", Offset = "0x24A6F10", VA = "0x7BBCCA6F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B84", Offset = "0x1138B84")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x24A6F18", Offset = "0x24A6F18", VA = "0x7BBCCA6F18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B94", Offset = "0x1138B94")]
			set
			{
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158374", Offset = "0x1158374")]
		public uint state
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x24A6F20", Offset = "0x24A6F20", VA = "0x7BBCCA6F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BA4", Offset = "0x1138BA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x24A6F28", Offset = "0x24A6F28", VA = "0x7BBCCA6F28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BB4", Offset = "0x1138BB4")]
			set
			{
			}
		}

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B84", Offset = "0x1103B84")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B94", Offset = "0x1103B94")]
		private uint <state>k__BackingField;
	}
}
