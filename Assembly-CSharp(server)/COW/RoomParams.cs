using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001E3C RID: 7740
	[Token(Token = "0x2001E3C")]
	internal class RoomParams
	{
		// Token: 0x0600A927 RID: 43303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A927")]
		[Address(RVA = "0x1B32008", Offset = "0x1B32008", VA = "0x7BBC332008")]
		public RoomParams()
		{
		}

		// Token: 0x0400AEA3 RID: 44707
		[Token(Token = "0x400AEA3")]
		[FieldOffset(Offset = "0x10")]
		public uint configID;

		// Token: 0x0400AEA4 RID: 44708
		[Token(Token = "0x400AEA4")]
		[FieldOffset(Offset = "0x14")]
		public uint group;

		// Token: 0x0400AEA5 RID: 44709
		[Token(Token = "0x400AEA5")]
		[FieldOffset(Offset = "0x18")]
		public uint member;

		// Token: 0x0400AEA6 RID: 44710
		[Token(Token = "0x400AEA6")]
		[FieldOffset(Offset = "0x1C")]
		public uint spectator;

		// Token: 0x0400AEA7 RID: 44711
		[Token(Token = "0x400AEA7")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0400AEA8 RID: 44712
		[Token(Token = "0x400AEA8")]
		[FieldOffset(Offset = "0x28")]
		public string code;

		// Token: 0x0400AEA9 RID: 44713
		[Token(Token = "0x400AEA9")]
		[FieldOffset(Offset = "0x30")]
		public bool enableSpectate;

		// Token: 0x0400AEAA RID: 44714
		[Token(Token = "0x400AEAA")]
		[FieldOffset(Offset = "0x34")]
		public uint roomType;

		// Token: 0x0400AEAB RID: 44715
		[Token(Token = "0x400AEAB")]
		[FieldOffset(Offset = "0x38")]
		public uint visualStyle;

		// Token: 0x0400AEAC RID: 44716
		[Token(Token = "0x400AEAC")]
		[FieldOffset(Offset = "0x3C")]
		public uint setting;

		// Token: 0x0400AEAD RID: 44717
		[Token(Token = "0x400AEAD")]
		[FieldOffset(Offset = "0x40")]
		public uint setting2;

		// Token: 0x0400AEAE RID: 44718
		[Token(Token = "0x400AEAE")]
		[FieldOffset(Offset = "0x44")]
		public bool emulatorCheck;

		// Token: 0x0400AEAF RID: 44719
		[Token(Token = "0x400AEAF")]
		[FieldOffset(Offset = "0x45")]
		public bool contestantRoleCheck;

		// Token: 0x0400AEB0 RID: 44720
		[Token(Token = "0x400AEB0")]
		[FieldOffset(Offset = "0x46")]
		public bool roomDataInherit;
	}
}
