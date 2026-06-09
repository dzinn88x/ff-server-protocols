using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D56 RID: 7510
	[Token(Token = "0x2001D56")]
	public class AttendaceItemInfo : IComparable<AttendaceItemInfo>
	{
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600A3BA RID: 41914 RVA: 0x0002B488 File Offset: 0x00029688
		// (set) Token: 0x0600A3BB RID: 41915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACB")]
		public uint AttendaceItemID
		{
			[Token(Token = "0x600A3BA")]
			[Address(RVA = "0x15526E0", Offset = "0x15526E0", VA = "0x7BBBD526E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A3C", Offset = "0x1145A3C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A3BB")]
			[Address(RVA = "0x15526E8", Offset = "0x15526E8", VA = "0x7BBBD526E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A4C", Offset = "0x1145A4C")]
			private set
			{
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x0002B4A0 File Offset: 0x000296A0
		// (set) Token: 0x0600A3BD RID: 41917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACC")]
		public bool Signed
		{
			[Token(Token = "0x600A3BC")]
			[Address(RVA = "0x15526F0", Offset = "0x15526F0", VA = "0x7BBBD526F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A3BD")]
			[Address(RVA = "0x1552708", Offset = "0x1552708", VA = "0x7BBBD52708")]
			set
			{
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x0002B4B8 File Offset: 0x000296B8
		// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000ACD")]
		public uint SignState
		{
			[Token(Token = "0x600A3BE")]
			[Address(RVA = "0x1552700", Offset = "0x1552700", VA = "0x7BBBD52700")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A5C", Offset = "0x1145A5C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A3BF")]
			[Address(RVA = "0x1552750", Offset = "0x1552750", VA = "0x7BBBD52750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A6C", Offset = "0x1145A6C")]
			set
			{
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACE")]
		public List<AwardItemInfo> AwardInfoList
		{
			[Token(Token = "0x600A3C0")]
			[Address(RVA = "0x1552758", Offset = "0x1552758", VA = "0x7BBBD52758")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3C1")]
		[Address(RVA = "0x1552760", Offset = "0x1552760", VA = "0x7BBBD52760")]
		public static implicit operator AttendaceItemInfo(AttendanceItem item)
		{
			return null;
		}

		// Token: 0x0600A3C2 RID: 41922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3C2")]
		[Address(RVA = "0x1552964", Offset = "0x1552964", VA = "0x7BBBD52964")]
		public static implicit operator AttendaceItemInfo(NewPlayerRewardItem item)
		{
			return null;
		}

		// Token: 0x0600A3C3 RID: 41923 RVA: 0x0002B4D0 File Offset: 0x000296D0
		[Token(Token = "0x600A3C3")]
		[Address(RVA = "0x1552AF8", Offset = "0x1552AF8", VA = "0x7BBBD52AF8", Slot = "4")]
		public int CompareTo(AttendaceItemInfo other)
		{
			return 0;
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3C4")]
		[Address(RVA = "0x15528F4", Offset = "0x15528F4", VA = "0x7BBBD528F4")]
		public AttendaceItemInfo()
		{
		}

		// Token: 0x0400A9D5 RID: 43477
		[Token(Token = "0x400A9D5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE5C", Offset = "0x112FE5C")]
		private uint <AttendaceItemID>k__BackingField;

		// Token: 0x0400A9D6 RID: 43478
		[Token(Token = "0x400A9D6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE6C", Offset = "0x112FE6C")]
		private uint <SignState>k__BackingField;

		// Token: 0x0400A9D7 RID: 43479
		[Token(Token = "0x400A9D7")]
		[FieldOffset(Offset = "0x18")]
		private List<AwardItemInfo> m_AwardInfoList;

		// Token: 0x02001D57 RID: 7511
		[Token(Token = "0x2001D57")]
		public enum EAttendanceSignState
		{
			// Token: 0x0400A9D9 RID: 43481
			[Token(Token = "0x400A9D9")]
			UnSigned,
			// Token: 0x0400A9DA RID: 43482
			[Token(Token = "0x400A9DA")]
			Signed,
			// Token: 0x0400A9DB RID: 43483
			[Token(Token = "0x400A9DB")]
			NeedSign,
			// Token: 0x0400A9DC RID: 43484
			[Token(Token = "0x400A9DC")]
			Claimed
		}
	}
}
