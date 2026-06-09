using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020010A7 RID: 4263
	[Token(Token = "0x20010A7")]
	public class LegendClothData : CsvDataIndexedReading, IGetId
	{
		// Token: 0x06004271 RID: 17009 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x6004271")]
		[Address(RVA = "0x14002FC", Offset = "0x14002FC", VA = "0x7BBBC002FC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004272")]
		[Address(RVA = "0x1400304", Offset = "0x1400304", VA = "0x7BBBC00304", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004273")]
		[Address(RVA = "0x1400310", Offset = "0x1400310", VA = "0x7BBBC00310", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x140075C", Offset = "0x140075C", VA = "0x7BBBC0075C", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x1401308", Offset = "0x1401308", VA = "0x7BBBC01308")]
		public LegendClothData()
		{
		}

		// Token: 0x04005169 RID: 20841
		[Token(Token = "0x4005169")]
		[FieldOffset(Offset = "0x10")]
		public uint SetId;

		// Token: 0x0400516A RID: 20842
		[Token(Token = "0x400516A")]
		[FieldOffset(Offset = "0x14")]
		public uint LegentType;

		// Token: 0x0400516B RID: 20843
		[Token(Token = "0x400516B")]
		[FieldOffset(Offset = "0x18")]
		public uint Level;

		// Token: 0x0400516C RID: 20844
		[Token(Token = "0x400516C")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID ParachuteEffectMale;

		// Token: 0x0400516D RID: 20845
		[Token(Token = "0x400516D")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID ParachuteEffectFemale;

		// Token: 0x0400516E RID: 20846
		[Token(Token = "0x400516E")]
		[FieldOffset(Offset = "0x24")]
		public Color ColorVal;

		// Token: 0x0400516F RID: 20847
		[Token(Token = "0x400516F")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID ColorIcon;

		// Token: 0x04005170 RID: 20848
		[Token(Token = "0x4005170")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID ParachuteEffectIcon;

		// Token: 0x04005171 RID: 20849
		[Token(Token = "0x4005171")]
		[FieldOffset(Offset = "0x3C")]
		public ResourceID TeamEffectIcon;

		// Token: 0x04005172 RID: 20850
		[Token(Token = "0x4005172")]
		[FieldOffset(Offset = "0x40")]
		public string Title;

		// Token: 0x04005173 RID: 20851
		[Token(Token = "0x4005173")]
		[FieldOffset(Offset = "0x48")]
		public ResourceID IPTag;

		// Token: 0x04005174 RID: 20852
		[Token(Token = "0x4005174")]
		[FieldOffset(Offset = "0x50")]
		public List<ResourceID> OtherTags;
	}
}
