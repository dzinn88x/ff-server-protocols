using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	[ProtoContract]
	public class RoomIDReq
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x24A6430", Offset = "0x24A6430", VA = "0x7BBCCA6430")]
		public RoomIDReq()
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0000E760 File Offset: 0x0000C960
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C48", Offset = "0x1158C48")]
		public ulong room_id
		{
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x24A6438", Offset = "0x24A6438", VA = "0x7BBCCA6438")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139744", Offset = "0x1139744")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600215D")]
			[Address(RVA = "0x24A6440", Offset = "0x24A6440", VA = "0x7BBCCA6440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139754", Offset = "0x1139754")]
			set
			{
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0000E778 File Offset: 0x0000C978
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C5C", Offset = "0x1158C5C")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x600215E")]
			[Address(RVA = "0x24A6448", Offset = "0x24A6448", VA = "0x7BBCCA6448")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139764", Offset = "0x1139764")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x24A6450", Offset = "0x24A6450", VA = "0x7BBCCA6450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139774", Offset = "0x1139774")]
			set
			{
			}
		}

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104164", Offset = "0x1104164")]
		private ulong <room_id>k__BackingField;

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104174", Offset = "0x1104174")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
