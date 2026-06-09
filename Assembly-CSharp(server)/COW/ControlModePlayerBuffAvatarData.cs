using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D7 RID: 4311
	[Token(Token = "0x20010D7")]
	public class ControlModePlayerBuffAvatarData : CSVBaseData
	{
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EC")]
		public uint[] ClothIDs
		{
			[Token(Token = "0x6004344")]
			[Address(RVA = "0x160071C", Offset = "0x160071C", VA = "0x7BBBE0071C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D458", Offset = "0x113D458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004345")]
			[Address(RVA = "0x1600724", Offset = "0x1600724", VA = "0x7BBBE00724")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D468", Offset = "0x113D468")]
			set
			{
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x160072C", Offset = "0x160072C", VA = "0x7BBBE0072C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004347")]
		[Address(RVA = "0x1600738", Offset = "0x1600738", VA = "0x7BBBE00738", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004348")]
		[Address(RVA = "0x160090C", Offset = "0x160090C", VA = "0x7BBBE0090C")]
		public ControlModePlayerBuffAvatarData()
		{
		}

		// Token: 0x040052D5 RID: 21205
		[Token(Token = "0x40052D5")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsFemale;

		// Token: 0x040052D6 RID: 21206
		[Token(Token = "0x40052D6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F33C", Offset = "0x112F33C")]
		private uint[] <ClothIDs>k__BackingField;
	}
}
