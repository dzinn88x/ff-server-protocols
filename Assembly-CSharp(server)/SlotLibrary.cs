using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class SlotLibrary : SlotLibraryBase
{
	// Token: 0x060008F1 RID: 2289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x225EF10", Offset = "0x225EF10", VA = "0x7BBCA5EF10")]
	private void Awake()
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x225EF20", Offset = "0x225EF20", VA = "0x7BBCA5EF20", Slot = "13")]
	public override void UpdateDictionary()
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x225F114", Offset = "0x225F114", VA = "0x7BBCA5F114", Slot = "14")]
	public override void ValidateDictionary()
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x225F19C", Offset = "0x225F19C", VA = "0x7BBCA5F19C", Slot = "4")]
	public override void AddSlotAsset(SlotDataAsset slot)
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x225F4B0", Offset = "0x225F4B0", VA = "0x7BBCA5F4B0", Slot = "10")]
	public override bool HasSlot(string name)
	{
		return default(bool);
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x225F544", Offset = "0x225F544", VA = "0x7BBCA5F544", Slot = "11")]
	public override bool HasSlot(int nameHash)
	{
		return default(bool);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x225F5C8", Offset = "0x225F5C8", VA = "0x7BBCA5F5C8", Slot = "6")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x225F764", Offset = "0x225F764", VA = "0x7BBCA5F764", Slot = "7")]
	public override SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x225F84C", Offset = "0x225F84C", VA = "0x7BBCA5F84C", Slot = "8")]
	public override SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x225F94C", Offset = "0x225F94C", VA = "0x7BBCA5F94C", Slot = "9")]
	public override SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x225F6A0", Offset = "0x225F6A0", VA = "0x7BBCA5F6A0")]
	private SlotData Internal_InstantiateSlot(int nameHash)
	{
		return null;
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x225FA64", Offset = "0x225FA64", VA = "0x7BBCA5FA64", Slot = "5")]
	public override SlotDataAsset[] GetAllSlotAssets()
	{
		return null;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x225FA6C", Offset = "0x225FA6C", VA = "0x7BBCA5FA6C", Slot = "12")]
	public override SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x225FB14", Offset = "0x225FB14", VA = "0x7BBCA5FB14")]
	public SlotLibrary()
	{
	}

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected SlotDataAsset[] slotElementList;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	private Dictionary<int, SlotDataAsset> slotDictionary;
}
