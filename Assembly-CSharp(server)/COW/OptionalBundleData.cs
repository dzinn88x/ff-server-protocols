using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001150 RID: 4432
	[Token(Token = "0x2001150")]
	public class OptionalBundleData : CsvDataIndexedReading
	{
		// Token: 0x06004524 RID: 17700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x203745C", Offset = "0x203745C", VA = "0x7BBC83745C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x2037468", Offset = "0x2037468", VA = "0x7BBC837468", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004526")]
		[Address(RVA = "0x203795C", Offset = "0x203795C", VA = "0x7BBC83795C", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004527")]
		[Address(RVA = "0x203831C", Offset = "0x203831C", VA = "0x7BBC83831C")]
		public OptionalBundleData()
		{
		}

		// Token: 0x040055BE RID: 21950
		[Token(Token = "0x40055BE")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040055BF RID: 21951
		[Token(Token = "0x40055BF")]
		[FieldOffset(Offset = "0x14")]
		public uint Order;

		// Token: 0x040055C0 RID: 21952
		[Token(Token = "0x40055C0")]
		[FieldOffset(Offset = "0x18")]
		public EInventory.AwardType AwardType;

		// Token: 0x040055C1 RID: 21953
		[Token(Token = "0x40055C1")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardID;

		// Token: 0x040055C2 RID: 21954
		[Token(Token = "0x40055C2")]
		[FieldOffset(Offset = "0x20")]
		public uint AwardNum;

		// Token: 0x040055C3 RID: 21955
		[Token(Token = "0x40055C3")]
		[FieldOffset(Offset = "0x24")]
		public uint AwardTime;

		// Token: 0x040055C4 RID: 21956
		[Token(Token = "0x40055C4")]
		[FieldOffset(Offset = "0x28")]
		public EInventory.AwardType ReturnType;

		// Token: 0x040055C5 RID: 21957
		[Token(Token = "0x40055C5")]
		[FieldOffset(Offset = "0x2C")]
		public uint ReturnID;

		// Token: 0x040055C6 RID: 21958
		[Token(Token = "0x40055C6")]
		[FieldOffset(Offset = "0x30")]
		public uint ReturnNum;

		// Token: 0x040055C7 RID: 21959
		[Token(Token = "0x40055C7")]
		[FieldOffset(Offset = "0x34")]
		public bool IsPreview;

		// Token: 0x040055C8 RID: 21960
		[Token(Token = "0x40055C8")]
		[FieldOffset(Offset = "0x38")]
		public uint PreviewAvatar;

		// Token: 0x040055C9 RID: 21961
		[Token(Token = "0x40055C9")]
		[FieldOffset(Offset = "0x3C")]
		public uint DefaultMaleRole;

		// Token: 0x040055CA RID: 21962
		[Token(Token = "0x40055CA")]
		[FieldOffset(Offset = "0x40")]
		public uint DefaultFemaleRole;

		// Token: 0x040055CB RID: 21963
		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0x44")]
		public uint OriginalPrice;
	}
}
