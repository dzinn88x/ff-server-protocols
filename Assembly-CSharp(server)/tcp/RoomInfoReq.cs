using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	[ProtoContract]
	public class RoomInfoReq
	{
		// Token: 0x0600206D RID: 8301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206D")]
		[Address(RVA = "0x24A66BC", Offset = "0x24A66BC", VA = "0x7BBCCA66BC")]
		public RoomInfoReq()
		{
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0000DE60 File Offset: 0x0000C060
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158180", Offset = "0x1158180")]
		public ulong room_id
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x24A66C4", Offset = "0x24A66C4", VA = "0x7BBCCA66C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138944", Offset = "0x1138944")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x24A66CC", Offset = "0x24A66CC", VA = "0x7BBCCA66CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138954", Offset = "0x1138954")]
			set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0000DE78 File Offset: 0x0000C078
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158194", Offset = "0x1158194")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x24A66D4", Offset = "0x24A66D4", VA = "0x7BBCCA66D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138964", Offset = "0x1138964")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x24A66DC", Offset = "0x24A66DC", VA = "0x7BBCCA66DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138974", Offset = "0x1138974")]
			set
			{
			}
		}

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A64", Offset = "0x1103A64")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A74", Offset = "0x1103A74")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
