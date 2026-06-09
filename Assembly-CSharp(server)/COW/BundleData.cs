using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020010BA RID: 4282
	[Token(Token = "0x20010BA")]
	public class BundleData : CsvDataIndexedReading
	{
		// Token: 0x060042C9 RID: 17097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x14E814C", Offset = "0x14E814C", VA = "0x7BBBCE814C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x14E8158", Offset = "0x14E8158", VA = "0x7BBBCE8158", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x14E8550", Offset = "0x14E8550", VA = "0x7BBBCE8550", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x14E8D10", Offset = "0x14E8D10", VA = "0x7BBBCE8D10")]
		public BundleData()
		{
		}

		// Token: 0x040051E6 RID: 20966
		[Token(Token = "0x40051E6")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040051E7 RID: 20967
		[Token(Token = "0x40051E7")]
		[FieldOffset(Offset = "0x14")]
		public uint AwardID;

		// Token: 0x040051E8 RID: 20968
		[Token(Token = "0x40051E8")]
		[FieldOffset(Offset = "0x18")]
		public uint AwardNum;

		// Token: 0x040051E9 RID: 20969
		[Token(Token = "0x40051E9")]
		[FieldOffset(Offset = "0x1C")]
		public uint AwardTime;

		// Token: 0x040051EA RID: 20970
		[Token(Token = "0x40051EA")]
		[FieldOffset(Offset = "0x20")]
		public EInventory.AwardType AwardType;

		// Token: 0x040051EB RID: 20971
		[Token(Token = "0x40051EB")]
		[FieldOffset(Offset = "0x24")]
		public bool IsPreview;

		// Token: 0x040051EC RID: 20972
		[Token(Token = "0x40051EC")]
		[FieldOffset(Offset = "0x28")]
		public uint PreviewAvatar;

		// Token: 0x040051ED RID: 20973
		[Token(Token = "0x40051ED")]
		[FieldOffset(Offset = "0x30")]
		public string ImageUrl;

		// Token: 0x040051EE RID: 20974
		[Token(Token = "0x40051EE")]
		[FieldOffset(Offset = "0x38")]
		public EInventory.AwardType ReturnType;

		// Token: 0x040051EF RID: 20975
		[Token(Token = "0x40051EF")]
		[FieldOffset(Offset = "0x3C")]
		public uint ReturnID;

		// Token: 0x040051F0 RID: 20976
		[Token(Token = "0x40051F0")]
		[FieldOffset(Offset = "0x40")]
		public uint ReturnNum;
	}
}
