using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001144 RID: 4420
	[Token(Token = "0x2001144")]
	public class ManualWeaponData : CSVBaseData
	{
		// Token: 0x060044FD RID: 17661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x1A56650", Offset = "0x1A56650", VA = "0x7BBC256650", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x1A5665C", Offset = "0x1A5665C", VA = "0x7BBC25665C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x1A5699C", Offset = "0x1A5699C", VA = "0x7BBC25699C")]
		public ManualWeaponData()
		{
		}

		// Token: 0x04005541 RID: 21825
		[Token(Token = "0x4005541")]
		[FieldOffset(Offset = "0x10")]
		public string UnlockIcon;

		// Token: 0x04005542 RID: 21826
		[Token(Token = "0x4005542")]
		[FieldOffset(Offset = "0x18")]
		public string LabelPic1;

		// Token: 0x04005543 RID: 21827
		[Token(Token = "0x4005543")]
		[FieldOffset(Offset = "0x20")]
		public string LabelText1;

		// Token: 0x04005544 RID: 21828
		[Token(Token = "0x4005544")]
		[FieldOffset(Offset = "0x28")]
		public string NameKey;

		// Token: 0x04005545 RID: 21829
		[Token(Token = "0x4005545")]
		[FieldOffset(Offset = "0x30")]
		public string IntroKey;

		// Token: 0x04005546 RID: 21830
		[Token(Token = "0x4005546")]
		[FieldOffset(Offset = "0x38")]
		public string SubTitle;

		// Token: 0x04005547 RID: 21831
		[Token(Token = "0x4005547")]
		[FieldOffset(Offset = "0x40")]
		public uint EventID;

		// Token: 0x04005548 RID: 21832
		[Token(Token = "0x4005548")]
		[FieldOffset(Offset = "0x44")]
		public uint PageID;

		// Token: 0x04005549 RID: 21833
		[Token(Token = "0x4005549")]
		[FieldOffset(Offset = "0x48")]
		public uint LocationID;

		// Token: 0x0400554A RID: 21834
		[Token(Token = "0x400554A")]
		[FieldOffset(Offset = "0x4C")]
		public uint SubTitleID;

		// Token: 0x0400554B RID: 21835
		[Token(Token = "0x400554B")]
		[FieldOffset(Offset = "0x50")]
		public bool Link;
	}
}
