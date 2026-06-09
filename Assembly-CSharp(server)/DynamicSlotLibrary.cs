using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
public class DynamicSlotLibrary : SlotLibrary
{
	// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x23F3618", Offset = "0x23F3618", VA = "0x7BBCBF3618")]
	public void Start()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x23F3690", Offset = "0x23F3690", VA = "0x7BBCBF3690")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x23F3694", Offset = "0x23F3694", VA = "0x7BBCBF3694")]
	public void ClearEditorAddedAssets()
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x23F3698", Offset = "0x23F3698", VA = "0x7BBCBF3698")]
	public void UpdateDynamicSlotLibrary([Optional] int? nameHash)
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x23F37E0", Offset = "0x23F37E0", VA = "0x7BBCBF37E0")]
	public void UpdateDynamicSlotLibrary(string slotName)
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x23F391C", Offset = "0x23F391C", VA = "0x7BBCBF391C", Slot = "12")]
	public override SlotDataAsset GetSlotDataAsset(string name)
	{
		return null;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x23F39F4", Offset = "0x23F39F4", VA = "0x7BBCBF39F4")]
	private void AddSlotAssets(SlotDataAsset[] slots)
	{
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x23F3A74", Offset = "0x23F3A74", VA = "0x7BBCBF3A74", Slot = "6")]
	public override SlotData InstantiateSlot(string name)
	{
		return null;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x23F3C70", Offset = "0x23F3C70", VA = "0x7BBCBF3C70", Slot = "7")]
	public override SlotData InstantiateSlot(int nameHash)
	{
		return null;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x23F3E9C", Offset = "0x23F3E9C", VA = "0x7BBCBF3E9C", Slot = "8")]
	public override SlotData InstantiateSlot(string name, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x23F40A8", Offset = "0x23F40A8", VA = "0x7BBCBF40A8", Slot = "9")]
	public override SlotData InstantiateSlot(int nameHash, List<OverlayData> overlayList)
	{
		return null;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x23F42F4", Offset = "0x23F42F4", VA = "0x7BBCBF42F4")]
	public string GetOriginatingAssetBundle(string slotName)
	{
		return null;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x23F45C8", Offset = "0x23F45C8", VA = "0x7BBCBF45C8")]
	public DynamicSlotLibrary()
	{
	}

	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool dynamicallyAddFromResources;

	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1100898", Offset = "0x1100898")]
	public string resourcesFolderPath;

	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool dynamicallyAddFromAssetBundles;

	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x11008D0", Offset = "0x11008D0")]
	public string assetBundleNamesToSearch;

	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x400085A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	// Token: 0x0400085B RID: 2139
	[Token(Token = "0x400085B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	[NonSerialized]
	public bool downloadAssetsEnabled;
}
