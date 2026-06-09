using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UMACharacterSystem;
using UnityEngine;

// Token: 0x02000196 RID: 406
[Token(Token = "0x2000196")]
public class UMATextRecipe : UMAPackedRecipeBase, IUintId
{
	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000865 RID: 2149 RVA: 0x000039A8 File Offset: 0x00001BA8
	// (set) Token: 0x06000866 RID: 2150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000095")]
	public uint Id
	{
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x260A0DC", Offset = "0x260A0DC", VA = "0x7BBCE0A0DC", Slot = "8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1133240", Offset = "0x1133240")]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x260A0E4", Offset = "0x260A0E4", VA = "0x7BBCE0A0E4", Slot = "9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1133250", Offset = "0x1133250")]
		set
		{
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x25FCE48", Offset = "0x25FCE48", VA = "0x7BBCDFCE48")]
	public string GetWardrobeSlot()
	{
		return null;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x260A0EC", Offset = "0x260A0EC", VA = "0x7BBCE0A0EC")]
	public static List<WardrobeSettings> GenerateWardrobeSet(Dictionary<string, UMATextRecipe> wardrobeRecipes, params string[] slotsToSave)
	{
		return null;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x260A44C", Offset = "0x260A44C", VA = "0x7BBCE0A44C", Slot = "4")]
	public override void Load(UMAData.UMARecipe umaRecipe, [Optional] UMAContext context)
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x260A48C", Offset = "0x260A48C", VA = "0x7BBCE0A48C")]
	protected UMATextRecipe.DCSUniversalPackRecipe PackedLoadDCSInternal(UMAContext context)
	{
		return null;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x260A4F4", Offset = "0x260A4F4", VA = "0x7BBCE0A4F4")]
	public static UMATextRecipe.DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, string recipeToUnpack, [Optional] UMATextRecipe targetUTR)
	{
		return null;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x25FC89C", Offset = "0x25FC89C", VA = "0x7BBCDFC89C")]
	public static UMATextRecipe.DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, UMATextRecipe recipe, [Optional] UMATextRecipe targetUTR)
	{
		return null;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x260ABC0", Offset = "0x260ABC0", VA = "0x7BBCE0ABC0")]
	public void Save(UMAData.UMARecipe umaRecipe, UMAContext context, Dictionary<string, UMATextRecipe> wardrobeRecipes, bool backwardsCompatible = true)
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x260AC78", Offset = "0x260AC78", VA = "0x7BBCE0AC78", Slot = "5")]
	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x260AD60", Offset = "0x260AD60", VA = "0x7BBCE0AD60")]
	public void SaveDCS(DynamicCharacterAvatar dcaToSave, string recipeName, DynamicCharacterAvatar.SaveOptions saveOptions)
	{
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x260A788", Offset = "0x260A788", VA = "0x7BBCE0A788")]
	public static string GetRecipesType(string recipeString)
	{
		return null;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x000039C0 File Offset: 0x00001BC0
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x260AA94", Offset = "0x260AA94", VA = "0x7BBCE0AA94")]
	public static bool RecipeHasWardrobeSet(string recipeString)
	{
		return default(bool);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x260AB3C", Offset = "0x260AB3C", VA = "0x7BBCE0AB3C")]
	public static List<WardrobeSettings> GetRecipesWardrobeSet(string recipeString)
	{
		return null;
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x000039D8 File Offset: 0x00001BD8
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x260AC74", Offset = "0x260AC74", VA = "0x7BBCE0AC74")]
	public static byte RecipeTypeToByte(UMATextRecipe.ERecipeType t)
	{
		return 0;
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x260AE48", Offset = "0x260AE48", VA = "0x7BBCE0AE48", Slot = "6")]
	public override UMAPackedRecipeBase.UMAPackRecipe PackedLoad(UMAContext context)
	{
		return null;
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x260B2B4", Offset = "0x260B2B4", VA = "0x7BBCE0B2B4")]
	private UMAPackedRecipeBase.PackedSlotDataV2 ConvertToSlotDataV2(UMATextRecipe.MiniPackedSlotData s, ref bool hasSkinColor)
	{
		return null;
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x260B578", Offset = "0x260B578", VA = "0x7BBCE0B578")]
	private UMAPackedRecipeBase.PackedOverlayDataV2 ConvertToOverlayDataV2(UMATextRecipe.MiniPackedOverlayData v, ref bool hasSkinColor)
	{
		return null;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x260B4D0", Offset = "0x260B4D0", VA = "0x7BBCE0B4D0")]
	public static UMAPackedRecipeBase.PackedOverlayColorDataV3 CreateColorDataV3(string name)
	{
		return null;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x260B6BC", Offset = "0x260B6BC", VA = "0x7BBCE0B6BC", Slot = "7")]
	public override void PackedSave(UMAPackedRecipeBase.UMAPackRecipe packedRecipe, UMAContext context)
	{
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x000039F0 File Offset: 0x00001BF0
	[Token(Token = "0x6000879")]
	[Address(RVA = "0x260BECC", Offset = "0x260BECC", VA = "0x7BBCE0BECC")]
	private int GetSkipCount(int i, LinkedList<UMATextRecipe.IntVec2> skips)
	{
		return 0;
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087A")]
	[Address(RVA = "0x260BB58", Offset = "0x260BB58", VA = "0x7BBCE0BB58")]
	private UMATextRecipe.MiniPackedSlotData ConvertToSlotDataMini(UMAPackedRecipeBase.PackedSlotDataV2 s2, int skinColorIndex, LinkedList<UMATextRecipe.IntVec2> skips)
	{
		return null;
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600087B")]
	[Address(RVA = "0x260C01C", Offset = "0x260C01C", VA = "0x7BBCE0C01C")]
	private UMATextRecipe.MiniPackedOverlayData ConvertToOverlayDataMini(UMAPackedRecipeBase.PackedOverlayDataV2 o2, int skinColorIndex)
	{
		return null;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087C")]
	[Address(RVA = "0x25F71A4", Offset = "0x25F71A4", VA = "0x7BBCDF71A4")]
	public void ClearResourceRef()
	{
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x260C138", Offset = "0x260C138", VA = "0x7BBCE0C138")]
	public UMATextRecipe()
	{
	}

	// Token: 0x0400085C RID: 2140
	[Token(Token = "0x400085C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[NonSerialized]
	public byte recipeTypeByte;

	// Token: 0x0400085D RID: 2141
	[Token(Token = "0x400085D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string DisplayValue;

	// Token: 0x0400085E RID: 2142
	[Token(Token = "0x400085E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public List<string> compatibleRaces;

	// Token: 0x0400085F RID: 2143
	[Token(Token = "0x400085F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string wardrobeSlot;

	// Token: 0x04000860 RID: 2144
	[Token(Token = "0x4000860")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public List<string> Hides;

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public List<string> suppressWardrobeSlots;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public List<string> beSuppressWardrobeSlots;

	// Token: 0x04000863 RID: 2147
	[Token(Token = "0x4000863")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1100968", Offset = "0x1100968")]
	private uint <Id>k__BackingField;

	// Token: 0x04000864 RID: 2148
	[Token(Token = "0x4000864")]
	public const byte RecipeTypeStandard = 0;

	// Token: 0x04000865 RID: 2149
	[Token(Token = "0x4000865")]
	public const byte RecipeTypeWardrobe = 1;

	// Token: 0x04000866 RID: 2150
	[Token(Token = "0x4000866")]
	public const byte RecipeTypeWardrobeCollection = 2;

	// Token: 0x04000867 RID: 2151
	[Token(Token = "0x4000867")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UMATextRecipe.MiniPackRecipe recipeData;

	// Token: 0x04000868 RID: 2152
	[Token(Token = "0x4000868")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int[] m_DefaultRect;

	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	private class DCSRecipeChecker
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public List<WardrobeSettings> checkedWardrobeSet
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x260ADC8", Offset = "0x260ADC8", VA = "0x7BBCE0ADC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x260C7AC", Offset = "0x260C7AC", VA = "0x7BBCE0C7AC")]
		public DCSRecipeChecker()
		{
		}

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string packedRecipeType;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<WardrobeSettings> wardrobeRecipesJson;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<WardrobeSettings> wardrobeSet;
	}

	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	[Serializable]
	public class DCSPackRecipe
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public OverlayColorData[] sharedColors
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x25FEDC0", Offset = "0x25FEDC0", VA = "0x7BBCDFEDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x25F9C4C", Offset = "0x25F9C4C", VA = "0x7BBCDF9C4C")]
		public DCSPackRecipe()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x260C2A8", Offset = "0x260C2A8", VA = "0x7BBCE0C2A8")]
		public DCSPackRecipe(DynamicCharacterAvatar dcaToSave, string recipeName, string pRecipeType, DynamicCharacterAvatar.SaveOptions saveOptions, params string[] slotsToSave)
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x260C680", Offset = "0x260C680", VA = "0x7BBCE0C680")]
		public DCSPackRecipe(UMAPackedRecipeBase.UMAPackRecipe umaPackRecipe, string recipeName = "", string pRecipeType = "Standard", [Optional] List<WardrobeSettings> wardrobeSetToSave)
		{
		}

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string packedRecipeType;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string race;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UMAPackedRecipeBase.PackedOverlayColorDataV3> characterColors;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<WardrobeSettings> wardrobeSet;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string raceAnimatorController;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OverlayColorData[] _sharedColors;
	}

	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	[Serializable]
	public class DCSUniversalPackRecipe : UMAPackedRecipeBase.UMAPackRecipe
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public OverlayColorData[] sharedColors
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x25FE4EC", Offset = "0x25FE4EC", VA = "0x7BBCDFE4EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x260A728", Offset = "0x260A728", VA = "0x7BBCE0A728")]
		public DCSUniversalPackRecipe()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x260A95C", Offset = "0x260A95C", VA = "0x7BBCE0A95C")]
		public DCSUniversalPackRecipe(UMAPackedRecipeBase.UMAPackRecipe umaPackRecipe, string pRecipeType = "Standard")
		{
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x260A80C", Offset = "0x260A80C", VA = "0x7BBCE0A80C")]
		public DCSUniversalPackRecipe(UMATextRecipe.DCSPackRecipe dcsPackRecipe)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x260C84C", Offset = "0x260C84C", VA = "0x7BBCE0C84C")]
		public DCSUniversalPackRecipe(UMAData.UMARecipe recipeToSave, [Optional] Dictionary<string, UMATextRecipe> wardrobeRecipes, string pRecipeType = "DynamicCharacterAvatar")
		{
		}

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public List<WardrobeSettings> wardrobeSet;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string packedRecipeType;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private OverlayColorData[] _sharedColors;
	}

	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public enum ERecipeType : byte
	{
		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		Standard,
		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		Wardrobe,
		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		WardrobeCollection,
		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		DynamicCharacterAvatar
	}

	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	[Serializable]
	public class ByteFlags
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x260C26C", Offset = "0x260C26C", VA = "0x7BBCE0C26C")]
		public bool HasFlag(byte b)
		{
			return default(bool);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x260C280", Offset = "0x260C280", VA = "0x7BBCE0C280")]
		public void SetFlag(byte b)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x260C290", Offset = "0x260C290", VA = "0x7BBCE0C290")]
		public void UnsetFlag(byte b)
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x260C2A0", Offset = "0x260C2A0", VA = "0x7BBCE0C2A0")]
		public ByteFlags()
		{
		}

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte flags;
	}

	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	[Serializable]
	public class MiniPackRecipe
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x260BEC4", Offset = "0x260BEC4", VA = "0x7BBCE0BEC4")]
		public MiniPackRecipe()
		{
		}

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string race;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UMATextRecipe.MiniPackedSlotData[] slots;
	}

	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[Serializable]
	public class MiniPackedSlotData
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x260C00C", Offset = "0x260C00C", VA = "0x7BBCE0C00C")]
		public MiniPackedSlotData()
		{
		}

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int scale;

		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int copyIdx;

		// Token: 0x04000881 RID: 2177
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UMATextRecipe.MiniPackedOverlayData overlay;
	}

	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	[Serializable]
	public class MiniPackedOverlayData : UMATextRecipe.ByteFlags
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x260C128", Offset = "0x260C128", VA = "0x7BBCE0C128")]
		public void SetSkinColor()
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x260B6B0", Offset = "0x260B6B0", VA = "0x7BBCE0B6B0")]
		public bool HasSkinColor()
		{
			return default(bool);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x260C120", Offset = "0x260C120", VA = "0x7BBCE0C120")]
		public MiniPackedOverlayData()
		{
		}

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		public const byte FLAG_SKIN_COLOR = 1;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string id;
	}

	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	private class IntVec2
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x260BEBC", Offset = "0x260BEBC", VA = "0x7BBCE0BEBC")]
		public IntVec2()
		{
		}

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int a;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int b;
	}
}
