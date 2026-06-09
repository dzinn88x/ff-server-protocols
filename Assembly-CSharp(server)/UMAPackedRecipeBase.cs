using System;
using Il2CppDummyDll;
using UMA;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public abstract class UMAPackedRecipeBase : UMARecipeBase
{
	// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x2607378", Offset = "0x2607378", VA = "0x7BBCE07378", Slot = "4")]
	public override void Load(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000900")]
	[Address(RVA = "0x2607BF4", Offset = "0x2607BF4", VA = "0x7BBCE07BF4", Slot = "5")]
	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	// Token: 0x06000901 RID: 2305
	[Token(Token = "0x6000901")]
	public abstract UMAPackedRecipeBase.UMAPackRecipe PackedLoad(UMAContext context);

	// Token: 0x06000902 RID: 2306
	[Token(Token = "0x6000902")]
	public abstract void PackedSave(UMAPackedRecipeBase.UMAPackRecipe packedRecipe, UMAContext context);

	// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000903")]
	[Address(RVA = "0x2607C54", Offset = "0x2607C54", VA = "0x7BBCE07C54")]
	public static UMAPackedRecipeBase.UMAPackRecipe PackRecipeV2(UMAData.UMARecipe umaRecipe)
	{
		return null;
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000904")]
	[Address(RVA = "0x2608A64", Offset = "0x2608A64", VA = "0x7BBCE08A64")]
	public static UMAData.UMARecipe UnpackRecipeVersion2(UMAPackedRecipeBase.UMAPackRecipe umaPackRecipe, UMAContext context)
	{
		return null;
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000905")]
	[Address(RVA = "0x26073B4", Offset = "0x26073B4", VA = "0x7BBCE073B4")]
	public static void UnpackRecipeVersion2(UMAData.UMARecipe umaRecipe, UMAPackedRecipeBase.UMAPackRecipe umaPackRecipe, UMAContext context)
	{
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000906")]
	[Address(RVA = "0x26096BC", Offset = "0x26096BC", VA = "0x7BBCE096BC")]
	private static OverlayData InstantiateOverlay(UMAContext context, SlotData tempSlotData, string id)
	{
		return null;
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000907")]
	[Address(RVA = "0x2609874", Offset = "0x2609874", VA = "0x7BBCE09874")]
	protected UMAPackedRecipeBase()
	{
	}

	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[Serializable]
	public class packedSlotData
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x260A0CC", Offset = "0x260A0CC", VA = "0x7BBCE0A0CC")]
		public packedSlotData()
		{
		}

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x10")]
		public string slotID;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x18")]
		public int overlayScale;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x1C")]
		public int copyOverlayIndex;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x20")]
		public UMAPackedRecipeBase.packedOverlayData[] OverlayDataList;
	}

	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Serializable]
	public class packedOverlayData
	{
		// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x260A0C4", Offset = "0x260A0C4", VA = "0x7BBCE0A0C4")]
		public packedOverlayData()
		{
		}

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x10")]
		public string overlayID;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x18")]
		public int[] colorList;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x20")]
		public int[][] channelMaskList;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x28")]
		public int[][] channelAdditiveMaskList;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x30")]
		public int[] rectList;
	}

	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[Serializable]
	public class PackedSlotDataV2
	{
		// Token: 0x0600090A RID: 2314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2608A1C", Offset = "0x2608A1C", VA = "0x7BBCE08A1C")]
		public PackedSlotDataV2()
		{
		}

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x18")]
		public int scale;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x1C")]
		public int copyIdx;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x20")]
		public UMAPackedRecipeBase.PackedOverlayDataV2[] overlays;
	}

	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	[Serializable]
	public class PackedOverlayDataV2
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x2608A5C", Offset = "0x2608A5C", VA = "0x7BBCE08A5C")]
		public PackedOverlayDataV2()
		{
		}

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x18")]
		public int colorIdx;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x20")]
		public int[] rect;
	}

	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	[Serializable]
	public class PackedOverlayColorDataV2
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2609884", Offset = "0x2609884", VA = "0x7BBCE09884")]
		public PackedOverlayColorDataV2()
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x26098F8", Offset = "0x26098F8", VA = "0x7BBCE098F8")]
		public PackedOverlayColorDataV2(OverlayColorData colorData)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2608F9C", Offset = "0x2608F9C", VA = "0x7BBCE08F9C")]
		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x18")]
		public byte[] color;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x20")]
		public byte[][] masks;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x28")]
		public byte[][] addMasks;
	}

	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	[Serializable]
	public class PackedOverlayColorDataV3
	{
		// Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x260A020", Offset = "0x260A020", VA = "0x7BBCE0A020")]
		public PackedOverlayColorDataV3()
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x25F9CA4", Offset = "0x25F9CA4", VA = "0x7BBCDF9CA4")]
		public PackedOverlayColorDataV3(OverlayColorData colorData)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2608AE0", Offset = "0x2608AE0", VA = "0x7BBCE08AE0")]
		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x18")]
		public short[] colors;
	}

	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	[Serializable]
	public class UMAPackRecipe
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2608934", Offset = "0x2608934", VA = "0x7BBCE08934")]
		public static bool ArrayHasData(Array array)
		{
			return default(bool);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2608958", Offset = "0x2608958", VA = "0x7BBCE08958")]
		public static bool SlotIsValid(SlotData slotData)
		{
			return default(bool);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x260A094", Offset = "0x260A094", VA = "0x7BBCE0A094")]
		public static bool SlotIsValid(UMAPackedRecipeBase.packedSlotData packedSlotData)
		{
			return default(bool);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x2608A2C", Offset = "0x2608A2C", VA = "0x7BBCE08A2C")]
		public static bool SlotIsValid(UMAPackedRecipeBase.PackedSlotDataV2 packedSlot)
		{
			return default(bool);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x26097D0", Offset = "0x26097D0", VA = "0x7BBCE097D0")]
		public static bool MaterialIsValid(UMAMaterial material)
		{
			return default(bool);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2608898", Offset = "0x2608898", VA = "0x7BBCE08898")]
		public static bool RaceIsValid(RaceData raceData)
		{
			return default(bool);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2608888", Offset = "0x2608888", VA = "0x7BBCE08888")]
		public UMAPackRecipe()
		{
		}

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x10")]
		public int version;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x18")]
		public UMAPackedRecipeBase.packedSlotData[] packedSlotDataList;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x20")]
		public UMAPackedRecipeBase.PackedSlotDataV2[] slotsV2;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x28")]
		public UMAPackedRecipeBase.PackedOverlayColorDataV2[] colors;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x30")]
		public UMAPackedRecipeBase.PackedOverlayColorDataV3[] fColors;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x38")]
		public int sharedColorCount;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x40")]
		public string race;
	}
}
